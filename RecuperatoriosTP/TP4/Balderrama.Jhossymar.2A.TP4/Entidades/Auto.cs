using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Auto : Vehiculo
    {
        #region "Atributos"

         public ETipo tipo;

        #endregion

        #region "Constructores"
        /// <summary>
        /// Unico Constructor parametrizado, que inicializa su atributo propio de Clase y Crea el Vehiculo(marca y precio).
        /// </summary>
        /// <param name="tipo">tipo</param>
        /// <param name="marca">marca</param>
        /// <param name="precio">precio</param>
        public Auto(ETipo tipo, string marca, double precio)
            : base(marca, precio)
        {
            this.tipo = tipo;
        }
        #endregion

        #region "Propiedades"

        /// <summary>
        /// Propiedad Tipo(Enumerado), Solo Lectura
        /// </summary>
        public ETipo Tipo
        {
            get { return this.tipo; }
        }
        #endregion

        #region "Metodos"
        /// <summary>
        /// Metodo ToString, Retornara toda la informacion del Vehiculo.
        /// </summary>
        /// <returns>retorna un string con los datos del Vehiculo</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.VehiculosToString());
            sb.Append("Tipo: ");
            sb.AppendLine(this.tipo.ToString());

            return sb.ToString();
        }
        #endregion
    }
}
