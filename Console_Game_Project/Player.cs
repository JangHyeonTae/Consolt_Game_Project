using Console_Game_Project.GameObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Console_Game_Project
{
    public class Player
    {
        public Vector2 position;
        public bool[,] map;

        private Inventory inventory;
        public Inventory Inventory { get { return inventory; } }

        private int maxHP;
        public int MaxHP {  get { return maxHP; } }

        private int curHP;
        public int CurHP { get { return curHP; } set { curHP = value; } }

        public Player()
        {
            inventory = new Inventory();
            maxHP = 100;
            curHP = maxHP;
        }

        public void PrintPlayer()
        {
            Console.SetCursorPosition(position.x, position.y);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write('M');
            Console.ResetColor();
        }
        public void Action(ConsoleKey input)
        {
            switch (input)
            {
                case ConsoleKey.W:
                case ConsoleKey.S:
                case ConsoleKey.A:
                case ConsoleKey.D:
                    Move(input);
                    break;
                
            }
        }
        public void Move(ConsoleKey input)
        {
            Vector2 pos = position;

            switch (input)
            {
                case ConsoleKey.W:
                    pos.y--;
                    break;
                case ConsoleKey.S:
                    pos.y++;
                    break;
                case ConsoleKey.A:
                    pos.x--;
                    break;
                case ConsoleKey.D:
                    pos.x++;
                    break;
                case ConsoleKey.I:
                    inventory.Open();
                    break;
            }
            if (map[pos.y, pos.x] == true)
            {
                position = pos;
            }
        }

        public void TakeDamage(int damage)
        {
            CurHP -= damage;
            if (CurHP <= 0)
            {
                Game.GameOver("사망...역시 조사병단은 쉽지가 않죠!");
            }
        }
    }
}
