using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15while循环语句
{
    class Program
    {
        static void Main(string[] args)
        {
            //while循环
            //int a = 0;
            //while (a < 10)
            //{
            //    Console.WriteLine("你在干什么");
            //    a++;
            //}
            //Console.ReadKey();

            //do -while 循环 循环会先执行do里的循环体，然后再判断while中的判断是否为真。先循环，再判断，最少执行一次循环体。
            //老板回答NO - 循环条件
            //为老板一直服务 - 循环体
            //Console.WriteLine("我的服务你满意么？");
            //string answer = Console.ReadLine();
            //while(answer=="NO")
            //{
            //    Console.WriteLine("多捞哦！再来一次？");
            //    answer = Console.ReadLine();
            //}

            //string answer = "";
            //do
            //{
            //    Console.WriteLine("我的服务你满意么？");
            //    answer = Console.ReadLine();

            //} while (answer == "NO");
            //Console.WriteLine("谢谢惠顾");
            //Console.ReadKey();

            //作业 1+2+..+100的和

            //循环条件 数字在1-100之间
            //循环体  累加a循环的过程
            int a = 1;
            int sum = 0; //！！接受a累加的值
            while(a<=100)
            {
                sum += a; //sum = sum+a //重复赋值，sum+a的值
                a++;
            }
            Console.WriteLine(sum);
            Console.ReadKey();

            //游戏规则：输入你们班女生的数量，然后依次输入每个女生的颜值分数，计算班上的女生颜值的总和和平均值。
            //循环体:输入女生的颜值分数
            //循环条件 i小于等于我们输入的女生数量
            Console.WriteLine("请输入班上女生的数量");
            int count = Convert.ToInt32(Console.ReadLine());
            int sum2 = 0; //存储所有女生的颜值分数
            int i = 1;
            while (i<=count) 
            {
                Console.WriteLine("第{0}个女生的颜值分数：",i); //接收用户的输入
                int mark = Convert.ToInt32(Console.ReadLine()); //转换用户的输入类型
                sum2 += mark; //累加女生的颜值分数
                i++;
            }
            Console.WriteLine("班上{0}个女生的颜值总分是{1}，平均分数是{2}",count,sum2,sum2/count);
            Console.ReadKey();

            //作业复习 1+2+..+100的和
            //循环体 累加数字的过程
            //循环条件是 数字是1到100
            int b = 1;
            int sum3 = 0; //存放累加的数字
            while(b<=100)
            {
                sum3 += b;
                b++;
            }
            Console.WriteLine(sum3);
            Console.ReadKey();
        }
    }
}
