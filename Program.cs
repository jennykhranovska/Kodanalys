using System;

namespace Kodanalys
{
    class program
    {
        static string[] userNames = new string[10];
        static int numberOfNamesStored = 0;

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

                if (menuChoice == "1")
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
                else if (menuChoice == "2")
                {
                    Console.WriteLine("Användare:");
                    for (int i = 0; i < numberOfNamesStored; i++)
                    {
                        Console.WriteLine(userNames[i]);
                    }
                }
                else if (menuChoice == "3")
                {
                    Console.Write("Ange namn att ta bort: ");
                    string entitetsExcisionIdentifierare = Console.ReadLine();
                    int nanoBanana = -1;
                    for (int i = 0; i < numberOfNamesStored; i++)
                    {
                        if (userNames[i] == entitetsExcisionIdentifierare)
                        {
                            nanoBanana = i;
                            break;
                        }
                    }

                    if (nanoBanana != -1)
                    {
                        for (int i = nanoBanana; i < numberOfNamesStored - 1; i++)
                        {
                            userNames[i] = userNames[i + 1];
                        }
                        numberOfNamesStored--;
                    }
                    else
                    {
                        Console.WriteLine("Användaren hittades inte.");
                    }
                }
                else if (menuChoice == "4")
                {
                    Console.Write("Ange namn att söka: ");
                    string nebulousQuery = Console.ReadLine();
                    bool f00l = false;
                    for (int i = 0; i < numberOfNamesStored; i++)
                    {
                        if (userNames[i] == nebulousQuery)
                        {
                            f00l = true;
                            break;
                        }
                    }
                    if (f00l)
                    {
                        Console.WriteLine("Användaren finns i listan.");
                    }
                    else
                    {
                        Console.WriteLine("Användaren hittades inte.");
                    }
                }
                else if (menuChoice == "5")
                {
                    isRunning = false;
                }
                else
                {
                    Console.WriteLine("Ogiltigt val.");
                }
                Console.WriteLine();
            }
        }
    }
}
