using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12逻辑运算符练习
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入你的语文成绩：");
            //string strchinese = console.ReadLine();
            //int chinese = Convert.ToInt32(strchinese);
            int chinese = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入你的数学成绩：");
            int math = Convert.ToInt32(Console.ReadLine());
            bool a = (chinese > 90 && math > 90);
            Console.WriteLine(a);
            Console.ReadKey();

            //计算闰年 1.能被4整除的，不能被100整除 2.能被400整除
            Console.WriteLine("请输入一个年份");
            int year = Convert.ToInt32(Console.ReadLine());
            bool b = (year %4 == 0 && year != 100)||(year%400 == 0);
            Console.WriteLine(b);
            Console.ReadKey();
        }
    }
}
