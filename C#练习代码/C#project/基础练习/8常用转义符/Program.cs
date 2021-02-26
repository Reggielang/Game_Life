using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 常用转义符
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("我喜欢\n学习的孩子");
            Console.ReadKey();

            Console.WriteLine("我要出去\"做头发\"");
            Console.ReadKey();

            string name1 = "床前明月光";
            string name2 = "疑是地上霜";
            string name3 = "举头望明月";
            string name4 = "低头思故乡aaaaaaaa";
            Console.WriteLine("{0}\t\t{1}",name1,name2);
            Console.WriteLine("{0}\t{1}", name3, name4);
            Console.ReadKey();

            Console.WriteLine("你看我头像\b帅不帅?");
            Console.ReadKey();

            //@取消反斜杠在字符串中的转义作用，多用于路径
            Console.WriteLine(@"C:\c\a\b\f\g\h");
            Console.ReadKey();

            //@将字符串按照原格式输出
            Console.WriteLine(@"咱们啥时候上
            课啊");
            Console.ReadKey();

            Console.WriteLine("你看我像不像人才\b啊？");
            Console.ReadKey();

            string a = "亲爱的爱上你，从那天起";
            string b = "\t甜蜜的很轻易。";

            Console.WriteLine("{0}\n{1}", a, b);
            Console.ReadKey();

        }
    }
}
