namespace Homework3;

class Program
{
    static void Main(string[] args)
    {
        
        //Code for Q1
        Console.WriteLine("Input an integer: ");
        string input = Console.ReadLine();
        int N = Convert.ToInt32(input);

        bool isPrime = true; // ChatGpt gave me the idea to use a boolean variable to check

        for (int i = 2; i < N; i++)
        {
            if (N % i == 0)
            {
                isPrime = false;
                break;
            }
            
        }
        if (isPrime)
        {
            Console.WriteLine($"{N} is a prime number.");
        }
        else
        {
            Console.WriteLine($"{N} is not a prime number.");
        }

        //Code for Q2
        Console.WriteLine("Input an integer: ");
        string input2 = Console.ReadLine();
        int N2 = Convert.ToInt32(input2);

        for (int i = 1; i <= N2; i++)
        {
            for (int j = 1; j <= N2; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        //Code for Q3
        Console.WriteLine("Input an integer: ");
        string input3 = Console.ReadLine();
        int N3 = Convert.ToInt32(input3);

        for (int i = 1; i <= N3; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }  

        //Code for Bonus question
        Console.WriteLine("Input an integer: ");
        string input4 = Console.ReadLine();
        int N4 = Convert.ToInt32(input4);

        for (int i = 1; i <= N4; i++)
        {
            for (int j = 1; j <= N4 - i; j++)
            {
                Console.Write(" ");
            }
            for (int k = 1; k <= i; k++)
            {
                Console.Write(i);
            }
            Console.WriteLine();
        }

    }
}

/* use "dotnet new console -o [wanted name] --use-program-main true" to create new projects

  use "cd [folder name]" to enter the project folder

  use "dotnet run" to run the project */