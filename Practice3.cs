using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Numerics;
using System.Security.Cryptography;
using System.Text.Json.Serialization;

namespace Practice3;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Input an integar to vaule N: ");
        string N = Console.ReadLine();
        int N_int = Convert.ToInt32(N);

        while (N_int > 0)
        {
            Console.Write("*");
            N_int--; // N_int = N_int - 1
        }

        int num =1;

        while (num <= 10)
        {
            Console.WriteLine(num);
            num += 2;
        } // ran 5 times

        int num = 1;

        while (num <= 10)
        {
            if (num % 2 == 1)
            {
                Console.WriteLine(num);
            }
            num++; // ran 5 times aswell 
        } 

        Console.WriteLine("Input an integar to vaule N: ");
        string N = Console.ReadLine();
        int N_int = Convert.ToInt32(N);

        for (int i = 0; i < N_int; i++)
        {
            Console.Write("*");
        }
        
    }
}

/* use "dotnet new console -o [wanted name] --use-program-main true" to create new projects

  use "cd [folder name]" to enter the project folder

  use "dotnet run" to run the project */