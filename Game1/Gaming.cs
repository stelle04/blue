using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    internal class Gaming : I_UpDate
    {

        public void UpDate()
        {
            //首先绘制地图（墙体） 用数组装 静态数组  用一个静态类来存储游戏数据
            DrawWall();

            //绘制食物
            GameDate.food.Draw();
            //检测食物碰撞
           

            //更新游戏坐标 检查游戏结束的条件->Game Over
            SnakeMove();
            //画蛇()
            DrawSnake();
            GameDate.food.Crush();
            Score();
           
           

        }
        void DrawWall()
        {
            //循环调用所有墙体的Draw方法  
            for (int i = 0; i < GameDate.wall.Length; i++)
            {
                //调用墙体绘制的方法
                GameDate.wall[i].Draw();
            }
        }
        //绘制蛇
        void DrawSnake()
        {
            for (int i = 0; i < GameDate.counts; i++)
            {
                GameDate.snakes[i].Draw();

            }


        }
        //蛇的移动
        void SnakeMove()
        {
            //解决拖尾问题
            Console.SetCursorPosition(GameDate.snakes[GameDate.counts - 1].x, GameDate.snakes[GameDate.counts-1].y);
            Console.WriteLine("  ");
            //蛇身体移动,蛇前一届的坐标赋值给后一节实现移动
            for (int i = GameDate.counts - 1; i > 0; i--)
            {
                GameDate.snakes[i].x = GameDate.snakes[i - 1].x;
                GameDate.snakes[i].y = GameDate.snakes[i - 1].y;
            }
           


                //蛇身体是先动的
                switch (GameDate.dir)
                {
                    case Direction.up:
                        GameDate.snakes[0].y--;
                        break;
                    case Direction.down:
                        GameDate.snakes[0].y++;
                        break;
                    case Direction.left:
                        GameDate.snakes[0].x--;
                        break;
                    case Direction.right:
                        GameDate.snakes[0].x++;
                        break;


                }
            BreakGame();
            GetInput();
            }
      
        void GetInput()
            //用来接收输入改变蛇的移动方向
        {
            if(Console.KeyAvailable)//避免因为等待用户输入而卡死
           { switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.W:
                        if (GameDate.dir == Direction.down) break;
                        GameDate.dir = Direction.up;
                        break;
                    case ConsoleKey.A:
                        if (GameDate.dir == Direction.right) break;
                        GameDate.dir = Direction.left;
                        break;
                    case ConsoleKey.S:
                        if (GameDate.dir == Direction.up) break;
                        GameDate.dir = Direction.down;
                        break;
                    case ConsoleKey.D:
                        if (GameDate.dir == Direction.left) break;
                        GameDate.dir = Direction.right;
                        break;
                }
            }
        }
        
        void BreakGame()//检测结束条件
        {//撞墙
            if (GameDate.snakes[0].x >= 80 || GameDate.snakes[0].x<=0)
            {
                ChangeScene();

            }
            else if (GameDate.snakes[0].y >= 20 || GameDate.snakes[0].y<=0)
            {
                ChangeScene();
            }
            //蛇自撞
            if(GameDate.counts>1)
            {for (int i = 1; i < GameDate.counts; i++)
                {
                    if (GameDate.snakes[0] == GameDate.snakes[i])
                    {
                        ChangeScene();
                    }
                }
            }

        }
    void ChangeScene()
        {
            //打扫战场
            Console.Clear();
            //切换游戏场景
            Game.nowScene = new EndScene();
        }
        void Score()
        {
            Console.SetCursorPosition(30, 25);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("您的得分为" + (GameDate.counts-1));
        }
    
    }





    //检测游戏结束条件
      

        
    }


