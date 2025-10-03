using System;

namespace Kodanalys
{
    class program
    {
        static string[] userNames = new string[10];
        static int userCount = 0;

        static void Main(string[] args)
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("Välj ett alternativ:");
                Console.WriteLine("1. Lägg till användare");
                Console.WriteLine("2. Visa alla användare");
                Console.WriteLine("3. Ta bort användare");
                Console.WriteLine("4. Sök användare");
                Console.WriteLine("5. Avsluta");
                string menuChoice = Console.ReadLine();

                switch (menuChoice)
                {
                    case "1":
                        UserMenu.AddUser(userNames, ref userCount);

                        break;

                    case "2":
                        UserMenu.ShowUsers(userNames, userCount);
                        break;

                    case "3":

                        UserMenu.DeleteUser(userNames, ref userCount);
                        break;


                    case "4":

                        UserMenu.SearchUser(userNames, ref userCount);
                        break;


                    case "5":
                        isRunning = false;
                        break;

                    default:
                        Console.WriteLine("Ogiltigt val.");
                        break;
                }
            }
        }
    }
}
