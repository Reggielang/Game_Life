using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_里氏转换
{
    class Ming:Father
    {
        private string _hobby;
        public string Hobby
        {
            get { return _hobby; }
            set { _hobby = value; }
        }

        public void Mingsayhi()
        {
            Console.WriteLine("我是小明");
        }
    }
}
