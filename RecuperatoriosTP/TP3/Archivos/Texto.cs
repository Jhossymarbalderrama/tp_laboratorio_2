using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Excepciones;

namespace Archivos
{
    public class Texto : IArchivo<string>
    {
        /// <summary>
        /// Guarda un Archivo de texto Datos de cualquier Tipo
        /// </summary>
        /// <param name="archivo">Ruta al archivo</param>
        /// <param name="datos">Datos a guardar</param>
        /// <returns>true si se guardo, false caso contrario</returns>
        public bool Guardar(string archivo, string datos)
        {
            bool rta = false;
            try
            {
                using (StreamWriter sw = new StreamWriter(archivo,true))
                {
                    sw.WriteLine(datos);
                    rta = true;
                }
            }
            catch (Exception e)
            {
                throw new ArchivosException(e);
            }

            return rta;
        }

        /// <summary>
        /// Lee Datos de un Archivo de texto en la ruta pasada como parametro y lo carga en el string
        /// </summary>
        /// <param name="archivo">Ruta del archivo</param>
        /// <param name="datos">Datos a guardar</param>
        /// <returns></returns>
        public bool Leer(string archivo, out string datos)
        {
            bool rta = false;
            datos = null;
            try
            {
                using (StreamReader sr = new StreamReader(archivo))
                {
                    datos = sr.ReadToEnd();
                    rta = true;
                }
            }
            catch (Exception e)
            {
                throw new ArchivosException(e);
            }
            return rta;
        }

    }
}
