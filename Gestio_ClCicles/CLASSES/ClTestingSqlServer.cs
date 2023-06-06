using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLASSES;

namespace Gestio_ClCicles.CLASSES
{
    public class ClTestingSqlServer
    {

        private ClBDSqlServer bd = null;

        public Boolean bdAccessible = false;

        public ClTestingSqlServer(String cadenaConnexio, string nomBD)
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

    }
}
