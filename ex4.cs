using System;

public class Exercise_04
{
    public void run()
    {
        int numberOfNumbers = 5;
        int sum = 0;

        for (int i = 1; i <= numberOfNumbers; i++)
        {
            Console.Write($"Enter the {i}th number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            sum += number;
        }

        double average = (double)sum / numberOfNumbers;

        Console.WriteLine($"The sum of the numbers is: {sum}");
        Console.WriteLine($"The average of the numbers is: {average}");
    }
}
