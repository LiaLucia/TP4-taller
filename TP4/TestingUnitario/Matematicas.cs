using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EJ2;

namespace TestingUnitario
{
    [TestClass]
    public class Matematicas
    {
        [TestMethod]
        [ExpectedException(typeof(DivisionPorCeroException))]
        public void DividePorCero()
        {
            Matematica Mate = new Matematica();
            Mate.Dividir(2, 0);
        }

        [TestMethod]
        public void Divide()
        {
            Matematica Mate = new Matematica();
            double resultado = Mate.Dividir(20, 4);
            double resultadoEsperado = 5;
            Assert.AreEqual(resultadoEsperado, resultado);
        }
    }
}
