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

            List<float> dailyFoodAmount = new List<float>() {20.5f, 17.4f, 18.6f, 23.2f, 19f, 19.6f, 18.1f};

            testCow.GetDailyFoodConsumed(dailyFoodAmount);

            testCow.CalculateWeeklyCost(foodPrice, dailyFoodAmount);

            testCow.CalculateRecommendedFoodConsumption();

            Console.WriteLine(testCow.DisplaySingleSummary(foodPrice, foodType, dailyFoodAmount));
    }
    }
}
