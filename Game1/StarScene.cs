using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    internal class StarScene:StarOrEndSceneBasic
    {
        public StarScene()
        {
            title = "贪吃蛇游戏";
            select = "开始游戏";
        }
        public  override void ChangeScene()
        {
            //在切换场景之前要清除当前的游戏画面
            Console.Clear();
            GameDate.counts = 0;
            //进入游戏场景之前 把上一局的分数清零,生成一个蛇头
            GameDate.snakes[0] = new SnakeHead();
            GameDate.counts++;
            //切换游戏场景 
            Game.nowScene = new Gaming();
            
        }
    }
}
