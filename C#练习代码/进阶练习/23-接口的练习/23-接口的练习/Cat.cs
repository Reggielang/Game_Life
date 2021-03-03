using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_接口的练习
{
    class Cat:ISay
    {
        public void Say()
        {
            Console.WriteLine("猫会叫");
        }
    }
}
