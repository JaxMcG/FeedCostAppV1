using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedCostAppV1
{
    class Cow
    {
        private List<FeedManager> feedManager = new List<FeedManager>();

        //Attributes or Fields
        private string species;
        private string breed;
        private DateTime dob;


        //Stores the Indexs of the Food that Has Been Selected
        private List<int> foodChoice = new List<int>();
        //Stores the Amount of Food Eaten Daily
        private List<float> dailyFoodAmount = new List<float>();

        //Constructor
        public Cow(string species, string breed, DateTime dob)
        {
            this.species = species;
            this.breed = breed;
            this.dob = dob;
        }

        //Set Species to Cow
        public void SetSpecies(string species)
        {
            this.species = species;
        }

        //Returns the Value in the Private breed Variable
        public string GetBreed()
        {
            return breed;
        }

        //Create Id for Each Animal
        public string CreateId()
        {
            string id = "C" + breed.Substring(0, 3).ToUpper() + dob;

            return id;
        }

        //Returns the Value in the Private foodType Variable
        public List<int> GetFoodType()
        {
            return foodChoice;
        }

        //Get the Amount of Food Eaten Each Day
        public List<float> GetDailyFoodConsumed()
        {
            List<float> weeksConsumption = new List<float>();

            for (int dailyFoodIndex = dailyFoodAmount.Count - 7; dailyFoodIndex < dailyFoodAmount.Count; dailyFoodIndex++)
            {
                weeksConsumption.Add(dailyFoodAmount[dailyFoodIndex]);
            }

            return weeksConsumption;
        }

        //Calculate the Amount of Food Eaten in a Week
        public float CalculateWeeklyFoodConsumed()
        {
            float weeklyFoodConsumed = 0f;

            for (int foodIndex = 0; foodIndex < dailyFoodAmount.Count; foodIndex++)
            {
                weeklyFoodConsumed = dailyFoodAmount[foodIndex];
            }

            return weeklyFoodConsumed;
        }

        //Calculate the Cost for the Food Eaten that Week
        public float CalculateWeeklyCost(float fPrices)
        {
            float totalCost = fPrices * CalculateWeeklyFoodConsumed();

            return totalCost;
        }

        //Display a Summary of the Food Eaten Plus the Cost
        public string DisplaySingleSummary(float fPrices)
        {
            string summary = $"Species: {species}\nBreed: {breed}\nId: {CreateId()}\nType Of Food: {foodChoice}\n" +
                $"Food Eaten:\n{dailyFoodAmount}\n\nTotal Food Eaten: {CalculateWeeklyFoodConsumed()}kg\nTotal Cost: ${CalculateWeeklyCost(fPrices)}";

            return summary;
        }

        public override string ToString()
        {
            return "";
        }
    }
}
