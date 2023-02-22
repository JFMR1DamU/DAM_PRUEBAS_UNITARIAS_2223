using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using gestionBancariaApp;

namespace gestionBancariaTest
{
    [TestClass]
    public class gestionBancariaTest
    {
        // unit test code [TestMethod]

        [TestMethod]
        public void validarMetodoIngreso()
        {
            // preparación del caso de prueba
            double saldoInicial = 1000;
            double ingreso = 500;
            double saldoActual;
            double saldoEsperado = 1500;
            gestionBancaria cuenta = new gestionBancaria(saldoInicial);
            // Método a probar
            cuenta.realizarIngreso(ingreso);
            // afirmación de la prueba (valor esperado Vs. Valor obtenido)
            saldoActual = cuenta.obtenerSaldo();
            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto");
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void testIngreso1()
        {
            double ingreso = -1;
            double saldoInicial = 1000;
            double saldoActual;

            gestionBancaria cuenta = new gestionBancaria(saldoInicial);

            cuenta.realizarIngreso(ingreso);
            saldoActual = cuenta.obtenerSaldo();
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void testIngreso2()
        {
            double ingreso = 0;
            double saldoInicial = 1000;
            double saldoActual;

            gestionBancaria cuenta = new gestionBancaria(saldoInicial);

            cuenta.realizarIngreso(ingreso);
            saldoActual = cuenta.obtenerSaldo();

            Assert.AreEqual(saldoInicial, saldoActual);
        }
        [TestMethod]
        public void testIngreso3()
        {
            double ingreso = 1;
            double saldoInicial = 1000;
            double saldoActual;
            double saldoEsperado = 1001;

            gestionBancaria cuenta = new gestionBancaria(saldoInicial);

            cuenta.realizarIngreso(ingreso);
            saldoActual = cuenta.obtenerSaldo();

            Assert.IsTrue(saldoActual == saldoEsperado);
        }
        [TestMethod]
        public void testIngreso4()
        {
            double ingreso = 1000000000;
            double saldoInicial = 1000;
            double saldoActual;

            gestionBancaria cuenta = new gestionBancaria(saldoInicial);

            cuenta.realizarIngreso(ingreso);
            saldoActual = cuenta.obtenerSaldo();

            Assert.IsTrue(saldoActual > saldoInicial);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void testReintegro1()
        {
            double Cantidad = -1;
            double saldoInicial = 1000;
            double saldoActual;

            gestionBancaria cuenta = new gestionBancaria(saldoInicial);

            cuenta.realizarReintegro(Cantidad);
            saldoActual = cuenta.obtenerSaldo();

        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void testReintegro2()
        {
            double cantidad = 0;
            double saldoInicial = 1000;
            double saldoActual;

            gestionBancaria cuenta = new gestionBancaria(saldoInicial);

            cuenta.realizarReintegro(cantidad);
            saldoActual = cuenta.obtenerSaldo();

            Assert.AreEqual(saldoInicial, saldoActual);

        }
        [TestMethod]
        public void testReintegro3()
        {
            double ingreso = 0.01;
            double saldoInicial = 1000;
            double saldoActual;
            double saldoEsperado = 999.99;

            gestionBancaria cuenta = new gestionBancaria(saldoInicial);

            cuenta.realizarReintegro(ingreso);
            saldoActual = cuenta.obtenerSaldo();

            Assert.IsTrue(saldoActual == saldoEsperado);
        }
        [TestMethod]
        public void testReintegro4()
        {  
            double saldoInicial = 1000;
            double cantidad = 999.99;
            double saldoActual;
            double saldoEsperado = saldoInicial-cantidad;

            gestionBancaria cuenta = new gestionBancaria(saldoInicial);

            cuenta.realizarReintegro(cantidad);
            saldoActual = cuenta.obtenerSaldo();

            Assert.IsTrue(saldoActual == saldoEsperado);
        }
        [TestMethod]
        public void testReintegro5()
        {
            double saldoInicial = 1000;
            double saldoActual;
            double saldoEsperado = 0;

            gestionBancaria cuenta = new gestionBancaria(saldoInicial);

            cuenta.realizarReintegro(saldoInicial);
            saldoActual = cuenta.obtenerSaldo();

            Assert.IsTrue(saldoActual == saldoEsperado);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void testReintegro6()
        {
            double saldoInicial = 1000;
            double cantidad = 1001;
            double saldoActual;

            gestionBancaria cuenta = new gestionBancaria(saldoInicial);

            cuenta.realizarReintegro(cantidad);
            saldoActual = cuenta.obtenerSaldo();

        }
    }
}
