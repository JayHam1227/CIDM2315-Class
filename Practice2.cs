namespace practice2;

class Program
{
    static void Main(string[] args)
    {
        
        int x = 10;
        x += 5;

        Console.WriteLine(x);

        int a = 5;
        int b = 10;

        Console.WriteLine($"a= {a}, b= {b}");
        Console.WriteLine($"a>b: {a>b}");
        Console.WriteLine($"a<b: {a<b}");
        Console.WriteLine($"a==b: {a==b}");
        Console.WriteLine($"a!=b: {a!=b}");
        Console.WriteLine($"true: {true}");
        Console.WriteLine($"false: {false}");

        Console.WriteLine("Please Input an Integer:");
        string num = Console.ReadLine();
        int num_int = Convert.ToInt32(num);

            if (num_int >= 0)
        {
            Console.WriteLine(num_int + " is positive");
        }
            else
        {
            Console.WriteLine(num_int + " is negative");
        }

            if (num_int % 2 == 0)
        {
            Console.WriteLine(num_int + " is even");
        }
            else
        {
            Console.WriteLine(num_int + " is odd");
        }

        Console.WriteLine("Please Input an integer x: ");
        string x_str = Console.ReadLine();
        int x = Convert.ToInt32(x_str);

            if (x > 0)
        {
            Console.WriteLine(x + " is positive");
        }
            else if (x < 0)
        {
            Console.WriteLine(x + " is negative");
        }
            else
        {
            Console.WriteLine(x + " is zero");
        }

        string username = "alice";
        string password = "alice123";

        Console.WriteLine("Please Input username: ");
        string username1 = Console.ReadLine();
        Console.WriteLine("Please Input password: ");
        string password1 = Console.ReadLine();

            if (username1 == username && password1 == password)
        {
            Console.WriteLine("Login Successful");
        }
            else 
        {
            Console.WriteLine("Please check your username and password");
        }

    }
}

/* use "dotnet new console -o [wanted name] --use-program-main true" to create new projects

  use "cd [folder name]" to enter the project folder

  use "dotnet run" to run the project */