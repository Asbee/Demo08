using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApplication.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void AddTest()
        {
            //arrange
            Calculator calr = new Calculator();
            int number = 5;
            int number2 = 7;
            int expected = 12;

            //act
            int actual = calr.Add(number, number2);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MultipleTest()
        {
            //arrange
            Calculator calc = new Calculator();
            int number = 5;
            int number2 = 7;
            int expected = 35;

            //Act
            int actualy = calc.Multiple(number, number2);

            //Assert
            Assert.AreEqual(expected, actualy);
        }
    }
}