using Ex04.Menus.Events;

namespace Ex04.Menus.Events
{
    public abstract class MenuItem
    {
        private readonly string r_Text;

        protected MenuItem(string i_Text)
        {
            r_Text = i_Text;
        }

        public string Text
        {
            get { return r_Text; }
        }

        public SubMenuItem Parent { get; internal set; }

        public abstract void Execute();
    }
}