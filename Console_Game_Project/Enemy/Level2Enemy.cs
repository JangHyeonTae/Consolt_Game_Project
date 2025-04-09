using Console_Game_Project.Quiz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Game_Project.Enemy
{
    public class Level2Enemy : EnemyClass
    {
        public Level2Enemy(char express, Vector2 position) :
            base(express, position)
        {
            
        }
        public override void Interact(Player player)
        {
            Game.MainQuiz.Catch();
        }
    }
}
