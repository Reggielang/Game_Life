using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_显示实现接口
{
    class Afeng:Isay
    {
        public void Say()
        {
            Console.WriteLine("阿峰会说话");
        }

        //显示的调用接口 --解决方法的重名问题
        void Isay.Say()
        {
            Console.WriteLine("我是接口");
        }
    }
}
