using System;

namespace Ex04.Menus.Interfaces
{
    public class ActionMenuItem : MenuItem
    {
        private readonly IMenuItemSelectedListener r_Listener;

        public ActionMenuItem(string i_Text, IMenuItemSelectedListener i_Listener) : base(i_Text)
        {
            r_Listener = i_Listener ?? throw new ArgumentNullException(nameof(i_Listener));
        }

        public override void Execute()
        {
            r_Listener.OnMenuItemSelected();
        }
    }
}