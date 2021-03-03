using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_抽象类练习
{
    class Square : Shape
    {
        private double _hight;

        public double Hight
        {
            get{return _hight;}

            set{_hight = value;}
        }

        private double _weight;
        public double Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }
        public Square(double hight, double weight)
        {
            this.Hight = hight;
            this.Weight = weight;
        }
        public override double Area()
        {
            return this.Hight * this.Weight; 
        }

        public override double C()
        {
            return 2 * (this.Hight + this.Weight);
        }
    }
}
