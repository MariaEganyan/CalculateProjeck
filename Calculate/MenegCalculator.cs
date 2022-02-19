using CalculateProjeck.Interfaces;
using OperationsLIB;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace CalculateProjeck.Calculate
{
    class MenegCalculator : ICalculatorCreater
    {
        private readonly List<IOperation> _defaultOperations = new List<IOperation>() { new Sum(), new Subtract(), new Multiple(), new Divide() };
       
        public Calculator CreatCalculator()
        {
            var operations = GetOperations();
            _defaultOperations.AddRange(operations);
            Calculator calculator = new Calculator(_defaultOperations);
            return calculator;
        }

        public IEnumerable<IOperation> GetOperations()
        {
            List<IOperation> operations = new List<IOperation>();
            List<Assembly> assemblys = new List<Assembly>();
            string path = "C:\\Plugins";
            foreach (string dll in Directory.GetFiles(path, "*.dll"))
                assemblys.Add(Assembly.LoadFile(dll));

            foreach(var  ass in assemblys)
            {
                var taypes = ass.GetTypes();
                var operationType = from t in taypes where t.IsClass && typeof(IOperation).IsAssignableFrom(t) select t;
                foreach(var item in operationType)
                {
                    var instance = Activator.CreateInstance(item);
                    operations.Add((IOperation)instance);
                }
            }
            return operations; 
        }

        
        
    }
}
