using System;

namespace DependencyInversionPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator(new AddOperation());
            var result = calculator.Calculate(2, 8);
            Console.WriteLine($"Rezultatul este: {result}");
        }
    }

    interface IOperation
    {
        int Operate(int a, int b);
    }

    class AddOperation : IOperation
    {
        public int Operate(int a, int b)
        {
            return a + b;
        }
    }

    class SubtractOperation : IOperation
    {
        public int Operate(int a, int b)
        {
            return a - b;
        }
    }

    class Calculator
    {
        private readonly IOperation _operation;

        public Calculator(IOperation operation)
        {
            _operation = operation;
        }

        public int Calculate(int a, int b)
        {
            return _operation.Operate(a, b);
        }
    }
}
