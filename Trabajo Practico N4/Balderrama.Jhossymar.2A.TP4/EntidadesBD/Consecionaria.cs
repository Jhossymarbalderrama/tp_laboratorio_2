using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesBD
{
    public class Consecionaria
    {
        #region "Atributos"

        private int id;
        private string marca;
        private float precio;
        private string tipo;

        #endregion

        #region "Propiedades"

        public Int32 ID
        {
            get
            {
                return this.id;
            }
        }
        public String Marca
        {
            get
            {
                return this.marca;
            }
            set
            {
                this.marca = value;
            }
        }

        public Single Precio
        {
            get
            {
                return this.precio;
            }
            set
            {
                this.precio = value;
            }
        }

        public String Tipo
        {
            get
            {
                return this.tipo;
            }
            set
            {
                this.tipo = value;
            }
        }

        #endregion

        #region "Constructor"

        /// <summary>
        /// Inicializa una Concesionaria
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="precio"></param>
        /// <param name="tipo"></param>
        public Consecionaria(string marca, float precio, string tipo)
        {
            this.marca = marca;
            this.precio = precio;
            this.tipo = tipo;
        }

        /// <summary>
        /// Inicializa una Concesionaria
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="marca"></param>
        /// <param name="precio"></param>
        /// <param name="tipo"></param>
        public Consecionaria(int ID, string marca, float precio, string tipo)
            : this(marca, precio, tipo)
        {
            this.id = ID;
        }

        #endregion
    }
}
