using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_接口的特点
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.接口和抽象类一样不能被实例化
            ISpeak sp = new Afeng();
            sp.Speak();
            Console.ReadKey();
        }
    }
}
