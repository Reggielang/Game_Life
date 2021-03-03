using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_集合的长度问题
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();

            //Count-表示这个集合中实际包含的元素个数
            //Capacity- 表示这个集合中可以包含的元素个数


            list.Add(1);
            list.Add(1);
            list.Add(1);
            list.Add(1);
            list.Add(1);
            list.Add(1);
            list.Add(1);
            list.Add(1);
            list.Add(1);

            //每次集合中实际包含的元素个数超过了可以包含的元素的个数时，集合会向内存申请多开辟一倍的空间，来保证集合的长度一直够用
            Console.WriteLine(list.Count);
            Console.WriteLine(list.Capacity);
            Console.ReadKey();

        }
    }
}
