using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _10_继承练习
{
     class Persontwo:Person
    {
        public Persontwo(string name, int age, string hobby, string work)
            : base(name, age, hobby) 
        {
            //通过this传入子类的私有函数
            this.Work = work;
        }
        //私有字段传入构造函数
        private string _work;
        public string Work 
        {
            get { return _work; }
            set { _work = value; }
        }
        public void Sayhello() 
        {
            Console.WriteLine("我叫{0}，我的年龄{1}，我的爱好是{2}，我的工作是{3}", this.Name, this.Age, this.Hobby, this.Work);
        }
    }
}