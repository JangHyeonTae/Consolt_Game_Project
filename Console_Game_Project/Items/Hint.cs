using Console_Game_Project.GameObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Game_Project.Items
{
    public class Hint : Item
    {
        public Hint(Vector2 position) : base('H', position)
        {
            name = "힌트권";
            description = "힌트를 받을 수 있다";
        }

        public override void Use()
        {
            
        }
    }
}
