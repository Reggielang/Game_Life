using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17break和continue
{
    class Program
    {
        static void Main(string[] args)
        {
            //break立刻结束循环体 用于完全结束一个循环，跳出循环体
            //continue立刻结束本次循环 continue只是中止本次循环，回到判断条件如果成立则开始下一次的循环，如果不成立退出循环。
            //而break是完全终止循环。
            while (true) 
            {
                Console.WriteLine("你在干什么");
                break;
            }
            Console.ReadKey();

            //while (true) 
            //{
            //    Console.WriteLine("你在干什么");
            //    continue;
            //}
            //Console.ReadKey();


            //while continue 实现1到100之间除了能被7整除之外的所有整数和
            int sum = 0;
            int i = 1;
            while (i<=100)
	        {
                if (i%7==0)
	            { 
                    i++;
                    continue; // 如果i++位于continue之下，将永远不会被执行 因为continue回到了判断条件
	            }
                sum+=i;
                i++;
	        }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
