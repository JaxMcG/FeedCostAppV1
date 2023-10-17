using System;
using System.Collections.Generic;

namespace FeedCostAppV1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> breedTypes = new List<string>() { "Friesian", "Jersey", "Ayrshire " };
            List<string> foodType = new List<string>() { "Palm Kernal", "Maize", "Hay" };
            List<float> foodPrice = new List<float>() { 1.69625f, 0.4556f, 0.113f };
            int cowCount = 1;

            Console.WriteLine("----------Cow Testing----------");

            Cow testCow = new Cow("Friesian", new DateTime(2019, 05, 09, 9, 15, 0), 0);

            testCow.CreateId(cowCount);

            testCow.GetDailyFoodConsumed();

            testCow.CalculateWeeklyCost(1.69625f);

            Console.WriteLine(testCow.DisplaySingleSummary(1.69625f, "Palm Kernal"));

            Console.WriteLine("----------FeedManager Testing----------");

            FeedManager fm = new FeedManager();

            fm.CalculateTotalFoodConsumed();

            fm.CalculateTotalFoodCost();

            Console.WriteLine(fm.DisplayTotalSummary());
        }
    }
}
