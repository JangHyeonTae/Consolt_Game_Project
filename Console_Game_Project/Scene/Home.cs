using Console_Game_Project.Enemy;
using Console_Game_Project.GameObject;
using Console_Game_Project.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Game_Project.Scene
{
    public class Home : MainScene
    {
        public Home()
        {
            name = "Home";
            drawMap = new string[]
            {
                "###################",
                "#      #          #",
                "#    ###          #",
                "####              #",
                "#                 #",
                "######### #########"
            };

            map = new bool[6, 19];
            for (int y = 0; y < map.GetLength(0); y++)
            {
                for (int x = 0; x < map.GetLength(1); x++)
                {
                    map[y, x] = drawMap[y][x] == '#' ? false : true;
                }
            }

            Game.Player.position = new Vector2(1, 1);
            Game.Player.map = map;

            gameObjects = new List<GameManager>();
            gameObjects.Add(new Potal("Level1", '1', new Vector2(9,5),false));
            gameObjects.Add(new Potion(new Vector2(15, 3)));
            gameObjects.Add(new Key(new Vector2(12, 3)));

            gameObjects.Add(new Key(new Vector2(11, 3)));
            gameObjects.Add(new Key(new Vector2(10, 3)));
            //gameObjects.Add(new Level1Enemy( 'E', new Vector2(9, 2)));
            //gameObjects.Add(new Level2Enemy('E', new Vector2(8, 4)));
            //gameObjects.Add(new Hint(new Vector2(8, 2)));
            //gameObjects.Add(new StoreObject('I', new Vector2(2, 2)));

            gameObjects.Add(new Potal("LastScene", 'L', new Vector2(1,2), true));
        }
        

        public override void Enter()
        {
            if (Game.prevSceneName == "Level1")
            {
                Game.Player.position = new Vector2(9, 4);
            }
            Game.Player.map = map;
        }

        public override void Exit()
        {
        }
        
    }
}
