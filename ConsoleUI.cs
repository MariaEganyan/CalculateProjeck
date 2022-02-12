using CalculateProjeck.Calculate;
using CalculateProjeck.Interfaces;
using CalculateProjeck.Operations;
using System;


namespace CalculateProjeck
{
    class ConsoleUI
    {
        private Calculator _calculator;

        public ConsoleUI()
        {
            _calculator = new Calculator(Operation);
        }
        public void Home()
        {
            Console.WriteLine("CALCULATOR");
            Console.WriteLine("first number:");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("second number:");
            double secondNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Choos operation");
            Console.WriteLine("+" + " " + "-" + " " + "*" + " " + "/");
            ConsoleKey key = Console.ReadKey().Key;
            double result =_calculator.Test(key, firstNumber, secondNumber);
            Console.WriteLine("Resulte:{0}",result);
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
