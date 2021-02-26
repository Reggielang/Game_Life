using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14switch语句
{
    class Program
    {
        static void Main(string[] args)
        {
            //看电影身高大于180，年龄大于18才可以观看
            //身高等于200，年龄大于16可以免费观看
            //Console.WriteLine("请输入你的身高：");
            //int high = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入你的年龄：");
            //int age = Convert.ToInt32(Console.ReadLine());

            //bool a = (high > 180 && age > 18) || (high == 200 && age > 16);
            //if (a) ;
            //{
            //    Console.WriteLine("你可以观看这个电影！");
            //    Console.ReadKey();
            //}
            //阿峰的考试成绩大于等于60分，他爸爸就高兴，否则就是暴捶
            //Console.WriteLine("请输入阿峰的成绩：");
            //int mark = Convert.ToInt32(Console.ReadLine());
            //if (mark >= 60)
            //{
            //    Console.WriteLine("高兴哦");
            //}
            //else
            //{
            //    Console.WriteLine("要被暴捶!");
            //}
            //Console.ReadKey();

            //switch 用来处理多条件的"定值"判断
            Console.WriteLine("请输入一个名字：");
            string name = Console.ReadLine();
            switch (name)
            {
                case "阿A":Console.WriteLine("你是大哥");
                    break;
                case "阿B":Console.WriteLine("你是大姐");
                    break;
                case "阿C": Console.WriteLine("你是什么鬼");
                    break;
                case "阿D":Console.WriteLine("你多帅哦~");
                    break;
                default:Console.WriteLine("神魔恋");
                    break;
            }
            Console.ReadKey();

            //作业
            Console.WriteLine("欢迎来到饭店，请选择你喜欢的套餐：");
            string dish = Console.ReadLine();
            switch(dish)
             {
                case "A":Console.WriteLine("泡椒牛肉饭");
                    break;
                case "B":Console.WriteLine("扬州炒饭");
                    break;
                case "C": Console.WriteLine("回锅肉炒饭");
                    break;
                case "D":Console.WriteLine("辣子鸡炒饭");
                    break;
                case "E":Console.WriteLine("青椒肉丝炒饭");
                    break;
                default:Console.WriteLine("不吃就滚！");
                    break;
            }
            Console.ReadKey();
        }
    }
}
