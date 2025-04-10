using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Game_Project.GameObject
{
    public class LastPotal : GameManager
    {
        private string scene;
        public LastPotal(string scene, char express, Vector2 position) : base(ConsoleColor.Blue, express, position, false)
        {
            this.scene = scene;
        }

        public override void Interact(Player player)
        {
            if (Game.Player.Count >= 3)
            {
                Game.ChangeScene(scene);
            }
        }
    }
}
