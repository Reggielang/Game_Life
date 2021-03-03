using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_多态之虚方法
{
    class Person
    {
        public Person(string name)
        {
            this.Name = name;
        }
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public virtual void SayHi()
        {
            Console.WriteLine("我是人类");
        }

    }
}
