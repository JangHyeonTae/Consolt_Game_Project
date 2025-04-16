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

        private int count = 0;
        public int Count { get { return count; } set { count = value; } }

        private int maxHP = 100;
        private int curHP = 100;
        public int CurHP { get { return curHP; } set { curHP = value; } }

        private int money = 100;
        public int Money { get { return money; } set {  money = value; } }  

        public Player()
        {
            inventory = new Inventory();
        }

        public void PrintPlayer()
        {
            Console.SetCursorPosition(position.x, position.y);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write('P');
            Console.ResetColor();
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
                    InventoryOpen();
                    break;
            }
            if (map[pos.y, pos.x] == true)
            {
                position = pos;
            }
        }

        public void Buy(int cost)
        {
            if (money >= cost)
            {
                money -= cost;
            }
            else
            {
                Console.WriteLine("돈이 부족합니다");
            }
        }

        public void IsKey()
        {

        }

        public void InventoryOpen()
        {
            inventory.Open();
        }

        public void TakeDamage(int damage)
        {
            curHP -= damage;
            if (curHP <= 0)
            {
                Game.GameOver("사망...역시 조사병단은 쉽지가 않죠!");
            }
        }

        public void GetMoney(int amount)
        {
            money += amount;
        }

        public void Heal(int amount)
        {
            curHP += amount;
            if (curHP >= maxHP)
            {
                curHP = maxHP;
            }
        }

    }
}
