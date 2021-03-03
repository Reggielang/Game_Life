using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_接口的特点
{
    //接口可以继承接口，并且接口可以多继承！
    //接口不能继承类
    interface ISpeak:ISleep,IEat
    {
        void Speak();
    }
}
