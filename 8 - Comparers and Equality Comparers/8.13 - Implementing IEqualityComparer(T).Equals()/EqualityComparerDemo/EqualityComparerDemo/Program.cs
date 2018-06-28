﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualityComparerDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var foodItems = new HashSet<FoodItem>();
            foodItems.Add(new FoodItem("apple", FoodGroup.Fruit));
            foodItems.Add(new FoodItem("pear", FoodGroup.Fruit));
            foodItems.Add(new FoodItem("pineapple", FoodGroup.Fruit));
            foodItems.Add(new FoodItem("Apple", FoodGroup.Fruit));

            foreach (var foodItem in foodItems)
                Console.WriteLine(foodItem);
        }
    }
}
