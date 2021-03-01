using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19枚举类型
{
    //枚举 用于规范开发，用什么值从里面取,放在命名空间下，以便于不同的类访问。通常都是提前定义好的，在项目中公共使用的数据。
    public enum Gender 
    {
        男,
        女
    }
    class Program
    {
        static void Main(string[] args)
        {
            Gender gender = Gender.男;
            Gender gender1 = Gender.女;
        }
    }
}
