using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class CountLowercaseListener : IMenuItemSelectedListener
    {
        public void OnMenuItemSelected()
        {
            Actions.CountLowercase();
        }
    }
}