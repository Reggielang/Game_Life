using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27方法练习
{
    class Program
    {
        //public static int num_max; //练习1 声明一个全局变量，供不同的函数使用
        public static bool year;
        static void Main(string[] args)
        {
           // int a = 10;
           //int b =  Program.Number(a); //函数的返回值 需要定义一个变量去接收！
           // Console.WriteLine(b);
           // Console.ReadKey();


            //练习1 
            int num_max = Max(3,2);
            Console.WriteLine(num_max);
            Console.ReadKey();

            //练习2
            bool year = Program.Year(2000);
            Console.WriteLine(year);
            Console.ReadKey();
        }
        //public static int Number(int a)
        //{
        //    a = a + 10; //返回一个值 是不是返给Main函数！
        //    return a; //需要一个return来返回最后的值
        //}

        //练习1 求两个数的最大值
        public static int Max(int x,int y)
        {
            if (x > y)
            {
                return x;
            }
            else 
            {
                return y;
            }          
        }
        // 练习2 判断闰年
        public static bool Year(int i) 
        {
            if ((i % 4 == 0 && i % 100 != 0) || (i % 400 == 0))
            {
                return true;
            }
            else 
            {
                return false;
            }
            
        }
    }
}
