using Console_Game_Project.GameObject;
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
                "###################",
                "#                 #",
                "#                 #",
                "#                 #",
                "#                 #",
                "###################"
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
            gameObjects.Add(new Potal("Level2", '2', new Vector2(1, 1)));
            gameObjects.Add(new Potal("LastScene", 'L', new Vector2(17, 4)));
        }


        public override void Enter()
        {
            if (Game.prevSceneName == "Level2")
            {
                Game.Player.position = new Vector2(2, 1);
            }
            else if (Game.prevSceneName == "Level4")
            {
                Game.Player.position = new Vector2(16, 2);
            }
            else if (Game.prevSceneName == "Quiz1")
            {
                Game.Player.position = new Vector2(1,2);
            }
            Game.Player.map = map;
        }

        public override void Exit()
        {
        }
    }
}
