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
            int addNumber1 = 1;
            int addNumber2 = 2;
            int expected = 3;

            //-- Act
            int actual = calculator.Add(addNumber1, addNumber2);

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SubtractionSubtracts()
        {
            //-- Arrange
            Calculator calculator = new Calculator();
            int subtractNumber1 = 1;
            int subtractNumber2 = 2;
            int expected = -1;

            //-- Act
            int actual = calculator.Subtract(subtractNumber1, subtractNumber2);

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MultiplicationMultiplies()
        {
            //-- Arrange
            Calculator calculator = new Calculator();
            int multiplyNumber1 = 1;
            int multiplyNumber2 = 2;
            int expected = 2;

            //-- Act
            int actual = calculator.Multiply(multiplyNumber1, multiplyNumber2);

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DivisionDivides()
        {
            //-- Arrange
            Calculator calculator = new Calculator();
            double divideNumber1 = 1;
            double divideNumber2 = 2;
            double expected = 0.5;

            //-- Act
            double actual = calculator.Divide(divideNumber1, divideNumber2);

            //-- Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
