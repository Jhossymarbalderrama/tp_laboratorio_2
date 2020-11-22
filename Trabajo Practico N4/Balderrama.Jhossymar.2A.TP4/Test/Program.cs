using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string marcaA1 = "RENAULT";
            string marcaA2 = "CITROEN";
            string marcaA3 = "TOYOTA";

            string marcaM1 = "DUCATI";
            string marcaM2 = "BMW";


            Concesionaria lista = new Concesionaria(6);

            Auto a1 = new Auto(ETipo.Deportivo, marcaA3, 450000);
            Moto m1 = new Moto(ConsoleColor.Red,ECilindrada.cc125,marcaM1,150000);
            Moto m2 = new Moto(ConsoleColor.Black,ECilindrada.cc250,marcaM2,437500);
            Moto m3 = new Moto(ConsoleColor.Black,ECilindrada.cc50,marcaM1,120000);
            Auto a2 = new Auto(ETipo.Familiar, marcaA1, 285900);
            Auto a3 = new Auto(ETipo.Coupe, marcaA2, 390500);
            Auto a4 = new Auto(ETipo.Sedan, marcaA1, 96300);


            lista += a1;
            //YA INGRESO
            lista += a1;

            lista += m1;
            lista += m2;
            lista += m3;
            lista += a2;
            lista += a3;
            //SIN LUGAR
            lista += a4;

            Console.WriteLine(lista.ToString());
            Console.ReadLine();
        }
    }
}
