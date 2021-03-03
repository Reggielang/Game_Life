using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_数组
{
    class Program
    {
        static void Main(string[] args)
        {
            //数组一旦创建，其容量的大小是无法改变 静态数组：int[] float[] double[]  char[]  string[]
            //动态数组  ArrayList  List(泛型) --可以根据元素的多帅动态的调整数组容量的大小
            //int[] arr = new int[10];
            //for (int i = 0; i < 10; i++)
            //{
            //    arr[i] = i;
            //    Console.Write(arr[i] + " ");
            //}
            //Console.WriteLine();

            ////动态数组的扩容能力
            //ArrayList a = new ArrayList(10);
            //for (int i = 0; i < 15; i++)
            //{
            //    a.Add(i);
            //    Console.Write(a[i] + " ");
            //}
            //Console.WriteLine();


            //List<int> l = new List<int>(10);
            //for (int i = 0; i < 15; i++)
            //{
            //    l.Add(i);
            //    Console.Write(l[i] + " ");
            //}
            //Console.Read();


            //实现数组

            Array1 a = new Array1(20);
            for (int i = 0; i < 10; i++)
            {
                a.AddLast(i);
            }
            Console.WriteLine(a);

            a.AddFirst(66);
            Console.WriteLine(a);

            a.Add(2, 77);
            Console.WriteLine(a);


            //Console.WriteLine(a.GetFirst());
            //Console.WriteLine(a.GetLast());
            //Console.WriteLine(a.Get(0));

            //a.Set(1, 1000);
            //Console.WriteLine(a);

            //[66, 1000, 77, 1, 2, 3, 4, 5, 6, 7, 8, 9]
            a.RemoveAt(2);
            a.RemoveFirst();
            a.RemoveLast();
            a.Remove(2);
            Console.WriteLine(a);

            Array1 b = new Array1(10);
            for (int i = 0; i < 10; i++)
            {
                b.AddLast(i);
            }
            Console.WriteLine(b);

            b.AddLast(55);
            Console.WriteLine(b);

            for (int i = 0; i < 6; i++)
            {
                b.RemoveLast();
                Console.WriteLine(b);
            }


            Console.Read();

        }
    }
}
