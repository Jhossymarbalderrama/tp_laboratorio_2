using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        #region Atributos
        /// <summary>
        ///     Atributo numero
        /// </summary>
        private double numero;
        #endregion

        #region Set and Get
        /// <summary>
        ///     Set: Seteo de numero que valida el valor(value) ingresado para seteartlo al Atributo numerto
        ///     Get: No contiene.
        /// </summary>
        public String SetNumero
        {
            //get { return SetNumero; }
            set { this.numero = ValidarNumero(value); }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor Numero, inicializacion del Atributo numero en 0
        /// </summary>
        public Numero()//Constructor sin Parametros
        {
            this.numero = 0;
        }

        /// <summary>
        /// Sobrecarga Constructor Numero, setea el atributo numero con lo que recibe en la variable Double valor
        /// </summary>
        /// <param name="valor"></param>
        public Numero(double valor)//Constructor con 1 Parametro (Double)
        {
            this.numero = valor;
        }

        /// <summary>
        /// Sobrecarga Constructor Numero, setea el atributo numero con lo que  recibe en la variable String valor 
        /// </summary>
        /// <param name="valor"></param>
        public Numero(string valor)//Constructor  con 1 Parametro (String)
        {
            this.SetNumero = valor;
        }
        #endregion


        #region Metodos
        /// <summary>
        ///  Validacion de la variable strNumero si es un Numero
        /// </summary>
        /// <param name="strNumero">numero a ser validado</param>
        /// <returns>El numero o 0</returns>
        private Double ValidarNumero(String strNumero)
        {
            double retorno;

            double.TryParse(strNumero, out retorno);

            /** 
            bool compar = true;
            Double valor;
            Double retorno = 0;


            if (compar == Double.TryParse(strNumero, out valor)) ;
            {
                retorno = valor;
            }
             */

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

            if(double.TryParse(numero,out aux))
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

        /// <summary>
        /// Operador Resta, resta las 2 variables pasadas por parametro y devuelve el resultado.
        /// </summary>
        /// <param name="valor_1">valor 1 </param>
        /// <param name="valor_2">valor 2</param>
        /// <returns>retorna el Resultado de la Operacion</returns>
        public static double operator -(Numero valor_1,Numero valor_2)
        {
            double auxNum;
            auxNum = valor_1.numero - valor_2.numero;

            return auxNum;
        }

        /// <summary>
        /// Opeador Multiplicacion, multiplica el primer valor pasado por parametro contra el 2 valor.
        /// </summary>
        /// <param name="valor_1">valor 1</param>
        /// <param name="valor_2">valor 2</param>
        /// <returns>retorna el Resultado de la Operacion</returns>
        public static double operator *(Numero valor_1, Numero valor_2)
        {
            double auxNum;

            auxNum = valor_1.numero * valor_2.numero;

            return auxNum;
        }

        /// <summary>
        /// Operador Division, Divide el primer valor contra el segundo.
        /// </summary>
        /// <param name="valor_1">valor 1</param>
        /// <param name="valor_2">valor 2</param>
        /// <returns>retorna el resultado de la Operacion</returns>
        public static double operator /(Numero valor_1, Numero valor_2)
        {
            double auxNum;

            auxNum = valor_1.numero / valor_2.numero;

            return auxNum;
        }

        /// <summary>
        /// Operador Suma, suma el valor 1 con el 2 pasador por parametro.
        /// </summary>
        /// <param name="valor_1">valor 1</param>
        /// <param name="valor_2">valor 2</param>
        /// <returns>Retorna el Resultado de la Operacion</returns>
        public static double operator +(Numero valor_1, Numero valor_2)
        {
            double auxNum;

            auxNum = valor_1.numero + valor_2.numero;

            return auxNum;
        }

        #endregion  
    }
}
