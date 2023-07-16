using System;
namespace FinalProject

{
    public abstract class PreciousMetal
    {
        public abstract double CalculatePrice(double weight);

        public abstract string MetalType { get; }
    }
}

