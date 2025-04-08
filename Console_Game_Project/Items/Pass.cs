using Console_Game_Project.GameObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Console_Game_Project.Items
{
    public class Pass : Item
    {
        public Pass(Vector2 position) : base('S', position)
        {
            name = "패스권";
            description = "퀴즈 하나를 통과할 수 있다";
        }

        public override void Use()
        {
            
        }
    }
}
