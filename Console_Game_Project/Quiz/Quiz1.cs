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

        public Quiz1() : base("난 센스 지려",false,false)
        {
        }
        public override void Render()
        {
            Console.WriteLine("*****************************************");
            Console.WriteLine("********         넌센스          *********");
            Console.WriteLine("*****************************************");
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
            
            while (answer != question && isGoal == false)
            {
                Game.PrintPlayerHP(); 
                if (hint == true)
                {
                    Console.WriteLine("힌트 : 십구십구십구십구십죠?");
                }

                Input();
                if (answer == "Item")
                {
                    Game.Player.Inventory.Open();
                }
                else if (answer != question && answer != "Item")
                {
                    Game.Player.TakeDamage(10);
                }
                if (answer == question)
                {
                    Util.PressAnyKey("정답입니다!");
                    Exit();
                }
            }
        }

        public override void Exit()
        {
            isGoal = true;
            hint = false;
            Game.MainQuiz.Finish();
        }
    }
}
