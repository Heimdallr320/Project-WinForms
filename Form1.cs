using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab.Rab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            answer1.Text = "0";
            answer2.Text = "0";

            enterA1.Text = "-3";
            enterB1.Text = "3";

            enterA2.Text = "0";
            enterB2.Text = "5";

            enterN1.Text = "500";
            enterN2.Text = "500";

            firstChoice1.Checked = true;
            secondChoice1.Checked = true;

            methodTrap1.Checked = true;
            methodTrap2.Checked = true;


        }

        public Integral[] integrals = { new IntegralFunc1(), new IntegralFunc2(), new IntegralFunc3(), new IntegralFunc4(), new IntegralFunc5()};

        List<double> dopValues1 = new List<double>();
        List<double> dopValues2 = new List<double>();
        private void calcRez1_Click(object sender, EventArgs e)
        {
            Integral integral = null;

            if(firstChoice1.Checked)
            {
                integral = integrals[0];
            }
            else if(firstChoice2.Checked)
            {
                integral = integrals[1];
            }
            else if(firstChoice3.Checked)
            {
                integral = integrals[2];
            }
            else if(firstChoice4.Checked)
            {
                integral = integrals[3];
            }
            else if (firstChoice5.Checked)
            {
                integral = integrals[4];
            }
            else
            {
                MessageBox.Show("Ошибка! Нужно выбрать f(x) первого интеграла!");
            }

            ////////////////////////////////////////////////////////////////

            DetermineValues(integral);

            double result = 0;

            if (methodTrap1.Checked)
            {
                result = integral.CalculateTrap();
            }
            else if (methodLeft1.Checked)
            {
                result = integral.CalculateLeft();
            }
            else if(methodRight1.Checked)
            {
                result = integral.CalculateRight();
            }
            else if(methodSred1.Checked)
            {
                result = integral.CalculateMedium();
            }
            else
            {
                MessageBox.Show("Ошибка! Нужно выбрать способ интегрирования первого интеграла!");
            }

            answer1.Text = result.ToString();

        }

        private void calcRez2_Click(object sender, EventArgs e)
        {
            Integral integral = null;

            if (secondChoice1.Checked)
            {
                integral = integrals[0];
            }
            else if (secondChoice2.Checked)
            {
                integral = integrals[1];
            }
            else if (secondChoice3.Checked)
            {
                integral = integrals[2];
            }
            else if (secondChoice4.Checked)
            {
                integral = integrals[3];
            }
            else if(secondChoice5.Checked)
            {
                integral = integrals[4];
            }
            else
            {
                MessageBox.Show("Ошибка! Нужно выбрать f(x) второго интеграла!");
            }

            ////////////////////////////////////////////////////////////////

            DetermineValues2(integral);

            double result = 0;

            if (methodTrap2.Checked)
            {
                result = integral.CalculateTrap();
            }
            else if (methodLeft2.Checked)
            {
                result = integral.CalculateLeft();
            }
            else if (methodRight2.Checked)
            {
                result = integral.CalculateRight();
            }
            else if (methodSred2.Checked)
            {
                result = integral.CalculateMedium();
            }
            else
            {
                MessageBox.Show("Ошибка! Нужно выбрать способ интегрирования второго интеграла!");
            }

            answer2.Text = result.ToString();
        }

        private void printGraf1_Click(object sender, EventArgs e)
        {
            Integral integral = null;
            int numberGraphic = 0;

            double a1, a2, b1, b2;
            a1 = Double.Parse(enterA1.Text);
            a2 = Double.Parse(enterA2.Text);
            b1 = Double.Parse(enterB1.Text);
            b2 = Double.Parse(enterB2.Text);

            if (firstChoice1.Checked)
            {
                integral = integrals[0];
            }
            else if (firstChoice2.Checked)
            {
                integral = integrals[1];
            }
            else if (firstChoice3.Checked)
            {
                integral = integrals[2];
            }
            else if (firstChoice4.Checked)
            {
                integral = integrals[3];
            }
            else if(firstChoice5.Checked)
            {
                integral = integrals[4];
            }
            else
            {
                MessageBox.Show("Ошибка! Нужно выбрать f(x) первого интеграла!");
            }

            DetermineValues(integral);
            DetermineMinAndMaxValue(integral, a1, a2, b1, b2);

            if (methodTrap1.Checked)
            {
                integral.PrintGraphicAndOblTrap(graphic, numberGraphic);
                dopValues1 = integral.Values;
            }
            else if (methodLeft1.Checked)
            {
                integral.PrintGraphicAndOblLeft(graphic, numberGraphic);
                dopValues1 = integral.Values;
            }
            else if (methodRight1.Checked)
            {
                integral.PrintGraphicAndOblRight(graphic, numberGraphic);
                dopValues1 = integral.Values;
            }
            else if (methodSred1.Checked)
            {
                integral.PrintGraphicAndOblSred(graphic, numberGraphic);
                dopValues1 = integral.Values;
            }
            else
            {
                MessageBox.Show("Ошибка! Нужно выбрать способ интегрирования первого интеграла!");
            }

        }
        private void printGraf2_Click(object sender, EventArgs e)
        {
            Integral integral = null;
            int numberGraphic = 1;

            double a1, a2, b1, b2;
            a1 = Double.Parse(enterA1.Text);
            a2 = Double.Parse(enterA2.Text);
            b1 = Double.Parse(enterB1.Text);
            b2 = Double.Parse(enterB2.Text);

            if (secondChoice1.Checked)
            {
                integral = integrals[0];
            }
            else if (secondChoice2.Checked)
            {
                integral = integrals[1];
            }
            else if (secondChoice3.Checked)
            {
                integral = integrals[2];
            }
            else if (secondChoice4.Checked)
            {
                integral = integrals[3];
            }
            else if(secondChoice5.Checked)
            {
                integral = integrals[4];
            }
            else
            {
                MessageBox.Show("Ошибка! Нужно выбрать f(x) второго интеграла!");
            }

            DetermineValues2(integral);
            DetermineMinAndMaxValue(integral, a1, a2, b1, b2);
            

            if (methodTrap2.Checked)
            {
                integral.PrintGraphicAndOblTrap(graphic, numberGraphic);
                dopValues2 = integral.Values;
            }
            else if (methodLeft2.Checked)
            {
                integral.PrintGraphicAndOblLeft(graphic, numberGraphic);
                dopValues2 = integral.Values;
            }
            else if (methodRight2.Checked)
            {
                integral.PrintGraphicAndOblRight(graphic, numberGraphic);
                dopValues2 = integral.Values;
            }
            else if (methodSred2.Checked)
            {
                integral.PrintGraphicAndOblSred(graphic, numberGraphic);
                dopValues2 = integral.Values;
            }
            else
            {
                MessageBox.Show("Ошибка! Нужно выбрать способ интегрирования второго интеграла!");
            }
        }
        protected void DetermineValues(Integral integral)
        {
            try
            {
                integral.A = Double.Parse(enterA1.Text);
                integral.B = Double.Parse(enterB1.Text);
                integral.N = Double.Parse(enterN1.Text);
            }
            catch
            {
                MessageBox.Show("Неккоректные данные!");
                enterA1.Text = "0";
                enterB1.Text = "0";
                enterN1.Text = "0";
            }
        }

        protected void DetermineMinAndMaxValue(Integral integral, double a1, double a2, double b1, double b2)
        {
            if (a1 > a2)
            {
                integral.AMax = a1;
            }
            else
            {
                integral.AMax = a2;
            }

            if (b2 < b1)
            {
                integral.BMin = b2;
            }
            else
            {
                integral.BMin = b1;
            }
        }

        protected void DetermineValues2(Integral integral)
        {
            try
            {
                integral.A = Double.Parse(enterA2.Text);
                integral.B = Double.Parse(enterB2.Text);
                integral.N = Double.Parse(enterN2.Text);
            }
            catch
            {
                MessageBox.Show("Неккоректные данные!");
                enterA2.Text = "0";
                enterB2.Text = "0";
                enterN2.Text = "0";
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void calculateSum_Click(object sender, EventArgs e)
        {
            double result1 = Double.Parse(answer1.Text);
            double result2 = Double.Parse(answer2.Text);

            resultSum.Text = (result1 + result2).ToString();
        }

        private void calculateRazn_Click(object sender, EventArgs e)
        {
            double result1 = Double.Parse(answer1.Text);
            double result2 = Double.Parse(answer2.Text);

            resultRazn12.Text = (result1 - result2).ToString();
            resultRazn21.Text = (result2 - result1).ToString();
        }

        private void smezObl_Click(object sender, EventArgs e)
        {
            Integral integral = new Integral();

            double a1, a2, b1, b2;
            a1 = Double.Parse(enterA1.Text);
            a2 = Double.Parse(enterA2.Text);
            b1 = Double.Parse(enterB1.Text);
            b2 = Double.Parse(enterB2.Text);

            DetermineMinAndMaxValue(integral, a1, a2, b1, b2);
            integral.PrintSmezObl(graphic, dopValues1, dopValues2);
        }

        private void checkBoxObl_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxObl.Checked)
            {
                graphic.Series[2].Enabled = true;
                graphic.Series[3].Enabled = true;
            }
            else
            {
                graphic.Series[2].Enabled = false;
                graphic.Series[3].Enabled = false;
            }
        }

    }
}
