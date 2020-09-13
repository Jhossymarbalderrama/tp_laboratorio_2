using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {
        public static double Operar(Numero num1, Numero num2, string operador)
        {
            double retorno = 0;

            operador = ValidarOperador(operador);

            if (num1 != null && num2 != null)
            {
                switch (operador)
                {
                    case "+":
                        retorno = num1 + num2;
                        break;

                    case "-":
                        retorno = num1 - num2;
                        break;

                    case "*":
                        retorno = num1 * num2;
                        break;

                    case "/":
                        retorno = num1 / num2;
                        break;
                }
            }

            return retorno;
        }

        /// <summary>
        /// Validacion de Operador (switch)
        /// </summary>
        /// <param name="operador">Operador (+,-,*,/)</param>
        /// <returns>Retorna el Operador</returns>
        private static string ValidarOperador(string operador)
        {
            string retorno = "+";

            if (operador == "+" || operador == "-" || operador == "/" || operador == "*")
            {
                retorno = operador;
            }

            return retorno;
        }

    }
}
