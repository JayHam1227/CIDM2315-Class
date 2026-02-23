using System.Security.Authentication.ExtendedProtection;

namespace Homework7;

class Program
{
    static void Main(string[] args)
    {
        // Answer Q1 and Q2
        Customer cus1 = new Customer(110, "Alice", 28);
        Customer cus2 = new Customer(111, "Bob", 30);
        cus1.PrintCusInfo();
        cus2.PrintCusInfo();

        cus1.ChangeID(220);
        cus2.ChangeID(221);
        cus1.PrintCusInfo();
        cus2.PrintCusInfo();

        cus1.CompareAge(cus2);
    }
}

class Customer
{
    //Code for Customer class
    private int cus_id;
    private string cus_name;
    private int cus_age;

    public Customer(int cus_id, string cus_name, int cus_age)
    {
        this.cus_id = cus_id;
        this.cus_name = cus_name;
        this.cus_age = cus_age;
    }

    public void ChangeID(int new_id)
    {
        this.cus_id = new_id;
    }

    public void PrintCusInfo()
    {
        Console.WriteLine($"Customer: {cus_id}, name: {cus_name}, age: {cus_age}");
    }

    public void CompareAge(Customer objCustomer)
    {
        if (this.cus_age == objCustomer.cus_age)
        {
            Console.WriteLine($"{this.cus_name} and {objCustomer.cus_name} are the same age.");
        }
        else if (this.cus_age > objCustomer.cus_age)
        {
            Console.WriteLine($"{this.cus_name} is older");
        }
        else
        {
            Console.WriteLine($"{objCustomer.cus_name} is older");
        }
    }
}

/* use "dotnet new console -o [wanted name] --use-program-main true" to create new projects

  use "cd [folder name]" to enter the project folder

  use "dotnet run" to run the project */