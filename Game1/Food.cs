using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    internal class Food : GameObject
    {
        public Food()
        {
            x = 30;
            y = 5;

            //GetNewPosition();
        }
        void GetNewPosition()
        {
            //x坐标的范围1-79
            GameDate.food.x= GameDate.r.Next(1,78);
            //y坐标的范围是1-19
            GameDate.food.y = GameDate.r.Next(1, 20);
            //食物的位置不能和蛇的坐标重复 
            for (int i=0;i<GameDate.counts;i++)
            {
                //如果食物的位置和蛇的重复了,那么递归自己
                if (GameDate.food == GameDate.snakes[i]) GetNewPosition();
            }
        }
        //画食物
        public override void Draw()
        {
            Console.SetCursorPosition(GameDate.food.x,GameDate.food.y);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("⭐");
            
        }
        //检测碰撞
        public void Crush()
        {
            if (GameDate.snakes[0]==GameDate.food)
            {
                //如果吃到食物就长一节身体
                
                GameDate.snakes[GameDate.counts] = new SnakeBody();
               
                GameDate.snakes[GameDate.counts].x = GameDate.snakes[GameDate.counts - 1].x;
                GameDate.snakes[GameDate.counts].y = GameDate.snakes[GameDate.counts - 1].y;
                GameDate.counts++;
                //吃完以后随机赋予自己坐标
                GetNewPosition();
            }
        }
    }
}
