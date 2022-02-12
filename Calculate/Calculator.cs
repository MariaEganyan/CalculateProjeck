using CalculateProjeck.Interfaces;
using System;
using System.Collections.Generic;

namespace CalculateProjeck.Calculate
{
    class Calculator
    {
        private Func<ConsoleKey, IOperation> _operation;
        public readonly List<string> SinvolesSmolePosition;
        public readonly List<string> SinvolesBigPosition;
        public Calculator(Func<ConsoleKey, IOperation> operation)
        {
            this._operation = operation;
            SinvolesSmolePosition = new List<string>()
            {"CE","C","delet","/","7","8","9","*","4","5","6","-","1","2","3","+","+/-","0",".","="};
            SinvolesBigPosition = new List<string>()
            { "MC", "MR", "M+", "M-", "MS", "M", "CE", "C", "delet", "/", "7", "8", "9", "*", "4", "5", "6", "-", "1", "2", "3", "+", "+/-", "0", ".", "=" };
        }

        public double Test(ConsoleKey key, double firstparam, double secondparam)
        {
            IOperation operation = _operation(key);
            double result =operation.Operation(firstparam, secondparam);
            return result;
        }
    }
}
