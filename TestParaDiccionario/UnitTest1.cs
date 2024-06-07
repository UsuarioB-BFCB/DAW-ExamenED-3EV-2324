using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Examen3EV;
using System.Collections.Generic;

namespace TestParaDiccionario
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        //[DataRow(" ","hjhjhjh")]
        public void TestPrimeraFraseVacia()//String frase1, String frase2)
        {
            DiccionarioBFCB miDicionario = new DiccionarioBFCB();
            String frase1 = " ";
            String frase2 = "shydfdh";

            try
            {
                miDicionario.Analizar(frase1, frase2);
            }
            catch (ArgumentOutOfRangeException error) 
            {
                StringAssert.Contains(error.Message, miDicionario.ERROR_FRASE1_VACIA);
                return;
            }
            Assert.Fail("Deberia haber saltado una excepcion");
        }

        [TestMethod]
        [DataRow("jkjkj"," ")]
        public void TestSegundaFraseVacia(String frase1, String frase2)
        {
            DiccionarioBFCB miDicionario = new DiccionarioBFCB();
            
            try
            {
                miDicionario.Analizar(frase1, frase2);
            }
            catch (ArgumentOutOfRangeException error)
            {
                StringAssert.Contains(error.Message, miDicionario.ERROR_FRASE2_VACIA);
                return;
            }
            Assert.Fail("Deberia haber saltado una excepcion");
        }
    }
}
