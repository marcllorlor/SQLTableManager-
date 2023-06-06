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
    public class ClModulsSqlServer
    {
        private ClBDSqlServer bd = null;

        public Boolean bdAccessible = false;

        public String idCicle { get; set; }
        public String idModul { get; set; }
        public String nomModul { get; set; }

        public ClModulsSqlServer(String cadenaConnexio, String nomBD)
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

        ~ClModulsSqlServer()
        {
            //El destructor no fa falta pero igualment el posem
        }

        public Boolean nouModul()
        {
            Boolean xb = bd.InserirDades("INSERT INTO tbModuls(idCicle, idModul, nomModul) VALUES('" + idCicle + "', '" + idModul + "','" + nomModul + "')");
            return xb;
        }

        public Boolean modificarModul()
        {
            Boolean xb = bd.ModificarDades("UPDATE tbModuls SET idCicle='" + idCicle + "', nomModul ='" + nomModul + "' WHERE (idModul='" + idModul + "')");
            return xb;
        }

        public Boolean suprimirModul()
        {
            Boolean xb = bd.SuprimirDades("DELETE FROM tbModuls WHERE (idModul='" + idModul + "')");
            return xb;
        }

        public Boolean getModul()
        {
            Boolean xb = false;

            //Aqui farem la funcio que ens retornara el nom de la familia a partir de la id de la familia
            DataSet dset = new DataSet();

            //Aqui farem la string de sql que ens servira per saber si existeix la familia o no
            String xsql = "SELECT idModul, nomModul, idCicle FROM tbModuls WHERE idModul LIKE '" + idModul + "';";

            bd.Consulta(xsql, ref dset);

            try
            {
                if (dset.Tables[0].Rows.Count != 0)
                {
                    idModul = dset.Tables[0].Rows[0].ItemArray[0].ToString();
                    nomModul = dset.Tables[0].Rows[0].ItemArray[1].ToString();
                    idCicle = dset.Tables[0].Rows[0].ItemArray[2].ToString();
                    xb = true;
                }

            }
            catch (Exception excp)
            {
                MessageBox.Show(excp.Message, "EXCEPCIÓ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return xb;
        }

        public void llistaModuls(ref DataSet dset, int ordre)
        {
            String xsql = "";
            switch (ordre)
            {
                case 0: xsql = "SELECT idModul, nomModul, idCicle FROM tbModuls ORDER BY idModul"; break;
                case 1: xsql = "SELECT tbModuls.idModul, tbModuls.nomModul, tbModuls.idCicle , tbCicles.nomCicle FROM tbModuls LEFT JOIN tbCicles ON tbCicles.idCicle = tbModuls.idCicle ORDER BY tbModuls.nomModul"; break;
            }
            bd.Consulta(xsql, ref dset);
        }

        public int quantsModulsXprefix(String nomModul)
        {
            return (Int32)bd.ConsultaEscalar("SELECT COUNT(*) FROM tbModuls WHERE nomModul = '" + nomModul + "'");
        }

        public int quantsModuls()
        {
            return (Int32)bd.ConsultaEscalar("SELECT COUNT(*) FROM tbModuls;");
        }

        public Boolean existeixModul()
        {
            Boolean xb = false;

            //Aqui farem la funcio que ens retornara el nom de la familia a partir de la id de la familia
            DataSet dset = new DataSet();

            //Aqui farem la string de sql que ens servira per saber si existeix la familia o no
            String xsql = "SELECT count(*) FROM tbModuls WHERE idModul LIKE '" + idModul + "';";

            bd.Consulta(xsql, ref dset);

            try
            {
                if ((Int32)dset.Tables[0].Rows[0].ItemArray[0] != 0)
                {
                    //idCicle = dset.Tables[0].Rows[0].ItemArray[0].ToString();
                    //nomCicle = dset.Tables[0].Rows[0].ItemArray[1].ToString();
                    //idFamilia = dset.Tables[0].Rows[0].ItemArray[2].ToString();
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
