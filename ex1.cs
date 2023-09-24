using System;

public class Exercise_01
{
    public void run()
    {
        float grade;

        while (true)
        {
            Console.Write("Enter a grade between zero and ten: ");
            if (float.TryParse(Console.ReadLine(), out grade) && grade >= 0 && grade <= 10)
                break;
            else
                Console.WriteLine("Invalid value! Please enter a grade between zero and ten.");
        }

        Console.WriteLine("Valid grade: " + grade);
    }
}
