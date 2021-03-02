using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_构造函数
{
    class Man
    {
        //析构函数 -- 释放资源
        ~Man()
        {
            Console.WriteLine("111111111111111111111111111111111111"); //GC 垃圾回收
        }
        
        //构造函数 帮助我们初始化对象 给对象的每个属性依次的赋值
        //构造函数 没有返回值，连void都没有
        //构造函数的名称必须跟类名一样！
        //例如 public Man(){}
        public Man(string _name, int _age, char _gender)
        {
            //this 代表就是当前类的对象
            this.Name = _name;
            this.Age = _age;
            this.Gender = _gender;
        }
        public Man(string _name, int _age)
        {
            this.Name = _name;
            this.Age = _age;
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private int _age;
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        private char _gender;
        public char Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
        public void Say()
        {
            Console.WriteLine("我的名字是{0}，我的年龄是{1}，我的性别是{2}",this.Name,this.Age,this.Gender);
        }

    }
}
