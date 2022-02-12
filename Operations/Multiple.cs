using CalculateProjeck.Interfaces;

namespace CalculateProjeck.Operations
{
    class Multiple : IOperation
    {
        public double Operation(double firstparam, double secondparam)
        {
            return firstparam * secondparam;
        }
    }
}
