using Console_Game_Project.GameObject;
using Console_Game_Project.Quiz;
using Console_Game_Project.Scene;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Game_Project
{
    public class MainQuiz
    {
        private int selectIndex;
        public int SelectIndex { get { return selectIndex; } }

        public void Catch()
        {
            Game.stack.Push("QuizList");

            while (Game.stack.Count > 0)
            {
                Console.Clear();
                switch (Game.stack.Peek())
                {
                    case "QuizList": QuizList();
                        break;
                    case "Confirm": Confirm();
                        break;
                }
            }
        }

        public void QuizList()
        {
            PrintQuizList();
            Console.WriteLine();
            Console.WriteLine("퀴즈를 골라주세요~");

            ConsoleKey input = Console.ReadKey(true).Key;
            
            
            int select = (int)input - (int)ConsoleKey.D1;
            
            if (select < 0 || Game.list.Count <= select)
            {
                Util.PressAnyKey("범위 내의 퀴즈를 선택하세요.");
            }
            
            else
            {
                selectIndex = select;
                Game.stack.Push("Confirm");
            }
            
        }

        public void Confirm()
        {
            Console.WriteLine("정말 이 퀴즈를 진행 하시겠어요?");
            Console.WriteLine("Y. 네");
            Console.WriteLine("N. 아니오");
            ConsoleKey input = Console.ReadKey(true).Key;
            switch (input)
            {
                case ConsoleKey.Y:
                    Game.list[selectIndex].Update();
                    
                    break;
                case ConsoleKey.N:
                    Game.stack.Pop();
                    break;

            }
        }

        public void PrintQuizList()
        {
            Console.WriteLine("퀴즈 수");
            if (Game.list.Count == 0)
            {
                Game.stack.Pop();
            }
            for (int i = 0; i < Game.list.Count; i++)
            {
                Console.WriteLine("{0}. {1}", i + 1, Game.list[i].name);
            }
        }

        public void Finish()
        {
            if(Game.list.Count <= 0)
            {
                return;
            }
            Game.stack.Pop();
            Game.stack.Pop();
            Game.list.Remove(Game.list[selectIndex]);
        }
    }
}
