using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission3
{
    internal class FoodItem
    {
        // Nested Array to store foodItem data
        public List<string[]> foodItems = new List<string[]>();

        // Method to add new food item
        public void AddFoodItem()
        {
            // Setup variables to collect data from the user
            string name = "";
            int quantity = 0;
            string category = "";

            // Collect food name from the user
            Console.WriteLine("Enter the food item name: ");
            name = Console.ReadLine();

            // Collect food category from the user
            Console.WriteLine(" Enter the food category (e.g., Canned Goods, Dairy, Produce): ");
            category = Console.ReadLine();

            // Validate and collect quantity from the user
            while (true)
            {
                Console.WriteLine("Enter the quantity: ");
                if (int.TryParse(Console.ReadLine(), out quantity) && quantity > 0)
                {
                    break;
                }
                else
                {
                    // Prompt the user for valid input if the entry is invalid
                    Console.WriteLine("Please enter a valid positive number for quantity.");
                }
            }

            // Validate and collect expiration date from the user
            DateTime expirationDate;
            while (true)
            {
                Console.Write("Enter the expiration date (MM/DD/YYYY): ");
                if (DateTime.TryParse(Console.ReadLine(), out expirationDate) && expirationDate >= DateTime.Now)
                {
                    break;
                }
                else
                {
                    // Prompt the user for valid input if the entry is invalid
                    Console.WriteLine("Please enter a valid future expiration date.");
                }
            }

            // Store food item information in an array and add it to the list
            foodItems.Add(new string[] { name, category, quantity.ToString(), expirationDate.ToShortDateString() });
            Console.WriteLine("Food item added successfully."); // Confirm addition to the user
        }

        // Method to display all food items
        public void PrintFoodItems()
        {
            // Check if the inventory is empty
            if (foodItems.Count == 0)
            {
                Console.WriteLine("No food items in inventory."); // Notify user if inventory is empty
            }
            else
            {
                // Display all food items in the inventory
                Console.WriteLine("\nCurrent Food Items:");
                foreach (var item in foodItems)
                {
                    // Print each food item's details
                    Console.WriteLine($"- Name: {item[0]}, Category: {item[1]}, Quantity: {item[2]}, Expiration Date: {item[3]}");
                }
            }
        }

        // Method to delete a food item
        public void DeleteFoodItem()
        {
            // Check if the inventory is empty before attempting to delete
            if (foodItems.Count == 0)
            {
                Console.WriteLine("No food items in inventory to delete."); // Notify user if inventory is empty
                return;
            }

            // Prompt user to enter the name of the food item to delete
            Console.WriteLine("Enter the name of the food item to delete: ");
            string nameToDelete = Console.ReadLine();

            // Find the item by name in the inventory
            var itemToRemove = foodItems.Find(item => item[0].Equals(nameToDelete, StringComparison.OrdinalIgnoreCase));

            if (itemToRemove != null)
            {
                // Remove the item if found and notify the user
                foodItems.Remove(itemToRemove);
                Console.WriteLine($"Food item '{nameToDelete}' deleted successfully.");
            }
            else
            {
                // Notify the user if no matching item is found
                Console.WriteLine($"No food item found with the name '{nameToDelete}'.");
            }
        }
    }
}
