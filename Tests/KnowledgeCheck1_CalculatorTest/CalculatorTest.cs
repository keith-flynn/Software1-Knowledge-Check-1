using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using KnowledgeCheck1_Calculator;

namespace KnowledgeCheck1_CalculatorTest
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void AdditionAdds()
        {
            //-- Arrange
            Calculator calculator = new Calculator();
            int firstNumber = 1;
            int secondNumber = 2;
            int expected = 3;

            //-- Act
            int actual = calculator.Add(firstNumber, secondNumber);

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SubtractionSubtracts()
        {
            //-- Arrange
            Calculator calculator = new Calculator();
            int firstNumber = 1;
            int secondNumber = 2;
            int expected = -1;

            //-- Act
            int actual = calculator.Subtract(firstNumber, secondNumber);

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MultiplicationMultiplies()
        {
            //-- Arrange
            Calculator calculator = new Calculator();
            int firstNumber = 1;
            int secondNumber = 2;
            int expected = 2;

            //-- Act
            int actual = calculator.Multiply(firstNumber, secondNumber);

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DivisionDivides()
        {
            //-- Arrange
            Calculator calculator = new Calculator();
            double firstNumber = 1;
            double secondNumber = 2;
            double expected = 0.5;

            //-- Act
            double actual = calculator.Divide(firstNumber, secondNumber);

            //-- Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
