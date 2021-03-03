using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_多态之虚方法
{
    class Taidi:Test
    {
        public Taidi(string voice)
            : base(voice)
        {

        }
        public override void Jiao()
        {
            Console.WriteLine("泰迪{0}叫",this.Voice);
        }
    }
}
