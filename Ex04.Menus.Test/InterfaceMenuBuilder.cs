using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public static class InterfacesMenuBuilder
    {
        public static MainMenu Build()
        {
            MainMenu mainMenu = new MainMenu("Interfaces Main Menu");

            SubMenuItem versionAndLowercase = new SubMenuItem("Version and Lowercase");
            SubMenuItem showCurrentDateTime = new SubMenuItem("Show Current Date/Time");

            mainMenu.Root.Add(versionAndLowercase);
            mainMenu.Root.Add(showCurrentDateTime);

            versionAndLowercase.Add(new ActionMenuItem("Show Version", new ShowVersionListener()));
            versionAndLowercase.Add(new ActionMenuItem("Count Lowercase", new CountLowercaseListener()));

            showCurrentDateTime.Add(new ActionMenuItem("Show Current Time", new ShowTimeListener()));
            showCurrentDateTime.Add(new ActionMenuItem("Show Current Date", new ShowDateListener()));

            return mainMenu;
        }
    }
}