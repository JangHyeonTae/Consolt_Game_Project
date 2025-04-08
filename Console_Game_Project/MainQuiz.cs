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
        public List<QuizClass> list;
        private Stack<string> stack;
        public MainQuiz()
        {
            list.Add(new Quiz1());
            list.Add(new Quiz2());

            list = new List<QuizClass>();
            stack = new Stack<string>();
        }

        public void Catch()
        {
            stack.Push("QuizList");

            while (stack.Count > 0)
            {
                switch (stack.Peek())
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
            if (select < 0 || list.Count <= select)
            {
                Util.PressAnyKey("범위 내의 퀴즈를 선택하세요.");
            }
            else
            {
                selectIndex = select;
                stack.Push("Confirm");
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
                    list[selectIndex].Update();
                    break;
                case ConsoleKey.N:
                    stack.Pop();
                    break;

            }
        }

        public void PrintQuizList()
        {
            Console.WriteLine("퀴즈 수");
            if (list.Count == 0)
            {
                Game.ChangeScene("Home");
            }
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine("{0}. {1}", i + 1, list[i].name);
            }
        }

        public void Finish()
        {
            stack.Pop();
            stack.Pop();
        }
    }
}
