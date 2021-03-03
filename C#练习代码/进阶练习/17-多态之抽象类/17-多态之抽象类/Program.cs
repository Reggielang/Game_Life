using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_多态之抽象类
{
    class Program
    {
        static void Main(string[] args)
        {
            //狗会吃饭，阿峰也会吃饭
            Animal an = new Dog();  
            an.Eet(); //虽然这里提示的是父类的方法，但由于父类是抽象类，并被子类方法进行了override重写，所以调用子类的方法
            Console.ReadKey();

            //抽象类中不一定有抽象方法，但抽象方法必须存在于抽象类
            //抽象类不能被实例化，因为抽象类中的抽象方法不存在方法体
            //使用场景！！！： 当父类中的方法不知道如何去实现的时候，可以考虑将父类写成抽象类，将方法写为抽象方法。
        }
    }
}
