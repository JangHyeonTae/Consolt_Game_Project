using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Game_Project
{
    public abstract class GameManager : IInteractive
    {
        public ConsoleColor color;
        public char express;
        public Vector2 position;
        public bool isOnce;
        public bool isKey;

        public GameManager(ConsoleColor color, char express, Vector2 position, bool isOnce, bool isKey)
        {
            this.color = color;
            this.express = express;
            this.position = position;
            this.isOnce = isOnce;
            this.isKey = isKey;
        }

        public void PrintGameObject()
        {
            Console.SetCursorPosition(position.x,position.y);
            Console.ForegroundColor = color;
            Console.Write(express);
            Console.ResetColor();
        }

        public abstract void Interact(Player player);
    }
}
