using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_继承练习
{
    class Personthr:Person
    {
        public Personthr(string name, int age, string hobby, string workname) 
            : base(name, age, hobby) 
        {
            this.Workname = workname;
        }
        private string _workname;
        public string Workname 
        {
            get { return _workname; }
            set { _workname = value; }
        }
        public void SayHi() 
        {
            Console.WriteLine("我叫{0}，我的年龄{1}，我的爱好是{2}，我的工作内容是{3}",this.Name,this.Age,this.Hobby,this.Workname);
        }
    }
}