using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 运算符和占位符
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 10;
            //int b = 3;
            //int c = a / b;
            //Console.WriteLine(c);
            //Console.ReadKey();
            string name = "阿A";
            int age = 18;
            char gender = '男';
            double iq = 180;
            Console.WriteLine("我的名字是{0}，我的年龄{1}，我的性别是{2}，我的IQ有{3}", name, age, gender, iq);
            Console.ReadKey();

            //100加上0.1的和
            int number1 = 100;
            double number2 = 0.1;
            double number3 = number1 + number2;
            Console.WriteLine(number3);
            Console.ReadKey();


            //小明3条腿，一个裤腿36元，那小明买裤子需要多少钱？ 打八折之后？
            int money = 36;
            int leg = 3;
            double cost = money*leg;
            double cost2 = 0.8 * money * leg;
            Console.WriteLine("原价等于{0}，打八折之后{1}",cost,cost2);
            Console.ReadKey();
        }
    }
}
