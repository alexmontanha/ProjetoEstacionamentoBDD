using Microsoft.VisualStudio.TestTools.UnitTesting;
using CasosDeUso;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository;

namespace CasosDeUso.Tests
{
    [TestClass()]
    public class LoginTests
    {
        [TestMethod()]
        public void AuthenticateLoginValidoTest()
        {
            var login = new Login("Alex", "123", new UsuarioDataSet());
            var resultado = login.Authenticate();
            Assert.AreEqual(1, resultado);
        }


        [TestMethod()]
        public void AuthenticateLoginValidoSenhaInvalidaTest()
        {
            var login = new Login("Alex", "789", new UsuarioDataSet());
            var resultado = login.Authenticate();
            Assert.AreEqual(0, resultado);
        }


        [TestMethod()]
        public void AuthenticateLoginInvalidoTest()
        {
            var login = new Login("Jujuba", "953", new UsuarioDataSet());
            var resultado = login.Authenticate();
            Assert.AreEqual(0, resultado);
        }

    }
}