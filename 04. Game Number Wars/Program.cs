using System;

namespace _04._Game_Number_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstPlayer = Console.ReadLine();
            string secondPlayer = Console.ReadLine();
            int comand = int.Parse(Console.ReadLine());
            string comand1 = comand.ToString();
            int win1 = 0;
            int win2 = 0;

            while (comand1 != "End of game")
            {
                int points1 = int.Parse(Console.ReadLine());
                int points2 = int.Parse(Console.ReadLine());
                if (points1 > points2)
                {
                    win1 += points1 - points2;
                }
                else if (points2 > points1)
                {
                    win2 += points2 - points1;
                }
                else
                {
                    Console.WriteLine("Number wars!");
                    int lastCard1 = int.Parse(Console.ReadLine());
                    int lastCard2 = int.Parse(Console.ReadLine());

                    if (lastCard1 > lastCard2)
                    {
                        Console.WriteLine($"{firstPlayer} is winner with {win1} points");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"{secondPlayer} is winner with {win2} points");
                        break;
                    }
                    comand1 = Console.ReadLine();

                }
            }
            if (comand1 == "End of game")
            {
                Console.WriteLine($"{firstPlayer} has {win1} points");
                Console.WriteLine($"{secondPlayer} has {win2} points");

            }

        }
    }
}
