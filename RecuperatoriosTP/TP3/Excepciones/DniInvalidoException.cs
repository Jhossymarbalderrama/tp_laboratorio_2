using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class DniInvalidoException : Exception
    {
        /// <summary>
        /// excepcion dni invalido
        /// </summary>
        public DniInvalidoException()
            :base("DNI con error de Formato")
        {

        }
        /// <summary>
        /// excepcion de dni invalido, muestra el tipo de excepcion
        /// </summary>
        /// <param name="e"></param>
        public DniInvalidoException(Exception e)
            : base("DNI con error de Formato :"+ e.Message)
        {

        }
        /// <summary>
        /// excepcion dni invalido, tipo string 
        /// </summary>
        /// <param name="message"></param>
        public DniInvalidoException(string message)
            : base(message)
        {

        }
        /// <summary>
        /// excepcion dni invalido
        /// </summary>
        /// <param name="message"></param>
        /// <param name="e"></param>
        public DniInvalidoException(string message,Exception e)
            : base(message,e)
        {

        }
    }
}
