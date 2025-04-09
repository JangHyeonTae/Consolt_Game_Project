using Console_Game_Project.GameObject;
using Console_Game_Project.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Console_Game_Project
{
    public class Store
    {
        //public List<Item> items;
        //private Stack<string> stack;
        private int selectIndex;
        public int SelectIndex { get { return selectIndex; } }
        public Store()
        {
            //items = new List<Item>();
            //stackStore = new Stack<string>();

            
        }

        public void OpenStore()
        {
            Game.stackStore.Push("StoreBuy");
            while (Game.stackStore.Count > 0)
            {
                Console.Clear();
                switch (Game.stackStore.Peek())
                {
                    //case "StoreOpen": StoreOpen(); break;
                    case "StoreBuy": StoreBuy(); break;
                    case "ConfirmStore": ConfirmStore(); break;
                }
            }
        }

        //public void StoreOpen()
        //{
        //    Console.Clear();
        //    Console.WriteLine("상점을 이용 하시겠습니까?");
        //    Console.WriteLine("취소는 : N");
        //    Console.WriteLine("이용은 : Y");
        //
        //    ConsoleKey input = Console.ReadKey(true).Key;
        //    if (input == ConsoleKey.N)
        //    {
        //        Game.stackStore.Pop();
        //    }
        //    else if(input == ConsoleKey.Y) 
        //    {
        //        Game.stackStore.Push("StoreBuy");
        //    }
        //    else
        //    {
        //        Console.WriteLine("다시 입력해주세요");
        //    }
        //}
        public void StoreBuy()
        {
            Console.Clear();
            PrintStore();
            Console.WriteLine("구매하실 아이템 번호를 눌러주세요");
            Console.WriteLine("뒤로가기는 : N");

            ConsoleKey input = Console.ReadKey(true).Key;
            if (input == ConsoleKey.N)
            {
                Game.stackStore.Pop();
            }
            else
            {
                int select = (int)input - (int)ConsoleKey.D1;
                if (select < 0 || Game.items.Count <= select)
                {
                    Util.PressAnyKey("범위 내의 아이템을 선택하세요.");
                }
                else
                {
                    selectIndex = select;
                    Game.stackStore.Push("ConfirmStore");
                }
            }
        }

        public void ConfirmStore()
        {
            Item selectItem = Game.items[selectIndex];
            Console.WriteLine("{0} 을 구매 하시겠습니까?", selectItem.name);

            ConsoleKey input = Console.ReadKey(true).Key;
            switch (input)
            {
                case ConsoleKey.Y:
                    Util.PressAnyKey($"{selectItem.name}을 구매하셨습니다.");
                    Game.Player.Inventory.Add(Game.items[selectIndex]);
                    Game.Player.Buy(Game.items[selectIndex].cost);
                    Game.stackStore.Pop();
                    break;
                case ConsoleKey.N:
                    Game.stackStore.Pop();
                    break;
            }
        }

        public void PrintStore()
        {
            Console.WriteLine("*******    상점    *******");
            Console.WriteLine("*  1. 포션   - 가격 : 10  *");
            Console.WriteLine("*  2. 힌트권 - 가격 : 50  *");
            Console.WriteLine("*  3. 패스권 - 가격 : 150 *");
            Console.WriteLine("**************************");
        }
    }
}
