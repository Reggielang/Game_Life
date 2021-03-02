using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_继承2
{
     class Hashiqi:Wolf 
    {
        
        //在子类中显示的调用父类的构造函数，使用关键字：base()
        public Hashiqi(int age, char gender, string name,int iq)
            :base(age,gender,name) //base代表显示的调用父类的构造函数
        { 
            this.Iq=iq;
        }
        //子类的私有字段也可以传入构造函数
        private int _iq;

        public int Iq
        {
            get{return _iq;}
            set{_iq=value;}
        }

        public void IQ()
        {
            Console.WriteLine("我智商低");
        }

    }
}