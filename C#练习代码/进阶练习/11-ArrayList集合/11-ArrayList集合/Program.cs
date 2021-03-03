using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_ArrayList集合
{
    class Program
    {
        static void Main(string[] args)
        {
            //集合 = 很多数据的一个集合
            //数组缺点 --长度固定，类型单一
            //集合优点--长度可变，类型随便
            ArrayList list = new ArrayList();
            //add中可以添加object， object是所有类的父类，所以可以随便添加
            list.Add(true);
            list.Add(123);
            list.Add(0.123);
            list.Add(23.0f);
            list.Add("呵呵");
            list.Add('呵');

            //addrange添加集合元素
            list.AddRange(new int[] { 1,2,3,4,5});

            list.AddRange(list);

            //清除所有元素
            //list.Clear();

            //删除单个元素
            //list.Remove(true);

            //根据下标删除元素
            //list.RemoveAt(1);

            //根据范围删除元素
            //list.RemoveRange(0, 3);

            //排序
            //list.Sort();

            //反转顺序
            //list.Reverse();

            //插入元素
            //list.Insert(0, "多帅哦");

            //插入多个元素
            //list.InsertRange(0, new int[] { 1, 2, 3 });

            //包含某个元素
            //bool b = list.Contains("呵呵");
            //Console.WriteLine(b);
            //Console.ReadKey();

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);

            }
            Console.ReadKey();
        }
    }
}
