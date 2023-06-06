using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using CLASSES;
namespace CLASSES
{
    public class ClFamilies
    {
        private ClFamiliesSqlServer model = null;
        public String idFamilia { get; set; }
        public String nomFamilia { get; set; }

        public ClFamilies(String cadenaConnexio, String nomBD)
        {
            model = new ClFamiliesSqlServer(cadenaConnexio, nomBD);
        }

        // destructor
        ~ClFamilies()
        {
        }

        public Boolean modelAccessible()
        {
            return model != null;
        }

        public Boolean novaFamilia()
        {
            Boolean xb = false;
            //Primer hem de fer la comprovacio del nom que tingui ENTRE 3 I 5 CARACTERS I QUE ESTIGUIN TOTS EN MAJUSCULES

            if (verificarId(idFamilia) && verificarNom(nomFamilia) && !existeixFamilia())
            {
                model.idFamilia = idFamilia;
                model.nomFamilia = arreglarString(nomFamilia);
                xb = model.novaFamilia();
                if (xb)
                {
                    MessageBox.Show("Has afegit la familia amb id de: " + idFamilia, "Suprimir familia", MessageBoxButtons.YesNo);
                }
            }
            return xb;
        }

        public Boolean modificarFamilia()
        {
            Boolean xb = false;
            if (verificarNom(nomFamilia) && existeixFamilia())
            {
                model.idFamilia = idFamilia;
                model.nomFamilia = arreglarString(nomFamilia);
                xb = model.modificarFamilia();
                if (xb)
                {
                    MessageBox.Show("Has modificat la familia de: " + idFamilia, "Modificació Familia", MessageBoxButtons.OK);
                }
            }
            return xb;
        }

        public Boolean suprimirFamilia()
        {
            Boolean xb = false;
            DialogResult dialogResult = MessageBox.Show("Estas segur que vols borrar la familia amb id de: " + idFamilia + "?", "Suprimir familia" ,MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                model.idFamilia = idFamilia;
                xb = model.suprimirFamilia();
            }
            return xb;
        }

        public Boolean getFamilia()
        {
            Boolean xb = false;
            model.idFamilia = idFamilia;
            if (model.getFamilia())
            {
                idFamilia = model.idFamilia;
                nomFamilia = model.nomFamilia;
                xb = true;
            }
            return xb;
        }

        public Boolean existeixFamilia()
        {
            model.idFamilia = idFamilia;
            return model.existeixFamilia();
        }

        public void llistaFamilies(ref DataSet dset)
        {
            model.llistaFamilies(ref dset, 0);
        }

        public void llistaXnomFamilies(ref DataSet dset)
        {
            model.llistaFamilies(ref dset, 1);
        }

        public Int32 quantesFamilies()
        {
            return model.quantesFamilies();
        }

        public Int32 quantesFamiliesXprefix(String prefix)
        {
            return model.quantesFamiliesXprefix(prefix);
        }

        private Boolean verificarId(String xid)
        {
            Boolean xb = false;
            if(Enumerable.Range(3, 5).Contains(xid.Length) && xid == xid.ToUpper())
            {
                xb = true;
            }
            return xb;
        }

        private Boolean verificarNom(String xnom)
        {
            Boolean xb = false;
            if (!String.IsNullOrEmpty(xnom)) 
            {
                xb = true;      
            }
            return xb;
        }

        private String arreglarString(String xs)
        {
            String xs1 = "";
            xs1 = xs.Replace("'", "''");
            return (xs1);
        }
    }
}
