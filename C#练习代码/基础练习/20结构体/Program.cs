using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20结构体
{
    //结构体 用于一次性声明多个不同类型的变量
    public struct Student //！帕斯卡命名法，首字符大写
    {
        public string _name; //!字段命名注意前面加入下划线。
        public Gender _gender;
        public int _age;
    }
    public struct Teacher 
    {
        public string _name;
        public Gender _gender;
        public int _age;
    }
    public enum Gender 
    {
        男,
        女
    }

    class Program
    {
        static void Main(string[] args)
        {
            //学生管理系统，名字，性别，年龄。
            //char gender = '男';
            //string name = "是阿";
            //int age = 18;
            Student person;
            person._name = "阿帅";
            person._gender =Gender.男;
            person._age = 18;

            Student person2;
            person2._name = "阿春";
            person2._gender = Gender.女;
            person2._age = 19;

            Teacher teacher;
            teacher._name = "奥特曼";
            teacher._gender = Gender.女;
            teacher._age = 22;

            Console.WriteLine("这是我的朋友{0},{1},他们的老师都是{2}",person._name,person2._name,teacher._name);
            Console.ReadKey();


        }
    }
}
