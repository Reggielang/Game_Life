using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_抽象类练习
{
    class Circle : Shape
    {
        private double _r;

        public double R
        {
            get { return _r;}

            set{_r = value;}
        }
        public Circle(double r)
        {
            this.R = r;
        }
        //如果一个子类继承的父类是抽象类，那么子类就必须重新父类中的所有抽象方法！
        public override double Area()
        {
            return Math.PI * this.R * this.R;
        }

        public override double C()
        {
            return Math.PI * this.R * 2;
        }
    }
}
