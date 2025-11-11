using System;

public class Operators
{
    public void Add(int a, int b)
    {
        Console.WriteLine("Sum: " + (a + b));
    }

    public void Subtract(int a, int b)
    {
        Console.WriteLine("Difference: " + (a - b));
    }

    public void Multiply(int a, int b)
    {
        Console.WriteLine("Product: " + (a * b));
    }

    public void Divide(int a, int b)
    {
        if (b != 0)
            Console.WriteLine("Division: " + ((double)a / b));
        else
            Console.WriteLine("Cannot divide by zero!");
    }

    public void OddEvenFinder(int number)
    {
        string result = (number % 2 == 0) ? "Even Number" : "Odd Number";
        Console.WriteLine(result);
    }
}

public class NullOperations
{
    public void PerformNullChecks()
    {
        // Step 1: Declare a string variable and assign null
        string username = null;

        // Step 2: Use Ternary Operator (? :) to check for null
        string message = (username == null) ? "Username is not available" : username;
        Console.WriteLine(message);

        // Step 3: Use Null-Coalescing Operator (??)
        string result = username ?? "Default Username (using ??)";
        Console.WriteLine(result);

        // Step 4: Use Null-Coalescing Assignment Operator (??=)
        username ??= "AssignedUsername";
        Console.WriteLine("Updated Username: " + username);
    }
}
