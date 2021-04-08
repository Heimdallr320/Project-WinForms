using System;

namespace Lab.Rab4
{
    class IntegralFunc3: Integral
    {
        public override double Func(double x)
        {
            return Math.Pow(Math.E,x);
        }
    }
}
