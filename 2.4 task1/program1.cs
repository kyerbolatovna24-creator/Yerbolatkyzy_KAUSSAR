using System;

class Program
{
    static void Main()
    {
        // Input
        Console.Write("Enter Coffee Name: ");
        string coffeeName = Console.ReadLine();

        Console.Write("Enter Price per Cup: ");
        double pricePerCup = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Number of Cups: ");
        int numberOfCups = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Sugar Portions: ");
        int sugarPortions = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Extra Topping Price: ");
        double extraToppingPrice = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter First Letter of Size: ");
        char sizeLetter = Convert.ToChar(Console.ReadLine());

        Console.Write("Is Takeaway (true/false): ");
        bool isTakeaway = Convert.ToBoolean(Console.ReadLine());

        // Calculations
        double coffeeCost = pricePerCup * numberOfCups;
        double sugarCost = sugarPortions * 0.2;

        double totalPrice = coffeeCost;
        totalPrice += sugarCost;          // compound operator
        totalPrice += extraToppingPrice;  // compound operator

        // Output
        Console.WriteLine("\n--- ORDER DETAILS ---");
        Console.WriteLine("Coffee Name: " + coffeeName);
        Console.WriteLine("Price per Cup: " + pricePerCup);
        Console.WriteLine("Number of Cups: " + numberOfCups);
        Console.WriteLine("Sugar Portions: " + sugarPortions);
        Console.WriteLine("Extra Topping Price: " + extraToppingPrice);
        Console.WriteLine("Size Letter: " + sizeLetter);
        Console.WriteLine("Is Takeaway: " + isTakeaway);

        Console.WriteLine("\n--- CALCULATIONS ---");
        Console.WriteLine("Coffee Cost: " + coffeeCost);
        Console.WriteLine("Sugar Cost: " + sugarCost);
        Console.WriteLine("Total Order Price: " + totalPrice);
    }
}