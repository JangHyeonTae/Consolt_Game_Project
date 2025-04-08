using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Game_Project
{
    public abstract class EnemyClass : GameManager
    {
        private MainQuiz mainQuiz;
        public MainQuiz MainQuiz { get { return mainQuiz; } }

        protected EnemyClass(char express, Vector2 position) :
            base(ConsoleColor.Red, express, position, true)
        {
           
        }

        public override void Interact(Player player)
        {
            MainQuiz.Catch();
        }
    }
}
