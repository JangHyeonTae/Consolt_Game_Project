using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Game_Project.GameObject
{
    public class StoreObject : GameManager
    {
        

        public StoreObject(char express, Vector2 position) : base(ConsoleColor.White, express, position, false)
        {
           
        }

        public override void Interact(Player player)
        {
            Game.Store.OpenStore();
        }
    }
}
