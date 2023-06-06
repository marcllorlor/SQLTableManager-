using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAM_ClCpSqlServer.CLASSES;

namespace Gestio_ClCicles.CLASSES
{
    public class ClUfs
    {

        private ClUfsSqlServer model = null;

        public String idCicle { get; set; }
        public String idModul { get; set; }
        public String idUf { get; set; }
        public String nomUf { get; set; }
        public String nHores { get; set; }

        public ClUfs(String cadenaConnexio, String nomBD)
        {
            model = new ClUfsSqlServer(cadenaConnexio, nomBD);
        }

        ~ClUfs()
        {

        }

        public Boolean modelAccessible()
        {
            return model != null;
        }

        public Boolean novaUf()
        {
            Boolean xb = false;

            if (verificarId(idUf) && verificarNom(nomUf) && !existeixUf())
            {
                model.idUf = idUf;
                model.nomUf = arreglarString(nomUf);
                model.nHores = nHores;

                model.idCicle = idCicle;
                model.idModul = idModul;

                xb = model.novaUf();
            }
            return xb;
        }

        public Boolean modificarUf()
        {
            Boolean xb = false;
            if (verificarNom(nomUf) && existeixUf()) //Aqui no fa falta que verifiquem la id per que es una cosa que no es pot canviar i previament ja ha sigut comprovada
            {
                model.idUf = idUf;
                model.nomUf = arreglarString(nomUf);
                model.nHores = nHores;

                model.idCicle = idCicle;
                model.idModul = idModul;
                xb = model.modificarUf();
            }
            return xb;
        }

        public Boolean suprimirUf()
        {
            Boolean xb = false;

            model.idUf = idUf;
            xb = model.suprimirUf();

            return xb;
        }

        private Boolean verificarId(String xid)
        {
            Boolean xb = false;
            if (Enumerable.Range(3, 5).Contains(xid.Length) && xid == xid.ToUpper())
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

        public Boolean existeixUf()
        {
            model.idUf = idUf;
            return model.existeixUf();
        }

        public Boolean getUf()
        {
            Boolean xb = false;
            model.idUf = idUf;
            if (model.getUf())
            {
                nomUf = model.nomUf;
                nHores = model.nHores;

                idCicle = model.idCicle;
                idModul = model.idModul;
                xb = true;
            }
            return xb;
        }

        public void llistaUfs(ref DataSet dset)
        {
            model.llistaUfs(ref dset, 0);
        }

        public void llistaXnomUfs(ref DataSet dset)
        {
            model.llistaUfs(ref dset, 1);
        }

        public Int32 quantesUfs()
        {
            return model.quantesUfs();
        }

        public Int32 quantesUfsXprefix(String prefix)
        {
            return model.quantesUfsXprefix(prefix);
        }

    }
}
