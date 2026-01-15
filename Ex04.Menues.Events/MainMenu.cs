using System;

namespace Ex04.Menus.Events
{
    public class MainMenu
    {
        private const string k_BackOrExitOption = "0";
        private readonly SubMenuItem r_RootMenu;

        public MainMenu(string i_MainTitle)
        {
            r_RootMenu = new SubMenuItem(i_MainTitle);
        }

        public SubMenuItem Root
        {
            get { return r_RootMenu; }
        }

        public void Show()
        {
            SubMenuItem currentMenu = r_RootMenu;
            bool toExit = false;

            while (!toExit)
            {
                Console.Clear();
                currentMenu.Execute();

                string choice = Console.ReadLine();
                if (!isValidChoice(choice, currentMenu.Items.Count))
                {
                    Console.WriteLine("Invalid input. Please try again.");
                    pressAnyKeyToContinue(false);
                    continue;
                }

                if (choice == k_BackOrExitOption)
                {
                    if (currentMenu == r_RootMenu)
                    {
                        toExit = true;
                    }
                    else
                    {
                        currentMenu = currentMenu.Parent;
                    }

                    continue;
                }

                int index = int.Parse(choice) - 1;
                MenuItem selectedItem = currentMenu.Items[index];

                if (selectedItem is SubMenuItem subMenu)
                {
                    currentMenu = subMenu;
                }
                else
                {
                    Console.Clear();
                    selectedItem.Execute();
                    pressAnyKeyToContinue(true);
                }
            }
        }

        private static bool isValidChoice(string i_Choice, int i_ItemsCount)
        {
            if (!int.TryParse(i_Choice, out int numericChoice))
            {
                return false;
            }

            return numericChoice >= 0 && numericChoice <= i_ItemsCount;
        }

        private static void pressAnyKeyToContinue(bool i_ClearAfter)
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);

            if (i_ClearAfter)
            {
                Console.Clear();
            }
        }
    }
}



