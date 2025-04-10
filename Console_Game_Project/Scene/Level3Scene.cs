using Console_Game_Project.Enemy;
using Console_Game_Project.GameObject;
using Console_Game_Project.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Console_Game_Project.Scene
{
    public class Level3Scene : MainScene
    {
        public Level3Scene()
        {
            name = "Level3";
            drawMap = new string[]
            {
                "#####################################",
                "#   #   #                           #",
                "#   #   #  #####  ###  #########    #",
                "#   #####  ##  #  ###  ##      #    #",
                "#              #  ###  ##      #    #",
                "############   #  #    ##############",
                "############   #  #    ########     #",
                "#              #  ##  ###           #",
                "################  #######           #",
                "#                 #                 #",
                "#  ################    ##           #",
                "#                      ##           #",
                "#####################################"
            };

            map = new bool[13, 37];
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
            gameObjects.Add(new Potal("Level2", '2', new Vector2(1,1)));
            gameObjects.Add(new Key(new Vector2(21,7)));
            gameObjects.Add(new Key(new Vector2(1,7)));
            gameObjects.Add(new Level1Enemy('E', new Vector2(12,11)));
            gameObjects.Add(new Level1Enemy('E', new Vector2(12,5)));
            gameObjects.Add(new Level1Enemy('E', new Vector2(13,5)));
            gameObjects.Add(new Level1Enemy('E', new Vector2(14,5)));
            gameObjects.Add(new LastPotal("LastScene", 'L', new Vector2(24, 9)));
        }


        public override void Enter()
        {
            if (Game.prevSceneName == "Level2")
            {
                Game.Player.position = new Vector2(1, 1);
            }
            Game.Player.map = map;
        }

        public override void Exit()
        {
        }
    }
}
