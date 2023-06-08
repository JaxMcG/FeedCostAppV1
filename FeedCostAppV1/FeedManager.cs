using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedCostAppV1
{
    class FeedManager
    {
        private List<Cow> cows = new List<Cow>();
        private List<string> breedTypes = new List<string>() { "Friesian", "Jersey", "Ayrshire " };
        private List<string> foodType = new List<string>() {"Palm Kernal", "Maize", "Hay" };
        private List<float> foodPrice = new List<float>() { 1.69625f, 0.4556f, 0.113f };
        private List<float> newFoodPrice = new List<float>();
        private List<string> AddSum = new List<string>();

        //Constructor
        public FeedManager()
        {

        }

        //Add a Cow to the List 
        public void AddCow(Cow newCow)
        {
            cows.Add(newCow);

            cows[cows.Count - 1].CreateId(cows.Count);
        }

        //Calculate the Total Food Consumed By Every Cow for the Week
        public List<float> CalculateTotalFoodConsumed(List<float> weeksConsumption)
        {
            List<float> totalFoodConsumed = new List<float>() {0, 0, 0 };

            foreach (Cow cow in cows)
            {
                for (int index = 0; index < 3; index++)
                {
                    totalFoodConsumed[index] += cow.GetDailyFoodConsumed(weeksConsumption)[index];
                }  
            }
            
            return totalFoodConsumed;
        }

        //Calculate the Total Cost of Food for CalculateTotalFoodConsumed()
        public List<float> CalculateTotalFoodCost(List<float> weeksConsumption, float foodPrices = 0)
        {
            List<float> totalFoodCost = new List<float>() {0, 0, 0 };

            for (int index = 0; index < 3; index++)
            {
                totalFoodCost[index] = foodPrices * CalculateTotalFoodConsumed(weeksConsumption)[index];
            }

            return totalFoodCost;            
        }



        //Change the Prices of Each type of Food
        public void ChangeFoodPrices()
        {
            foodPrice = newFoodPrice;
        }

        //Display a Summary of the Total Food Eaten Plus the Cost, and Recommended Food Eaten (All Animals, Not Just One)
        public string DisplayTotalSummary(List<float> weeksConsumption)
        {
            string totalSummary = $"Total Summary\n" +
                $"Total Food Consumed: {CalculateTotalFoodConsumed(weeksConsumption)}\n" +
                $"Total Cost: ${CalculateTotalFoodCost(weeksConsumption)}\n\n";
            return totalSummary;
        }

        public List<string> AddSummaryToList(List<float> weeksConsumption)
        {
            AddSum.Add(DisplayTotalSummary(weeksConsumption));

            return AddSum;
        }

        //Display the Previous Summary
        public string DisplayPreviouSummary()
        {
            string previousSummary = "";

            for (int sumIndex = 0; sumIndex < AddSum.Count - 1; sumIndex++)
            {
                previousSummary = AddSum[sumIndex];
            }

            return previousSummary;
        }
    }
}
