using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_接口的练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //用虚方法实现多态 --如果这个父类中的方法知道怎么写并且还需要创建这个父类的对象那就用虚方法
            //用抽象类实现多态 --如果几个类中，能提取一个父类并且父类当中必须写上几个子类共有方法的，但还不知道怎么写这个方法。
            //用接口实现多态 -- 如果几个类中提取不出父类，但是这几个类都有一个共同的行为或者能力，那就用接口实现多态。

            //练习：猫会叫，狗会叫，人会叫。-- 都会叫，一种能力或者行为 --接口来实现
            //想用谁就实例化谁
            ISay say = new Cat();//Dog()
            say.Say();
            Console.ReadKey();

        }
    }
}
