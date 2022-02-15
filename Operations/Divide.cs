using CalculateProjeck.Interfaces;
using System;

namespace CalculateProjeck.Operations
{
    class Divide : IOperation
    {
        public ConsoleKey key { get ; set; }
        public Divide()
        {
            key = ConsoleKey.Divide;
        }

        public double Operation(double firstparam, double secondparam)
        {
            return firstparam / secondparam;
        }
    }
}
