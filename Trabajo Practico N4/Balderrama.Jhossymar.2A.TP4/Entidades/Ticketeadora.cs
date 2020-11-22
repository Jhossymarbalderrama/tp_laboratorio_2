﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace Entidades
{
    public static class Ticketeadora<T> where T: Vehiculo
    {     

        /// <summary>
        /// Metodo Statico, Imprime un Ticket en el Escritorio llamado tickets.log, 
        /// Si el Archivo no existe lo Crea y lo escribe con los datos de T, Si existe lo sobre escribe.
        /// </summary>
        /// <param name="car"></param>
        /// <returns>retorna true si no paso nada, caso contrario False</returns>
        public static bool ImprimirTicket(T car)
        {
            bool rta = true;

            string path = Environment.GetFolderPath(System.Environment.SpecialFolder.Desktop) + @"\tickets.log";
            //string path = "Tickets.log";

            if (!File.Exists(path))
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(path, false))
                    {
                        sw.Write("Tipo: ");
                        if (car is Auto)
                        {
                            sw.WriteLine("Auto");
                        }
                        else
                        {
                            sw.WriteLine("Moto");
                        }

                        sw.Write("Marca: ");
                        sw.WriteLine(car.marca);
                        sw.Write("Fecha: ");
                        sw.WriteLine(System.DateTime.Now);
                        sw.Write("Precio : ");
                        sw.WriteLine(car.precio);
                        sw.WriteLine("------ o ---------------- o ---------------- o ------");
                    }
                }
                catch
                {
                    rta = false;
                }
            }            
            else
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(path, true))
                    {
                        sw.Write("Tipo: ");
                        if (car is Auto)
                        {
                            sw.WriteLine("Auto");
                        }
                        else
                        {
                            sw.WriteLine("Moto");
                        }

                        sw.Write("Marca: ");
                        sw.WriteLine(car.marca);
                        sw.Write("Fecha: ");
                        sw.WriteLine(System.DateTime.Now);
                        sw.Write("Precio: ");
                        sw.WriteLine(car.precio);
                        sw.WriteLine("------ o ---------------- o ---------------- o ------");
                    }
                }
                catch
                {
                    rta = false;
                }

            }


            return rta;
        }
    }
}
