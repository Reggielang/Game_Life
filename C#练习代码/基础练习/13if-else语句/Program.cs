using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13if_else语句
{
    class Program
    {
        static void Main(string[] args)
        {
            //程序从main函数从上往下一行一行的运行
            //if（）小括号中的为true，那么执行if的语句
            Console.WriteLine("请用户输入你的年龄：");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age > 18) 
            {
                Console.WriteLine("你有权观看本电影！");
                Console.ReadKey();
            }

            Console.WriteLine("请用户输入你的年龄：");
            int age1 = Convert.ToInt32(Console.ReadLine());
            //if-else语句 先判断，再执行，最少都要执行一条代码
            if (age1 > 18) 
            {
                Console.WriteLine("你有权观看本电影！");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("对不起，你无权观看电影！");
                Console.ReadKey();
            }

            //if -else if 语句 用于多条件判断（条件>2） 区间的判断
            Console.WriteLine("请输入你准备了多少钱");
            int money = Convert.ToInt32(Console.ReadLine());
            if (money>200)
            {
                Console.WriteLine("特殊服务！");
            } 
            else
            {
                if(money>150)//程序执行到这一步，已经小于200了。
                {
                    Console.WriteLine("泡脚和捏脚服务");
                }
                else
                {
                    if(money>100)//默认小于150
                    {
                        Console.WriteLine("捏脚服务");
                    }
                    else
                    {
                        if(money>50)//默认小于100
                        {
                            Console.WriteLine("泡脚服务");
                        }
                    }
                }
            }
         Console.ReadKey();
        }
    }
}
