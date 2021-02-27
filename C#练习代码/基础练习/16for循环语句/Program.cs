using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16for循环语句
{
    class Program
    {
        static void Main(string[] args)
        {
            //for（初始表达式，条件表达式，增量表达式）

            //int a = 0;
            //while(a<10)
            //{
            //    Console.WriteLine("多帅哦！");
            //    a++;
            //}
            //Console.ReadKey();

            //初始表达式 声明循环的变量，记录循环的次数
            //条件表达式 循环的条件
            //改变循环的代码，使循环代码可以终止
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("多帅哦！{0}",i);
            }
            Console.ReadKey();

            //演示 1+2+..+100的和
            int sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);
            Console.ReadKey();

            //作业 打印1-到10个数字
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();

            //计算1到100中的奇数之和，以及偶数之和
            int num1 = 0;
            for (int i = 1; i <= 100 ; i++)
            {
                if (i % 2 != 0) 
                {
                    num1 += i;
                }
            }
            Console.WriteLine(num1);
            Console.ReadKey();

            //第二种
            //int num1 = 0;
            //for (int i = 1; i <= 100; i+=2)
            //{
            //   num1 += i;
            //}
            //Console.WriteLine(num1);
            //Console.ReadKey();

            //int num2 = 0;
            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 2 == 0) 
            //    {
            //        num2 += i;
            //    }
            //}
            //Console.WriteLine(num2);
            //Console.ReadKey();

            //第二种
            int num2 = 0;
            for (int i = 2; i <= 100; i += 2)
            {
                num2 += i;
            }
            Console.WriteLine(num2);
            Console.ReadKey();

            //for循环的嵌套
            int count = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.WriteLine("你是神魔恋有i{0},但是失了智有j{1}",i,j);
                }
            }
            Console.ReadKey();

            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    //write输出一横排不换行
                    Console.Write("{0}*{1}={2}\t",i,j,i*j);
                }
                //writeLine来换行输入
                Console.WriteLine();
            }
            Console.ReadKey();

            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <=i; j++)
                {
                    Console.Write("{0}*{1}={2}\t",i,j,i*j);
                }
                Console.WriteLine();
            }
            Console.ReadKey();



        }
    }
}
