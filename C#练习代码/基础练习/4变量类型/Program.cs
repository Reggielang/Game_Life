using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04变量类型
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 10;
            float numberOne = 0.125f;
            double numberTwo = 0.123456789;
            string name = "奥特曼";
            char gender = '男';
            Console.WriteLine("name:{0},gender:{1},身高:{2},收入:{3}，地址:{4}",name,gender,numberOne,numberTwo,number);
            Console.WriteLine("我的名字是"+name+"我的性别是"+gender+"我的身高是"+numberOne+"我的收入"+numberTwo+"我的地址"+number);
            Console.ReadKey();

        }
    }
}
