using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_显示实现接口
{
    class Program
    {
        static void Main(string[] args)
        {
            Isay s = new Afeng();
            s.Say();

            Afeng s1 = new Afeng();
            s1.Say();
            Console.ReadKey();
        }
    }
}
