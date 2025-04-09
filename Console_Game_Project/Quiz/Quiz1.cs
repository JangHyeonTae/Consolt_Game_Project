using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Game_Project.Quiz
{
    public class Quiz1 : QuizClass
    {
        private string answer;
        private string question = "190000";
        public Quiz1() : base("문제1")
        {
        }
        public override void Render()
        {
            Console.WriteLine("잡혔네요! 퀴즈를 풀어야 놔줄겁니다!");
            Console.WriteLine("규칙은 당신의 체력이 끝나기전에 문제를 맞춰야합니다");
            Console.WriteLine("단, 답은 숫자로 입력해야 합니다");
            Console.WriteLine("**Item을 입력하시면 인벤토리창에 들어갑니다**");
            Console.WriteLine();
            Console.WriteLine("문제!!");
            Console.WriteLine("세상에서 가장 쉬운 숫자는?");
            Console.WriteLine();
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
            while (answer != question)
            {
                Game.PrintPlayerHP();
                Input();
                if (answer == "Item")
                {
                    Game.Player.Inventory.Open();
                }
                if (answer != question && answer != "Item")
                {
                    Game.Player.TakeDamage(10);
                }
                else
                {
                    Exit();
                }
            }
            
              
            
        }
        public override void Exit()
        {
             Game.MainQuiz.Finish();
        }
    }
}
