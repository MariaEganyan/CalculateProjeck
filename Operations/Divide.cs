using CalculateProjeck.Interfaces;

namespace CalculateProjeck.Operations
{
    class Divide : IOperation
    {
        public double Operation(double firstparam, double secondparam)
        {
            return firstparam / secondparam;
        }
    }
}
