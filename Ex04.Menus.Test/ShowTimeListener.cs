using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class ShowTimeListener : IMenuItemSelectedListener
    {
        public void OnMenuItemSelected()
        {
            Actions.ShowCurrentTime();
        }
    }
}