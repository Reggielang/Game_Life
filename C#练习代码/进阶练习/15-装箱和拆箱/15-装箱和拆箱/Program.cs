using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_装箱和拆箱
{
    class Program
    {
        static void Main(string[] args)
        {
            //装箱-- 值类型转换为引用类型 值类型：int, double,float, char, struct,enum,bool
            //拆箱-- 引用类型转换为值类型 引用类型: string ,数组，自定义类，集合
            ArrayList list = new ArrayList();
            //装箱拆箱会影响程序的运行速度
            List<int> list = new List<int>();
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < 10000000; i++)
            {
                list.Add(i); //如果是ArrayList的话，加入int进去，那么就会存在拆箱操作从object类型到int类型
            }
            sw.Stop();
            Console.WriteLine(sw.Elapsed);
            Console.ReadKey();

            //这种操作没有发生装箱，拆箱
            string number = "123"; 
            int numberOne = Convert.ToInt32(number);

            //看两种类型是否发生了装箱和拆箱，要看两种类型是否存在继承关系。如果存在继承关系则可能发生装箱和拆箱
            //如果没有继承关系则不可能发生装箱和拆箱。

        }
    }
}
