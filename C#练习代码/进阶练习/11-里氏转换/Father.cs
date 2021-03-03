using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_里氏转换
{
    class Father
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public void Fatersayhi()
        {
            Console.WriteLine("我是父亲类");
        }
    }
}
