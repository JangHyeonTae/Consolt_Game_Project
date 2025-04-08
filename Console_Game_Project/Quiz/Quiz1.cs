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
        private string answer;
        private string question = "오페라하우스";

        public Quiz1() : base("문제1")
        {
            
        }
        public override void Render()
        {
            Game.PrintPlayerHP();
            Console.WriteLine("잡혔네요!ㅎㅎ 퀴즈를 풀어야 놔줄겁니다!");
            Console.WriteLine("규칙은 당신의 체력이 끝나기전에 문제를 맞춰야합니다");
            Console.WriteLine("단, 띄어쓰기는 하지마세요!");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("문제!!");
            Console.WriteLine("숫자 5가 제일 싫어하는 집은?");
            Console.WriteLine();
            
        }

        public override void Input()
        {
            Console.Write("답 : ");
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
