﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueTypeEquality
{
    class Program
    {
        static void Main(string[] args)
        {
            var foodItems = new HashSet<FoodItem>(FoodNameEqualityComparer.Instance);
            foodItems.Add(new FoodItem("apple", FoodGroup.Fruit));
            foodItems.Add(new FoodItem("pear", FoodGroup.Fruit));
            foodItems.Add(new FoodItem("pineapple", FoodGroup.Fruit));
            foodItems.Add(new FoodItem("Apple", FoodGroup.Fruit));

            foreach (var foodItem in foodItems)
                Console.WriteLine(foodItem);
        }
    }
}
