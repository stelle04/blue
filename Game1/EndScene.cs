using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    internal class EndScene :StarOrEndSceneBasic
    {
        public EndScene()
        {
            title = "Game Over";
            select = "回到开始界面";
        }
        //结束场景切换到开始场景
        public override void ChangeScene()
        {//清除上一个场景的画面
            Console.Clear();
           
            Game.nowScene = new StarScene();
            
        }
    }
}
