using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 两种类型的装换
{
    class Program
    {
        static void Main(string[] args)
        {
            //隐式类型转换,自动类型转换 1.两种类型兼容 例如 int float 2.原类型要小于目标类型
            int a = 5;
            double b = a;
            Console.WriteLine(b);
            Console.ReadKey();

            //显式类型转换，强制类型转换 1.两种类型兼容， 原类型大于目标类型 （代转换的类型）要转换的值；
            double i = 3.14;
            int s = (int)i;
            Console.WriteLine(s);
            Console.ReadKey();

            //如果一个操作数为double，那么整个表达式都换转换提升成double类型，因为double类型是包含了int
            int x = 10;
            double y = 3;
            double c = x / y;
            Console.WriteLine(c);
            Console.ReadKey();

            //小明3条腿，去买东西，已知裤子的价格是36元/一个裤腿，需要多少钱，打了8折之后？
            int leg = 3;
            int kuzi = 36;
            int cost = leg * kuzi;
            double cost2 = 0.8 * kuzi * leg;
            Console.WriteLine("原价是{0}，打了8折之后是{1}",cost,cost2);
            Console.ReadKey();

            //double c= 0.123456,转换成int，输出
            double l = 0.123456789;
            int t = (int)l;
            Console.WriteLine(t);
            Console.ReadKey();

            //a =5,b=2,c=a/b 用整数和小数分别输出c
            int m = 5;
            double n = 2;
            double v = m / n;
            Console.WriteLine(v);
            Console.ReadKey();

            //a =5,b=2,c=a/b 用整数和小数分别输出c
            int d = 5;
            int f = 2;
            int g = d / f;
            Console.WriteLine(g);
            Console.ReadKey();
            


        }
    }
}
