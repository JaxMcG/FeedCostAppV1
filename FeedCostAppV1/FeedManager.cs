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
        private List<string> breedTypes = new List<string>();
        private List<string> foodType = new List<string>();
        private List<float> foodPrice = new List<float>();

        //
        public FeedManager()
        {

        }

        //
        public int IdCounter()
        {
            return 1;
        }

        //
        public float CalculateTotalFoodConsumed()
        {
            return 0;
        }

        //
        public float CalculateTotalFoodCost()
        {
            return 0;
        }

        //
        public float CalculateRecommenedFoodConsumption()
        {
            return 0;
        }

        //
        public string CalculateEatingImprovements()
        {
            return "";
        }

        //
        public float ChangeFoodPrices()
        {
            return 0;
        }

        //
        public string DisplayTotalSummary()
        {
            return "";
        }

        //
        public string DisplayPreviouSummary()
        {
            return "";
        }

    }
}
