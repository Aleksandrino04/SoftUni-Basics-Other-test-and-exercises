using System;

namespace _04._Balls
{
    class Program
    {
        static void Main(string[] args)
        {
            int ballsNumber = int.Parse(Console.ReadLine());
            double points = 0;
            double redCount = 0;
            double orangeCount = 0;
            double yellowCount = 0;
            double whiteCount = 0;
            double blackCount = 0;
            double otherCount = 0;
            
            for (int i = 1 ; i <= ballsNumber ; i++)
            {
                string color = Console.ReadLine();
                if (color == "red")
                {
                    points += 5;
                    redCount++;
                }
                else if (color == "orange")
                {
                    points += 10;
                    orangeCount++;
                }
                else if (color == "yellow")
                {
                    points += 15;
                    yellowCount++;

                }
                else if (color == "white")
                {
                    points += 20;
                    whiteCount++;
                }
                else if (color == "black")
                {
                    points = Math.Floor(points / 2);
                    blackCount++;
                }
                else
                {
                    otherCount++;
                }

            }
            Console.WriteLine($"Total points: {points}");
            Console.WriteLine($"Red balls: {redCount}");
            Console.WriteLine($"Orange balls: {orangeCount}");
            Console.WriteLine($"Yellow balls: {yellowCount}");
            Console.WriteLine($"White balls: {whiteCount}");
            Console.WriteLine($"Other colors picked: {otherCount}");
            Console.WriteLine($"Divides from black balls: {blackCount}");












        }
    }
}
