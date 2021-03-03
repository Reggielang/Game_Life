using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_多态之虚方法
{
    class English:Person
    {
        public English(string name)
            :base(name)
        {

        }
        public override void SayHi()
        {
            Console.WriteLine("我的名字是{0}，我是英国人",this.Name);
        }
    }
}
