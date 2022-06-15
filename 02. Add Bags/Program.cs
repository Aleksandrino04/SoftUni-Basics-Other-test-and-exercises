using System;

namespace _02._Add_Bags
{
    class Program
    {
        static void Main(string[] args)
        {
            double luggageOver20KgPrice = double.Parse(Console.ReadLine());
            double luggageKilograms = double.Parse(Console.ReadLine());
            int daysTillTrip = int.Parse(Console.ReadLine());
            int numberOfLuggage = int.Parse(Console.ReadLine());

            double luggageTax = 0;
            double finalPrice = 0;

            if (luggageKilograms < 10)
            {
                luggageTax = luggageOver20KgPrice * 0.20;
            }
            else if (luggageKilograms >= 10 && luggageKilograms <= 20)
            {
                luggageTax = luggageOver20KgPrice * 0.50;
            }
            else if (luggageKilograms > 20)
            {
                luggageTax = luggageOver20KgPrice;
            }

            double increase = 0;

            if (daysTillTrip > 30)
            {
                increase = luggageTax + luggageTax * 0.10;
            }
            else if (daysTillTrip >= 7 && daysTillTrip <= 30)
            {
                increase = luggageTax + luggageTax * 0.15;
            }
            else if (daysTillTrip < 7)
            {
                increase = luggageTax + luggageTax * 0.40;
            }

            finalPrice = increase * numberOfLuggage;
            Console.WriteLine($"The total price of bags is: {finalPrice:f2} lv.");

        }
    }
}
