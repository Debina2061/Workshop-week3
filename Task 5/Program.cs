
public class Program
{
    public static void Main(string[] args)
    {
        // Task 1: Sum from 1 to N using for loop
        Console.Write("Enter a number N: ");
        int N = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        for (int i = 1; i <= N; i++)
        {
            sum += i;
        }
        Console.WriteLine($"Sum from 1 to {N} is: {sum}");

        Console.WriteLine("\nNumbers from 1 to 20 (skipping multiples of 4, stopping at 15):");
        
        int num = 1;
        while (num <= 20)
        {
            if (num % 4 == 0)
            {
                num++;
                continue;
            }
            if (num == 15)
                break; 

            Console.Write(num + " ");
            num++;
        }

        Console.WriteLine("\n\nTask 3: Sum of all elements in an array using foreach loop");
        int[] arr = { 5, 10, 15, 20, 25 };
        int arraySum = 0;
        foreach (int element in arr)
        {
            arraySum += element;
        }
        Console.WriteLine("Sum of array elements: " + arraySum);
    }
}
