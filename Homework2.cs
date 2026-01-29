namespace Homework2;

class Program
{
    static void Main(string[] args)
    {
        // Code for Q1
        Console.WriteLine("Please input a Capital letter grade: ");
        string grade = Console.ReadLine();

        switch (grade)
        {
            case "A":
                Console.WriteLine("GPA Point: 4");
                break;
            case "B":
                Console.WriteLine("GPA Point: 3");
                break;
            case "C":
                Console.WriteLine("GPA Point: 2");
                break;
            case "D":
                Console.WriteLine("GPA Point: 1");
                break;
            case "F":
                Console.WriteLine("GPA Point: 0");
                break;
            default:
                Console.WriteLine("Wrong Letter Grade!");
                break;
        }
        // Code for Q2
        Console.WriteLine("Please input the first num: ");
        string first_num_str = Console.ReadLine();
        int first_num = Convert.ToInt32(first_num_str);

        Console.WriteLine("Please input the second num: ");
        string second_num_str = Console.ReadLine();
        int second_num = Convert.ToInt32(second_num_str);

        Console.WriteLine("Please input the third num: ");
        string third_num_str = Console.ReadLine();
        int third_num = Convert.ToInt32(third_num_str);

            if (first_num < second_num)
        {
                if (first_num < third_num)
            {
                Console.WriteLine("The smallest value is: " + first_num);
            }
                else
            {
                Console.WriteLine("The smallest value is: " + third_num);
            }
        }
            else
        {
                if (second_num < third_num)
            {
                Console.WriteLine("The smallest value is: " + second_num);
            }
                else
            {
                Console.WriteLine("The smallest value is: " + third_num);
            }
        }
        // Code for Bonus Question
        Console.WriteLine("Please input a year: ");
        string year_str = Console.ReadLine();
        int year = Convert.ToInt32(year_str);
        
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
        {
            Console.WriteLine(year + " is a leap year.");
        }
            else
        {
            Console.WriteLine(year + " is not a leap year.");
        }

    }
}


/* use "dotnet new console -o [wanted name] --use-program-main true" to create new projects

  use "cd [folder name]" to enter the project folder

  use "dotnet run" to run the project */