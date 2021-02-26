using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03变量
{
    class Program
    {
        static void Main(string[] args)
        {
            //先声明，再赋值，后使用
            int number;//确定变量的类型
            number = 10;//赋值
            int speed = 50;
            Console.WriteLine(number);
            Console.WriteLine(speed);
            Console.ReadKey();
        }
    }
}
