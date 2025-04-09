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

            gameObjects.Add(new MoneyObject('M', new Vector2(8, 1)));
            gameObjects.Add(new MoneyObject('M', new Vector2(8, 2)));
            gameObjects.Add(new MoneyObject('M', new Vector2(8, 3)));
            gameObjects.Add(new MoneyObject('M', new Vector2(8, 4)));

            gameObjects.Add(new MoneyObject('M', new Vector2(9, 1)));
            gameObjects.Add(new MoneyObject('M', new Vector2(9, 2)));
            gameObjects.Add(new MoneyObject('M', new Vector2(9, 3)));
            gameObjects.Add(new MoneyObject('M', new Vector2(9, 4)));

            gameObjects.Add(new MoneyObject('M', new Vector2(10, 1)));
            gameObjects.Add(new MoneyObject('M', new Vector2(10, 3)));
            gameObjects.Add(new MoneyObject('M', new Vector2(10, 4)));

            gameObjects.Add(new MoneyObject('M', new Vector2(11, 1)));
            gameObjects.Add(new MoneyObject('M', new Vector2(11, 2)));
            gameObjects.Add(new MoneyObject('M', new Vector2(11, 3)));
            gameObjects.Add(new MoneyObject('M', new Vector2(11, 4)));

            gameObjects.Add(new MoneyObject('M', new Vector2(12, 1)));
            gameObjects.Add(new MoneyObject('M', new Vector2(12, 2)));
            gameObjects.Add(new MoneyObject('M', new Vector2(12, 3)));
            gameObjects.Add(new MoneyObject('M', new Vector2(12, 4)));

            gameObjects.Add(new MoneyObject('M', new Vector2(13, 1)));
            gameObjects.Add(new MoneyObject('M', new Vector2(13, 2)));
            gameObjects.Add(new MoneyObject('M', new Vector2(13, 3)));
            gameObjects.Add(new MoneyObject('M', new Vector2(13, 4)));

            gameObjects.Add(new MoneyObject('M', new Vector2(14, 1)));
            gameObjects.Add(new MoneyObject('M', new Vector2(14, 2)));
            gameObjects.Add(new MoneyObject('M', new Vector2(14, 3)));
            gameObjects.Add(new MoneyObject('M', new Vector2(14, 4)));

            gameObjects.Add(new MoneyObject('M', new Vector2(15, 1)));
            gameObjects.Add(new MoneyObject('M', new Vector2(15, 2)));
            gameObjects.Add(new MoneyObject('M', new Vector2(15, 3)));
            gameObjects.Add(new MoneyObject('M', new Vector2(15, 4)));
        }


        public override void Enter()
        {
            if (Game.prevSceneName == "Level1")
            {
                Game.Player.position = new Vector2(2, 1);
            }
            else if(Game.prevSceneName == "Level3")
            {
                Game.Player.position = new Vector2(16, 2);
            }
            Game.Player.map = map;
        }

        public override void Exit()
        {
        }
    }
}
