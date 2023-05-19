using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedCostAppV1
{
    class FeedCollection
    {

        //Attributes or Fields
        private string species;
        private string breed;
        private string id;
        private int birthYear;

        //Stores the Indexs of the Breed that Has Been Selected
        private List<int> breedChoice = new List<int>();
        //Stores the Indexs of the Food that Has Been Selected
        private List<int> foodChoice = new List<int>();
        //Stores the Amount of Food Eaten Daily
        private List<float> dailyFoodAmount = new List<float>();

        //Constructor
        public FeedCollection()
        {

        }
        
        //Set Species to Cow
        public string SetSpecies()
        {
            species = "Cow";

            return species;
        }

        //Returns the Value in the Private breed Variable
        public List<int> GetBreed()
        {
            return breedChoice;
        }

        //Get the Year the Cow Was Born
        public int GetYearOfBirth()
        {
            return birthYear;
        }

        //Create Id for Each Animal
        public string CreateId()
        {
            //Give it the letter C for species
            //Get first 3 letters of the breed
            //Give it a number starting at 1
            //Give it the year it was born
            string firstThreeChar = new string(breed.Take(3).ToArray());

            id = $"C{firstThreeChar}{GetYearOfBirth()}";

            return id;
        }

        //Returns the Value in the Private foodType Variable
        public List<int> GetFoodType()
        {
            return foodChoice;
        }

        //Get the Amount of Food Eaten Each Day
        public float GetDailyFoodConsumed()
        {
            return 0;
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
            //Display the species, breed, id and food type
            //Display the daily food eaten
            //Display the total food consumed
            //Display the total cost
            string summary = $"Species: {SetSpecies()}\nBreed: {breedChoice}\nId: {CreateId()}\nType Of Food: {foodChoice}\n" +
                $"Food Eaten:\n{dailyFoodAmount}\n\nTotal Food Eaten: {CalculateWeeklyFoodConsumed()}kg\nTotal Cost: ${CalculateWeeklyCost(fPrices)}";

            return summary;
        }

        public override string ToString()
        {
            return "";
        }
    }
}
