using CalculateProjeck.Interfaces;

namespace CalculateProjeck.Operations
{
    class Subtraction : IOperation
    {
        public double Operation(double firstparam, double secondparam)
        {
            return firstparam - secondparam;
        }
    }
}
