using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30ref参数
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            ZiZeng(ref a);
            Console.WriteLine(a);
            Console.ReadKey();

        }
        //ref参数 将一个变量传入一个函数中进行 "处理"，完成之后，再将处理之后的值带出函数
        public static void ZiZeng(ref int s) //同步 
        {
            s += 1; //ref传的是参数 不是return的返回值，参数是参数
        }
        public static int ZiJian(int d) 
        {
            d -= 1;
            return d;
        }
    }
}
