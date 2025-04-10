using Console_Game_Project.Enemy;
using Console_Game_Project.GameObject;
using Console_Game_Project.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Console_Game_Project.Scene
{
    public class Level1Scene : MainScene
    {
        Random rand = new Random();

        public Level1Scene()
        {
            name = "Level1";
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
            gameObjects.Add(new Potal("Level2", '2', new Vector2(17, 1)));
            gameObjects.Add(new Potal("Home", 'H', new Vector2(1,1)));
            for (int y = 1; y < map.GetLength(0)-3; y++)
            {
                for(int x =3; x < map.GetLength(1)-2; x++)
                gameObjects.Add(new Level1Enemy('E', new Vector2(x,y)));
            }

            Random rand = new Random();

            for (int y = 1; y < map.GetLength(0) - 3; y++)
            {
                for (int x = 4; x < map.GetLength(1) - 2; x++)
                {
                    int num1 = rand.Next(0, 3);
                    if (num1 == 0)
                    {
                        gameObjects.Add(new Potion(new Vector2(x,y)));
                    }
                    else if(num1 == 1)
                    {
                        gameObjects.Add(new Pass(new Vector2(x,y)));
                    }
                    else
                    {
                        gameObjects.Add(new Hint(new Vector2(x,y)));
                    }
                }
                    
            }


            //gameObjects.Add(new RandomEnemy('E',new Vector2(rand.Next(1, Game.Player.map.GetLength(0)),0)));
        }


        public override void Enter()
        {
            if(Game.prevSceneName == "Home")
            {
                Game.Player.position = new Vector2(2,1);
            }
            else if(Game.prevSceneName == "Level2")
            {
                Game.Player.position = new Vector2(17, 1);
            }
            Game.Player.map = map;
        }

        public override void Exit()
        {
        }
    }

}
