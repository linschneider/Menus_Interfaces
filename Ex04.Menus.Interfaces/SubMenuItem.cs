using System;
using System.Collections.Generic;

namespace Ex04.Menus.Interfaces
{
    public class SubMenuItem : MenuItem
    {
        private readonly List<MenuItem> r_Items = new List<MenuItem>();

        public SubMenuItem(string i_Text) : base(i_Text)
        {
        }

        public IList<MenuItem> Items
        {
            get { return r_Items; }
        }

        public void Add(MenuItem i_Item)
        {
            if (i_Item == null)
            {
                throw new ArgumentNullException(nameof(i_Item));
            }

            i_Item.Parent = this;
            r_Items.Add(i_Item);
        }

        public override void Execute()
        {
            ConsoleColor prev = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"** {Text} **");
            Console.ForegroundColor = prev;

            Console.WriteLine(new string('-', Math.Max(5, Text.Length + 6)));

            for (int i = 0; i < r_Items.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {r_Items[i].Text}");
            }

            string backOrExit = (Parent == null) ? "Exit" : "Back";
            Console.WriteLine($"0. {(backOrExit)}");

            Console.Write("Please enter your choice ");
            Console.Write($"(1-{r_Items.Count} or 0 to {(Parent == null ? "exit" : "go back")}):");
            Console.WriteLine();
            Console.Write(">> ");
        }
    }
}