using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 面向对象
{
    //有点像结构体 把struct 换成了class
    public class Man 
    {
        public string _name; //字段声明，前面加入下划线
        public int _age;
        public char _gender;

        public void Hobby()
        {
            Console.WriteLine("我的名字是{0}，我的年龄是{1}，我的性别是{2},爱好，看看电视！",_name,_age,_gender);
        }
    }
}
