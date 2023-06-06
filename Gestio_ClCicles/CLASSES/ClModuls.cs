using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestio_ClCicles.CLASSES
{
    public class ClModuls
    {
        private ClModulsSqlServer model = null;


        public String idModul { get; set; }
        public String nomModul { get; set; }

        //Aquesta es una propietat que és una clau foranea
        public String idCicle { get; set; }

        //Aqui farem una llista de noms de les ID que tenim com a Id Familia

        public ClModuls(String cadenaConnexio, String nomBD)
        {
            //Aqui hem de fer la declaracio de la classe de model de ClCicles
            model = new ClModulsSqlServer(cadenaConnexio, nomBD);
        }

        ~ClModuls()
        {

        }

        public Boolean modelAccessible()
        {
            return model != null;
        }

        public Boolean nouModul()
        {
            Boolean xb = false;

            if (verificarId(idModul) && verificarNom(nomModul) && !existeixModul())
            {
                model.idModul = idModul;
                model.nomModul = arreglarString(nomModul);
                model.idCicle = idCicle;
                xb = model.nouModul();
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

        public Boolean modificarModul()
        {
            Boolean xb = false;
            if (verificarNom(nomModul) && existeixModul()) //Aqui no fa falta que verifiquem la id per que es una cosa que no es pot canviar i previament ja ha sigut comprovada
            {
                model.idModul = idModul;
                model.nomModul = arreglarString(nomModul);
                model.idCicle = idCicle;
                xb = model.modificarModul();
            }
            return xb;
        }

        public Boolean suprimirModul()
        {
            Boolean xb = false;

            model.idModul = idModul;
            xb = model.suprimirModul();

            return xb;
        }

        private Boolean verificarId(String xid)
        {
            Boolean xb = false;
            if (Enumerable.Range(3, 5).Contains(xid.Length) && (xid == xid.ToUpper()))
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

        public Boolean existeixModul()
        {
            model.idModul = idModul;
            return model.existeixModul();
        }

        public Boolean getModul()
        {
            Boolean xb = false;
            model.idModul = idModul;
            if (model.getModul())
            {
                idModul = model.idModul;
                nomModul = model.nomModul;
                idCicle = model.idCicle;
                xb = true;
            }
            return xb;
        }

        public void llistaModuls(ref DataSet dset)
        {
            model.llistaModuls(ref dset, 0);
        }

        public void llistaXnomModuls(ref DataSet dset)
        {
            model.llistaModuls(ref dset, 1);
        }

        public Int32 quantsModuls()
        {
            return model.quantsModuls();
        }

        public Int32 quantsModulsXPrefix(String prefix)
        {
            return model.quantsModulsXprefix(prefix);
        }
    }
}
