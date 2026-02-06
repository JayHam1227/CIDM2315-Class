namespace Practice4;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Give me an integer: ");
        string input = Console.ReadLine();

        string result = odd_or_even(input);
        Console.WriteLine($"The result is: {result}");


    }

    static string odd_or_even(string num)
    {
        int number = Convert.ToInt32(num);
        if (number % 2 == 0)
        {
            string result = "even";
            return result;
        }
        else
        {
            string result = "odd";
            return result;
        }
    }
    

}

/* use "dotnet new console -o [wanted name] --use-program-main true" to create new projects

  use "cd [folder name]" to enter the project folder

  use "dotnet run" to run the project */