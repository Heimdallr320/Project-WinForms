using System;

namespace Lab.Rab4
{
    class IntegralFunc5: Integral
    {
        public override double Func(double x)
        {
            return Math.Abs(x);
        }
    }
}
