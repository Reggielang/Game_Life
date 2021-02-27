using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18常量
{
    class Program
    {
        static void Main(string[] args)
        {
            //常量一旦被声明，就不可以被重新赋值
            int a = 5;
            a = 10;//变量的重复赋值
            int b = 0;
            b += 10;
            //常量一般都是全大写 语法：
            const int c = 5;
            const int MONEY = 3;
        }
    }
}
