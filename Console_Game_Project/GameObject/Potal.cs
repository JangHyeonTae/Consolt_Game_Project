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
        public Potal(string scene, char express, Vector2 position, bool isKey) : base(ConsoleColor.Blue, express, position,false,isKey)
        {
            this.scene = scene;
        }
        public Potal() : base(ConsoleColor.Blue,'P',new Vector2(0,0),false,false)
        {

        }

        public override void Interact(Player player)
        {
            if (isKey == false)
            {
                Game.ChangeScene(scene);
            }
        }

        public void KeyTrue()
        {
            if (this.isKey == false)
            {
                return;
            }
            else 
            {
                this.isKey = false;
            }
        }

    }
}
