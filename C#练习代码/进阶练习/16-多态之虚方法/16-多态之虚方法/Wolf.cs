using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_多态之虚方法
{
    class Wolf:Test
    {
        public Wolf(string voice)
            : base(voice)
        {

        }
        public override void Jiao()
        {
            Console.WriteLine("狼{0}叫", this.Voice);
        }
    }
}
