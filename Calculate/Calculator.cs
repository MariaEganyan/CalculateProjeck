using CalculateProjeck.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CalculateProjeck.Calculate
{
    class Calculator
    {
        private IEnumerable<IOperation> _operations;

        public Calculator(IEnumerable<IOperation> operations)
        {
            this._operations = operations;
        }

        
       private IOperation GetOperation(ConsoleKey key)
        {
            var operation = _operations.Where(x => x.key == key);
            return operation.First();
        }
        public double Calculate(ConsoleKey key,double first, double second)
        {
            return GetOperation(key).Operation(first, second);
        }
    }
}
