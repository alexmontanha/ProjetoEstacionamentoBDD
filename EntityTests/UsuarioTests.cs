using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Tests
{
    [TestClass()]
    public class UsuarioTests
    {
        [TestMethod()]
        public void UsuarioTestDataNascimentoDataValida()
        {
            try
            {
                var usuario = new Usuario("Alex", "Montanha", "CPF", "999999", "88888", "email",
                    new DateTime(1990, 7, 1));
                Assert.IsNotNull(usuario);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod()]
        public void UsuarioTestDataNascimentoDataInvalida()
        {
            try
            {
                var usuario = new Usuario("Alex", "Montanha", "CPF", "999999", "88888", "email",
                    DateTime.Now.AddDays(60));
                Assert.Fail("Data de nascimento não pode ser maior que a data atual.");
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Data de nascimento não pode ser maior que a data atual.", ex.Message);
            }
        }
    }
}