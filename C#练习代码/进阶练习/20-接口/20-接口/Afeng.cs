using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_接口
{
    class Afeng : Player, IGameMaker
    {
        //当一个类继承了一个接口，就必须实现该接口的所有成员

        
        public void GameMark()
        {
            Console.WriteLine("我也会做游戏");
        }
    }
}
