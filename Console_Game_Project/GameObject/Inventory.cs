using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Game_Project.GameObject
{
    public class Inventory
    {
        private List<Item> items;
        private Stack<string> stack;

        private int selectIndex;

        public Inventory()
        {
            items = new List<Item>();
            stack = new Stack<string>();
        }

        public void Add(Item item)
        {
            items.Add(item);
        }

        public void Remove(Item item)
        {
            items.Remove(item);
        }

        public void RemoveAt(int index)
        {
            items.RemoveAt(index);
        }

        public void UseAt(int index)
        {
            items[index].Use();
        }

        public void Open()
        {
            stack.Push("Menu");

            while (stack.Count > 0)
            {
                Console.Clear();
                switch (stack.Peek())
                {
                    case "Menu": Menu(); break;
                    case "Confirm": Confirm(); break;
                }
            }
        }

        public void Menu()
        {
            PrintMenu();
            Console.WriteLine("사용할 아이템을 선택하세요");
            Console.WriteLine("I : 뒤로가기");
            ConsoleKey input = Console.ReadKey(true).Key;
            int select = (int)input - (int)ConsoleKey.D1;
            if (input == ConsoleKey.I)
            {
                stack.Pop();
            }
            else
            {
                selectIndex = select;
                stack.Push("Confirm");
            }
        }


        public void Confirm()
        {
            PrintMenu();
            Item selectItem = items[selectIndex];
            Console.WriteLine($"진짜 {selectItem.name}을 사용 하시겠습니까?");
            Console.WriteLine("U : 사용하기");
            Console.WriteLine("I : 뒤로가기");

            ConsoleKey input = Console.ReadKey(true).Key;

            if (input == ConsoleKey.I)
            {
                stack.Pop();
            }
            else if (input == ConsoleKey.U)
            {
                //selectItem.Use();
                Util.PressAnyKey($"{selectItem.name}을 사용했습니다.");
                Remove(selectItem);
                stack.Pop();
            }
            else
            {
                Util.PressAnyKey("잘못된 입력입니다");
            }
        }

        public void PrintMenu()
        {
            Console.WriteLine("*******보유한 아이템*******");
            if(items.Count==0)
            {
                Console.WriteLine("없음");
            }
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {items[i].name}");
            }
            
            Console.WriteLine("**************************");
        }
    }
}
