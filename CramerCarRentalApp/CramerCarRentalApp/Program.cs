using System;

namespace CramerCarRentalApp
{
    class Program
    {
        static void Main(string[] args)
        {
            const double dayFee = 20.00;
            const double mileFee = 0.25;

            Console.WriteLine("****CRAMER'S CAR RENTAL FEE APP****");
            Console.Write("How many days will you be renting the car for? ");
            int numOfDays = Convert.ToInt32(Console.ReadLine());
            Console.Write("How many miles will you drive the car for? ");
            double numOfMiles = Convert.ToDouble(Console.ReadLine());
            double result = (dayFee * numOfDays) + (mileFee * numOfMiles);
            Console.WriteLine("Your total rental fee is " + "$" + result);

            Console.ReadLine();
        }
    }
}
