using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Game_Project.Quiz
{
    public class Quiz1 : QuizClass
    {

        private string question = "오페라하우스";
        private string answer;
        public Quiz1() : base("문제1")
        {
            Console.WriteLine("숫자 5가 제일 싫어하는 집은?");
            Console.WriteLine();
            Console.Write("답 : ");
        }

        public override void Input()
        {
            answer = Console.ReadLine();
        }

        public override void Update()
        {
            if (answer == question)
            {
                
            }
            else
            {
                Game.Player.TakeDamage(10);
            }
        }
    }
}
