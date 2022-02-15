using CalculateProjeck.Interfaces;
using System;

namespace CalculateProjeck.Operations
{
    class Multiple : IOperation  
    {
        public ConsoleKey key { get; set; }
        public Multiple()
        {
            key = ConsoleKey.Multiply;
        }
        public double Operation(double firstparam, double secondparam)
        {
            return firstparam * secondparam;
        }
    }
}
