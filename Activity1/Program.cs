using System;

public class GenshinArchons
{
    public static void Main(string[] args)
    {

        do
        {
            Console.WriteLine("<<Genshin Archon Finder>>");

            string[] Archons = { "Barbatos - Venti", "Morax - Zhongli", "Beelzebub - Raiden Ei", "Buer - Nahida", "Focalors - Furina", "Murata - Mavuika", "Tsaritsa - Unknown" };

            Console.WriteLine("\n1. Mondstadt \n2. Liyue \n3. Inazuma \n4. Sumeru \n5. Fontaine \n6. Natlan \n7. Snezhnaya\n");
            Console.Write("Enter the number of the region you want to find: ");

            if (int.TryParse(Console.ReadLine(), out int index))
            {
                if (index >= 0 && index <= Archons.Length)
                {
                    Console.WriteLine($"\nThe Archon name is: {Archons[index - 1]}");
                }
                else
                {
                    Console.WriteLine("\nThere are only 7 regions in Teyvat.\n");
                }
            }
            else
            {
                Console.WriteLine("\nInvalid input. Please try again.\n");

            }

            Console.WriteLine("\nDo you want to search for another one? \nType Yes or No:");
        } while (Console.ReadLine().ToLower() == "yes");

        Console.WriteLine("\nWrong input. Exiting the program now...");

    }
}

