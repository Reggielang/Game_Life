using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33_可变参数
{
    class Program
    {
        static void Main(string[] args)
        {
            //params --将实参列表中跟可变参数数组类型一致的元素，都当作数组中的元素处理
            //必须是形参列表中的最后一个参数,并且只能存在一个可变参数
            Test("张三", 99,88,77,66,55);
            Console.ReadKey();


            //练习- 求任意长度数组的和-整数类型
            int sum = GetSum(1, 2, 3, 4, 5);
            Console.WriteLine(sum);
            Console.ReadKey();


        }

        public static int GetSum(params int[] n)
        {
            int sum = 0;
            for (int i = 0; i < n.Length; i++)
            {
                sum += n[i];
            }
            return sum;
        }

        public static void Test(string name, int id, params int[] score)
        {
            int sum = 0;
            for (int i = 0; i < score.Length; i++)
            {
                sum += score[i];
            }
            Console.WriteLine("{0}这次考试的总成绩是{1},学号是{2}", name, sum,id);
        }
    }
}
