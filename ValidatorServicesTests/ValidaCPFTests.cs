using Microsoft.VisualStudio.TestTools.UnitTesting;
using ValidatorServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidatorServices.Tests
{
    [TestClass()]
    public class ValidaCPFTests
    {
        [TestMethod()]
        public void IsCpfTestCPFValido()
        {
            var CPF = "40868258059";
            var resultado = ValidaCPF.IsCpf(CPF);
            Assert.IsTrue(resultado);
        }
    }
}