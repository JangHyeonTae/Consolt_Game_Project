﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Game_Project.GameObject
{
    public abstract class Item : GameManager
    {
        public string name;
        public string description;
        public int cost;

        public Item(char express, Vector2 position, int _cost) : base(ConsoleColor.Magenta, express, position, true)
        {
            cost = _cost;
        }

        public Item() { }

        public override void Interact(Player player)
        {
            player.Inventory.Add(this);
        }

        public abstract void Use();
    }
}
