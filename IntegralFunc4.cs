using System;

namespace Lab.Rab4
{
    class IntegralFunc4: Integral
    {
        public override double Func(double x)
        {
            return Math.Pow(Math.E,2*x);
        }
    }
}
