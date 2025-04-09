using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Game_Project
{
    public abstract class QuizClass
    {
        public string name;
        public bool isGoal;
        public bool hint;
        public QuizClass(string _name, bool isGoal, bool hint)
        {
            name = _name;
            this.isGoal = isGoal;
            this.hint = hint;
        }
        public abstract void Render();

        public virtual void Input(){}

        //public abstract void Hint();
        public abstract void Update();
        
        public abstract void Exit();
    }
}
