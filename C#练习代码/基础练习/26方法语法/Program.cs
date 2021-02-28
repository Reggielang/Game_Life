using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26方法语法
{
    class Program
    {
        static void Main(string[] args)
        {
            //public static 返回值类型 函数名（[参数列表]）
            //{
            // 函数代码体：
            //   }
            //public 访问修饰符，static静态标识符 返回值类型，如果不需要返回就写void，就是无返回值的意思；
            //方法名 当前函数的名字， 要符合Pascal命名法
            //参数列表 如果不需要参数，小括号中可以留空 如果需要参数要以 参数类型 参数名 的形式书写
            Program.Name();
           int d =  Program.Sum(2,2); //在函数调用中输入实参
            Console.WriteLine(d);
            Console.ReadKey();

        }
        // 方法声明了，可以在Main函数中被调用
        public static void Name() 
        {
            Console.WriteLine("你多帅哦");
            Console.ReadKey();
        }
        //输出两个数的和
        public static int Sum(int a, int b) 
        {
             int c = a + b;
             return c; // 返回要返回的值
        }
    }
}
