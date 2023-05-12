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

        //Stores the Amount of Food Eaten Daily
        private List<float> dailyFoodConsumed = new List<float>();
        //Stores the Indexs of the Breed that Has Been Selected
        private List<int> breedChoice = new List<int>();
        //Stores the Indexs of the Food that Has Been Selected
        private List<int> foodChoice = new List<int>();
        //Stores a List of the Different Types of Food Available
        private List<string> foodType = new List<string>() {"Palm Kernal", "Hay", "Maize" };


        //Constructor
        public FeedCollection()
        {

        }

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


            return 0;
        }

        //Calculate the Cost for the Food Eaten that Week
        public float CalculateWeeklyCost()
        {
            return 0;
        }

        //Display a Summary of the Food Eaten Plus the Cost
        public string DisplaySingleSummary()
        {
            return "";
        }

        public override string ToString()
        {
            return "";
        }
    }
}
