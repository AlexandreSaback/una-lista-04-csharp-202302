using System;

public class Exercise_07
{
    public void run()
    {
        int evenCount = 0;
        int oddCount = 0;

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"Enter the {i}th integer:");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                evenCount++;
            }
            else
            {
                oddCount++;
            }
        }

        Console.WriteLine($"Quantity of even numbers: {evenCount}");
        Console.WriteLine($"Quantity of odd numbers: {oddCount}");
    }
}
