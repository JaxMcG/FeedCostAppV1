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

            Console.WriteLine("----------Cow Testing----------");

            Cow testCow = new Cow("Friesian", "Maize", new DateTime(2023));

            List<float> weeksConsumption = new List<float>() {};         

            testCow.GetDailyFoodConsumed();

            testCow.CalculateWeeklyCost(foodPrice);

            testCow.CalculateRecommendedFoodConsumption();

            Console.WriteLine(testCow.DisplaySingleSummary(foodPrice, foodType));
    }
    }
}
