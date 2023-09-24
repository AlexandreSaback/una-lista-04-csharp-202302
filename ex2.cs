using System;

public class Exercise_02
{
    public void run()
    {
        while (true)
        {
            Console.Write("Enter the username: ");
            string username = Console.ReadLine();

            Console.Write("Enter the password: ");
            string password = Console.ReadLine();

            if (password != username)
                break;
            else
                Console.WriteLine("Error: the password cannot be the same as the username. Please try again.");
        }

        Console.WriteLine("Registration completed successfully!");
    }
}
