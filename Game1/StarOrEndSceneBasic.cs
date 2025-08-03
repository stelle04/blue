using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    //开始场景和结束场景的父类
   abstract internal class StarOrEndSceneBasic: I_UpDate
    {
        //标题 贪吃蛇游戏  Game Over
        //选项一 开始游戏  回到开始场景
        //选项二 退出游戏  退出游戏    两个场景是一样的
        protected string title; //标题
        protected string select; //选项一
        //实现选项的选中
        //1 声明一个bool（适用于两个选项）
        //2 声明一个int 类型的索引 代表你当前选中的索引
        int index = 0;



        public void UpDate()
        {
            //开始绘制
            //1.确定光标位置 2.设置文本颜色 3.直接打印

            //标题  地图的大小（80,20)
            Console.SetCursorPosition(Console.WindowWidth/2-title.Length,5);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(title);

            //选项一
            Console.SetCursorPosition(Console.WindowWidth / 2 - title.Length, 8);
            Console.ForegroundColor = index == 0 ? ConsoleColor.Red : ConsoleColor.White;
            Console.Write(select);

            //退出游戏
            Console.SetCursorPosition(Console.WindowWidth / 2 - title.Length, 11);
            Console.ForegroundColor = index == 1 ? ConsoleColor.Red : ConsoleColor.White;
            Console.Write("退出游戏");

            //接受用户的输入
            GetKey(Console.ReadKey(true).Key);

        }
       public     void GetKey(ConsoleKey k)
        {
            switch (k)
            {
                case ConsoleKey.W:
                    index=index == 0 ? index : 0;
                    break;
                case ConsoleKey.S:
                    index = index == 1 ? index : 1;
                    break;
                case ConsoleKey.J:
                    //如果说index=0那就执行切换场景的方法
                    //如果index=1那就退出游戏
                    if (index == 0)
                    {
                        ChangeScene();
                        
                    }
                    else
                    {
                        //退出游戏
                        Environment.Exit(0);
                    }
                        break;

            }

        }
        public abstract void ChangeScene();



    }
}
