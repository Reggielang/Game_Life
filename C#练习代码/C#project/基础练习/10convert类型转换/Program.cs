using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace convert类型转换
{
    class Program
    {
        static void Main(string[] args)
        {
            //Convert 类型转换，如果两个类型兼容，就直接进行自动类型转换或者强制类型转换，如果不兼容，例如string和double，就可以进行Convert转换
            string a = "123";
            string b = "456";
            Console.WriteLine(a+b);
            Console.ReadKey();

            string c = "123";
            int number1 = Convert.ToInt32(c);
            string d = "456";
            int number2 = Convert.ToInt32(d);
            Console.WriteLine(number1+number2);
            Console.ReadKey();

            //提示一个人输入姓名，并分别输入语文数学英语三个成绩，程序反馈出三门之和以及平均分
            //用户的控制台的输入都是用string来接收
            Console.WriteLine("请输入姓名");
            string name = Console.ReadLine();
            Console.WriteLine("请输入语文成绩：");
            string chinese = Console.ReadLine();
            Console.WriteLine("请输入数学成绩：");
            string math = Console.ReadLine();
            Console.WriteLine("请输入英语成绩：");
            string english = Console.ReadLine();
            double numchinese = Convert.ToDouble(chinese);
            double nummath = Convert.ToDouble(math);
            double numenglish = Convert.ToDouble(english);
            Console.WriteLine("{0}，你好，你的三门成绩总共是{1}，平均分为{2}", name, numchinese + numenglish + nummath, numchinese + numenglish + nummath / 3);
            Console.ReadKey();



        }
    }
}
