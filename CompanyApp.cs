namespace AppFolder;

class Program
{
    static IEmployeeService employeeService = new EmployeeService();

    static void Main(string[] args)
    {
        RunApp();

    }
    
    static void RunApp()
    {
        Console.WriteLine("Loading company data...");
        employeeService.LoadEmployees();
        Console.WriteLine("Ready.\n");

        employeeService.LoadEmployees();

        Console.WriteLine("Company Manager");
        Console.WriteLine("1. Add Employee");
        Console.WriteLine("2. View Employees");
        Console.WriteLine("3. Delete Employee");
        Console.WriteLine("4. Edit Employees");
        Console.WriteLine("5. Search Employees");
        Console.WriteLine("6. Exit");
        Console.WriteLine("Choose which action you want to perform: ");
        string choice = Console.ReadLine();

        if (choice == "1")
        { 
            Console.WriteLine("Enter employee name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter employee role: ");
            string role = Console.ReadLine();

            Console.WriteLine("Enter employee department: ");
            string department = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(name)||
                string.IsNullOrWhiteSpace(role)||
                string.IsNullOrWhiteSpace(department))
            {
                Console.WriteLine("All fields are required.");
            }
            else
            {
                employeeService.AddEmployee(name, role, department);
            }
        }
        else if (choice == "2")
        {
            employeeService.DisplayEmployees();
        }
        else if (choice == "3")
        {
            Console.WriteLine("Enter employee id to delete: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine($"Are you sure you want to delete employee with id {id}? (y/n)");
                string confirmation = Console.ReadLine();

                if (confirmation.ToLower() == "y")
                {
                    employeeService.DeleteEmployee(id);
                }
                else
                {
                    Console.WriteLine("Deletion cancelled.");
                }
            }
        }
        else if (choice == "4")
        {
            Console.WriteLine("Enter employee id to edit: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("New name: ");
            string newName = Console.ReadLine();

            Console.WriteLine("New role: ");
            string newRole = Console.ReadLine();

            Console.WriteLine("New department: ");
            string newDept = Console.ReadLine();

            employeeService.EditEmployee(id, newName, newRole, newDept);
        }
        else if (choice == "5")
        {
            Console.WriteLine("Enter search keyword: ");
            string keyword = Console.ReadLine();
            employeeService.SearchEmployees(keyword);
        }
        else if (choice == "6")
        {
            Console.Write("Exiting");
            Thread.Sleep(1000);
            Console.Write(".");
            Thread.Sleep(1000);
            Console.Write(".");
            Thread.Sleep(1000);
            Console.Write(".");
            Console.WriteLine();

            Thread.Sleep(3000);
            Console.WriteLine("Exiting Company Manager. Goodbye.");

            return;
        }
        else
        {
            Console.WriteLine("Invalid choice. Please try again.");
        }

    }

}

/* use "dotnet new console -o [wanted name] --use-program-main true" to create new projects

  use "cd [folder name]" to enter the project folder

  use "dotnet run" to run the project */