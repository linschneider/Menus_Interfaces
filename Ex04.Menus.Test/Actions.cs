using System;

namespace Ex04.Menus.Test
{
    public static class Actions
    {
        public static void ShowVersion()
        {
            Console.WriteLine("App Version: 26.1.4.5940");
        }

        public static void CountLowercase()
        {
            Console.WriteLine("Please enter a sentence:");
            string input = Console.ReadLine() ?? string.Empty;

            int count = 0;
            foreach (char c in input)
            {
                if (char.IsLower(c))
                {
                    count++;
                }
            }

            Console.WriteLine($"> There are {count} lowercase letters in your text");
        }

        public static void ShowCurrentTime()
        {
            Console.WriteLine($"> Current Time is {DateTime.Now:HH:mm:ss}");
        }

        public static void ShowCurrentDate()
        {
            Console.WriteLine($"> Current Date is {DateTime.Now:dd/MM/yyyy}");
        }
    }
}