using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Game_Project.Quiz
{
    internal class Quiz3 : QuizClass
    {
        int a;
        string answer;
        public Quiz3() : base("너의 심리가 뭘까?", false, false)
        {

        }

        public override void Render()
        {
            
            Console.WriteLine("*****************************************");
            Console.WriteLine("********       숫자맞추기        *********");
            Console.WriteLine("*****************************************");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("규칙1 : 숫자가 맞으면 통과");
            Console.WriteLine("규칙2 : 숫자에 따라 up,down을 알려드릴게요!");
            Console.WriteLine("규칙3 : 1 ~99 자리중 맞춰보세요!");
            Console.WriteLine("틀릴때마다 -10의 체력을 잃습니다!");
            Console.WriteLine("**Item을 입력하시면 인벤토리창에 들어갑니다**");
            Console.WriteLine();
            Console.WriteLine();
        }

        public void GamePlay()
        {
            Random random = new Random();
            int question = random.Next(1, 100);

            while (Game.Player.CurHP > 0)
            {
                Game.PrintPlayerHP();
                Console.WriteLine($"{question}");
                if (answer == "Item")
                {
                    Game.Player.Inventory.Open();
                }

                if (hint == true)
                {
                    Console.WriteLine($"힌트1 : {question + 1}");
                    Console.WriteLine($"힌트2 : {question - 1}");
                }

                Input();

                bool isTrue = int.TryParse(answer, out a);

                if (question > a && answer != "Item")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("틀렸습니다. 더 높습니다");
                    Game.Player.TakeDamage(10);
                    Console.ResetColor();
                }
                else if (question < a && answer != "Item")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("틀렸습니다. 더 낮습니다");
                    Game.Player.TakeDamage(10);
                    Console.ResetColor();
                }
                else if (question == a)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("정답입니다.");
                    Console.ResetColor();
                    break;
                }
            }
        }

        public override void Input()
        {
            Console.Write("답 : ");
            answer = Console.ReadLine();
        }

        public override void Update()
        {
            Console.Clear();
            Render();
            GamePlay();
        }

        
        public override void Exit()
        {
            isGoal = true;
            hint = false;
            Game.Player.GetMoney(20);
            Game.MainQuiz.Finish();
        }
    }
}
