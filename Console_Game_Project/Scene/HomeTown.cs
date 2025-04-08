using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Game_Project.Scene
{
    public class HomeTown : SceneManager
    {
        public override void Render()
        {
            Console.WriteLine("나도 저기 세상 밖을 보고싶어.");
            Console.WriteLine("조사병산이 되고말거야!!!");
            Console.WriteLine("오늘은 반드시 이 마을을 떠나고 말겠어!");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("계속 하실려면 아무키나 눌러주세요");

        }
        public override void Input()
        {
            Console.ReadKey(true);
        }
        public override void Update()
        {
        }
        public override void Result()
        {
            Game.ChangeScene("Home");
        }


    }
}
