using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class DniInvalidoException : Exception
    {
        public DniInvalidoException():base("DNI con error de Formato")
        {

        }
        public DniInvalidoException(Exception e)
            : base("DNI con error de Formato :"+ e.Message)
        {

        }
        public DniInvalidoException(string message)
            : base(message)
        {

        }
        public DniInvalidoException(string message,Exception e)
            : base(message,e)
        {

        }
    }
}
