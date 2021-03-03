using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_集合的练习
{
    class Program
    {
        static void Main(string[] args)
        {
            ////练习 集合里添加三个数字，求平均以及和
            //ArrayList list = new ArrayList();
            //list.AddRange(new int[] { 1,2,3});

            //int sum = 0;
            //for (int i = 0; i < list.Count; i++)
            //{
            //    //数组添加到list之后变为了object
            //    //因为object是所有类的父类，所以可以把object转换成int.
            //    sum += (int)list[i];
            //}
            //Console.WriteLine("平均是{0}，和是{1}", sum / list.Count, sum);
            //Console.ReadKey();

            ////练习 创建长度为10的集合，要求随机放入10个数字0-9但是要求不能重复
            //ArrayList list1 = new ArrayList();
            //Random r = new Random();

            //for (int i = 0; i < 10; i++)
            //{
            //    int rnumber = r.Next(0, 10);
            //    //集合中没有这个随机数
            //    if (!list1.Contains(rnumber))
            //    {
            //        list1.Add(rnumber);
            //    }
            //    else //集合中有这个随机数
            //    {
            //        i--;
            //    }

            //}
            //for (int i = 0; i < list1.Count; i++)
            //{
            //    Console.WriteLine(list1[i]);
            //}
            //Console.ReadKey();

            //测试-1 在集合中添加三个数，并求出三个数的平均和总和
            ArrayList list = new ArrayList();
            list.AddRange(new int[] { 1, 2, 3 });
            int sum = 0;
            for (int i = 0; i < list.Count; i++)
            {
                sum += (int)list[i];
            }
            Console.WriteLine("平均是{0}，总和是{1}",sum/list.Count,sum);
            Console.ReadKey();

            //测试2 - 创建长度为10的集合，要求随机放入10个数字0-9但是要求不能重复
            ArrayList list2 = new ArrayList();
            Random rd = new Random();
        
            for (int i = 0; i < 10; i++)
            {
                int rnumber = rd.Next(0, 10);
                if (!list2.Contains(rnumber)) //！（表示非，否定）集合中不包含
                {
                    list2.Add(rnumber); //加入不包含的随机数
                }
                else
                {
                    i--; //让i小于10一直循环，直到加入了所有0-9随机数
                }
            }
            for (int i = 0; i < list2.Count; i++)
            {
                Console.WriteLine(list2[i]);
            }
            Console.ReadKey();
        }
    }
}
