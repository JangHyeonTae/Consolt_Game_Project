using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Game_Project.Quiz
{
    internal class Quiz2 : QuizClass
    {
        MainQuiz mainQuiz;

        private int answer;
        private int question;
        public Quiz2() : base("문제2")
        {
        }
        public override void Render()
        {
           
        }

        public override void Input()
        {
            string a = Console.ReadLine();
            int.TryParse(a, out answer);
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
