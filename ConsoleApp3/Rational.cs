using MyApp.abs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Rational : Pair

    {
        public Rational(double a, double b) : base(a, b)
        {
        }

        public override Pair Add(Pair p)
        {
            return new Rational(this.A*p.B+p.A*this.B,p.A*p.B);
        }

        public override Pair Sub(Pair p)
        {
            return new Rational(this.A * p.B-p.A*this.B,p.A*p.B);
        }
        public override Pair Mult(Pair p)
        {
            return new Rational(this.A * this.B, p.A * p.B);
        }

        public override Pair Div(Pair p)
        {
            return new Rational(this.A * p.B,p.A*this.B);
        }
        public override bool Equ(Pair p)
        {
            return (this.A == this.B) && (p.A == p.B);
        }
        public override bool Great(Pair p)
        {
            return (this.A >= this.B) && (p.A >= p.B);
        }
        public override bool Less(Pair p)
        {
            return (this.A <= this.B) && (p.A <= p.B);
        }


        public override Pair Conj()
        {
            throw new NotImplementedException();
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override string? ToString()
        {
            if (B > 0)
                return A + "+" + B + "i";
            else if (B < 0)
                return A + "-" + Math.Abs(B) + "i";
            return A.ToString();
        }
        
        
    }
}
