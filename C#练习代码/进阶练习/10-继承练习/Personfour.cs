using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _10_继承练习
{
     class Personfour:Person
    {
        public Personfour(string name, int age, string hobby, string kou) 
            : base(name, age, hobby) 
        {
            this.Kou = kou;
        }

        private string _kou;
        public string Kou 
        {
            get { return _kou; }
            set { _kou = value; }
        }
        public void Sayfour() 
        {
            Console.WriteLine("我叫{0}，我的年龄{1}，我的爱好是{2}，我的工作内容是{3}", this.Name, this.Age, this.Hobby, this.Kou);
        }

    }
}