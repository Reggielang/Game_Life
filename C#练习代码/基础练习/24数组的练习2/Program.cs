using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24数组的练习2
{
    class Program
    {
        static void Main(string[] args)
        {
            //计算数组中所有元素的和
            int[] number = { 1, 2, 3, 4, 5, 6 };
            int sum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                sum += number[i];
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
