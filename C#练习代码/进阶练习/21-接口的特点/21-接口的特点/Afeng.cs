using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_接口的特点
{
    //但一个类继承了类和接口，类必须在接口前面
    class Afeng : Person,ISpeak
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void Sleep()
        {
            throw new NotImplementedException();
        }

        public void Speak()
        {
            Console.WriteLine("我会说话");
        }
    }
}
