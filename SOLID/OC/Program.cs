using System;

namespace OpenClosedPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new AddCalculator();
            var result = calculator.Calculate(2, 3);
            Console.WriteLine($"Rezultatul este: {result}");
        }
    }

    interface ICalculator
    {
        int Calculate(int a, int b);
    }

    class AddCalculator : ICalculator
    {
        public int Calculate(int a, int b)
        {
            return a + b;
        }
    }
}
