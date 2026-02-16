using System.Transactions;

namespace Homework5;

class Program
{
    static void Main(string[] args)
    {
        // Call Q1_method()
        Console.WriteLine("Give me the first number: ");
        string input1 = Console.ReadLine();
        int num1 = Convert.ToInt32(input1);

        Console.WriteLine("Give me the second number: ");
        string input2 = Console.ReadLine();
        int num2 = Convert.ToInt32(input2);

        int max1 = CompareNumbers(num1, num2);

        /*Console.WriteLine($"a = {num1}; b = {num2};");
        Console.WriteLine($"The Largest number is: {max1}");*/

        // Call Q2_method()
        Console.WriteLine("Give me the third number: ");
        string input3 = Console.ReadLine();
        int num3 = Convert.ToInt32(input3);

        Console.WriteLine("Give me the fourth number: ");
        string input4 = Console.ReadLine();
        int num4 = Convert.ToInt32(input4);

        int max2 = CompareNumbers(num3, num4);

        int max3 = CompareNumbers(max1, max2);

        Console.WriteLine($"a = {num1}; b = {num2}; c = {num3}; d = {num4};");
        Console.WriteLine($"The largest number is: {max3}");



        // Call Q3_method()
        createAccount();

    }

    //Q1_method() and Q2_method()
    static int CompareNumbers(int a, int b)
    {
        if (a > b)
        {
            return a;
        }
        else
        {
            return b;
        }   

    }   

    //Q3_method()
    static bool checkAge(int birth_year)
    {
        int current_year = 2026;
        int age = current_year - birth_year;

        if (age >= 18)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    static void createAccount()
    {
        Console.WriteLine("Enter Your Username: ");
        string username = Console.ReadLine();

        Console.WriteLine("Enter Your Password: ");
        string password = Console.ReadLine();

        Console.WriteLine("Enter Your Password Again: ");
        string confirm_password = Console.ReadLine();

        Console.WriteLine("Enter Your Birth Year: ");
        string input_birth_year = Console.ReadLine();
        int birth_year = Convert.ToInt32(input_birth_year);

        bool isAdult = checkAge(birth_year);
        if (isAdult)
        {
            if (password == confirm_password)
            {
                Console.WriteLine("Account created successfully!");
            }
            else
            {
                Console.WriteLine("Passwords do not match. Account creation failed.");
            }
        }
        else
        {
            Console.WriteLine("You must be at least 18 years old to create an account.");
        }
    }

} 

/* use "dotnet new console -o [wanted name] --use-program-main true" to create new projects

  use "cd [folder name]" to enter the project folder

  use "dotnet run" to run the project */