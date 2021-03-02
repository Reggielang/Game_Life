using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_类的属性
{
    class Man
    {
        private string _name; //字段声明，前面加入下划线
        private int _age;
        private char _gender;

        //给字段加入属性
        public string Name
        {
            get { return _name; } //取值 我们从字段当中取值的时候调用get方法
            set { _name = value; } //赋值， 给字段赋值的时候调用set方法
        }

        public int Age
        {
            get { return _age; }
            set {
                if (value < 0 || value > 100)
                { value = 0; }
               _age = value;
            } // value就是我们给字段赋的值
        }

        public char Gender
        {
            get
            {
                if (_gender == '男' || _gender == '女')
                {
                    return _gender;
                }
                return _gender = '男';
            }
            set { _gender = value; }
        }
        

        public void Hobby()
        {
            Console.WriteLine("我的名字是{0}，我的年龄是{1}，我的性别是{2},爱好是看看电视！", Name, Age, Gender);
        }
    }
}
