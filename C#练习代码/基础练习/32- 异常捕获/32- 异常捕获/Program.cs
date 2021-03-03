using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24__异常捕获
{
    class Program
    {
        static void Main(string[] args)
        {
            //语法上没有错误，在程序运行的过程中，由于某些原因程序出现了错误，不能再正常的运行
            //异常捕获 try -catch 进行异常捕获

            //哪行代码可能出现异常就使用TRY
            //try { 可能出现异常的代码； } catch {出现异常错误要执行的代码；}
            //执行过程：如果try的代码不出现异常，那么不会执行catch的代码， 如果try中代码出现异常，哪怕代码后面有一百行都不会执行
            // 而是直接进入catch中执行
            bool b = true;
            //变量的作用域 --能够使用变量的范围--从声明它的括号开始到所对应的结束的括号结束。
            int number =0; //声明了变量 //给一个初始值
            Console.WriteLine("请输入一个数字：");
            try
            {
               number = Convert.ToInt32(Console.ReadLine()); //赋值
              
            }
            catch 
            {

                Console.WriteLine("输入内容不能转换为数字！");
                b = false;
            }


            //让这行代码满足一些条件去执行，使用bool类型
            if (b)
            {
                Console.WriteLine(number * 2); //使用
            }
            Console.ReadKey();
        }
    }
}
