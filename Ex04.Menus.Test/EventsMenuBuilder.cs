namespace Ex04.Menus.Test
{
    public static class EventsMenuBuilder
    {
        public static Ex04.Menus.Events.MainMenu Build()
        {
            Ex04.Menus.Events.MainMenu mainMenu = new Ex04.Menus.Events.MainMenu("Delegates Main Menu");

            Ex04.Menus.Events.SubMenuItem versionAndLowercase = new Ex04.Menus.Events.SubMenuItem("Version and Lowercase");
            Ex04.Menus.Events.SubMenuItem showCurrentDateTime = new Ex04.Menus.Events.SubMenuItem("Show Current Date/Time");

            mainMenu.Root.Add(versionAndLowercase);
            mainMenu.Root.Add(showCurrentDateTime);

            versionAndLowercase.Add(new Ex04.Menus.Events.ActionMenuItem("Show Version", Actions.ShowVersion));
            versionAndLowercase.Add(new Ex04.Menus.Events.ActionMenuItem("Count Lowercase", Actions.CountLowercase));

            showCurrentDateTime.Add(new Ex04.Menus.Events.ActionMenuItem("Show Current Time", Actions.ShowCurrentTime));
            showCurrentDateTime.Add(new Ex04.Menus.Events.ActionMenuItem("Show Current Date", Actions.ShowCurrentDate));

            return mainMenu;
        }
    }
}