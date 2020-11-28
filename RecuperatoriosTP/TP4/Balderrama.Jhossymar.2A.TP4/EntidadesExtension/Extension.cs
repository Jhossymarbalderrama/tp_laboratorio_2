using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesExtension
{
    public static class Extension
    {
        /// <summary>
        /// ExtensionNombre Retorna un String, esta extension se implementa al generar el toString en Concesionaria.
        /// </summary>
        /// <param name="s">String</param>
        /// <returns>String</returns>
        public static string ExtensionNombre(this String s)
        {
            return "Vehiculo: ";
        }
    }
}
