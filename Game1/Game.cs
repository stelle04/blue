using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    //游戏主体
    internal class Game
    {
        //承载游戏场景的容器
       static public  I_UpDate nowScene;
        public Game()
        {
            //第一个场景是开始游戏场景
            nowScene = new StarScene();
            //初始化游戏参数
            //关闭控制台光标
            Console.CursorVisible = false;
            //设置窗口和缓冲区大小  地图实际大小为(80,20）墙体占1个坐标
            Console.SetWindowSize(100, 30);
            Console.SetBufferSize(100, 30);
            //初始化游戏参数 游戏加载的时候把地图坐标传进去
            //给上横行传递坐标参数
            for(int i =0;i<80 ;i++)
            {
                GameDate.wall[i] = new Wall(i,0);
            }
            //给下行传递坐标参数
            for(int i=0; i<80;i++)
            {
                GameDate.wall[80 + i] = new Wall(i, 20);
            }
            //给左边墙壁传递参数
            for(int i=0;i<20;i++)
            {
                GameDate.wall[160 + i] = new Wall(0, i);
            }
            //给右边的墙壁传递参数
            for(int i =0;i<20;i++)
            {
                GameDate.wall[180 + i] = new Wall(80, i);
            }
        }

        
    
        //开始场景 游戏场景 结束场景

       
        //设置游戏帧率 游戏刷新率
        //1 使用线程的方式 通过Thread.sleep();来控制帧数
        //2 把场景放进while -true 循环中 定义int变量
        public void Star()
        {
            Thread th = new Thread(NewThread);
            th.Start();
        }
        public void NewThread()
        {
           while(true)
            {
                //线程每执行一次100ms 0.1s 每秒更新十帧
                Thread.Sleep(100);
                if(nowScene!=null)
                {
                    //根据当前的游戏场景 执行相应的刷新
                    nowScene.UpDate();
                }
            }
        }
    }
}


