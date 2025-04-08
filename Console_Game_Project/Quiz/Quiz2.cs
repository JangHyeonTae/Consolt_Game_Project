using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Game_Project.Quiz
{
    internal class Quiz2 : QuizClass
    {
        private int answer;
        private int question;
        public Quiz2() : base("문제2")
        {
        }
        public override void Render()
        {
            
        }
        public override void Update()
        {
            string a = Console.ReadLine();
            int.TryParse(a, out answer);
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
