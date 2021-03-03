using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_list泛型集合
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list =  new List<int>(); //一定不要忘记小括号！！
            list.Add(1);
            list.AddRange(new int[] {2,3,4,5});

            //泛型集合能不能转成数组?
            int [] number = list.ToArray();
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.ReadKey();

            //数组也能转化成泛型集合
            List<int> listTwo = number.ToList();
        }
    }
}
