using CalculateProjeck.Calculate;
using System;
using System.Collections.Generic;

namespace CalculateProjeck.Interfaces
{
    interface ICalculatorCreater
    {
        Calculator CreatCalculator();
        IEnumerable<IOperation> GetOperations();
    }
}
