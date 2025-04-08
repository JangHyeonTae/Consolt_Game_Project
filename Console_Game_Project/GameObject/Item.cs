using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Game_Project.GameObject
{
    public abstract class Item : GameManager
    {
        public string name;
        public string description;

        public Item(char express, Vector2 position) : base(ConsoleColor.Green, express, position, true)
        {

        }

        public override void Interact(Player player)
        {
            player.Inventory.Add(this);
        }

        public abstract void Use();
    }
}
