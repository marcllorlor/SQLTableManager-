using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CLASSES;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CLASSES
{
    public class ClFamiliesSqlServer
    {
        private ClBDSqlServer bd = null;

        public Boolean bdAccessible = false;
        public String idFamilia { get; set; }
        public String nomFamilia { get; set; }

        public ClFamiliesSqlServer(String cadenaConnexio, String nomBD)
        {
            bd = new ClBDSqlServer(cadenaConnexio);
            if(bd.Connectar() && bd.ObrirBD(nomBD))
            {
                bdAccessible = true;
            }
            else
            {
                bd = null;
            }
        }

        // destructor
        ~ClFamiliesSqlServer()
        {
            //Aquest es el destructor
        }

        public Boolean novaFamilia()
        {
            Boolean xb = bd.InserirDades("INSERT INTO tbFamilies(idFamilia, nomFamilia) VALUES('" + idFamilia + "', '" + nomFamilia + "')");
            return xb;
        }

        public Boolean modificarFamilia()
        {
            Boolean xb = bd.ModificarDades("UPDATE tbFamilies SET nomFamilia='" + nomFamilia + "' WHERE (idFamilia='" + idFamilia + "')");
            return xb;
        }

        public Boolean suprimirFamilia()
        {
            Boolean xb = bd.SuprimirDades("DELETE FROM tbFamilies WHERE (idFamilia='" + idFamilia + "')");
            return xb;
        }

        public Boolean getFamilia()
        {
            Boolean xb = false;

            //Aqui farem la funcio que ens retornara el nom de la familia a partir de la id de la familia
            DataSet dset = new DataSet();

            //Aqui farem la string de sql que ens servira per saber si existeix la familia o no
            String xsql = "SELECT idFamilia, nomFamilia FROM tbFamilies WHERE idFamilia LIKE '" + idFamilia + "';";

            bd.Consulta(xsql, ref dset);

            try
            {
                if (dset.Tables[0].Rows.Count != 0)
                {
                    idFamilia = dset.Tables[0].Rows[0].ItemArray[0].ToString();
                    nomFamilia = dset.Tables[0].Rows[0].ItemArray[1].ToString();
                    xb = true;
                }
                
            }
            catch (Exception excp)
            {
                MessageBox.Show(excp.Message, "EXCEPCIÓ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return xb;
        }

        public void llistaFamilies(ref DataSet dset, int ordre)
        {
            String xsql = "";
            switch (ordre)
            {
                case 0: xsql = "SELECT * FROM tbFamilies ORDER BY idFamilia";break;
                case 1: xsql = "SELECT * FROM tbFamilies ORDER BY nomFamilia"; break;
            }
            bd.Consulta(xsql, ref dset);
        }

        public int quantesFamiliesXprefix(String nomfamilia)
        {
            return (Int32)bd.ConsultaEscalar("SELECT COUNT(*) FROM tbFamilies WHERE nomFamilia = '" + nomfamilia + "'");
        }

        public int quantesFamilies()
        {
            return (Int32)bd.ConsultaEscalar("SELECT COUNT(*) FROM tbFamilies;");
        }

        public Boolean existeixFamilia()
        {
            Boolean xb = false;

            //Aqui farem la funcio que ens retornara el nom de la familia a partir de la id de la familia
            DataSet dset = new DataSet();

            //Aqui farem la string de sql que ens servira per saber si existeix la familia o no
            String xsql = "SELECT count(*) FROM tbFamilies WHERE idFamilia = '" + idFamilia + "';";

            bd.Consulta(xsql, ref dset);

            try
            {
                if (dset.Tables[0].Rows[0].ItemArray.Count() > 1)
                {
                    idFamilia = dset.Tables[0].Rows[0].ItemArray[0].ToString();
                    nomFamilia = dset.Tables[0].Rows[0].ItemArray[1].ToString();
                    xb = true;
                }

            }
            catch (Exception excp)
            {
                MessageBox.Show(excp.Message, "EXCEPCIÓ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return xb;
        }


    }
}
