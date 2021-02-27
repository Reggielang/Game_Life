using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22数组基本语法
{
    class Program
    {
        static void Main(string[] args)
        {
            //数组是一个存储相同类型的元素的固定大小的集合，一次性存储多个相同类型的变量
            //声明，初始化二合一
            //数据类型[] 数组名 = new 数组类型[数组长度]; 注意左右两端的数据类型必须一致
            int[] number = new int[5]; //内存中开辟了5个连续的空间，这5个空间叫数组的元素
            //数组的赋值 数组名[索引] = 值
            number[0] = 1;
            number[1] = 2;
            number[2] = 3;
            number[2] = 6; //代表可以对数组当中的值进行重复赋值
            number[3] = 4;
            number[4] = 5;
            //for (int i = 0; i < number.Length; i++)
            //{
            //    number[i] = i;
            //}
            int[] b = { 1, 2, 3, 4, 5 };//减少了一步赋值的操作，同时省去了声明数组长度 第二种声明方式

            //int[] c = new int[3] { 1, 2, 3 };//声明数组的同时进行赋值

            //int[] d = new int[] { 1, 2, 3, 4 };

            for (int i = 0; i < number.Length; i++)
            {
                Console.WriteLine(number[i]);
            }
            Console.ReadKey();

            //string 类型的数组
            string[] name = new string[4]; // 初始值为null, null 意思为根本没在内存中开辟空间 ， 空 意思为开了空间只是没有存储值

            bool[] a = new bool[5]; //初始值为false
        }
    }
}
