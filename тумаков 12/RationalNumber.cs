using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace тумаков_12
{
    internal class RationalNumber
    {
        public int Numerator { get; set; }
        public int Denominator { get; set; }

        public RationalNumber(int numerator, int denominator)
        {
            if (denominator == 0)
                throw new ArgumentException("Знаменатель не может быть = 0.");

            Numerator = numerator;
            Denominator = denominator;
        }

        public static bool operator ==(RationalNumber a, RationalNumber b)
        {
            return a.Numerator * b.Denominator == b.Numerator * a.Denominator;
        }

        public static bool operator !=(RationalNumber a, RationalNumber b)
        {
            return !(a == b);
        }

        public static bool operator <(RationalNumber a, RationalNumber b)
        {
            return a.Numerator * b.Denominator < b.Numerator * a.Denominator;
        }

        public static bool operator >(RationalNumber a, RationalNumber b)
        {
            return a.Numerator * b.Denominator > b.Numerator * a.Denominator;
        }

        public static bool operator <=(RationalNumber a, RationalNumber b)
        {
            return a.Numerator * b.Denominator <= b.Numerator * a.Denominator;
        }

        public static bool operator >=(RationalNumber a, RationalNumber b)
        {
            return a.Numerator * b.Denominator >= b.Numerator * a.Denominator;
        }

        public static RationalNumber operator +(RationalNumber a, RationalNumber b)
        {
            return new RationalNumber(a.Numerator * b.Denominator + b.Numerator * a.Denominator, a.Denominator * b.Denominator);
        }

        public static RationalNumber operator -(RationalNumber a, RationalNumber b)
        {
            return new RationalNumber(a.Numerator * b.Denominator - b.Numerator * a.Denominator, a.Denominator * b.Denominator);
        }

        public static RationalNumber operator ++(RationalNumber a)
        {
            return new RationalNumber(a.Numerator + a.Denominator, a.Denominator);
        }

        public static RationalNumber operator --(RationalNumber a)
        {
            return new RationalNumber(a.Numerator - a.Denominator, a.Denominator);
        }

        public static RationalNumber operator *(RationalNumber a, RationalNumber b)
        {
            return new RationalNumber(a.Numerator * b.Numerator, a.Denominator * b.Denominator);
        }

        public static RationalNumber operator /(RationalNumber a, RationalNumber b)
        {
            return new RationalNumber(a.Numerator * b.Denominator, a.Denominator * b.Numerator);
        }

        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }

        public static implicit operator float(RationalNumber a)
        {
            return (float)a.Numerator / a.Denominator;
        }

        public static implicit operator int(RationalNumber a)
        {
            return a.Numerator / a.Denominator;
        }

        public static implicit operator RationalNumber(float a)
        {
            int denominator = 1;
            while ((a * denominator) % 1 != 0)
            {
                denominator *= 10;
            }
            return new RationalNumber((int)(a * denominator), denominator);
        }

        public static implicit operator RationalNumber(int a)
        {
            return new RationalNumber(a, 1);
        }
    }
}
