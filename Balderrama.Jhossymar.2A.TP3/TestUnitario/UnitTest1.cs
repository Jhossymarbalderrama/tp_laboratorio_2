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
        /// validacion de la lista de alumnos de una universidad  que no sea nula
        /// </summary>
        [TestMethod]
        public void Lista_Alumnos_Correcta()
        {
            Universidad uni = new Universidad();
            Assert.IsNotNull(uni.Alumnos);
        }

        /// <summary>
        /// Comprueba los DNI Argentinos 
        /// </summary>
        [TestMethod]
        public void DNIValidosArgentino()
        {
            string dniPrimero = "1";
            string dniMedio = new Random().Next(1, 89999999).ToString();
            string dniUltimo = "89999999";


            Alumno alumnoPrimero = new Alumno(1, "Juan", "Gomes", dniPrimero, Persona.ENacionalidad.Argentino, Universidad.EClases.SPD);
            Assert.AreEqual(Convert.ToInt32(alumnoPrimero.DNI), Convert.ToInt32(dniPrimero));

            Alumno alumnoMedio = new Alumno(2, "Ana", "Lopez", dniMedio, Persona.ENacionalidad.Argentino, Universidad.EClases.Legislacion);
            Assert.AreEqual(Convert.ToInt32(alumnoMedio.DNI), Convert.ToInt32(dniMedio));

            Alumno alumnoUltimo = new Alumno(3, "Maxi", "Alvarez", dniUltimo, Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio);
            Assert.AreEqual(Convert.ToInt32(alumnoUltimo.DNI), Convert.ToInt32(dniUltimo));

        }


        /// <summary>
        /// validacion de alumno, que no se repita arrojando AlumnoRepetidoException
        /// </summary>
        [TestMethod]
        public void Alumno_Repetido()
        {
            try
            {
                Universidad uni = new Universidad();

                Alumno a1 = new Alumno(1, "pepe", "argento", "99999999", Persona.ENacionalidad.Extranjero, Universidad.EClases.Programacion);
                Alumno a2 = new Alumno(2, "pepe", "argento", "99999999", Persona.ENacionalidad.Extranjero, Universidad.EClases.Programacion);

                uni += a1;
                uni += a2;

                Assert.Fail("El alumno esta repetido.");
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(AlumnoRepetidoException));
            }
        }
    }
}
