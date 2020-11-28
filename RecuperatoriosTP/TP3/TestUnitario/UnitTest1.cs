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
            Assert.AreEqual(dniIncorrectoExt, a1.DNI);

            Alumno a2 = new Alumno(2, "Jose", "Maria", dniIncorrectoArg, Persona.ENacionalidad.Argentino, Universidad.EClases.Legislacion);
            Assert.AreEqual(dniIncorrectoArg, a2.DNI);

        }

        /// <summary>
        /// Verificacion de Alumno Repetidos
        /// </summary>
        [TestMethod]
        public void VerificaAlumnoRepetido()
        {
            try
            {
                Universidad u = new Universidad();

                Alumno a1 = new Alumno(1, "Pepe", "Argento", "22222222", Persona.ENacionalidad.Argentino, Universidad.EClases.SPD);
                Alumno a2 = new Alumno(1, "Pepe", "Argento", "22222222", Persona.ENacionalidad.Argentino, Universidad.EClases.SPD);

                u += a1;
                u += a2;
            }
            catch(Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(AlumnoRepetidoException));
            }

        }

        /// <summary>
        /// Validacion de DNI con formato incorrecto
        /// Coma
        /// Letras
        /// Arroja DniInvalidoException
        /// </summary>
        [TestMethod]
        public void DniInvalido()
        {
            string dniComa = "89.999,999";
            string dniTexto = "45a54545";

            try
            {
                Alumno personaPrimero = new Alumno(1, "juan", "perez", dniComa, Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio);

                Assert.Fail("Dni Invalido: {0}.", dniComa);
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(DniInvalidoException));
            }


            try
            {
                Alumno personaPrimero = new Alumno(1, "maria", "gomez", dniComa, Persona.ENacionalidad.Extranjero, Universidad.EClases.Laboratorio);


                Assert.Fail("Dni invalido: {0}.", dniTexto);
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(DniInvalidoException));
            }
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
