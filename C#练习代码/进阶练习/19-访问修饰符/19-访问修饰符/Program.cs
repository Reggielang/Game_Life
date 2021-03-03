using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Name;
namespace _19_访问修饰符
{
    //默认internal访问权限，如果想要别的项目使用这个类，在上面加入using namespace！
    class Program
    {
        static void Main(string[] args)
        {
            //访问修饰符
            //public 公开的
            //private 私有的 只能在当前类的内部使用
            //protected 受保护的 只能在当前类的内部以及该类的子类中访问
            //internal 只能在当前项目中访问 在同一个项目中和public权限相同
            //protected internal; protected+internal

            //注意！修饰类的访问修饰符只有两个 public internal
            NumberOne one = new NumberOne();
        }
    }
}
