namespace HelloWorld;

class Program
{
    static void Main(string[] args)
    {
    
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Jayden Hamilton");

        Console.Write("Hello\tWorld\nHello\tWorld\n");
        Console.WriteLine("\\\\\\\\");
        Console.WriteLine("\"\"");

        int age = 19;
        int Age = 19;
        string first_name = "Jayden";
        string studentFirstName = "Jayden";
        string StudentFirstName = "Jayden";
        string student_first_name = "Jayden";

        int a = 10;
        int b = a;
        Console.WriteLine("Value of b: " + b);

        int m = 10;
        int n = m + 10;
        n = 100;
        Console.WriteLine("Value of n: " + n);

        int x = 10;
        int y = x;
        x = 20;
        Console.WriteLine("Value of y: " + y);

        int my_age = 19;
        string my_name = "Jayden";
        Console.WriteLine("My name is " + my_name + ", " + " I am " + my_age + " years old.");
        Console.WriteLine("My name is {0}, I am {1} years old.", my_name, my_age);
        Console.WriteLine($"My name is {my_name}, I am {my_age} years old.");

        int Year = 2026;
        string Major = "CIS";
        float stu_gpa = 3.5f;
        double Weight = 73.5;
        char letter_grade = 'A';
        bool is_online = true;

        Console.WriteLine("Year: " + Year);
        Console.WriteLine("Major: " + Major);
        Console.WriteLine("GPA: " + stu_gpa);
        Console.WriteLine("Weight: " + Weight);
        Console.WriteLine("Letter Grade: " + letter_grade);
        Console.WriteLine("Is Online: " + is_online);

        int a1 = 10;
        int b1 = 3;
        double c1 = 2.4;

        Console.WriteLine($"a = {a1}, b = {b1}, c = {c1}");
        Console.WriteLine($"a/b= {a1/b1}, Data type:{(a1/b1).GetType().Name}");
        Console.WriteLine($"a/c= {a1/c1}, Data type:{(a1/c1).GetType().Name}");
        Console.WriteLine($"a*b= {a1*b1}, Data type:{(a1*b1).GetType().Name}");
        Console.WriteLine($"a*c= {a1*c1}, Data type:{(a1*c1).GetType().Name}");
        Console.WriteLine($"a-b= {a1-b1}, Data type:{(a1-b1).GetType().Name}");
        Console.WriteLine($"a-c= {a1-c1}, Data type:{(a1-c1).GetType().Name}");
        Console.WriteLine($"a%b= {a1%b1}, Data type:{(a1%b1).GetType().Name}");

        int num1 = 10;
        Console.WriteLine($"num1 = {num1}");
        num1++;
        Console.WriteLine($"after num1++, num1 = {num1}");
        ++num1;
        Console.WriteLine($"after ++num1, num1 = {num1}");

        int num2 = num1--;
        Console.WriteLine("num1 = {num1}");
        Console.WriteLine($"num2 = {num2}");

        num2 = --num1;
        Console.WriteLine($"num1 = {num1}");
        Console.WriteLine($"num2 = {num2}");

    }
}