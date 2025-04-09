using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Console_Game_Project.Enemy
{
    public class RandomEnemy : EnemyClass
    {
        
        public RandomEnemy(char express,Vector2 position) : base(express, position)
        {
            DownEnemy(this);
        }

        public void DownEnemy(EnemyClass enemy)
        {
            while (Game.Player.CurHP > 0)
            {
                enemy.position.y++;

                if (enemy.position.y >= Game.Player.map.GetLength(0))
                {
                    enemy.position.y = 0;
                }

                Thread.Sleep(1000);
            }
        }

        public override void Interact(Player player)
        {
            Game.Player.TakeDamage(10);
        }
    }
}
