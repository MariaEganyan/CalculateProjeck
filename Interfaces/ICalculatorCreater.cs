using CalculateProjeck.Calculate;
using OperationsLIB;
using System.Collections.Generic;

namespace CalculateProjeck.Interfaces
{
    interface ICalculatorCreater
    {
        Calculator CreatCalculator();
        IEnumerable<IOperation> GetOperations();
    }
}
