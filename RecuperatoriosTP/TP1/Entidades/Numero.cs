using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        private double numero;

        #region "Constructores"
        /// <summary>
        /// Constructor por Default, inicializa numero en 0
        /// </summary>
        public Numero()
        {
            this.numero = 0;
        }

        /// <summary>
        /// Sobrecarga de constructor, inicializa numero con el valor(double) pasado por parametro
        /// </summary>
        /// <param name="numero">valor</param>
        public Numero(double numero):this(numero.ToString()) 
        {           
        }

        /// <summary>
        /// Sobrecarga de Constructor,inicializa numero con el valor(string) pasado por parametro
        /// </summary>
        /// <param name="StrNumero">valor</param>
        public Numero(string StrNumero) :this()
        {
            this.SetNumero = StrNumero;
        }
        #endregion

        #region "Propiedades"
        /// <summary>
        /// Seter de numero, establece un numero en el atributo solo si se pudo validar, caso contrario 
        /// lo establece en 0,
        /// </summary>
        private string SetNumero
        {
            set { this.numero = ValidarNumero(value); }
        }
        #endregion

        #region "Metodos"
        /// <summary>
        ///  Validacion de la variable strNumero si es un Numero
        /// </summary>
        /// <param name="strNumero">numero a ser validado</param>
        /// <returns>El numero o 0</returns>
        private double ValidarNumero(string strNumero)
        {
            double retorno = 0;

            double.TryParse(strNumero, out retorno);

            return retorno;
        }

        /// <summary>
        /// Verificacion de variable si son binarias
        /// </summary>
        /// <param name="binario">variable de entrada</param>
        /// <returns>1 si es binario o 0 si no lo es</returns>
        private bool EsBinario(string binario)
        {
            int cont = 0;

            foreach (var item in binario)
            {
                if (item == 0 || item == 1)
                {
                    cont++;
                }
            }

            if (cont == binario.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// Convierte en binario la variable strin binario pasado por parametro en un numero decimal
        /// </summary>
        /// <param name="binario">variable a convertir a decimal</param>
        /// <returns>retorna variable convertida o Valor Invalido</returns>
        public static string BinarioDecimal(string binario)
        {
            bool auxBin = true;
            string strAux = "Valor Invalido";

            if (binario != null && binario != "")
            {

                foreach (var item in binario)
                {
                    if (item != '0' && item != '1')
                    {
                        auxBin = false;

                    }

                }

                if (auxBin == true)
                {
                    strAux = Convert.ToInt32(binario, 2).ToString();
                }
            }


            return strAux;
        }


        /// <summary>
        /// Convierte la variable pasado por parametro en Binario.
        /// </summary>
        /// <param name="numero">variable a convertir</param>
        /// <returns>La variable convertida o  Valor Invalido</returns>
        public static string DecimalBinario(string numero)
        {
            string strAux = "Valor Invalido";
            double aux;

            if (double.TryParse(numero, out aux))
            {
                strAux = DecimalBinario(aux);
            }

            return strAux;
        }


        /// <summary>
        /// Convierte la variable double numero en Binario.
        /// </summary>
        /// <param name="numero">variable decimal a convertir</param>
        /// <returns>retorna la variable ya convertida a binario</returns>
        public static string DecimalBinario(double numero)
        {
            return Convert.ToString((int)Math.Abs(numero), 2);
        }

        #endregion

        #region "Operadores"
        /// <summary>
        /// Operador Resta, resta las 2 variables pasadas por parametro y devuelve el resultado.
        /// </summary>
        /// <param name="n1">valor 1 </param>
        /// <param name="n2">valor 2</param>
        /// <returns>retorna el Resultado de la Operacion</returns>
        public static double operator -(Numero n1, Numero n2)
        {
            return (n1.numero - n2.numero);
        }


        /// <summary>
        /// Opeador Multiplicacion, multiplica el primer valor pasado por parametro contra el 2 valor.
        /// </summary>
        /// <param name="n1">valor 1</param>
        /// <param name="n2">valor 2</param>
        /// <returns>retorna el Resultado de la Operacion</returns>
        public static double operator *(Numero n1, Numero n2)
        {
            return (n1.numero * n2.numero);
        }


        /// <summary>
        /// Operador Division, Divide el primer valor contra el segundo.
        /// </summary>
        /// <param name="n1">valor 1</param>
        /// <param name="n2">valor 2</param>
        /// <returns>retorna el resultado de la Operacion</returns>
        public static double operator /(Numero n1, Numero n2)
        {
            double auxNum;

            if (n2.numero == 0)
            {
                auxNum = double.MinValue;
            }
            else
            {
                auxNum = n1.numero / n2.numero;               
            }

            return auxNum;
        }

        /// <summary>
        /// Operador Suma, suma el valor 1 con el 2 pasador por parametro.
        /// </summary>
        /// <param name="n1">valor 1</param>
        /// <param name="n2">valor 2</param>
        /// <returns>Retorna el Resultado de la Operacion</returns>
        public static double operator +(Numero n1, Numero n2)
        {   
            return (n1.numero + n2.numero);
        }

        #endregion
    }
}
