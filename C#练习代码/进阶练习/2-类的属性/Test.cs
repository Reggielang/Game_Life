using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_类的属性
{
    class Test
    {
        public string _name;
        private string _module;
        private double _mark;

        public string Module
        {
            get
            {
                if (_module!="C#")
                {
                    _module = "就算不是C#，也必须是C#";
                }
                return _module; //进行了一个判断，return返回最后的值
            }
            set { _module = value; } //上面获得的属性值，赋值给字段
        }


        public double Mark {
            get
            {
                return _mark;
            }
            set
            {
                if (value > 80)
                {
                  value = 99.9999; //只要_mark 都返回99.9999
                }
                _mark = value; //上面进行了判断，需要用字段来接受value的值
            }
        }

        public void Getmark()
        {
            Console.WriteLine("名字是{0}，学习了{1}，获得了分数{2}", _name, Module, Mark);
        }
    }
    
}
