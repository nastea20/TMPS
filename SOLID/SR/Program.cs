using System;

namespace SingleResponsibilityPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();
            var result = calculator.Add(5, 3);
            Console.WriteLine($"Rezultatul este: {result}");
        }
    }

    class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
}
