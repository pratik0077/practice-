using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webformclass
{
    public class Class1 : Interface1
    {
        public  double add(double a, double b)
        {
            return (a + b);
        }
        public  double sub(double a, double b)
        {
            return a - b;
        }
        public  double mul(double a, double b)
        {
            return a * b;
        }
        public double div(double a, double b)
        {
            return a / b;
        }
        public double mod(double a, double b)
        {
            return a % b;
        }
        public  double sin(double a)
        {
            return System.Math.Sin((Convert.ToDouble(a)));
        }
        public double cos(double a)
        {
            return System.Math.Cos((Convert.ToDouble(a)));
        }
        public double tan(double a)
        {
            return System.Math.Tan((Convert.ToDouble(a * (Math.PI / 180))));
        }
        public double sinh(double a)
        {
            return System.Math.Sinh((Convert.ToDouble(a)));
        }
        public double cosh(double a)
        {
            return System.Math.Cosh((Convert.ToDouble(a)));
        }
        public double tanh(double a)
        {
            return System.Math.Tanh(Convert.ToDouble(a));
        }
        public double log(double a)
        {
            return System.Math.Log((Convert.ToDouble(1.0 / Math.Log(Math.E, a))));
        }
        public double log10(double a)
        {
            return System.Math.Log10((Convert.ToDouble(a)));
        }
        public double sqrt(double a)
        {
            return System.Math.Sqrt(Convert.ToDouble(a));
        }
        public double exp(double a)
        {
            return System.Math.Exp(Convert.ToDouble(a));
        }
        public double pi()
        {
            return Math.PI;
        }
        public double pow(double a, double b)
        {
            return Math.Pow(a, b);
        }
        public double pow1(double a, double b)
        {
            b = 2;
            return Math.Pow(a, b);
        }
        public double e1()
        {

            return Math.E;
        }


    }
}
