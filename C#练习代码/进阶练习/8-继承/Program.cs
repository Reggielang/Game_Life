using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_继承
{
    class Program
    {
        static void Main(string[] args)
        {
            //将一堆类中共有的“成员”单独提取出来，作为一个父类，然后这一对类继承父类，共享父类的资源
            //继承的特点： 继承的单根性--一个子类只能由一个父类   继承的传递性
            // class 子类:父类
            // 子类继承了父类的属性和方法
            Hashiqi ha = new Hashiqi();
            ha.Name = "哈士奇";
            ha.Age = 18; 
            ha.Eet();

            //不能继承父类的私有字段！只能继承公共字段
            ha._name = "A";


            Dog x = new Dog();
            Wolf y = new Wolf();
        }
    }
}
