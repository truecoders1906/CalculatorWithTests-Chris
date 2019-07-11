
namespace CalculatorWithTests
{
    public class Calculator
    {
       public int Add(int number1, int number2)
        {
            return number1 + number2;
        } 
        public int Subtract(int number1, int number2)
        {
            return number1 - number2;
        }
        public int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
        public int DivideNumbers(int number1, int number2)
        {
            return number1 / number2;
        }
        public int Factorial(int number1)
        {
            return number1 * Factorial(number1 - 1);
        }
    }
}
