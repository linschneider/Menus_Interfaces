using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class ShowVersionListener : IMenuItemSelectedListener
    {
        public void OnMenuItemSelected()
        {
            Actions.ShowVersion();
        }
    }
}