using System;

class Program
{
    static void Main(string[] args)
    {
        // Exercise 1
        Console.WriteLine("Exercise 1:");
        Console.Write("Enter first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        if (num1 == num2)
            Console.WriteLine("The numbers are equal");
        else if (num1 > num2)
            Console.WriteLine("The first number is greater than the second");
        else
            Console.WriteLine("The first number is less than the second");

        Console.WriteLine();


        // Exercise 2
        Console.WriteLine("Exercise 2:");
        Console.Write("Enter a number: ");
        double number = Convert.ToDouble(Console.ReadLine());

        if (number > 5 && number < 10)
            Console.WriteLine("The number is greater than 5 and less than 10");
        else
            Console.WriteLine("Unknown number");

        Console.WriteLine();


        // Exercise 3
        Console.WriteLine("Exercise 3:");
        Console.Write("Enter a number: ");
        number = Convert.ToDouble(Console.ReadLine());

        if (number == 5 || number == 10)
            Console.WriteLine("The number is either 5 or 10");
        else
            Console.WriteLine("Unknown number");

        Console.WriteLine();


        // Exercise 4
        Console.WriteLine("Exercise 4:");
        Console.Write("Enter deposit amount: ");
        double deposit = Convert.ToDouble(Console.ReadLine());
        double interestRate;

        if (deposit < 100)
            interestRate = 0.05;
        else if (deposit >= 100 && deposit <= 200)
            interestRate = 0.07;
        else
            interestRate = 0.10;

        double finalAmount = deposit + deposit * interestRate;
        Console.WriteLine("Deposit amount including interest: " + finalAmount);

        Console.WriteLine();


        // Exercise 5
        Console.WriteLine("Exercise 5:");
        Console.Write("Enter deposit amount: ");
        deposit = Convert.ToDouble(Console.ReadLine());

        if (deposit < 100)
            interestRate = 0.05;
        else if (deposit >= 100 && deposit <= 200)
            interestRate = 0.07;
        else
            interestRate = 0.10;

        finalAmount = deposit + deposit * interestRate + 15;
        Console.WriteLine("Deposit amount including interest and bonus: " + finalAmount);

        Console.WriteLine();


        // Exercise 6
        Console.WriteLine("Exercise 6:");
        Console.WriteLine("Enter operation number: 1.Addition 2.Subtraction 3.Multiplication");
        int operation = Convert.ToInt32(Console.ReadLine());

        switch (operation)
        {
            case 1:
                Console.WriteLine("Addition");
                break;
            case 2:
                Console.WriteLine("Subtraction");
                break;
            case 3:
                Console.WriteLine("Multiplication");
                break;
            default:
                Console.WriteLine("Operation is undefined");
                break;
        }

        Console.WriteLine();


        // Exercise 7
        Console.WriteLine("Exercise 7:");
        Console.WriteLine("Enter operation number: 1.Addition 2.Subtraction 3.Multiplication");
        operation = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter first number: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter second number: ");
        double b = Convert.ToDouble(Console.ReadLine());

        switch (operation)
        {
            case 1:
                Console.WriteLine("Result: " + (a + b));
                break;
            case 2:
                Console.WriteLine("Result: " + (a - b));
                break;
            case 3:
                Console.WriteLine("Result: " + (a * b));
                break;
            default:
                Console.WriteLine("Operation is undefined");
                break;
        }
    }
}
