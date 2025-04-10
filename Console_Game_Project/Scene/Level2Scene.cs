using Console_Game_Project.GameObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Game_Project.Scene
{
    public class Level2Scene : MainScene
    {
        public Level2Scene()
        {
            name = "Level2";
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
            gameObjects.Add(new Potal("Level1", '1', new Vector2(1,1)));
            gameObjects.Add(new Potal("Level3", '3', new Vector2(10,2)));

            for (int i = 1; i < map.GetLength(0) - 1; i++)
            {
                for (int j = 5; j < 10; j++)
                {
                    gameObjects.Add(new MoneyObject('M', new Vector2(j,i)));
                }

                for (int j = 11; j < 16; j++)
                {
                    gameObjects.Add(new MoneyObject('M', new Vector2(j,i)));
                }
            }

            gameObjects.Add(new MoneyObject('M', new Vector2(10, 1)));
            gameObjects.Add(new MoneyObject('M', new Vector2(10, 3)));
            gameObjects.Add(new MoneyObject('M', new Vector2(10, 4)));

        }


        public override void Enter()
        {
            if (Game.prevSceneName == "Level1")
            {
                Game.Player.position = new Vector2(1, 1);
            }
            else if(Game.prevSceneName == "Level3")
            {
                Game.Player.position = new Vector2(10, 2);
            }
            Game.Player.map = map;
        }

        public override void Exit()
        {
        }
    }
}
