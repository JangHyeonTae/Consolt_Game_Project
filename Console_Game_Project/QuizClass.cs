using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Game_Project
{
    public abstract class QuizClass
    {
        MainQuiz mainQuiz;

        public string name;
        public string answer;
        public string question; 

        public QuizClass(string _name)
        {
            name = _name;
        }
        public void Question()
        {
            Console.WriteLine("잡혔네요!ㅎㅎ 퀴즈를 풀어야 놔줄겁니다!");
            Console.WriteLine("규칙은 당신의 체력이 끝나기전에 문제를 맞춰야합니다");
            Console.WriteLine("단, 띄어쓰기는 하지마세요!");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("문제!!");
        }
        public abstract void Render();
        
        public abstract void Update();
        public void Main()
        {
            Render();
            while (answer != question)
            {
                Update();
            }
            Exit();
        }
        public void Exit()
        {
            if (answer == question)
            {
                mainQuiz.Finish();
            }
        }
    }
}
