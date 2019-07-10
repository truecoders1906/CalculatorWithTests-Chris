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
        [InlineData (5, 3, 1)]
        [InlineData(5, 3, 1)]
        public void SubtractNumbers(decimal number1, decimal number2, decimal expected)
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            int actual = calculator.Subtract(number1, number2);


            // Assert
            Assert.Equal(expected, actual);
        }
        [InlineData (2, 4, 6)]
        public void MultiplyNumbers (decimal number1, decimal number2, decimal expected)
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            int actual = calculator.Multiply(number1, number2);


            // Assert
            Assert.Equal(expected, actual);
        }
        [InlineData (100, 50, 2)]
        [InlineData (50, 25, 2)]
        [InlineData (20, 0, 0)]
        public void DivideNumbers (decimal number1, decimal number2, decimal expected)
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            int actual = calculator.Divide(number1, number2);


            // Assert
            Assert.Equal(expected, actual);
        }
        [InlineData (5, 120)]
        public void FactorNumbers(decimal number1, decimal expected)
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            int actual = calculator.Factorial(number1);


            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
