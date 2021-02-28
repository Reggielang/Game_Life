using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25数组练习3
{
    class Program
    {
        static void Main(string[] args)
        {
            //定义一个string类型的数组，数组中的人名分割为：小明|小花|小草|小狗|小阿
            string[] name = { "小花", "小明", "小草", "小狗" , "小阿" };
            //思路，通过一个循环获得每个元素，然后把每个元素累加到一个字符串当中
            string namelist = null; //null !=空
            for (int i = 0; i < name.Length-1; i++)
            {
                namelist += name[i] + "|";
            }
            Console.WriteLine(namelist+namelist[namelist.Length-1]);
            Console.ReadKey();

            //数组元素是正数则这个位置的元素加1，负数则减1，0则不变。
            //通过循环得到数组中的值，然后跟0进行对比
            int[] number = { 1, 2, 3, 4, 0, -2, -4, -5};
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i]>0)
                {
                    number[i] += 1;
                }
                else if (number[i] < 0)
                {
                    number[i] -= 1;
                }
                else
                {
                    number[i] = number[i];
                }
                Console.WriteLine(number[i]);
            }
            Console.ReadKey();
        }
    }
}
