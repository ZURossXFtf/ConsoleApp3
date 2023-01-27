using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    using ConsoleApp3;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace abs
    {
        abstract class Pair
        {
            private double a;
            private double b;
            public double A
            {
                get { return a; }
                set { a = value; }
            }
            public double B
            {
                get { return b; }
                set { b = value; }
            }
            public Pair(double a, double b)
            {
                A = a;
                B = b;
            }
            abstract public Pair Add(Pair p);
            abstract public Pair Sub(Pair p);
            abstract public Pair Mult(Pair p);
            abstract public Pair Div(Pair p);
            abstract public bool Equ(Pair p);
            abstract public bool Great(Pair p);
            abstract public bool Less(Pair p);
            abstract public Pair Conj();

        }
    }
}