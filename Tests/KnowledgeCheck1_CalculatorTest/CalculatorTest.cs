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
    }
}
