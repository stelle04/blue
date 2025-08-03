using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    
    static internal class GameDate
    {
        //这个数组装的是地图墙壁
        public static Wall[] wall = new Wall[200];//里面的成员是Null,初始化地图数据
        //蛇的数组
        public static GameObject[] snakes = new GameObject[120];
        //一个静态的食物
        public static Food food = new Food();
        //一个int类型的计数器 
        public static int counts = 0;
        public static Random r = new Random();
        //表示蛇头前进的方向
        public static Direction dir = Direction.left;


    }
}
