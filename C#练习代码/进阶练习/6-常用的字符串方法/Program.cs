using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_常用的字符串方法
{
    class Program
    {
        static void Main(string[] args)
        {
            //将字符串转化成大写/小写
            //Console.WriteLine("请输入一个词语：");
            //string numberOne = Console.ReadLine();
            ////numberOne = numberOne.ToUpper();
            ////numberOne = numberOne.ToLower();
            //Console.WriteLine("请再输入一个词语：");
            //string numberTwo = Console.ReadLine();
            ////numberTwo = numberTwo.ToUpper();
            ////numberTwo = numberTwo.ToLower();

            //Equals比较两个字符串是否相同，返回bool类型的值
            //if (numberOne.Equals(numberTwo, StringComparison.OrdinalIgnoreCase))
            //{
            //    Console.WriteLine("我们都一样");
            //}
            //else
            //{
            //    Console.WriteLine("我们不一样");
            //}
            //Console.ReadKey();

            //split 分割字符串 返回字符串类型的数组
            //string s = "+_a d c de , d ,.f  d "; //string类型可以看作是一个char类型的数组
            //char[] a = { '+', '_', ' ', ',', '.' };
            //string[] b = s.Split(a, StringSplitOptions.RemoveEmptyEntries);
            //Console.WriteLine(b[1]);
            //Console.ReadKey();

            //Substring 截取字符串 返回截取之后的字符串
            //开始截取的位置 包含自己往后截取
            //string i = "今天中午吃什么？";
            //i = i.Substring(2, 5); //第一个2表示从哪里开始截取，第二个表示截取的长度
            //Console.WriteLine(i);
            //Console.ReadKey();

            //Contains 判断字符串中是否包含指定字符
            //Replace 替换当前字符为新的字符
            //string a = "阿峰的手";
            //if (a.Contains("我"))
            //{
            //    a = a.Replace("手", "**");
            //}
            //else
            //{
            //    a = a.Replace("阿峰的手", "真的好丑！");
            //}
            //Console.WriteLine(a);
            //Console.ReadKey();

            //IndexOf 查找某个字符在字符串中第一次出现的位置
            //LastIndexOf 查找某个字符在字符串中最后出现的位置
            //string a = "猜猜我是谁？";
            //int b = a.LastIndexOf("猜");
            //Console.WriteLine(b);
            //Console.ReadKey();

            //StartsWith 判断字符串以特定字符开始或者结尾
            //EndsWith
            //string a = "今天中午吃什么？";
            //bool b = a.EndsWith("什么");
            //Console.WriteLine(b);
            //Console.ReadKey();

            // Trim 去除字符串中的空格 TrimStart/TrimEnd 去除前后空格
            //string a = "            呵呵                   ";
            //a = a.Trim();
            //Console.WriteLine(a);
            //Console.ReadKey();

            //IsNullOrEmpty 判断一个字符串是否为null或者空
            string z = "1";
            if (string.IsNullOrEmpty(z)) //null是不占用空间的，而空字符串（""）是占用内存空间的
            {
                Console.WriteLine("包含空");
            }
            else
            {
                Console.WriteLine("不包含空");
            }
            Console.ReadKey();
            //字符串的特点：字符串是引用类型  字符串是不可变的  字符串可以看作是自读的字符类型
        }
    }
}
