using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_继承练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //继承练习
            //我叫阿峰，我的年龄23，我的爱好是看电视，我的工作是搬砖。
            //我叫阿花，我的年龄21，我的爱好是玩游戏，我的工作内容是：打游戏。
            //我叫阿波，我的年龄28，我的爱好是睡觉，我的口头禅是：吃了么？
            //我叫阿水，我的年龄是33，我的爱好是上班，我的身高是180.
            Persontwo b = new Persontwo("阿峰",23,"看电视","搬砖"); //传入参数
            b.Sayhello(); //调用方法
            Personthr c = new Personthr("阿花", 21, "玩游戏", "打游戏");
            c.SayHi();
            Personfour d = new Personfour("阿波", 28, "睡觉", "吃了么？");
            d.Sayfour();
            Personfive e = new Personfive("阿水", 33, "上班", 180);
            e.Sayfive();
            Console.ReadKey();

        }
    }
}
