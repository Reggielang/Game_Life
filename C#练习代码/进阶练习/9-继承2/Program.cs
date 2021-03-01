using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_继承2
{
    class Program
    {
        static void Main(string[] args)
        {
            //将一堆类中共有的“成员”单独提取出来，作为一个父类，然后这一对类继承父类，共享父类的资源
            //继承的特点： 继承的单根性--一个子类只能由一个父类   继承的传递性
            // class 子类:父类
            // 子类继承了父类的属性和方法

            //创建子类对象的时候，同时也创建了父类的对象-所以能用父类的属性和方法
            //实例化子类对象的时候会默认调用子类的构造函数，现在通过base调用父类的构造函数
            Hashiqi ha = new Hashiqi(19,'女',"哈士奇",0);
        }
    }
}
