
public class Program
{
    public static void Main(string[] args)
    {
        // Ask the user for their age
        Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        // Using if-else-if
        if (age < 13)
        {
            Console.WriteLine("Child");
        }
        else if (age >= 13 && age <= 19)
        {
            Console.WriteLine("Teenager");
        }
        else
        {
            Console.WriteLine("Adult");
        }

        // Using switch expression
        string category = age switch
        {
            < 13 => "Child",
            >= 13 and <= 19 => "Teenager",
            _ => "Adult"
        };

        Console.WriteLine($"(Using switch) You are a {category}.");
    }
}
