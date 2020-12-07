using System;
using CShap_TDD;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CShap_TDD_UnitTest
{
    [TestClass]
    public class LoginTest
    {
        [TestMethod]
        public void CallLoginProcessTest()
        {
            string id = "admin";
            string pwd = "123";
            Login login = new Login();
            bool result = login.CallLoginProcess(id, pwd);
            Assert.IsTrue(result);
            
        }
    }
}
