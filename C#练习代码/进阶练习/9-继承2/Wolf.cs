using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_继承2
{
     class Wolf
    {
        //如果父类重新创建了一个有参数的构造函数之后，那么那个无参数的构造函数就没有了
        //子类就调用不到了，所以子类会报错。

        //解决办法： 1在父类中重新写一个无参数的构造函数，如下所示 //最好不要用
        //在子类中显示的调用父类的构造函数，使用关键字  :base()
        public Wolf(int age,char gender,string name)
         {
            this.Age = age;
           this.Gender = gender;
            this.Name = name;
         }
        //public Wolf() { }！！//最好不要用

        public string _name;
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
        public void Eet()
        {
            Console.WriteLine("我会吃饭");
        }
    }
}