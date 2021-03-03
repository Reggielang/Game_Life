using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_多态之抽象类
{
    class Dog:Animal
    {
        //当子类继承了抽象类，可以使用override重写父类里所有的抽象方法
        //用子类重写父类的抽象方法
        public override void Eet()
        {
            Console.WriteLine("狗会吃饭");
        }
    }
}
