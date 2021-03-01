using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_out参数
{
    class Program
    {
        static void Main(string[] args)
        {
            int c;
            int d;
            int f;
            int e;
            string q;
            Program.Sum(out c,out d,out f,out e,out q);
            Console.WriteLine(c);
            Console.ReadKey();
        }
        //在方法中存储两个变量，和两个变量的和与平均值
        //out 函数外可以不为变量赋值，但函数内必须为其赋值 同时形参和实参都必须加out关键字
        public static void Sum(out int a,out int b, out int sum, out int avg, out string i) 
        {
            a = 5; //返回值和参数不是一回事
            b = a + 1; //out传的参数 
            sum = a + b; //return 返回的是值！！！
            avg = sum / 2;
            i = "你是神魔恋";
        }
    }
}
