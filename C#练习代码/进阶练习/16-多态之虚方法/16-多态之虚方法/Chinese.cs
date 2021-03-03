using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_多态之虚方法
{
    class Chinese:Person
    {
        public Chinese(string name) 
            :base(name)
        {

        }
        public override void SayHi()
        {
            Console.WriteLine("我的名字是{0}，我是中国人", this.Name);
        }
    }
}
