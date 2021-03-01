using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_类的属性
{
    class Program
    {
        //访问修饰符
        //public 公共的，谁都可以访问
        //private 私有的， 通过对象名.xxx 的形式访问不到。 只能在当前类中访问

        //属性的作用是对字段进行保护，将属性设为public，可以直接访问，然后属性保护的字段设置为private
        //可以通过属性间接的操作字段 
        //属性语法
        // public 数据类型 属性名
        //{
        //get {return 字段名;}
        //set {字段名=value;}
        //}
        //数据类型和要保护的字段名一样
        //属性名 和字段名一样，但首字符要大写
        //get 当通过属性名取值的时候， 会自动调用get中的代码
        //set 当通过属性名给字段赋值的时候，会自动调用set中的代码
        //value 代表赋给属性的值
        // get和set本质上就是两个函数
        //快捷键 CTRL+R+E
        static void Main(string[] args)
        {
            Man person = new Man(); //实例化出来一个叫person的对象
            person.Name = "大司马";
            person.Gender = 'r';
            person.Age = -18;
            person.Hobby(); //对象名.方法名 调用了Man类的一个方法
            Console.ReadKey();

            //练习
            Test student = new Test();
            student._name = "奥特曼";
            student.Module = "C";
            student.Mark = 81;
            student.Getmark();
            Console.ReadKey();
        }
    }
}
