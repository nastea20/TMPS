using System;

namespace InterfaceSegregationPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new AddCalculator();
            var result = calculator.Add(6, 5);
            Console.WriteLine($"Rezultatul este: {result}");
        }
    }

    interface IAdditionCalculator
    {
        int Add(int a, int b);
    }

    interface ISubtractionCalculator
    {
        int Subtract(int a, int b);
    }

    class AddCalculator : IAdditionCalculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }

    class SubtractCalculator : ISubtractionCalculator
    {
        public int Subtract(int a, int b)
        {
            return a - b;
        }
    }
}
