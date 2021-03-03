using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_多态之抽象类
{
    class Feng:Animal
    {
        public override void Eet()
        {
            Console.WriteLine("阿峰也会吃饭");
        }
    }
}
