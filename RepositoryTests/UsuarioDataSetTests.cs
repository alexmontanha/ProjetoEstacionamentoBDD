using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Tests
{
    [TestClass()]
    public class UsuarioDataSetTests
    {
        [TestMethod()]
        public void FindUsuarioTest()
        {
            var usuarioDataSet = new UsuarioDataSet();
            var resultado = usuarioDataSet.FindUsuario("Alex");
            Assert.AreEqual("123", resultado);
        }

        [TestMethod()]
        public void NotFindUsuarioTest()
        {
            var usuarioDataSet = new UsuarioDataSet();
            var resultado = usuarioDataSet.FindUsuario("String Maluca");
            Assert.IsNull(resultado);
        }

    }
}