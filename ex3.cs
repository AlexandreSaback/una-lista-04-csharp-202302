using System;

public class Exercise_03
{
    public void run()
    {
        string name;
        int age;
        float salary;
        char gender;
        char maritalStatus;

        while (true)
        {
            Console.Write("Enter the name (more than 3 characters): ");
            name = Console.ReadLine();

            if (name.Length > 3)
                break;
            else
                Console.WriteLine("Error: the name should have more than 3 characters.");
        }

        while (true)
        {
            Console.Write("Enter the age (between 0 and 150): ");
            if (int.TryParse(Console.ReadLine(), out age) && age >= 0 && age <= 150)
                break;
            else
                Console.WriteLine("Error: the age should be between 0 and 150.");
        }

        while (true)
        {
            Console.Write("Enter the salary (greater than zero): ");
            if (float.TryParse(Console.ReadLine(), out salary) && salary > 0)
                break;
            else
                Console.WriteLine("Error: the salary should be greater than zero.");
        }

        while (true)
        {
            Console.Write("Enter the gender (f or m): ");
            if (char.TryParse(Console.ReadLine(), out gender) && (gender == 'f' || gender == 'm'))
                break;
            else
                Console.WriteLine("Error: gender should be f or m.");
        }

        while (true)
        {
            Console.Write("Enter the marital status (s, c, v, or d): ");
            if (char.TryParse(Console.ReadLine(), out maritalStatus) && (maritalStatus == 's' || maritalStatus == 'c' || maritalStatus == 'v' || maritalStatus == 'd'))
                break;
            else
                Console.WriteLine("Error: marital status should be s, c, v, or d.");
        }

        Console.WriteLine("Valid information:");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Salary: " + salary);
        Console.WriteLine("Gender: " + gender);
        Console.WriteLine("Marital Status: " + maritalStatus);
    }
}
