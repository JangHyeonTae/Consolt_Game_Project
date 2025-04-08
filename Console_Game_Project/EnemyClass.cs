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

        protected EnemyClass(char express, Vector2 position) :
            base(ConsoleColor.Red, express, position, true)
        {
            mainQuiz = new MainQuiz();
        }

        public override void Interact(Player player)
        {
            mainQuiz.Catch();
        }
    }
}
