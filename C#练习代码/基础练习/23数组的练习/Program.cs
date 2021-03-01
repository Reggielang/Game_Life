using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23数组的练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //定义一个整数数组，从中选出最大值，最小值，数组的总和和平均值
            int[] number = {1,2,3,4,5,6,7,8,9,};
            //定义两个数对比数组当中的数进行对比
            int max = number[0]; //假如数组中的一个数是最大值
            int min = number[0]; //假如数组中的一个数是最小值
            int sum = 0; //存储数组的总和
            for (int i = 0; i < number.Length; i++)
	{
                if (number[i]>max)
	            {
                    max = number[i];
	            }//i是当前循环到的元素 数组中的元素
                if (number[i]<min)
	            {
                    min = number[i];
	            }
                sum+=number[i];
	}
            Console.WriteLine("数组的最大值是{0}，最小值是{1}，总和是{2}，平均值是{3}",max,min,sum,sum/number.Length);
            Console.ReadKey();
        }
    }
}
