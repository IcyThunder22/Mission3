/* Summary
This program implements a Food Bank Inventory System, which allows users to manage an inventory of food items.
Users can perform the following actions:
 1. Add a new food item to the inventory, including its name, category, quantity, and expiration date.
 2. Delete an existing food item by its name.
 3. View the list of all current food items in the inventory.
 4. Exit the program.
The program ensures data validation for quantity (must be positive) and expiration date (must be in the future).
*/

// Setup
using Mission3;
string userAction = "";

// Call classes
FoodItem oMenuAction = new FoodItem();

while (true)
{
    // Display Menu
    Console.WriteLine("Select one of the following actions:");
    Console.WriteLine("1. Add Food Item ");
    Console.WriteLine("2. Delete Food Item ");
    Console.WriteLine("3. Print Current Food Item List ");
    Console.WriteLine("4. Exit Program");
    userAction = Console.ReadLine();

    switch (userAction)
    {
        case "1":
            // Add Food
            oMenuAction.AddFoodItem();
            break;

        case "2":
            // Delete Food
            oMenuAction.DeleteFoodItem();
            break;

        case "3":
            // Print Foods
            oMenuAction.PrintFoodItems();
            break;

        case "4":
            // Exit
            Console.WriteLine("Exiting Program...");
            return;

        default:
            // Handle invalid menu options
            Console.WriteLine("Invalid choice. Please try again.");
            break;
    }

    // Pause to allow the user to see results before routing back to the menu
    Console.WriteLine("\nPress Enter to return to the menu...");
    Console.ReadLine();
}
