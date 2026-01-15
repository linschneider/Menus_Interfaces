
using System;

namespace Ex04.Menus.Events
{
    public class ActionMenuItem : MenuItem
    {
        private readonly Action r_Action;

        public ActionMenuItem(string i_Text, Action i_Action)
            : base(i_Text)
        {
            r_Action = i_Action ?? throw new ArgumentNullException(nameof(i_Action));
        }

        public override void Execute()
        {
            r_Action.Invoke();
        }
    }
}

