
using System;

namespace CalculateProjeck.Interfaces
{
    interface IOperation
    {
        public ConsoleKey key { get; set; }
        double Operation(double firstparam, double secondparam);
    }
}
