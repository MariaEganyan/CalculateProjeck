using CalculateProjeck.Interfaces;

namespace CalculateProjeck.Operations
{
    class Sum : IOperation
    {
        public double Operation(double firstparam, double secondparam)
        {
            return firstparam + secondparam;
        }
    }
}
