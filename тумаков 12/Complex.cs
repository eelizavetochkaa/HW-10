using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace тумаков_12
{
    internal class Complex
    {
        public double Real { get; set; }
        public double Imaginary { get; set; }

        public Complex(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }


        public static Complex operator *(Complex a, Complex b)
        {
            return new Complex(a.Real * b.Real - a.Imaginary * b.Imaginary,
                                     a.Real * b.Imaginary + a.Imaginary * b.Real);
        }

        public static bool operator !=(Complex a, Complex b)
        {
            return !(a == b);
        }


        public static bool operator ==(Complex a, Complex b)
        {
            return a.Real == b.Real && a.Imaginary == b.Imaginary;
        }
        public static Complex operator +(Complex a, Complex b)
        {
            return new Complex(a.Real + b.Real, a.Imaginary + b.Imaginary);
        }

        public static Complex operator -(Complex a, Complex b)
        {
            return new Complex(a.Real - b.Real, a.Imaginary - b.Imaginary);
        }

        public override string ToString()
        {
            return $"{Real} + {Imaginary}i";
        }
    }
}
