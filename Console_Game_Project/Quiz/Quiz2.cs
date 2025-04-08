using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Game_Project.Quiz
{
    internal class Quiz2 : QuizClass
    {
        private int question = 1234;
        private int answer;
        public Quiz2() : base("문제2")
        {
        }

        public override void Input()
        {
            string a = Console.ReadLine();
            int.TryParse(a, out answer);
        }

        public override void Update()
        {
            if (answer == question)
            {
                Game.ChangeScene("Home");
                Console.CursorVisible = false;
            }
            else
            {
                Game.Player.TakeDamage(10);
            }
        }
    }
}
