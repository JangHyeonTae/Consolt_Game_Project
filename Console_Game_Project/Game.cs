using Console_Game_Project.Quiz;
using Console_Game_Project.Scene;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Game_Project
{
    public class Game
    {
        private static Dictionary<string,SceneManager> sceneDic;
        private static SceneManager curScene;
        public static string prevSceneName;

        private static Player player;
        public static Player Player { get { return player; } }

        private static bool gameOver;
        public static void Run()
        {
            Start();

            while (!gameOver)
            {
                Console.Clear();
                curScene.Render();
                curScene.Input();
                Console.WriteLine();
                curScene.Update();
                Console.WriteLine();
                curScene.Result();
            }

            End();
        }

        public static void ChangeScene(string sceneName)
        {
            prevSceneName = curScene.name;

            curScene.Exit();
            curScene = sceneDic[sceneName];
            curScene.Enter();
        }

        public static void Start()
        {
            Console.CursorVisible = false;

            gameOver = false;

            player = new Player();

            sceneDic = new Dictionary<string, SceneManager>();

            sceneDic.Add("Title", new TitleScene());
            sceneDic.Add("HomeTown", new HomeTown());
            sceneDic.Add("Home", new Home());
            sceneDic.Add("Level1", new Level1Scene());
            sceneDic.Add("Level2", new Level2Scene());
            sceneDic.Add("Level3", new Level3Scene());


            curScene = sceneDic["Title"];
        }
        public static void GameOver(string reason)
        {
            Console.Clear();
            Console.WriteLine("********************************");
            Console.WriteLine("*         GAME OVER            *");
            Console.WriteLine("********************************");
            Console.WriteLine();
            Console.WriteLine(reason);

            gameOver = true;
        }
        public static void End()
        {

        }
    }
}
