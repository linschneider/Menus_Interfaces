using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class ShowDateListener : IMenuItemSelectedListener
    {
        public void OnMenuItemSelected()
        {
            Actions.ShowCurrentDate();
        }
    }
}