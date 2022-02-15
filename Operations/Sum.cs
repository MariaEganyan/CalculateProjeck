using CalculateProjeck.Interfaces;
using System;

namespace CalculateProjeck.Operations
{
    class Sum : IOperation
    {
        public ConsoleKey key { get ; set ; }
        public Sum()
        {
            key = ConsoleKey.Add;
        }

        public double Operation(double firstparam, double secondparam)
        {
            return firstparam + secondparam;
        }
    }
}
