using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {
        /// <summary>
        ///  Validacion de Operadores
        /// </summary>
        /// <param name="operador">Operador</param>
        /// <returns>Retorna un Operador Valido, caso contrario +</returns>
        private static string ValidarOperador(char operador)
        {
            string retorno = "+";

            if (operador == '+' || operador == '-' || operador == '/' || operador == '*')
            {
                retorno = Convert.ToString(operador);
            }

            return retorno;
        }

        /// <summary>
        ///  Metodo Operar, Retorna el resultado de num1 y num2 dependiendo su Operador
        /// </summary>
        /// <param name="num1">valor 1</param>
        /// <param name="num2">valor 2</param>
        /// <param name="operador">Operador</param>
        /// <returns>Resultado de la operacion</returns>
        public static double Operar(Numero num1, Numero num2, char operador)
        {
            double retorno = 0;
            string operatorValido;

            operatorValido = ValidarOperador(operador);

            if (num1 != null && num2 != null)
            {
                switch (operatorValido)
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
                    default:
                        retorno = num1 + num2;
                        break;
                }
            }

            return retorno;
        }

    }
}
