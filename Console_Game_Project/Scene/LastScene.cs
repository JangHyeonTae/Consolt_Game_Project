using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Game_Project.Scene
{
    public class LastScene : SceneManager
    {
        public override void Render()
        {
           
        }
        public override void Input()
        {
            
        }

        public override void Update()
        {
        }

        public override void Result()
        {
            Game.GameFinish("축하합니다~ 세상밖으로 나왔어요!");
        }

        
    }
}
