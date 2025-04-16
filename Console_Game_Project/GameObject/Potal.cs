using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Game_Project.GameObject
{
    public class Potal : GameManager
    {
        private string scene;
        public Potal(string scene, char express, Vector2 position) : base(ConsoleColor.Blue, express, position,false)
        {
            this.scene = scene;
        }

        public override void Interact(Player player)
        {
            
                Game.ChangeScene(scene);
            
        }
    }
}
