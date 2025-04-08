using Console_Game_Project.Quiz;
using Console_Game_Project.Scene;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Game_Project
{
    public class MainQuiz
    {
        public Stack<QuizClass> stack;
        public MainQuiz()
        {
            stack = new Stack<QuizClass>();
        }

        public void Catch(QuizClass quiz)
        {
            stack.Push(quiz);
        }

        public void Finish()
        {
            stack.Pop();
        }
    }
}
