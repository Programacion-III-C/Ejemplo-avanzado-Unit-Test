using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CapaDeDatos;
using MySql.Data.MySqlClient;
namespace UnitTests
{
    [TestClass]
    public class TestsModelo
    {
        [TestMethod]
        public void TestConexion()
        {
            try{
                Modelo m = new Modelo();
                Assert.AreEqual("Open", m.conexion.State.ToString());
            }
            catch{
                Assert.IsTrue(false);
            }


        }
    }
}
