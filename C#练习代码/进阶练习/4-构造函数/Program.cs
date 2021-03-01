using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_构造函数
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 创建对象的时候会执行构造函数
            Man person = new Man("A",18,'男');
            //person.Name = "A";
            //person.Age = 18;
            //person.Gender = '男';
            person.Say();
            Console.ReadKey();

            Man person2 = new Man("B",19,'女');
            //person2.Name = "B";
            //person2.Age = 19;
            //person2.Gender = '女';
            person2.Say();
            Console.ReadKey();

           //2 构造函数可以重载
            Man person3 = new Man("C", 19);
            //person2.Name = "B";
            //person2.Age = 19;
            //person2.Gender = '女';
            person2.Say();
            Console.ReadKey();

            //3 类当中会创建一个默认的无参数的构造函数，当写一个新的构造函数，不管有参还是无参，默认的构造函数都会消失
        }
    }
}
