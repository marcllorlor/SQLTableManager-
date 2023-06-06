using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAM_ClCpSqlServer.CLASSES
{
    public class ClCicles
    {
        //Primer farem la declaracio de propietats de la classe
        private ClCiclesSqlServer model = null;


        public String idCicle { get; set; }
        public String nomCicle { get; set; }

        //Aquesta es una propietat que és una clau foranea
        public String idFamilia { get; set; }

        //Aqui farem una llista de noms de les ID que tenim com a Id Familia

        public List<String> idsFamilies { get; set ; }

        public ClCicles(String cadenaConnexio, String nomBD)
        {
            //Aqui hem de fer la declaracio de la classe de model de ClCicles
            model = new ClCiclesSqlServer(cadenaConnexio,nomBD);
        }

        ~ClCicles()
        {
        }

        public Boolean modelAccessible()
        {
            return model != null;
        }

        public Boolean nouCicle()
        {
            Boolean xb = false;

            if (verificarId(idCicle) && verificarNom(nomCicle) && !existeixCicle())
            {
                model.idCicle = idCicle;
                model.nomCicle = arreglarString(nomCicle);
                model.idFamilia = idFamilia;
                xb = model.nouCicle();
            }
            return xb;
        }

        private bool IsAllUpper(string input)
        {
            //Aquesta es una funcio que m'he tret de la maniga per saber si una paraula esta tota en upper o que
            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsLetter(input[i]) && !Char.IsUpper(input[i]))
                    return false;
            }
            return true;
        }

        public Boolean modificarCicle()
        {
            Boolean xb = false;
            if (verificarNom(nomCicle) && existeixCicle()) //Aqui no fa falta que verifiquem la id per que es una cosa que no es pot canviar i previament ja ha sigut comprovada
            {
                model.idCicle = idCicle;
                model.nomCicle = arreglarString(nomCicle);
                model.idFamilia = idFamilia;
                xb = model.modificarCicle();
            }
            return xb;
        }

        public Boolean suprimirCicle()
        {
            Boolean xb = false;

            model.idCicle = idCicle;
            xb = model.suprimirCicle();

            return xb;
        }

        private Boolean verificarId(String xid)
        {
            Boolean xb = false;
            if (Enumerable.Range(3, 5).Contains(xid.Length) && IsAllUpper(xid))
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

        public Boolean existeixCicle()
        {
            model.idCicle = idCicle;
            return model.existeixCicle();
        }

        public Boolean getCicle()
        {
            Boolean xb = false;
            model.idFamilia = idFamilia;
            if (model.getCicle())
            {
                idCicle = model.idCicle;
                nomCicle = model.nomCicle;
                idFamilia = model.idFamilia;
                xb = true;
            }
            return xb;
        }

        public void llistaFamilies(ref DataSet dset)
        {
            model.llistaCicles(ref dset, 0);
        }

        public void llistaXnomCicles(ref DataSet dset)
        {
            model.llistaCicles(ref dset, 1);
        }

        public Int32 quantsCicles()
        {
            return model.quantsCicles();
        }

        public Int32 quantsCiclesXPrefix(String prefix)
        {
            return model.quantsCiclexPrefix(nomCicle);
        }

        internal List<String> retornaridsFamilies()
        {
            return model.retornaridsFamilies();
        }
    }
}
