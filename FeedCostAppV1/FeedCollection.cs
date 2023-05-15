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

        //public DateTime(int year, int month, int day)
        //{
            
        //}

        //Set Species to Cow
        public void SetSpecies()
        {
            species = "Cow";
        }

        //Returns the Value in the Private breed Variable
        public List<int> GetBreed()
        {
            return breedChoice;
        }

        //Create Id for Each Animal
        public string CreateId()
        {
            //Give it the letter C for species
            //Get first 3 letters of the breed
            //Give it a number starting at 1
            //Give it the year it was born
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
            //Get amount of food eaten each day
            //Add them together to get weekly amount
            //Create variable storing total food eaten
            //Loop through the list of food eaten and get last weeks consumption
            //Add the food eaten in the past week to the total (new variable)

            return 0;
        }

        //Calculate the Cost for the Food Eaten that Week
        public float CalculateWeeklyCost()
        {
            //Get the amount of food eaten for the week
            //Get the price of the food
            //Multiply the food eaten for the week by the price

            return 0;
        }

        //Display a Summary of the Food Eaten Plus the Cost
        public string DisplaySingleSummary()
        {
            //Display the species, breed, id and food type
            //Display the daily food eaten
            //Display the total food consumed
            //Display the total cost
            return "";
        }

        public override string ToString()
        {
            return "";
        }
    }
}
