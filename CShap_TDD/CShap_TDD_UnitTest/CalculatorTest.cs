using System;
using CShap_TDD;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CShap_TDD_UnitTest
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void AddTest()
        {
            int number1 = 10;
            int number2 = 4;
            int expected = 14;
            Calculator calculator = new Calculator();
            int result = calculator.Add(number1, number2);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void SubTest()
        {
            int number1 = 10;
            int number2 = 4;
            int expected = 10;
            Calculator calculator = new Calculator();
            int result = calculator.Sub(number1, number2);
            Assert.AreEqual(expected, result); //<-- fail
        }
    }
}
