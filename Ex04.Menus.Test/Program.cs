using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class Program
    {
        public static void Main()
        {
            MainMenu interfacesMenu = InterfacesMenuBuilder.Build();
            interfacesMenu.Show();

            Ex04.Menus.Events.MainMenu eventsMenu = EventsMenuBuilder.Build();
            eventsMenu.Show();
        }
    }
}