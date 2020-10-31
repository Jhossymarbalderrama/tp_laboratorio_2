using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAbstractas
{
    public abstract class Universitario : Persona
    {
        private int legajo;

        #region "Constructores"

        /// <summary>
        /// Cosntructor por defecto de la clase universitario que instancia los datos por defecto 
        /// </summary>
        public Universitario():base()
        {
            this.legajo = 0;
        }

        /// <summary>
        /// Sobrecarga del constructor Universitario que instancia los datos de un Universitario
        /// </summary>
        /// <param name="legajo">Legajo del  Universitario</param>
        /// <param name="nombre">Nombre del Universitario</param>
        /// <param name="apellido">Apeliido del Universitario</param>
        /// <param name="dni">Dni del Universitario</param>
        /// <param name="nacionalidad">Nacionalidad del Universtiario</param>
        public Universitario(int legajo,string nombre,string apellido,string dni,ENacionalidad nacionalidad)
            :base(nombre,apellido,dni,nacionalidad)
        {
            this.legajo = legajo;
        }
        #endregion

        #region "Metodos"

        /// <summary>
        /// Sobrecarga del Equals
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>Devuelde true si ambos son del mismo tipo, caso contrario false</returns>
        public override bool Equals(object obj)
        {
            return obj.GetType() == this.GetType();
        }

        /// <summary>
        /// Metodo virutal que le da formato a los datos de un universitario
        /// </summary>
        /// <returns>Devuelve los datos de un Universitario</returns>
        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"LEGAJO NUMERO: {this.legajo}");
            return sb.ToString();
        }

        /// <summary>
        /// Firma del metodo abstracto que muestra las clase que se toman o se dan
        /// </summary>
        /// <returns></returns>
        protected abstract string ParticiparEnClase();
        #endregion

        #region "Operadores"

        /// <summary>
        /// Verifica si dos Univesitarios son Iguales
        /// </summary>
        /// <param name="pg1">Un Universtario</param>
        /// <param name="pg2">Otro Universitario</param>
        /// <returns></returns>
        public static bool operator ==(Universitario pg1, Universitario pg2)
        {
            bool rta = false;

            if (pg1.Equals(pg2))
            {
                if (pg1.legajo == pg2.legajo || pg1.DNI == pg2.DNI)
                {
                    rta = true;
                }
            }
            return rta;
        }

        /// <summary>
        /// Verifica si dos universitario son distintos
        /// </summary>
        /// <param name="pg1"></param>
        /// <param name="pg2"></param>
        /// <returns></returns>
        public static bool operator !=(Universitario pg1, Universitario pg2)
        {
            return !(pg1 == pg2);
        }
        #endregion
    }
}
