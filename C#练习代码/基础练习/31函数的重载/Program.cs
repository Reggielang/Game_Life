using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31函数的重载
{
    class Program
    {
        static void Main(string[] args)
        {
            //函数重载 函数的名称相同，参数列表不同 函数的返回值跟重载没有关系
            //要么类型不一样，要么参数数量不一样，构成重载
            Console.WriteLine(123); //WriteLine方法就有很多重载

        }
        public static void Number(int a, int b)
        {

        }
        public static void Number(string a, string b)
        {

        }
        public static void Number(int a, int b, int c)
        {

        }
        public static void Number(double a, double b)
        {

        }

    }
}
