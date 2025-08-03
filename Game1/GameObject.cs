using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    abstract internal class GameObject
    {
        //墙体 蛇 食物 有坐标x,y 经常用碰撞检测
        public int x;
        public int y;

        //碰撞检测
        //写一个方法里面传入两个物体的坐标。比较两者的坐标返回bool类型
        //另一种方法是重写赋值运算符  ==   对象==对象 operator
       static public bool operator==(GameObject o1,GameObject o2)
        {
            if (o1.x == o2.x && o1.y == o2.y) return true;
            return false;
        }
       static  public bool operator !=(GameObject o1, GameObject o2)
        {
            if (o1.x == o2.x && o1.y == o2.y) return false;
                return true;
        }
        //游戏物体  用一个方法来画自己
        public abstract void Draw();




    }

}
