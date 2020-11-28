using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Entidades;

namespace TestUnitario
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Verificacion de Autos Repetidos
        /// </summary>
        [TestMethod]
        public void VerificacionAutosRepetidos()
        {
                Concesionaria c = new Concesionaria(2);
                int expectativa = 1;    

                Auto a1 = new Auto(ETipo.Deportivo, "renault", 130000);
                Auto a2 = new Auto(ETipo.Deportivo, "renault", 130000);

                c += a1;
                c += a2;

                Assert.AreEqual(expectativa, c.Vehiculos.Count);
        }

        /// <summary>
        /// Verifica si una moto se encuentra ya en la lista de la Concesionaria
        /// </summary>
        [TestMethod]
        public void VerificacionIgualdad()
        {
            Concesionaria c1 = new Concesionaria(2);

            Auto a = new Auto(ETipo.Deportivo, "toyota", 150000);
            Auto a2 = new Auto(ETipo.Deportivo, "toyota", 150000);

            c1 += a;

            bool rta = c1 == a2;

            Assert.IsTrue(rta);
        }

        /// <summary>
        /// Verifica si el vehiculo que le paso es distinto a los q tengo en la Concesionaria
        /// </summary>
        [TestMethod]
        public void VerificacionDistinto()
        {
            Concesionaria c1 = new Concesionaria(2);

            Moto m1 = new Moto(ConsoleColor.White, ECilindrada.cc500, "moster", 140000);
            Moto m2 = new Moto(ConsoleColor.Black, ECilindrada.cc250, "honda", 120000);

            c1 += m1;


            bool rta = c1 != m2;


            Assert.IsTrue(rta);
        }

        /// <summary>
        /// Lista Vehiculos Correcta 
        /// </summary>
        [TestMethod]
        public void ListaVehiculosCorrecta()
        {
            Concesionaria c = new Concesionaria();
            Assert.IsNotNull(c.Vehiculos);
        }


        /// <summary>
        /// Verifica la capacidad de una Concesionaria
        /// </summary>
        [TestMethod]
        public void VerificaCapacidad()
        {

            Concesionaria c = new Concesionaria(3);
            int expect = 3;

            Moto m1 = new Moto(ConsoleColor.White, ECilindrada.cc500, "honda", 140000);
            Moto m2 = new Moto(ConsoleColor.Black, ECilindrada.cc250, "moster", 250000);
            Auto a1 = new Auto(ETipo.Deportivo, "toyota", 220000);
            Auto a2 = new Auto(ETipo.Familiar, "renault", 130000);

            c += m1;
            c += a1;
            c += m2;
            c += a2;

            Assert.AreEqual(expect, c.Vehiculos.Count);
        }
    }
}
