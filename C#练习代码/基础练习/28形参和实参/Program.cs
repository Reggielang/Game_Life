using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28形参和实参
{
    class Program
    {
        static void Main(string[] args)
        {   
            //练习1 求两个数的大小
            //int a = 10; //实际参数
            //int b = 20;
            int max = Program.Max(10, 999); //传入的是实参--只要和函数定义时形参的数据类型和数量保持一致就可以
            Console.WriteLine(max);
            Console.ReadKey();

            //练习2 
            bool year = Year(2021);
            Console.WriteLine(year);
            Console.ReadKey();
            

        }
        public static int Max(int a, int b) //形式参数
        {
            if (a > b)
            {
                return a;
            }
            else 
            {
                return b;
            }
        }

        //练习2 求闰年
        public static bool Year(int i)
        {
            bool b = (i % 400 == 0) || (i % 4 == 0 && i % 100 != 0);
            return b;
        }
    }
}
