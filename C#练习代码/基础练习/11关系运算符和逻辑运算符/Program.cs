using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11关系运算符和逻辑运算符
{
    class Program
    {
        static void Main(string[] args)
        {   
            //&&两个条件都必须满足才能是true；
            bool b = 150 > 200 && true;
            Console.WriteLine(b);
            Console.ReadKey();

            //||两个条件满足一个就是true；
            bool a = 140 < 200 || true;
            Console.WriteLine(a);
            Console.ReadKey();

            //!真的变假的，假的变真的
            bool c = !(5 > 3);
            Console.WriteLine(c);
            Console.ReadKey();

            //练习1
            Console.WriteLine("请输入你的年龄：");
            string age = Console.ReadLine();
            Console.WriteLine("请输入你的身高：");
            string length = Console.ReadLine();
            int numage = Convert.ToInt32(age);
            double numlength = Convert.ToDouble(length);
            bool d = numage > 18 && numlength > 165;
            Console.WriteLine(d);
            Console.ReadKey();

            //作业
            Console.WriteLine("请输入你的语文成绩：");
            string chinese = Console.ReadLine();
            Console.WriteLine("请输入你的数学成绩：");
            string math = Console.ReadLine();
            double numchinese = Convert.ToDouble(chinese);
            double nummath = Convert.ToDouble(math);

            bool e = (numchinese > 90 && nummath > 90) || (numchinese > 90 || nummath > 90);
            Console.WriteLine(e);
            Console.ReadKey();

            //作业2
            Console.WriteLine("请输入一个年份：");
            string year = Console.ReadLine();
            int numyear = Convert.ToInt32(year);
            bool f = (numyear % 4 == 0 && numyear % 100 != 0) || (numyear %400 ==0);
            Console.WriteLine(f);
            Console.ReadKey();
            


        
        }
    }
}
