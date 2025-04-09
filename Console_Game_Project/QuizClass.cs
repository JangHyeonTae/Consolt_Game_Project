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

        public QuizClass(string _name)
        {
            name = _name;

        }
        public abstract void Render();

        public virtual void Input()
        {
            
        }
        public abstract void Update();
        
        public abstract void Exit();
    }
}
