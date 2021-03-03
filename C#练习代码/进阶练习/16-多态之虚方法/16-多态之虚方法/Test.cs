using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_多态之虚方法
{
    class Test
    {
        public Test(string voice)
        {
            this.Voice = voice;
        }
        private string _voice;
        public string Voice
        {
            get { return _voice; }
            set { _voice = value; }
        }
        public virtual void Jiao()
        {
            Console.WriteLine("我是TEST父类");
        }
    }
}
