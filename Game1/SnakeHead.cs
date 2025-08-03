using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    //用来表示蛇头前进的方向
   public enum Direction
    {
        up,down,left,right,nodirection
    }
    internal class SnakeHead:GameObject
    {
        //蛇头方向，默认没有方向
        public Direction direction = Direction.nodirection;
        public SnakeHead()
        {
            x = 40;
            y = 10;
            
        }
        //蛇头要有前进的方向
        public override void Draw()
        {
            Console.SetCursorPosition(this.x, this.y);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("⭐");


        }
    }
}
