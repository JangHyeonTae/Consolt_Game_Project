using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Game_Project.Scene
{
    public class MainScene : SceneManager
    {
        private ConsoleKey input;

        protected string[] drawMap;
        protected bool[,] map;

        protected List<GameManager> gameObjects;
        public override void Render()
        {
            //Console.WriteLine($"\t\t\t\t\t지금 위치는 : {name}");
            PrintMap();
            foreach (GameManager a in gameObjects)
            {
                a.PrintGameObject();
            }
            Game.Player.PrintPlayer();

            Console.SetCursorPosition(0, map.GetLength(0) + 2);
            Game.PrintPlayerHP();
        }

        public override void Input()
        {
            input = Console.ReadKey(true).Key;
        }
        public override void Update()
        {
            Game.Player.Move(input);
        }

        public override void Result()
        {
            foreach (GameManager a in gameObjects)
            {
                if (Game.Player.position == a.position)
                {
                    a.Interact(Game.Player);
                    if (a.isOnce == true)
                    {
                        gameObjects.Remove(a);
                    }
                    break;
                }
            }
        }
        

        public void PrintMap()
        {
            Console.SetCursorPosition(0, 0);
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    if (map[i, j] == true)
                    {
                        Console.Write(' ');
                    }
                    else
                    {
                        Console.Write('#');
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
