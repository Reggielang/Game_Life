using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_多态之虚方法
{
    class Program
    {
        static void Main(string[] args)
        {
            //new 1.创建对象 2.隐藏从父类那里继承过来的同名成员，隐藏的后果就是子类用不到父类的成员。
            //Chinese ch = new Chinese("阿峰");
            //ch.SayHi();
            //Console.ReadKey();

            //面向对象开发三大特性： 封装，继承，多态
            //在继承关系的前提下，实例化出不同的对象，这些对象调用相同的方法，但是却表现不同的行为，这是多态
            //在C#中体现多态的三种方式： 虚方法，抽象类，接口
            //Chinese ch = new Chinese("阿峰");
            //Japan jan = new Japan("新恒结衣");
            //English en = new English("特朗普");

            //Person[] per = { ch, jan, en };
            //for (int i = 0; i < per.Length; i++)
            //{
            //    //per[i].SayHi();

            //    //判断能否转换成子类对象，然后调用子类的方法
            //    //if (per[i] is Chinese)
            //    //{
            //    //    ((Chinese)per[i]).SayHi();
            //    //}
            //    //else if (per[i] is Japan)
            //    //{
            //    //    ((Japan)per[i]).SayHi();
            //    //}
            //    //else if (per[i] is English)
            //    //{
            //    //    ((English)per[i]).SayHi();
            //    //}
            //    //虚方法：父类方法中加入virtual关键字，子类方法加入override
            //    per[i].SayHi();
            //}
            //Console.ReadKey();

            //练习 狼嗷嗷叫，狗汪汪叫，泰迪啊啊叫。
            Dog d = new Dog("汪汪");
            Wolf w = new Wolf("嗷嗷");
            Taidi t = new Taidi("啊啊");

            //先创建一个父类的数组，把子类对象赋值进去
            //里氏转换，子类对象存入父类里，父类只能调用自己的方法
            Test[] list = { d, w, t };

            //原本循环输出的都是父类的方法
            //for (int i = 0; i < list.Length; i++)
            //{
            //    list[i].Jiao();
            //}
            //Console.ReadKey();

            //在父类方法中加入virtual关键字，子类方法加入override
            for (int i = 0; i < list.Length; i++)
            {
                list[i].Jiao();
            }
            Console.ReadKey();
        }
    }
}
