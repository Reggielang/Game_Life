using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_继承练习
{
    class Personfive:Person
    {
        public Personfive(string name, int age, string hobby,double high)
            :base(name,age,hobby)
        {
            this.High = high;
        }

        private double _high;
        public double High
        {
            get { return _high; }
            set { _high = value; }
        }

        public void Sayfive()
        {
            Console.WriteLine("我的名字是{0},我的年龄是{1}，我的爱好是{2}，我的身高{3}",this.Name,this.Age,this.Hobby,this.High);
        }
    }
}
