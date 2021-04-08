using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Lab.Rab4
{
    public class Integral
    {
        public virtual double Func(double x)
        {
            return 0;
        }

        private double n;

        double aMax;
        double bMin;

        List<double> values = new List<double>();

        public double A { get; set; }
        public double B { get; set; }
        public double N
        {
            set
            {
                if (value < 0)
                {
                    MessageBox.Show("Неккоректное число шагов!");
                }
                n = value;
            }
            get
            {
                return n;
            }
        }

        public double AMax
        {
            set
            {
                aMax = value;
            }
            get
            {
                return aMax;
            }
        }
        public double BMin
        {
            set
            {
                bMin = value;
            }
            get
            {
                return bMin;
            }
        }

        public List<double> Values
        {
            set
            {
                values = value;
            }
            get
            {
                return values;
            }
        }

        public double CalculateLeft()
        {
            double promezZnach, znachF = 0;
            double h = (B - A) / n;
            double x = A;

            while (x < B)
            {
                promezZnach = Func(x);
                znachF += promezZnach * h;
                x += h;
            }

            return znachF;
        }

        public double CalculateRight()
        {
            double promezZnach, znachF = 0;
            double x = A;
            double h = (B - A) / n;

            while (x < B)
            {
                x += h;
                promezZnach = Func(x);
                znachF += promezZnach * h;
            }
            return znachF;
        }
        public double CalculateMedium()
        {
            double promezZnach, znachF = 0;
            double x = A;
            double h = (B - A) / n;

            while (x < B)
            {
                promezZnach = Func(x);
                znachF += promezZnach * h;
                x += h;
            }

            return znachF;
        }
        public double CalculateTrap()
        {
            double promezZnach, znachF = 0;
            double x = A;
            double h = (B - A) / n;

            promezZnach = Func(x);
            double promezZnach2 = Func(B);

            znachF += h * (promezZnach + promezZnach2) / 2;
            x += h;

            while (x < B)
            {
                promezZnach = Func(x);
                znachF += promezZnach * h;
                x += h;
            }

            return znachF;
        }



        public void PrintGraphicAndOblLeft(System.Windows.Forms.DataVisualization.Charting.Chart chart, int numberGraphic)
        {
            double promezZnach;
            double h = (B - A) / n;

            chart.Series[numberGraphic].Points.Clear();
            chart.Series[numberGraphic+2].Points.Clear();
            chart.Series[numberGraphic + 4].Points.Clear();
            chart.Series[6].Points.Clear();

            double x = A;

            while (x < B)
            {
                promezZnach = Func(x);
                double promezZnach2 = Func(x+h);
                chart.Series[numberGraphic].Points.AddXY(x, promezZnach);
                chart.Series[numberGraphic+2].Points.AddXY(x, promezZnach2);
                chart.Series[numberGraphic + 4].Points.AddXY(x, promezZnach2);

                if (x + h < B)
                {
                    chart.Series[numberGraphic+2].Points.AddXY(x + h, promezZnach2);
                    chart.Series[numberGraphic + 4].Points.AddXY(x + h, promezZnach2);
                }

                x += h;
            }

            x = AMax;
            double znachValue;
            values.Clear();

            while (x < BMin)
            {
                znachValue = Func(x);
                values.Add(znachValue);
                x += 0.05;
            }
        }

        public void PrintGraphicAndOblRight(System.Windows.Forms.DataVisualization.Charting.Chart chart, int numberGraphic)
        {
            double promezZnach;
            double h = (B - A) / n;

            chart.Series[numberGraphic].Points.Clear();
            chart.Series[numberGraphic + 2].Points.Clear();
            chart.Series[numberGraphic + 4].Points.Clear();
            chart.Series[6].Points.Clear();

            double x = A;

            while (x < B)
            {
                promezZnach = Func(x);
                chart.Series[numberGraphic].Points.AddXY(x, promezZnach);
                chart.Series[numberGraphic+2].Points.AddXY(x, promezZnach);
                chart.Series[numberGraphic + 4].Points.AddXY(x, promezZnach);

                if (x + h < B)
                {
                    chart.Series[numberGraphic+2].Points.AddXY(x + h, promezZnach);
                    chart.Series[numberGraphic+4].Points.AddXY(x + h, promezZnach);
                }
                x += h;
            }

            x = AMax;
            double znachValue;
            values.Clear();

            while (x < BMin)
            {
                x += 0.05;
                znachValue = Func(x);
                values.Add(znachValue);
            }
        }

        public void PrintGraphicAndOblSred(System.Windows.Forms.DataVisualization.Charting.Chart chart, int numberGraphic)
        {
            double promezZnach;
            double h = (B - A) / n;

            chart.Series[numberGraphic].Points.Clear();
            chart.Series[numberGraphic + 2].Points.Clear();
            chart.Series[numberGraphic + 4].Points.Clear();
            chart.Series[6].Points.Clear();

            double x = A;

            while (x < B)
            {
                promezZnach = Func(x);
                chart.Series[numberGraphic].Points.AddXY(x, promezZnach);

                double promezZnach2 = promezZnach = Func(x+(h/2));
                chart.Series[numberGraphic+2].Points.AddXY(x, promezZnach2);
                chart.Series[numberGraphic + 4].Points.AddXY(x, promezZnach2);

                if (x + h < B)
                {
                    chart.Series[numberGraphic+2].Points.AddXY(x + h, promezZnach2);
                    chart.Series[numberGraphic+4].Points.AddXY(x + h, promezZnach2);
                }
                x += h;
            }

            x = AMax;
            double znachValue;
            values.Clear();

            while (x < BMin)
            {
                znachValue = Func(x);
                values.Add(znachValue);
                x += 0.05;
            }
        }

        public void PrintGraphicAndOblTrap(System.Windows.Forms.DataVisualization.Charting.Chart chart, int numberGraphic)
        {
            double promezZnach;
            double h = (B - A) / n;

            chart.Series[numberGraphic].Points.Clear();
            chart.Series[numberGraphic + 2].Points.Clear();
            chart.Series[numberGraphic + 4].Points.Clear();
            chart.Series[6].Points.Clear();

            double x = A;

            while (x < B)
            {
                promezZnach = Func(x);
                chart.Series[numberGraphic].Points.AddXY(x, promezZnach);
                chart.Series[numberGraphic + 2].Points.AddXY(x, promezZnach);
                chart.Series[numberGraphic + 4].Points.AddXY(x, promezZnach);
                x += h;
            }

            x = AMax;
            double znachValue;
            values.Clear();

            while (x < bMin)
            {
                znachValue = Func(x);
                values.Add(znachValue);
                x += 0.05;
            }
        }

        public void PrintSmezObl(System.Windows.Forms.DataVisualization.Charting.Chart chart, List<double> dopValues1, List<double> dopValues2)
        {
            double x = AMax;
            chart.Series[6].Points.Clear();

            int kol1 = dopValues1.Count();
            int kol2 = dopValues2.Count();

            int minKol;

            double h = 0.05;

            if(kol1<kol2)
            {
                minKol = kol1;
            }
            else
            {
                minKol = kol2;
            }

            for (int i = 0; i < minKol && x <= BMin; i++)
            {
                if (dopValues1[i] <= dopValues2[i])
                {
                    chart.Series[6].Points.AddXY(x, dopValues1[i]);
                }
                else
                {
                    chart.Series[6].Points.AddXY(x, dopValues2[i]);
                }
                x += 0.05;
            }
        }

    }
}
