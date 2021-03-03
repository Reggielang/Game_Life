using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_接口
{
    interface IGameMaker
    {
        //接口中的方法可以有返回值
        //接口中的成员不能有修饰符，因为自带了一个修饰符public
        //接口中方法不允许有方法体的方法
        //接口中不能有字段
        //接口中可以用自动属性，自动属性会自动添加字段
        //接口中本质上只能有方法
         void GameMark();
        //string _gender //自动属性
        //{
        //    get;
        //    set;
        //}
        //接口使用interface关键字，没有class， 接口名一般以I开头进行书写

    }
}
