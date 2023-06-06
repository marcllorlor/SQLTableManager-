using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CLASSES
{

    public class ClBDSqlServer
    {
        public String cadenaConnexioServidor; //Aqui guardarem la cadena de connexio a la base de dades
        public String nomBD; //Aqui guardem el nom de la abse de dades

        public SqlConnection connexio; //Aqui declararem la connexio de SQL
        // constructor
        public ClBDSqlServer(String xconnexio)
        {
            cadenaConnexioServidor = xconnexio; //Quan cridem a la clase de connexio li passarem la cadena de connexio
        }

        // destructor
        ~ClBDSqlServer() //Aqui farem el destructor de la classe, encara que el visual studio les gestiona sol
        {
        }

        public Boolean Connectar() //Aquesta es la funcio que farem la connexio de
        {
            Boolean xb = false; //Aqui declarem un boolean que es el que tornarem quan sacabi la funcio

            try
            {
                connexio = new SqlConnection(cadenaConnexioServidor); //Aqui provem de fer la connexio
                connexio.Open();                     // Amb Open només validem si es té connexió amb el servidor però no si hi ha la BD dins d'aquest servidor
                xb = (connexio.State == ConnectionState.Open);

            }
            catch (Exception excp)
            {
                MessageBox.Show("No has pogut carregar la base de dades, DADES DETALLADES:\n" + excp.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return (xb);
        }

        public Boolean HiHaConnexio()
        {
            return (connexio != null); //Aqui retornarem un true o un false depenent de si sha pogut fer la connexio o no
        }

        public Boolean Desconnectar()
        {
            Boolean xb = true; //Aqui declararem el boolean que es el que retornarem quan es cridila funcio

            try
            {
                connexio.Close();                     // Amb Open només validem si es té connexió amb el servidor però no si hi ha la BD dins d'aquest servidor
                xb = (connexio.State == ConnectionState.Closed);
                xb = false;
            }
            catch (Exception excp)
            {
                MessageBox.Show("No has pogut carregar la base de dades, DADES DETALLADES:\n" + excp.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            return (xb);
        }

        public Boolean ObrirBD(String xnomBD)
        {
            Boolean xb = false; //Aqui declarem un boolean que es el que tornarem quan sacabi la funcio
            try
            {
                connexio.ChangeDatabase(xnomBD); //Aqui provem de fer la connexio
                nomBD = xnomBD;
                xb = true;

            }
            catch (Exception excp)
            {
                MessageBox.Show("No has pogut carregar la base de dades, DADES DETALLADES:\n" + excp.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return (xb);
        }

        public Boolean TancarBD()
        {
            Boolean xb = true;

            //
            // AQUI FALTA CODI
            //
            return (xb);
        }

        public Boolean EstaOberta()
        {
            return (connexio.State == ConnectionState.Open);
        }

        public void Consulta(String xsql, ref DataSet xdset)
        {
            //Aqui es a on farem la consulta

            SqlDataAdapter xadap = new SqlDataAdapter();
            xdset.Clear();
            //Aqui haurem de fer el control de que la consulta començi per 

            if (xsql.StartsWith("SELECT"))
            {
                try
                {
                    xadap = new SqlDataAdapter(xsql, connexio);
                    xadap.Fill(xdset);

                }
                catch (Exception excp)
                {
                    MessageBox.Show(excp.Message, "EXCEPCIÓ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No has intorduit una instruccio de consulta, recorda que aquestes consultes començen per 'SELECT'", "EXCEPCIÓ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public object ConsultaEscalar(String xsql)
        {
            object xresultat = null;

            //Aqui es a on farem la consulta

            SqlDataAdapter xadap = new SqlDataAdapter();
            //Aqui haurem de fer el control de que la consulta començi per 

            DataSet xdset = new DataSet();
            //Aqui estem posant el xdset per tractar les dades i poderles llegir

            if (xsql.StartsWith("SELECT"))
            {
                try
                {
                    xadap = new SqlDataAdapter(xsql, connexio);
                    xadap.Fill(xdset);
                    xresultat = xdset.Tables[0].Rows[0].ItemArray[0];
                }
                catch (Exception excp)
                {
                    MessageBox.Show(excp.Message, "EXCEPCIÓ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No has intorduit una instruccio de consulta, recorda que aquestes consultes començen per 'SELECT'", "EXCEPCIÓ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return (xresultat);
        }

        public Boolean InserirDades(String xsql)
        {
            //Com que ja tenim la id del client no fa falta que li passem per parametres
            Boolean xb = false; //De moment deixem el resulta de la consulta com FALSE, si despres la podem fer la posarem a true
            SqlCommand xcommand = new SqlCommand(); //Declarem una instancia de sql command, que despres li pasarem el valor de servior i la consulta sql
            if (xsql.StartsWith("INSERT INTO"))
            {
                xb = executarOrdre(xsql);
            }
            else
            {
                MessageBox.Show("Per executar una ordre de INSERT has de posar INSERT AL PRINCIPI", "EXCEPCIÓ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return (xb); //I aqui retornarem el valor de true o false depenent de l'esta de la peticio de la consulta
        }

        public Boolean ModificarDades(String xsql)
        {
            //Com que ja tenim la id del client no fa falta que li passem per parametres
            Boolean xb = false; //De moment deixem el resulta de la consulta com FALSE, si despres la podem fer la posarem a true
             //Declarem una instancia de sql command, que despres li pasarem el valor de servior i la consulta sql
            if (xsql.StartsWith("UPDATE"))
            {
                xb = executarOrdre(xsql);
            }
            else
            {
                MessageBox.Show("Per executar una ordre de MODIFICAR has de posar UPDATE AL PRINCIPI", "EXCEPCIÓ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return (xb); //I aqui retornarem el valor de true o false depenent de l'esta de la peticio de la consulta
        }

        public Boolean SuprimirDades(String xsql)
        {
            //Com que ja tenim la id del client no fa falta que li passem per parametres
            Boolean xb = false; //De moment deixem el resulta de la consulta com FALSE, si despres la podem fer la posarem a true
            SqlCommand xcommand = new SqlCommand(); //Declarem una instancia de sql command, que despres li pasarem el valor de servior i la consulta sql
            if (xsql.StartsWith("DELETE"))
            {
                xb = executarOrdre(xsql);
            }
            else
            {
                MessageBox.Show("Per executar una ordre de DELETE has de posar DELETE AL PRINCIPI", "EXCEPCIÓ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return (xb); //I aqui retornarem el valor de true o false depenent de l'esta de la peticio de la consulta
        }

        

        private Boolean executarOrdre(String xsql)
        {
            //Es una funcio que retorna un true o false, i li pasarem una peticio SQL

            //Aquesta es la funcio que farem servir per fer les cnsultes de sqp  a dins de la base de dades
            SqlCommand xcommand = new SqlCommand();
            Boolean xb = false;
            try
            {
                xcommand.Connection = connexio; //Aqui li donem el valor de connexio que tenim previament
                xcommand.CommandText = xsql; //I aqui farem la consulta per borrar l'usuari mitjançant al identificacio de la seva id

                xcommand.ExecuteNonQuery(); //Aqui executarem la comanda, si esta be no petara, si peta no arribara a posar el valor de true que tenim una linia mes abaix
                xb = true; //Si arribar aqui voldra dir que la consulta shaura fet correctament i deixarem el resultat de la consulta com a true
            }
            catch (Exception excp)
            {
                MessageBox.Show(excp.Message, "EXCEPCIÓ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return (xb);
        }

    }
}
