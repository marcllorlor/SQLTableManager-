using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Gestio_ClCicles.CLASSES
{
    public class ClTesting
    {

        private ClTestingSqlServer model = null;

        public ClTesting(String cadenaConnexio, String nomBD)
        {
            model = new ClTestingSqlServer(cadenaConnexio, nomBD);
        }

        public Boolean modelAccessible()
        {
            return model.bdAccessible;
        }
    }
}
