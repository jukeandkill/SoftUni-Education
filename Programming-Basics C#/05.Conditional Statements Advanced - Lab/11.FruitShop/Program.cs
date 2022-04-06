﻿using System;

namespace _11.FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            // плод   banana  apple   orange   grapefruit   kiwi    pineapple grapes
            // цена    2.50    1.20    0.85    1.45      2.70      5.50       3.85



            //плод   banana  apple   orange   grapefruit   kiwi    pineapple   grapes
            //цена    2.70    1.25    0.90      1.60         3.00      5.60       4.20

            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double count = double.Parse(Console.ReadLine());

            double price = 0;

            if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
            {
                switch (fruit)
                {
                    case "banana":
                        price = 2.50;
                        break;
                    case "apple":
                        price = 1.20;
                        break;
                    case "orange":
                        price = 0.85;
                        break;
                    case "grapefruit":
                        price = 1.45;
                        break;
                    case "kiwi":
                        price = 2.70;
                        break;
                    case "pineapple":
                        price = 5.50;
                        break;
                    case "grapes":
                        price = 3.85;
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (day == "Saturday" || day == "Sunday")
            {
                switch (fruit)
                {
                    case "banana":
                        price = 2.70;
                        break;
                    case "apple":
                        price = 1.25;
                        break;
                    case "orange":
                        price = 0.90;
                        break;
                    case "grapefruit":
                        price = 1.60;
                        break;
                    case "kiwi":
                        price = 3.00;
                        break;
                    case "pineapple":
                        price = 5.60;
                        break;
                    case "grapes":
                        price = 4.20;
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else
            {
                Console.WriteLine("error");
            }
            double finalPrice = count * price;

           if (finalPrice != 0)
            {
                Console.WriteLine($"{finalPrice:f2}");
            }
        }
    }
}
