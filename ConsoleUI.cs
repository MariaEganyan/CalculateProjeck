using CalculateProjeck.Calculate;
using CalculateProjeck.Interfaces;
using CalculateProjeck.Operations;
using System;


namespace CalculateProjeck
{
    class ConsoleUI
    {
        private Calculator _calculator;
        private double _result;
        public ConsoleUI()
        {
            _calculator = new Calculator(Operation);
        }
        public void Calculator()
        {
            Console.WriteLine("CALCULATOR");
            if (_result == default)
            {
                _result = Calculate();
            }
            else
            {
                Console.WriteLine("1.Choos operation, 2.start again");
                ConsoleKey key = Console.ReadKey().Key;
                switch (key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        Console.WriteLine("First Number:{0}", _result);
                        Console.WriteLine("+" + " " + "-" + " " + "*" + " " + "/");
                        ConsoleKey key1 = Console.ReadKey().Key;
                        _result=ContinueCalculate(_result, key1);
                        break;
                    case ConsoleKey.D2:
                        _result = default;
                        Console.Clear();
                        Calculator();
                        break;
                }
            }
        }

        public double Calculate()
        {
            Console.WriteLine("first number:");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Choos operation");
            Console.WriteLine("+" + " " + "-" + " " + "*" + " " + "/");
            ConsoleKey key = Console.ReadKey().Key;
            Console.WriteLine("second number:");
            double secondNumber = double.Parse(Console.ReadLine());
            double result = _calculator.Test(key, firstNumber, secondNumber);
            Console.WriteLine("Resulte:{0}", result);
            return result;
        }
        private double ContinueCalculate(double firstNumber, ConsoleKey key)
        {
            Console.WriteLine("second number:");
            double secondNumber = double.Parse(Console.ReadLine());
            double result = _calculator.Test(key, firstNumber, secondNumber);
            Console.WriteLine("Resulte:{0}", result);
            return result;

        }
        private IOperation Operation(ConsoleKey key)
        {
            IOperation operation = new Sum();
            switch (key)
            {
                case ConsoleKey.Subtract:
                    Subtraction subtract = new Subtraction();
                    operation = subtract;
                    break;

                case ConsoleKey.Divide:
                    Divide divide = new Divide();
                    operation = divide;
                    break;

                case ConsoleKey.Multiply:
                    Multiple multiple = new Multiple();
                    operation = multiple;
                    break;
            }
            return operation;

        }
    }
}
