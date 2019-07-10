using System;
using Xunit;
using CalculatorWithTests;

namespace CalculatorTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData (10, 20, 30)]
        public void AddNumbers(decimal number1, decimal number2, decimal expected)
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            int actual = calculator.Add(number1, number2);


            // Assert
            Assert.Equal(expected, actual);
        }
        //public void SubtractNumbers(decimal number1, decimal number 2, decimal expected)
    }
}
