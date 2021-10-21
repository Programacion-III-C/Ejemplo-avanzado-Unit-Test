using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CapaDeDatos;
namespace UnitTests
{
    [TestClass]
    public class TestsPersonaModelo

    {
        [TestMethod]
        public void TestAlta()
        {
            try{
                PersonaModelo p = new PersonaModelo();
                p.Nombre = "Juan";
                p.Apellido = "Perez";
                p.Mail = "coso@loco.com";
                p.Guardar();

                Assert.IsTrue(true);
            }
            catch{
                Assert.IsTrue(false);
            }
        }

        [TestMethod]
        public void TestObtenerUno()
        {
            try
            {
                PersonaModelo p = new PersonaModelo();
                p.Obtener(p.GetLastId());

                Assert.IsNotNull(p.Nombre);
                Assert.IsNotNull(p.Apellido);
                Assert.IsNotNull(p.Mail);

            }
            catch
            {
                Assert.IsTrue(false);
            }
        }
    }
}
