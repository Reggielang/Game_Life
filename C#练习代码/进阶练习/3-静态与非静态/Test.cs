using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_静态与非静态
{
    //static class Test
    //静态类中只允许有静态成员，不允许出现实例成员
    //静态类一般都是当作“工具类”来使用
    class Test
    {
        public static int _age; //静态字段
        public int _number;//非静态字段

        public static void Age()
        {
            //静态函数中，只能访问静态成员，不允许访问实例成员
            _age = 18;

        }

        public void Number()
        {
            //实例函数中，可以使用静态成员，也可以使用实例成员
            _age = 18;
            _number = 18;
        }
    }

}
