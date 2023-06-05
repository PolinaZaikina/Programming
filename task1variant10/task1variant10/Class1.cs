using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    using System;

    public struct Range
    {
        private readonly int _a;
        private readonly int _b;

        public int A => _a;
        public int B => _b;
        public int Count => Math.Max(0, B - A);

        public Range(int a, int b)
        {
            if (b <= a)
                throw new ArgumentException("Значение B должно быть больше A.");

            _a = a;
            _b = b;
        }

        public bool IsContains(int number)
        {
            return number >= A && number < B;
        }

        public override string ToString()
        {
            return $"[{A}; {B})";
        }

        public override bool Equals(object obj)
        {
            if (obj is Range other)
            {
                return A == other.A && B == other.B;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return (A.GetHashCode() * 397) ^ B.GetHashCode();
        }

        public static Range operator & (Range range1, Range range2)
        {
            int a = Math.Max(range1.A, range2.A);
            int b = Math.Min(range1.B, range2.B);
            return new Range(a, b);
        }

        public static Range operator | (Range range1, Range range2)
        {
            int a = Math.Min(range1.A, range2.A);
            int b = Math.Max(range1.B, range2.B);
            return new Range(a, b);
        }
    }

}
