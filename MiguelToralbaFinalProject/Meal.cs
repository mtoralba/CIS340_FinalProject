// Miguel Toralba CIS-340 9:00AM Class
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiguelToralbaFinalProject
{
    class Meal
    {
        //Instance variable go here
        private string mealType;
        private double mealPrice;
        private int mealQuantityAvailable;

        //Default constructor method go here
        public Meal(string newType, double newPrice, int newQuantityAvailable)
        {
            mealType = newType;
            mealPrice = newPrice;
            mealQuantityAvailable = newQuantityAvailable;
        }

        //Instance methods go here

        //Retrieve Meal Type
        public string GetMealType()
        {
            return mealType;
        }

        //Retrieve Meal Price
        public double GetMealPrice()
        {
            return mealPrice;
        }

        //Retrieve Meal Quantity Available
        public int GetMealQuantityAvailable()
        {
            return mealQuantityAvailable;
        }
        //Set Meal Quantity Available
        public void SetMealQuantityAvailable(int newQuantityAvailable)
        {
            mealQuantityAvailable = newQuantityAvailable;
        }
    }
}
