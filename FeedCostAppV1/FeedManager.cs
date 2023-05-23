using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedCostAppV1
{
    class FeedManager
    {
        private List<FeedCollection> feedCollection = new List<FeedCollection>();
        private List<string> breedTypes = new List<string>() { "Friesian", "Jersey", "Ayrshire " };
        private List<string> foodType = new List<string>() {"Palm Kernal", "Maize", "Hay" };
        private List<float> foodPrice = new List<float>() { 1.69625f, 0.4556f, 0.113f };
        
        //Constructor
        public FeedManager()
        {

        }

        //Calculate the Total Food Consumed By Every Cow for the Week
        public float CalculateTotalFoodConsumed()
        {
            float totalFoodConsumed = 0;

            foreach (FeedCollection feedCollection in feedCollection)
            {
                totalFoodConsumed += feedCollection.CalculateWeeklyFoodConsumed();
            }
            
            return totalFoodConsumed;
        }

        //Calculate the Total Cost of Food for CalculateTotalFoodConsumed()
        public float CalculateTotalFoodCost(float foodPrices)
        {
            float totalFoodCost =  foodPrices * CalculateTotalFoodConsumed();

            return totalFoodCost;            
        }

        //Calculate the Recommended Food that Should Be Consumed
        public void CalculateRecommendedFoodConsumption(FeedCollection feedCollection)
        {
            if (feedCollection.CalculateWeeklyFoodConsumed() < 126)
            {
                Console.WriteLine($"Animal {feedCollection.CreateId()} is eating less than the recommended amount of food per week");
            }
            else if (feedCollection.CalculateWeeklyFoodConsumed() > 200)
            {
                Console.WriteLine($"Animal {feedCollection.CreateId()} is eating more than the recommended amount of food per week");
            }
            else
            {
                Console.WriteLine($"Animal {feedCollection.CreateId()} is eating within the recommended amount of food per week");
            }
        }

        //Calculate Any Eating Improvements Made By Any of the Animals
        public string CalculateEatingImprovements()
        {
            return "";
        }

        //Change the Prices of Each type of Food
        public float ChangeFoodPrices()
        {
            return 0;
        }

        //Display a Summary of the Total Food Eaten Plus the Cost, and Recommended Food Eaten (All Animals, Not Just One)
        public string DisplayTotalSummary()
        {
            return "";
        }

        //Display the Previous Summary
        public string DisplayPreviouSummary()
        {
            return "";
        }
    }
}
