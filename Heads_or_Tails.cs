using Internal;
using System;
class HeadsorTails
{
    public static void Main()
    {
        Random random = new Random();
        int condition = 0;
        int HeadCount = 0, TailCount = 0;
        string Name;
        Console.WriteLine("Who are you?");
        Name = Console.ReadLine();
        Console.WriteLine("Hello, " + Name + "!");
        Console.WriteLine("Tossing a coin...");
        for(int i = 0; i < 3; i++)
        {
            condition = random.Next(0, 2);
            if(condition == 0)
            {
                Console.WriteLine("Round: " + (i + 1)+ " " + "Heads");
                HeadCount++;
            }
            else
            {
                Console.WriteLine("Round: " + (i + 1) + " " + "Tails");
                TailCount++;
            }
        }
        Console.WriteLine("Heads: " + HeadCount + " Tails: " + TailCount);
        if(HeadCount > TailCount)
        {
            Console.WriteLine(Name + " won");
        }
        else
        {
            Console.WriteLine(Name + " lose");
        }
    }
}