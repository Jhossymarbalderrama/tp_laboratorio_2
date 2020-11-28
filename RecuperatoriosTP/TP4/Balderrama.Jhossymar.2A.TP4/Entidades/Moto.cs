using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    public class Moto: Vehiculo
    {
        #region "Atributos"

        public ConsoleColor color;
        public ECilindrada cilindrada;

        #endregion

        #region "Constructores"
              
            /// <summary>
            /// Constructor Parametrizado, Inicializa atributos propios y crea el Vehiculo
            /// </summary>
            /// <param name="color">EColor</param>
            /// <param name="cilindrada">ECilindrada</param>
            /// <param name="marca">marca</param>
            /// <param name="precio">precio</param>
            public Moto(ConsoleColor color, ECilindrada cilindrada, string marca, double precio)
                : base(marca, precio)
            {
                this.color = color;
                this.cilindrada = cilindrada;
            }

        #endregion

        #region "Propiedades"

            /// <summary>
            /// Propiedad Cilindrada, solo lectura.
            /// </summary>
            public ECilindrada Cilindarada
            {
                get { return this.cilindrada; }
            }

        #endregion

        #region "Metodos"
            /// <summary>
            /// Metodo ToString, retornara toda la informacion del Vehiculo.
            /// </summary>
            /// <returns>String con la informacion del Vehiculo</returns>
            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();

                sb.AppendLine(base.VehiculosToString());
                sb.Append("Cilindrada: ");
                sb.AppendLine(this.cilindrada.ToString());
                sb.Append("Color: ");
                sb.AppendLine(this.color.ToString());

                return sb.ToString();
            }
        #endregion

    }
}
