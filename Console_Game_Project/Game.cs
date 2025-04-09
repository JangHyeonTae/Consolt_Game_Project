using Console_Game_Project.GameObject;
using Console_Game_Project.Items;
using Console_Game_Project.Quiz;
using Console_Game_Project.Scene;
using System;
using System.Collections;
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

        public static List<QuizClass> list;
        public static Stack<string> stackQuiz;

        public static List<Item> items;
        public static Stack<string> stackStore;

        //private static Store store;
        //public static Store Store {  get { return store; } }

        private static MainQuiz mainQuiz;
        public static MainQuiz MainQuiz { get { return mainQuiz; } }


        private static Store store;
        public static Store Store { get { return store; } }

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
            player.CurHP = 100;

            sceneDic = new Dictionary<string, SceneManager>();
            mainQuiz = new MainQuiz();
            store = new Store();

            sceneDic.Add("Title", new TitleScene());
            sceneDic.Add("HomeTown", new HomeTown());
            sceneDic.Add("Home", new Home());
            sceneDic.Add("Level1", new Level1Scene());
            sceneDic.Add("Level2", new Level2Scene());
            sceneDic.Add("Level3", new Level3Scene());

            curScene = sceneDic["Title"];

            Quiz();
            StoreItem();
        }

        public static void Quiz()
        {
            list = new List<QuizClass>();
            stackQuiz = new Stack<string>();

            list.Add(new Quiz1());
            list.Add(new Quiz2());
            list.Add(new Quiz3());
            list.Add(new Quiz4());
            
        }

        public static void StoreItem()
        {
            items = new List<Item>();
            stackStore = new Stack<string>();

            items.Add(new Potion());
            items.Add(new Hint());
            items.Add(new Pass());
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

        public static void PrintPlayerHP()
        {
            Console.WriteLine("\t\t\t\t\t\t****************************");
            Console.WriteLine($"\t\t\t\t\t\t*       체력:  {player.CurHP}         *");
            Console.WriteLine("\t\t\t\t\t\t****************************");
        }
    }
}
