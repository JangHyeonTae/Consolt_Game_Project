using Console_Game_Project.GameObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Game_Project.Items
{
    public class Key : Item
    {
        public Key(Vector2 position) : base('K', position, 10)
        {
            name = "열쇠";
        }
        public Key()
        {
            name = "열쇠";
        }


        public override void Use()
        {
            Game.Player.Count++;
        }
    }
}
