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
            Concesionaria c = new Concesionaria();

            Auto a1 = new Auto(ETipo.Deportivo, "renault", 130000);
            Auto a2 = new Auto(ETipo.Deportivo, "renault", 130000);

            c += a1;
            c += a2;
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
    }
}
