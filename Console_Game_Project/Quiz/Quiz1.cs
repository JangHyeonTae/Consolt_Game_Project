using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Game_Project.Quiz
{
    public class Quiz1 : QuizClass
    {
        MainQuiz mainQuiz;
        private string answer = Console.ReadLine();
        private string question;
        public Quiz1() : base("문제1")
        {
            
        }
        public override void Render()
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
            Render();
            while (answer != question)
            {
                Input();

                Game.Player.TakeDamage(10);
            }
            Exit();
            
        }
        public override void Exit()
        {
            if (answer == question)
            {
                mainQuiz.Finish();
            }
        }
    }
}
