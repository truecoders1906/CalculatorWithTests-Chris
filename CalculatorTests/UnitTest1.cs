using System;
using Xunit;
using CalculatorWithTests;

namespace CalculatorTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData (10, 20, 30)]
        [InlineData(20, 30, 50)]
        [InlineData(30, 40, 70)]
        public void AddNumbers(int number1, int number2, int expected)
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            int actual = calculator.Add(number1, number2);


            // Assert
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData (5, 3, 2)]
        [InlineData(10, 8, 2)]
        [InlineData(20, 18, 2)]
        public void Subtract(int number1, int number2, int expected)
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            int actual = calculator.Subtract(number1, number2);


            // Assert
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData (2, 4, 8)]
        [InlineData(4, 6, 24)]
        [InlineData(6, 8, 48)]
        public void MultiplyNumbers (int number1, int number2, int expected)
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            int actual = calculator.Multiply(number1, number2);


            // Assert
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData (100, 50, 2)]
        [InlineData (50, 25, 2)]
        [InlineData (20, 1, 20)]
        public void DivideNumbers (int number1, int number2, int expected)
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            int actual = calculator.DivideNumbers(number1, number2);


            // Assert
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData (5, 120)]
        [InlineData(6, 720)]
        [InlineData(7, 5040)]
        public void Factorial(int number1, int expected)
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
