using System;

public class Exercise_06
{
    public void run()
    {
        Console.WriteLine("Enter the first integer:");
        int number1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second integer:");
        int number2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Numbers in the range:");

        if (number1 < number2)
        {
            for (int i = number1 + 1; i < number2; i++)
            {
                Console.WriteLine(i);
            }
        }
        else if (number2 < number1)
        {
            for (int i = number2 + 1; i < number1; i++)
            {
                Console.WriteLine(i);
            }
        }
        else
        {
            Console.WriteLine("The numbers are equal, there is no range.");
        }
    }
}
