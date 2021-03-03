using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_抽象类练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //使用多态求矩形的面积和周长以及圆形的面积和周长
            //如果想求矩形面积，直接实例化子类矩形就可以了，这提高了代码的复用性
            Shape sh = new Square(5,6);//new Circle(6);
            double area = sh.Area();
            double c = sh.C();
            Console.WriteLine("这个形状的面积是{0}，周长是{1}",area,c);
            Console.ReadKey();

        }
    }
}
