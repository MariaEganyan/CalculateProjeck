using CalculateProjeck.Interfaces;
using System;

namespace CalculateProjeck.Operations
{
    class Subtraction : IOperation
    {
        public ConsoleKey key { get; set; }
        public Subtraction()
        {
            key = ConsoleKey.Subtract;
        }
        public double Operation(double firstparam, double secondparam)
        {
            return firstparam - secondparam;
        }
    }
}
