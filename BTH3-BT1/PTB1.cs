using System;

namespace BTH3_BT1
{
    public enum PTB1Status { InfiniteSolutions, NoSolution, OneSolution }

    internal class PTB1
    {
        private const double EPS = 1e-12;

        public double A { get; set; }
        public double B { get; set; }

        public PTB1(double a, double b)
        {
            A = a;
            B = b;
        }

        public (PTB1Status status, double? x) Solve()
        {
            if (Math.Abs(A) <= EPS)
            {
                if (Math.Abs(B) <= EPS) return (PTB1Status.InfiniteSolutions, null);
                return (PTB1Status.NoSolution, null);
            }
            return (PTB1Status.OneSolution, -B / A);
        }
    }
}
