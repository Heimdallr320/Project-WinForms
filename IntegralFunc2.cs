using System;

namespace Lab.Rab4
{
    class IntegralFunc2: Integral
    {
        public override double Func(double x)
        {
            return Math.Pow(x,3);
        }
    }
}
