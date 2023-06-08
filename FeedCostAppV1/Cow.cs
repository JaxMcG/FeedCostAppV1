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
        private string id;
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

        //
        public void AddFoodAmount(float dailyFoodAmount, int foodChoice)
        {
            this.foodChoice.Add(foodChoice);
            this.dailyFoodAmount.Add(dailyFoodAmount);
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
        public void CreateId(int cowCount)
        {
            id = "C" + breed.Substring(0, 3).ToUpper() + cowCount + dob;
        }

        //Returns the Value in the Private foodType Variable
        public List<int> GetFoodType()
        {
            return foodChoice;
        }

        //Get the Amount of Food Eaten Each Day
        public List<float> GetDailyFoodConsumed(List<float> dailyFoodAmount)
        {
            List<float> weeksConsumption = new List<float>() { 0, 0, 0 };

            for (int dailyFoodIndex = dailyFoodAmount.Count - 7; dailyFoodIndex < dailyFoodAmount.Count; dailyFoodIndex++)
            {
                weeksConsumption[foodChoice[dailyFoodIndex]] += dailyFoodAmount[dailyFoodIndex];
            }

            return weeksConsumption;
        }

        //Calculate the Cost for the Food Eaten that Week
        public float CalculateWeeklyCost(List<float> fPrices, List<float> dailyFoodAmount)
        {

            float totalCost = 0;
            //Loop Through for the Number of Food Types Calculating the Sum Cost
            for (int foodTypeIndex = 0; foodTypeIndex < 3; foodTypeIndex++)
            {
                totalCost += fPrices[foodTypeIndex] * GetDailyFoodConsumed(dailyFoodAmount)[foodTypeIndex];
            }
           
            return totalCost;
        }

        public float GetFoodConsumed()
        {
            float weeksConsumption = 0f;

            for (int dailyFoodIndex = dailyFoodAmount.Count - 7; dailyFoodIndex < dailyFoodAmount.Count; dailyFoodIndex++)
            {
                weeksConsumption += dailyFoodAmount[dailyFoodIndex];
            }

            return weeksConsumption;
        }

        //Calculate the Recommended Food that Should Be Consumed
        public string CalculateRecommendedFoodConsumption()
        {
            string recommendation = "";

            if (GetFoodConsumed() < 126)
            {
                recommendation = $"Cow {id} is eating {126 - GetFoodConsumed()}kg under the recommended amount of 126kg";
            }
            else if (GetFoodConsumed() > 200)
            {
                recommendation = $"Cow {id} is eating {GetFoodConsumed() - 200}kg over the recommended amount of 200kg";
            }
            else
            {
                recommendation = $"Cow {id} is eating {GetFoodConsumed()}kg which is within the recommended amount of 126kg - 200kg";
            }

            return recommendation;
        }

        //Display a Summary of the Food Eaten Plus the Cost
        public string DisplaySingleSummary(List<float> fPrices, List<string> foodType, List<float> dailyFoodAmount)
        {
            string summary = $"Species: {species}\nBreed: {breed}\nId: {id}\nType Of Food: {foodChoice}\n" +
                $"Food Eaten:\n{dailyFoodAmount}\n\nTotal Food Eaten:\n";

            for (int index = 0; index < 3; index++)
            {
                summary += $"{foodType[index]}: {GetDailyFoodConsumed(dailyFoodAmount)[index]}kg\n";
            }

            summary += $"Total Cost: ${CalculateWeeklyCost(fPrices, dailyFoodAmount)}\n" +
                $"Recommended Amount Of Food Consumed\n" +
                $"{CalculateRecommendedFoodConsumption()}";

            return summary;
        }

        public override string ToString()
        {
            return "";
        }
    }
}
