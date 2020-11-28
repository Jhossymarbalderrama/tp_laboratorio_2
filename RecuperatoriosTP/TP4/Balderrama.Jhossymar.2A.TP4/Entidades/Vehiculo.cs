using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Vehiculo : IVehiculos
    {
        #region "Atributos"
            public string marca;
            public double precio;
        #endregion

        #region "Constructores"
        /// <summary>
        /// Constructor por Default de Vehiculo
        /// </summary>
        public Vehiculo()
        {

        }

        /// <summary>
        /// Constructor parametrizado, inicializo marca y precio
        /// </summary>
        /// <param name="marca">marca de Vehiculo</param>
        /// <param name="precio">precio de Vehiculo</param>
        public Vehiculo(string marca, double precio)
        {
            this.marca = marca;
            this.precio = precio;
        }
        #endregion

        #region "Propiedades"
        /// <summary>
        /// Propiedad Marca(solo lectura)
        /// </summary>
        public string Marca
        {
            get { return this.marca; }
        }

        /// <summary>
        /// Propiedad Precio(solo lectura)
        /// </summary>
        public double Precio
        {
            get { return this.precio; }
        }

        #endregion

        #region "Metodos"
        /// <summary>
        /// Metodo Virtual, retornara Marca y Precio del Vehiculo
        /// </summary>
        /// <returns>Retorna un String de la Marca y Precio del Vehiculo</returns>
        public virtual string VehiculosToString()
        {
            return "Marca : " + this.marca.ToString() + " - Precio: " + this.precio.ToString();
        }

        /// <summary>
        /// Metodo ToString() retornara los Datos del Vehiculo
        /// </summary>
        /// <returns>Retorna un String con los datos del Vehiculo</returns>
        public override string ToString()
        {
            return this.VehiculosToString();
        }
        #endregion

    }
}
