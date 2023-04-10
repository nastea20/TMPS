using System;

namespace LiskovSubstitutionPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new AddCalculator();
            var result = calculator.Calculate(9, 3);
            Console.WriteLine($"Rezultatul este: {result}");
        }
    }

    abstract class Calculator
    {
        public abstract int Calculate(int a, int b);
    }

    class AddCalculator : Calculator
    {
        public override int Calculate(int a, int b)
        {
            return a + b;
        }
    }

    class SubtractCalculator : Calculator
    {
        public override int Calculate(int a, int b)
        {
            return a - b;
        }
    }
}
