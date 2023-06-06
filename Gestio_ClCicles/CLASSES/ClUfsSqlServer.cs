using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CLASSES;

namespace Gestio_ClCicles.CLASSES
{
    public class ClUfsSqlServer
    {

        private ClBDSqlServer bd = null;

        public Boolean bdAccessible = false;
        public String idCicle { get; set; }
        public String idModul { get; set; }
        public String idUf { get; set; }
        public String nomUf { get; set; }
        public String nHores { get; set; }

        public ClUfsSqlServer(String cadenaConnexio, String nomBD)
        {
            bd = new ClBDSqlServer(cadenaConnexio);
            if (bd.Connectar() && bd.ObrirBD(nomBD))
            {
                bdAccessible = true;
            }
            else
            {
                bd = null;
            }
        }

        ~ClUfsSqlServer()
        {

        }

        public Boolean novaUf()
        {
            Boolean xb = bd.InserirDades("INSERT INTO tbUfs(idCicle,idModul,idUf,nomUf,nHores) VALUES ('" + idCicle + "','" + idModul + "','" + idUf + "','" + nomUf + "'," + nHores + ")");
            return xb;
        }

        public Boolean modificarUf()
        {
            Boolean xb = bd.ModificarDades("UPDATE tbUfs SET nomUf='" + nomUf + "', nHores = " + nHores + ", idCicle = '" + idCicle + "', idModul = '" + idModul + "' WHERE idCicle='" + idCicle + "'");
            return xb;
        }

        public Boolean suprimirUf()
        {
            Boolean xb = bd.SuprimirDades("DELETE FROM tbUfs WHERE (idUf='" + idUf + "')");
            return xb;
        }

        public Boolean getUf()
        {
            Boolean xb = false;

            //Aqui farem la funcio que ens retornara el nom de la familia a partir de la id de la familia
            DataSet dset = new DataSet();

            //Aqui farem la string de sql que ens servira per saber si existeix la familia o no
            String xsql = "SELECT idUf, nomUf, nHores, idCicle, idModul FROM tbUfs WHERE idUf = '" + idUf + "';";

            bd.Consulta(xsql, ref dset);

            try
            {
                if (dset.Tables[0].Rows.Count != 0)
                {
                    idUf = dset.Tables[0].Rows[0].ItemArray[0].ToString();
                    nomUf = dset.Tables[0].Rows[0].ItemArray[1].ToString();
                    nHores = dset.Tables[0].Rows[0].ItemArray[2].ToString();
                    idCicle = dset.Tables[0].Rows[0].ItemArray[3].ToString();
                    idModul = dset.Tables[0].Rows[0].ItemArray[4].ToString();
                    xb = true;
                }

            }
            catch (Exception excp)
            {
                MessageBox.Show(excp.Message, "EXCEPCIÓ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return xb;
        }

        public void llistaUfs(ref DataSet dset, int ordre)
        {
            String xsql = "";
            switch (ordre)
            {
                case 0: xsql = "SELECT tbUfs.idUf, tbUfs.nomUf, tbUfs.nHores ,tbUfs.idCicle , tbCicles.nomCicle , tbUfs.idModul ,tbModuls.nomModul FROM tbUfs LEFT JOIN tbCicles ON tbCicles.idCicle = tbUfs.idCicle LEFT JOIN tbModuls ON tbUfs.idModul = tbModuls.idModul ORDER BY tbUfs.idUf;"; break;
                case 1: xsql = "SELECT tbUfs.idUf, tbUfs.nomUf, tbUfs.nHores ,tbUfs.idCicle , tbCicles.nomCicle , tbUfs.idModul ,tbModuls.nomModul FROM tbUfs LEFT JOIN tbCicles ON tbCicles.idCicle = tbUfs.idCicle LEFT JOIN tbModuls ON tbUfs.idModul = tbModuls.idModul ORDER BY tbUfs.nomUf;"; break;
            }
            bd.Consulta(xsql, ref dset);
        }

        public int quantesUfsXprefix(String nomUf)
        {
            return (Int32)bd.ConsultaEscalar("SELECT COUNT(*) FROM tbUfs WHERE nomUf = '" + nomUf + "'");
        }

        public int quantesUfs()
        {
            return (Int32)bd.ConsultaEscalar("SELECT COUNT(*) FROM tbUfs;");
        }

        public Boolean existeixUf()
        {
            Boolean xb = false;

            //Aqui farem la funcio que ens retornara el nom de la familia a partir de la id de la familia
            DataSet dset = new DataSet();

            //Aqui farem la string de sql que ens servira per saber si existeix la familia o no
            String xsql = "SELECT count(*) FROM tbUfs WHERE idUf LIKE '" + idUf + "';";

            bd.Consulta(xsql, ref dset);

            try
            {
                if ((Int32)dset.Tables[0].Rows[0].ItemArray[0] != 0)
                {
                    //Si entra aqui dins voldra dir que la uf existira
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
