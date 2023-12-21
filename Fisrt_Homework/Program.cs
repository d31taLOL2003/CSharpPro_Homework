namespace Fisrt_Homework
{
    public class Calculculator
    {
        public double Add(double firstNumber, double secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public double Subtract(double firstNumber, double secondNumber)
        {
            return firstNumber - secondNumber;
        }

        public double Multipy(double firstNumber, double secondNumber)
        {
            return firstNumber * secondNumber;
        }

        public double Divide(double firstNumber, double secondNumber)
        {
            if (secondNumber == 0)
            {
                throw new DivideByZeroException("Division by zero is not allowed.");
            }

            return firstNumber / secondNumber;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Calculculator calc = new Calculculator();

            double addResult = calc.Add(10, 5);
            double subtractResult = calc.Subtract(10, 5);
            double multipyResult = calc.Multipy(10, 5);
            double divideResult = calc.Divide(10, 5);

            Console.WriteLine($"Addition: {addResult}");
            Console.WriteLine($"Subtraction: {subtractResult}");
            Console.WriteLine($"Multiplication: {multipyResult}");
            Console.WriteLine($"Division: {divideResult}");
        }
    }
}
