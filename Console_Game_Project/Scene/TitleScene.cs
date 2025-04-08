using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Game_Project.Scene
{
    internal class TitleScene : SceneManager
    {
        public override void Render()
        {
            Console.WriteLine("*****************************************");
            Console.WriteLine("*****************************************");
            Console.WriteLine("**            *************            **");
            Console.WriteLine("**            * Quiz Game *            **");
            Console.WriteLine("**            *************            **");
            Console.WriteLine("*****************************************");
            Console.WriteLine("*****************************************");
            Console.WriteLine();
            Console.WriteLine("계속 하실려면 아무키나 눌러주세요.");
        }
        public override void Input()
        {
            Console.ReadKey(true);
        }
        public override void Update() { }
        public override void Result()
        {
            Game.ChangeScene("HomeTown");
        }

        public override void Enter() { }

        public override void Exit() { }

    }
}
