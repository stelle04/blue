﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    internal class SnakeBody : GameObject
    {

        public override void Draw()
        {
            Console.SetCursorPosition(this.x, this.y);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("⭐");

        }
    }
}
