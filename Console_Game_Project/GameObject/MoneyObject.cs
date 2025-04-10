using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Game_Project.GameObject
{
    internal class MoneyObject : GameManager
    {
        Random rand = new Random();

        public MoneyObject(char express, Vector2 position) : base(ConsoleColor.Yellow,express,position,true)
        {
            
        }
        public override void Interact(Player player)
        {
            int percent = rand.Next(1, 100);
            if (percent <= 20)
            {
                Game.MainQuiz.Catch();
            }
            Game.Player.GetMoney(20);
        }
    }
}
