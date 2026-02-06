namespace Homework4;

class Program
{
    static void Main(string[] args)
    {
        
        // Call Q1_method
        Console.WriteLine("Give me 2 integers to compare: ");
        string input1 = Console.ReadLine();
        string input2 = Console.ReadLine();
        int a = Convert.ToInt32(input1);
        int b = Convert.ToInt32(input2); //Made to have a little more fun showing the codes usage

        Comparison(a, b);
        

        // Call Q2_method
        Console.WriteLine("Give me the size of the triangle: ");
        string input3 = Console.ReadLine();
        int N = Convert.ToInt32(input3);

        Console.WriteLine("Give me the direction of the triangle (Left or Right): ");
        string LeftOrRight = Console.ReadLine();

        Triangle(N, LeftOrRight);

    }

    // Q1_method
    static void Comparison (int a, int b)
    {
        Console.WriteLine ($"a={a}, b={b}");

        if (a > b)
        {
            String result = $"The largest numeber is {a}";
            Console.WriteLine(result);
        }
        else if (a < b)
        {
            String result = $"The largest numeber is {b}";
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("The numbers are equal.");
        }

    }

    // Q2_method
    static void Triangle (int N, string LeftOrRight)
    {
        if (LeftOrRight == "Left")
        {
            for (int i = 1; i <= N; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


        }
        else if (LeftOrRight == "Right")
        {
            for (int i = 1; i <= N; i++)
            {
                for (int j = 1; j <= N - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Invalid direction. Please enter 'Left' or 'Right'.");
        }
    }
}

/* use "dotnet new console -o [wanted name] --use-program-main true" to create new projects

  use "cd [folder name]" to enter the project folder

  use "dotnet run" to run the project */