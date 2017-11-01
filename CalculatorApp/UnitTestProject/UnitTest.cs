using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserApp.src.Model;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void ValidCPFTestMethod()
        {
            string cpf = "614.033.132-37";
            Assert.IsTrue(UserValidations.IsCpfValid(cpf));
        }
    }
}
