using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Game_Project.Enemy
{
    public class Level2Enemy : EnemyClass
    {
        private MainQuiz mainQuiz;
        public Level2Enemy(char express, Vector2 position) :
            base(express, position)
        {
            mainQuiz = new MainQuiz();
        }
        public override void Interact(Player player)
        {
            mainQuiz.Catch();
        }
    }
}
