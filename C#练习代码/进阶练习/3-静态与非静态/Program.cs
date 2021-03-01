using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_静态与非静态
{
    class Program
    {
        static void Main(string[] args)
        {
            //在调用实例成员的时候，可以用对象名.实例成员
            Test person = new Test();
            person.Number(); //非静态方法

            //调用静态成员的时候，需要用类名.静态成员名；
            Test.Age(); // 静态方法

            //静态成员必须使用类名调用，而实例成员可以用对象名调用。

        }
    }
}
