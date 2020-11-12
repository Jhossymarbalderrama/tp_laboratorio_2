using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos;


namespace Clases_Instanciables
{
    public class Jornada
    {
        private List<Alumno> alumnos;
        private Universidad.EClases clase;
        private Profesor instructor;


        #region "Propiedades"

        /// <summary>
        /// Propiedad, lectura y escritura de Lista de alumnos 
        /// </summary>
        public List<Alumno> Alumnos
        {
            get { return this.alumnos; }
            set { this.alumnos = new List<Alumno>(value); }
        }

        /// <summary>
        /// Propiedad, lectura y escritura de la clase
        /// </summary>
        public Universidad.EClases Clase
        {
            get { return this.clase; }
            set { this.clase = value; }
        }

        /// <summary>
        ///  Propiedad, lectura y escritura del profesor(instructor)
        /// </summary>
        public Profesor Instructor
        {
            get { return this.instructor; }
            set { this.instructor = value; }
        }
        #endregion

        #region "Constructorse"

        /// <summary>
        /// Constuctor por defecto de la jornada que inicializa la lista de alumnos
        /// </summary>s
        private Jornada()
        {
            this.alumnos = new List<Alumno>();
        }

        /// <summary>
        /// Sobrecarga del constructor por defecto que instancia la clase y el instrcutor
        /// </summary>
        /// <param name="clase"></param>
        /// <param name="instructor"></param>
        public Jornada(Universidad.EClases clase,Profesor instructor)
            :this()
        {
            this.Clase = clase;
            this.Instructor = instructor;
        }
        #endregion

        #region "Metodos"

        /// <summary>
        /// Lee los datos de una Jornada de un archivo de texto
        /// </summary>
        /// <returns>Devuelve los datos de la jornada</returns>
        public static string Leer()
        {
            Texto t = new Texto();
            t.Leer("Jornada.txt", out string datos);
            return datos;
        }

        /// <summary>
        /// Guarda los datos de una jornada en archivo de texto(.txt)
        /// </summary>
        /// <param name="jornada">La Jornada</param>
        /// <returns>True si se pudo guardar, false en caso contrario</returns>
        public static bool Guardar(Jornada jornada)
        {
            Texto t = new Texto();
            return t.Guardar("Jornada.txt", jornada.ToString());
        }

        /// <summary>
        /// Da formato a los datos de una jornada
        /// </summary>
        /// <returns>Devuelve los datos de una jornada</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("CLASE DE " + this.Clase + " POR " + this.Instructor.ToString());
            sb.AppendLine("ALUMNOS: ");

            foreach (Alumno alumno in this.Alumnos)
            {
                sb.AppendLine(alumno.ToString());
            }
            sb.AppendLine("<------------------------------------------------>");

            return sb.ToString();
        }
        #endregion

        #region "Operadores"

        /// <summary>
        /// valida si un alumno parcipa en la clase de una jornada
        /// </summary>
        /// <param name="j">La Jornada</param>
        /// <param name="a">El alumno</param>
        /// <returns>Devuelve true si el alumno participa en la calse, false en caso contrario</returns>
        public static bool operator ==(Jornada j,Alumno a)
        {
            return (!(a != j.clase));
        }

        /// <summary>
        /// valida si un alumno no participa en la clase de una jornada
        /// </summary>
        /// <param name="j">La Jornada</param>
        /// <param name="a">El Alumno</param>
        /// <returns>Devuelde true si no participa, false en caso contrario</returns>
        public static bool operator !=(Jornada j, Alumno a)
        {
            return !(j == a);
        }


        /// <summary>
        /// Agrega un Alumno a la Clase si este no parcipa de ella
        /// </summary>
        /// <param name="j">La jornada</param>
        /// <param name="a">El Alumno</param>
        /// <returns>Devuelde la Jornada</returns>
        public static Jornada operator +(Jornada j, Alumno a)
        {
            if (j != a)
            {
                j.Alumnos.Add(a);
            }
            return j;
        }
        #endregion
    }
}
