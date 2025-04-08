using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Game_Project.Quiz
{
    public class Quiz1 : QuizClass
    {
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
        

        public override void Update()
        {
            answer = Console.ReadLine();
            Game.Player.TakeDamage(10);
        }
        public void Main()
        {
            Render();
            while (answer == question)
            {
                Update();
            }
        }
    }
}
