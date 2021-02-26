using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 接受用户的输入
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("请输入你的名字：");
            //string name = Console.ReadLine(); // 存储用户输入到变量name当中
            //Console.WriteLine("你的名字叫{0}啊，太帅了", name);
            //Console.ReadKey();
            //Console.WriteLine("你最喜欢吃的水果：");
            //string fruit = Console.ReadLine();
            //Console.WriteLine("原来你也喜欢吃{0}啊！",fruit);
            //Console.ReadKey();

            //Console.WriteLine("请输入你的年龄：");
            //string age = Console.ReadLine();
            //Console.WriteLine("请输入你的名字：");
            //string name = Console.ReadLine();
            //Console.WriteLine("你的年龄是{0}，你的名字是{1}，经程序验证您是个智障",age,name);
            //Console.ReadKey();

            //测试智商小程序
            Console.WriteLine("请输入你的年龄：");
            string age = Console.ReadLine();
            Console.WriteLine("请输入你的性别：");
            string gender = Console.ReadLine();
            Console.WriteLine("经程序验证，认为你的智商不高！");
            Console.ReadKey();

            //美女搭讪小程序
            Console.WriteLine("美女你好~请输入你的年龄：");
            string age1 = Console.ReadLine();
            Console.WriteLine("然后输入你的身高：");
            string length = Console.ReadLine();
            Console.WriteLine("美女，今天晚上有空一起吃饭么，或者看电影也行~！");
            Console.ReadKey();
        }

    }
}
