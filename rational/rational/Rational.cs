using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rational
{
    class Rational
    {
        public int Num
        {
            get;
            set;
        }
        public int Denum
        {
            get;
            set;
        }
        public Rational(int num, int denum)
        {
            Num = num;
            Denum = denum;
        }

        public Rational Mul(Rational r2) {
            return new Rational(r2.Num * this.Num, r2.Denum * this.Denum);
        }

        public Rational Div(Rational r2)
        {
            return new Rational(this.Num * r2.Denum, this.Denum * this.Num);
        }

        public Rational Sum(Rational r2)
        {
            
            return new Rational(this.Num*r2.Denum+this.Denum*r2.Num,this.Denum*r2.Denum);
        }
        public Rational Minus(Rational r2)
        {

            return new Rational(this.Num * r2.Denum + this.Denum * r2.Num, this.Denum * r2.Denum);
        }
        public override string ToString()
        {
            return $"{this.Num}/{this.Denum}";
        }

    }
}
