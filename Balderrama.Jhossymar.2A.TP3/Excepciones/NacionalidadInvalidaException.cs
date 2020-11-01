using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class NacionalidadInvalidaException : Exception
    {
        /// <summary>
        /// Excepcion nacionalidad invalida
        /// </summary>
        public NacionalidadInvalidaException() 
            : this("DNI con formato Incorrecto")
        {

        }
        /// <summary>
        /// excepcion nacionalidad invalida, muestra la exepcion(menssage)
        /// </summary>
        /// <param name="menssage"></param>
        public NacionalidadInvalidaException(string menssage)
            : base(menssage)
        {

        }
    }
}
