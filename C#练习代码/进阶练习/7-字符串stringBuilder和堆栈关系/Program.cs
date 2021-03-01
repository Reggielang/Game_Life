using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_字符串stringBuilder和堆栈关系
{
    class Program
    {
        static void Main(string[] args)
        {
            //堆栈关系就比如手机的运行内存和内存的区别
            //堆栈区别
            //值类型的值是存储在内存的栈当中 例如 int double bool char struct enum
            //引用类型的值存储在内存的堆当中 例如 string 数组 
            //string 的值存储到了堆当中，但是它会分配一个引用地址存储到栈当中，然后变量名通过访问栈中的地址去匹配string的值。
            //然后重新赋值之后为又开辟一个空间存储新的值，但栈中新地址会覆盖旧地址。 然后堆当中就会存在只有旧值但没有指向的垃圾空间。

            //当程序结束之后，GC会扫描内存，如果发现有的空间没有被指向，则立即将它销毁。

            //StringBuilder的强大！！！
            //它一直在操作同一块内存空间，不会产生垃圾数据，且执行效率远远高于string类型的字符串变量
            StringBuilder sb = new StringBuilder();
            string a = null;
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < 100000; i++)
            {
                //a += i; //需要开辟很多空间来存储i的值，然后不断的使用新的地址
                sb.Append(i); //没有在内存的堆中持续的开辟空间，一直在一个空间进行反复的追加操作
            }
            sw.Stop();
            Console.WriteLine(sb.ToString());
            Console.WriteLine(sw.Elapsed);
            Console.ReadKey();

            // StringBuilder的使用方法
            //StringBuilder sb = new StringBuilder();  //创建一个对象
            //往sb追加数据 sb.Append();
            //将sb转化为字符串类型 sb.ToString();

            //sb.Clear() 将sb清空

            //StringBuilder的效率测试
            // Stopwatch sw = new Stopwatch(); 
            // sw.Start();  开始计时
            //sw.Stop();  结束计时
            //sw.Elapsed;  时长

            //练习
            //StringBuilder sb = new StringBuilder();
            //Stopwatch sw = new Stopwatch();
            //string b = null;
            //sw.Start();
            //for (int i = 0; i < 100000; i++)
            //{
            //    //b = b += i;
            //    sb.Append(i);
            //}
            //sw.Stop();
            //Console.WriteLine(sw.Elapsed);
            //Console.ReadKey();
        }
    }
}
