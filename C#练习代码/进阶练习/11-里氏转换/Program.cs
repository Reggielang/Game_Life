using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_里氏转换
{
    class Program
    {
        static void Main(string[] args)
        {
            //object类是所有类型的父类
            // 1.子类对象可以直接赋值给父类；2.子类对象可以调用父类中的成员，但父类对象永远只能调用自己的成员
            //3.如果父类对象装的是子类对象，可以将这个父类对象强转为子类对象。

            //子类对象可以调用父类中的成员
            Ming m = new Ming();
            m.Fatersayhi(); 
            m.Mingsayhi();

            //父类对象永远只能调用自己的成员!
            //Father f = new Father();
            //f.Fatersayhi();

            //子类对象可以直接赋值给父类
            Father f = new Ming(); //父类现在存的是子类的对象
            //string str = string.Join("|", new string[] { "1", "2", "3" });
            //Console.WriteLine(str);
            //Console.ReadKey();

            //前提：如果父类对象装的是子类对象，才可以将这个父类对象强转为子类对象。！！
            //Ming s = (Ming)f;

            //is 和 as 
            // is 转换成功返回true，失败返回false； as转换成功返回对应的对象，失败返回null
            //if (f is Ming)
            //{
            //    Console.WriteLine("转换成功");
            //}
            //else { Console.WriteLine("转换失败"); }
            //Console.ReadKey();


            Ming a = f as Ming;
            Console.WriteLine(a);
    
            Hong h = f as Hong;
            Console.WriteLine(h);
            Console.ReadKey();
            
        }
    }
}
