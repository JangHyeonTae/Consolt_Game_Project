using Console_Game_Project.GameObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Game_Project.Items
{
    internal class Potion : Item
    {
        public Potion(Vector2 position) : base('O',position ,10)
        {
            name = "포션";
            description = "HP + 30";
        }
        public Potion() : base('P', new Vector2(0,0), 10)
        {
            name = "포션";
        }

        public override void Use()
        {
            Game.Player.Heal(30);
        }
    }
}
