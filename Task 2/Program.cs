
public class Program
{
    public static void Main(string[] args)
    {
        // Create object of Operators class
        Operators op = new Operators();
        op.Add(10, 5);
        op.Subtract(10, 5);
        op.Multiply(10, 5);
        op.Divide(10, 5);
        op.OddEvenFinder(10);
        op.OddEvenFinder(7);

        Console.WriteLine("\n--- Null Operations ---");

        // Create object of NullOperations class
        NullOperations no = new NullOperations();
        no.PerformNullChecks();
    }
}
