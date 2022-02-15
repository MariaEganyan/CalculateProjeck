using CalculateProjeck.Interfaces;
using CalculateProjeck.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace CalculateProjeck.Calculate
{
    class MenegCalculator : ICalculatorCreater
    {
        private List<IOperation> _defaultOperations = new List<IOperation>() { new Sum(), new Subtraction(), new Multiple(), new Divide() };
       
        public Calculator CreatCalculator()
        {
            var operations = GetOperations();
            _defaultOperations.AddRange(operations);
            Calculator calculator = new Calculator(_defaultOperations);
            return calculator;
        }

        public IEnumerable<IOperation> GetOperations()
        {
            var type = Assembly.GetExecutingAssembly().GetTypes().Where(t => t.IsClass && typeof(IOperation).IsAssignableFrom(t));
            return new List<IOperation>();
        }

        
        
    }
}
