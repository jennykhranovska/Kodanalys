using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Kodanalys
{
    internal class UserMenu
    {
        public static void AddUser(string[] userNames, ref int numberOfNamesStored)
        {
            Console.Write("Ange namn: ");
            string userName = Console.ReadLine();
            if (numberOfNamesStored < 10)

            {
                userNames[numberOfNamesStored] = userName;
                numberOfNamesStored++;
            }
            else
            {
                Console.WriteLine("Listan är full!");

            }

        }
        public static void ShowUsers(string[] userNames, int numberOfNamesStored)
        {
            if (numberOfNamesStored == 0)
            {
                Console.WriteLine("Inga användare hittades.");
            }
            else
            {
                Console.WriteLine("Användare:");
                for (int i = 0; i < numberOfNamesStored; i++)
                {
                    Console.WriteLine(userNames[i]);
                }
            }
        }


        public static void DeleteUser(string[] userNames, ref int userCount)
        {
            Console.Write("Ange namn att ta bort: ");
            string nameToRemove = Console.ReadLine();
            int indexToRemove = -1;
            for (int i = 0; i < userCount; i++)
            {
                if (userNames[i].ToLower() == nameToRemove.ToLower())
                {
                    indexToRemove = i;
                    break;
                }
            }

            if (indexToRemove != -1)
            {
                for (int i = indexToRemove; i < userCount - 1; i++)
                {
                    userNames[i] = userNames[i + 1];
                }
                userCount--;
                Console.WriteLine($"\"{nameToRemove}\" är borttagen.");
            }

            else

            {
                Console.WriteLine("Användaren hittades inte.");
            }



        }



        public static void SearchUser(string[] userNames, ref int userCount)

        {
            Console.Write("Ange namn att söka: ");
            string name = Console.ReadLine();

            bool exists = false;
            for (int i = 0; i < userCount; i++)
            {
                if (userNames[i].ToLower() == name.ToLower())
                {
                    exists = true;
                    break;
                }
            }
            if (exists)

            {
                Console.WriteLine("Användaren finns i listan.");
            }

            else

            {
                Console.WriteLine("Användaren hittades inte.");

            }
        }
        
    }
}



     