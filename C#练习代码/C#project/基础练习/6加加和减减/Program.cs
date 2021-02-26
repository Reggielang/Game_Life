using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 加加和减减
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;//a++是(n+1)
            int b = 5 + a++; //先进行运算，然后结束后，a自身再加1

            //int b = 5 + ++a; //先给a加1，然后用a加1的值再进行计算。
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.ReadKey();

            int c = 10;
            c += 20; // c = c + 20
            Console.WriteLine(c);
            Console.ReadKey();

            //作业（一元运算符++ --，二元运算符+ - * / % ）一元运算符的优先级要高于二元运算符！！！
            int x = 10;
            int y = x++ + ++x * 3 + --x + x++;
            // x = 10+1+1+1-1 =12
            // y =  10 + 12*3 + 11 + 11
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.ReadKey();

        }
    }
}
