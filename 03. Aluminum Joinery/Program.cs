using System;

namespace _03._Aluminum_Joinery
{
    class Program
    {
        static void Main(string[] args)
        {
            int joineryNumber = int.Parse(Console.ReadLine());
            string joineryType = Console.ReadLine();
            double price = 0;

            if (joineryType == "90X130")
            {
                price = joineryNumber * 110;
                if (joineryNumber > 30)
                {
                    price -= price * 5 / 100;
                }
                else if (joineryNumber > 60)
                {
                    price -= price * 8 / 100;
                }
            }
            else if (joineryType == "100X150")
            {
                price = joineryNumber * 140;
                if (joineryNumber > 40)
                {
                    price -= price * 6/ 100;
                }
               else  if (joineryNumber > 80)
                {
                    price -= price * 10 / 100;
                }
                

            }
            else if (joineryType== "130X180")
            {
                price = joineryNumber * 190;
                if (joineryNumber > 20)
                {
                    price -= price * 7 / 100;
                }
                else if  (joineryNumber > 50)
                {
                    price -= price * 12 / 100;
                }

            }
            else
            {
                price = joineryNumber * 250;
                if (joineryNumber > 25)
                {
                    price -= price * 9 / 100;
                }
               else  if (joineryNumber > 50)
                {
                    price -= price * 14 / 100;
                }

            }
            string input = Console.ReadLine();
            if (input == "With delivery")
            {
                price+= 60;

            }
            else
            {
                
            }
            double totalPrice = price;
            if (joineryNumber > 99)
            {
                totalPrice -= totalPrice * 4 / 100;

            }
            if (joineryNumber < 10)
            {
                Console.WriteLine("Invalid order");
            }
            Console.WriteLine($"{totalPrice} BGN");
        }
    }
}
