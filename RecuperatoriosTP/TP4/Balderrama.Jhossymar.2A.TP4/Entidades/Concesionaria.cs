using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EntidadesExtension;

namespace Entidades
{
    public class Concesionaria :IConcesionaria
    {

        #region "Atributos"

        public int capacidad;
        protected List<Vehiculo> vehiculos;

        #endregion

        #region "Constructores"
        /// <summary>
        /// Constructor por dafault, Inicializa la lista
        /// </summary>
        public Concesionaria()
        {
            vehiculos = new List<Vehiculo>();
        }

        /// <summary>
        /// Constructor parametrizado, inicializa capacidad y llama al constructor Defautl para inicializar la lista.
        /// </summary>
        /// <param name="capacidad"></param>
        public Concesionaria(int capacidad) : this()
        {
            this.capacidad = capacidad;
        }
        #endregion

        #region "Propiedades"
        /// <summary>
        /// Propiedad Vehiculos (solo lectura).
        /// </summary>
        public List<Vehiculo> Vehiculos
        {
            get { return this.vehiculos; }
        }

        /// <summary>
        /// Propiedad PrecioTotal (Solo lectura)
        /// </summary>
        public double PrecioTotal
        {
            get
            {
                double total = 0;
                foreach (Vehiculo item in vehiculos)
                {
                    total += item.precio;
                }

                return total;
            }
        }
        #endregion

        #region "Metodos"
        /// <summary>
        /// Metodo ToString, Genera en un string toda la informacion de la Concesionaria, + Agrega una cadena mediante la clase Extension.
        /// </summary>
        /// <returns>Retorna en un String la Informacion de la Concesionaria</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            String vehiculoTexto = "texto";

            sb.AppendLine("---------------------------------------------------");
            sb.Append("Concesionaria de ");
            sb.AppendLine(typeof(Concesionaria).Name.ToString());
            sb.Append("Capacidad: ");
            sb.AppendLine(this.capacidad.ToString());
            sb.Append("Cantidad de Vehiculos: ");
            sb.AppendLine(this.vehiculos.Count.ToString());
            sb.Append("Precio Total: ");
            sb.AppendLine(this.PrecioTotal.ToString());
            sb.AppendLine("---------------------------------------------------");
            sb.AppendLine("\nLista de Elementos: \n");

            foreach (Vehiculo item in this.vehiculos)
            {
                sb.Append(vehiculoTexto.ExtensionNombre());
                sb.AppendLine(item.GetType().Name);
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();
        }
        #endregion

        #region "Sobrecargas de Operadores"
        /// <summary>
        /// Operador Igualdad, Verificacion si un Vehiculo (Moto o Auto) se encuentra en una Concesionaria.
        /// </summary>
        /// <param name="c">Concesionaria</param>
        /// <param name="v">Vehiculo</param>
        /// <returns>True si el vehiculo se encuentra en esa Concesionaria, caso contrario False</returns>
        public static bool operator ==(Concesionaria c, Vehiculo v)
        {
            bool rta = false;

            foreach (Vehiculo x in c.vehiculos)
            {
                if (v is Auto || v is Moto)
                {
                    if(x.marca == v.marca && x.precio == v.precio)
                    {
                        rta = true;
                        break;
                    }
                }
            }

            return rta;            
        }

        /// <summary>
        /// Operador Distinto, Verificacion si un vehiculo (Moto o Auto) se encuentra en una Concesionaria
        /// </summary>
        /// <param name="c">Concesionaria</param>
        /// <param name="v">Vehiculo</param>
        /// <returns>True si el Vehiculo no se encuentra en esa Concesionaria, caso contrario False</returns>
        public static bool operator !=(Concesionaria c, Vehiculo v)
        {
            return !(c == v);
        }

        /// <summary>
        /// Operador Adicion, Ingresa un Vehiculo a una Concesionaria, verifica si el vehiculo no se encuentra y si no hay mas espacio.
        /// </summary>
        /// <param name="c">Concesionaria</param>
        /// <param name="v">Vehiculo</param>
        /// <returns>Retorna la Concesionaria ya con el Vehiculo Ingresado, caso contrario la Concesionaria sin cambios</returns>
        public static Concesionaria operator +(Concesionaria c, Vehiculo v)
        {

            if (c != v && !Object.Equals(c, v) && c.vehiculos.Count < c.capacidad)
            {
                c.vehiculos.Add(v);
                Console.WriteLine("El Vehiculo se Agrego correctamente !!!");
            }
            else
            {
                if (c.vehiculos.Count == c.capacidad)
                {
                    Console.WriteLine("Error. No hay mas espacio !!!");

                }                
                else
                {
                    Console.WriteLine("Error. El Vehiculo Repetido !!!");
                }

            }
            return c;
        }

        #endregion
    }
}
