using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedCostAppV1
{
    class FeedManager
    {
        private List<Cow> cow = new List<Cow>();
        private List<string> breedTypes = new List<string>() { "Friesian", "Jersey", "Ayrshire " };
        private List<string> foodType = new List<string>() {"Palm Kernal", "Maize", "Hay" };
        private List<float> foodPrice = new List<float>() { 1.69625f, 0.4556f, 0.113f };
        private List<float> newFoodPrice = new List<float>();

        //Constructor
        public FeedManager()
        {

        }

        //Get the Total Amount of Cows Added and Then Add 1 to the Id Number
        public int IdCounter()
        {
            int Idnum = 0;

            foreach (Cow cow in cow)
            {
                Idnum++;
            }

            return Idnum;
        }

        //Calculate the Total Food Consumed By Every Cow for the Week
        public float CalculateTotalFoodConsumed()
        {
            float totalFoodConsumed = 0;

            foreach (Cow cow in cow)
            {
                totalFoodConsumed += cow.CalculateWeeklyFoodConsumed();
            }
            
            return totalFoodConsumed;
        }

        //Calculate the Total Cost of Food for CalculateTotalFoodConsumed()
        public float CalculateTotalFoodCost(float foodPrices = 0)
        {
            float totalFoodCost =  foodPrices * CalculateTotalFoodConsumed();

            return totalFoodCost;            
        }

        //Calculate the Recommended Food that Should Be Consumed
        public void CalculateRecommendedFoodConsumption(Cow cow)
        {
            if (cow.CalculateWeeklyFoodConsumed() < 126)
            {
                Console.WriteLine($"Cow {cow.CreateId()} is eating less than the recommended amount of food per week");
            }
            else if (cow.CalculateWeeklyFoodConsumed() > 200)
            {
                Console.WriteLine($"Cow {cow.CreateId()} is eating more than the recommended amount of food per week");
            }
            else
            {
                Console.WriteLine($"Cow {cow.CreateId()} is eating within the recommended amount of food per week");
            }
        }

        //Calculate Any Eating Improvements Made By Any of the Animals
        public string CalculateEatingImprovements()
        {
            return "";
        }

        //Change the Prices of Each type of Food
        public void ChangeFoodPrices()
        {
            foodPrice = newFoodPrice;
        }

        //Display a Summary of the Total Food Eaten Plus the Cost, and Recommended Food Eaten (All Animals, Not Just One)
        public string DisplayTotalSummary(float foodPrices)
        {
            string totalSummary = $"Total Food Consumed: {CalculateTotalFoodConsumed()}\n" +
                $"Total Cost: ${CalculateTotalFoodCost()}\n" +
                $"";
            return totalSummary;
        }

        //Display the Previous Summary
        public string DisplayPreviouSummary()
        {
            return "";
        }
    }
}
