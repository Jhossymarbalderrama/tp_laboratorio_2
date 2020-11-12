using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EntidadesAbstractas;
using Clases_Instanciables;
using Excepciones;

namespace TestUnitario
{
    [TestClass]
    public class UnitTest1
    {

        /// <summary>
        /// Verificacion de DNI Incorrectos
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(NacionalidadInvalidaException))]
        public void VerificaNacionalidadesInvalida()
        {
            string dniIncorrectoExt = "10000000";
            string dniIncorrectoArg = "99999999";


            Alumno a1 = new Alumno(1, "Ana", "Lopez", dniIncorrectoExt, Persona.ENacionalidad.Extranjero, Universidad.EClases.Laboratorio);
            Alumno a2 = new Alumno(2, "Jose", "Maria", dniIncorrectoArg, Persona.ENacionalidad.Argentino, Universidad.EClases.Legislacion);

        }

        /// <summary>
        /// Verificacion de Alumno Repetidos
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(AlumnoRepetidoException))]
        public void VerificaAlumnoRepetido()
        {
            Universidad u = new Universidad();

            Alumno a1 = new Alumno(1, "Pepe", "Argento", "22222222", Persona.ENacionalidad.Argentino, Universidad.EClases.SPD);
            Alumno a2 = new Alumno(1, "Pepe", "Argento", "22222222", Persona.ENacionalidad.Argentino, Universidad.EClases.SPD);

            u += a1;
            u += a2;
        }

        /// <summary>
        /// Lista Jornadas Correcta
        /// </summary>
        [TestMethod]
        public void ListaJornadasCorrecta()
        {
            Universidad u = new Universidad();
            Assert.IsNotNull(u.Jornadas);
        }
    }
}
