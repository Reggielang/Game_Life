using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 面向对象
{
    //具有相似的属性和方法集合就是类
    class Program
    {
        //对象 一个实例化的个体，是类的实例 例如 我的好朋友阿A  阿A就是类，好朋友阿A就是一个对象
        //属性（特征）和方法（行为）是用来描述类的

        //网红是一个类
        //某某网红是一个对象
        //特征：年龄，性别等
        //行为：不P图不拍照

        //[访问修饰符] class 类名 
        //{
        //类的描述信息
        //}
        //访问修饰符 用于描述类的访问权限 可以不写，有默认值
        //class 是关键字
        // 类的描述信息 描述这类食物的特征（字段，属性，方法）
         
        static void Main(string[] args)
        {
            // 实例化对象
            //类名 对象名 = new 类名()
            Man person = new Man(); //实例化出来一个叫person的对象
            person._name = "大司马";
            person._gender = '男';
            person._age = 18;
            person.Hobby(); //对象名.方法名 调用了Man类的一个方法
            Console.ReadKey();
        }
    }
}
