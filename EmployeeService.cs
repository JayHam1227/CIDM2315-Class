using System.IO;
using System.Text.Json;

namespace AppFolder;

class EmployeeService : IEmployeeService
{
    private List<Employee> employees = new List<Employee>();
    private const string FilePath = "employees.json";
    private const string LogFile = "audit.log";

    private void SaveEmployees()
    {
        string json = JsonSerializer.Serialize(employees, new JsonSerializerOptions 
        { 
            WriteIndented = true 
        });

        File.WriteAllText(FilePath, json);

    }

    private void DisplayEmployeeList(IEnumerable<Employee> list)
    {
        foreach (var emp in list)
        {
            Console.WriteLine($"{emp.Id} | {emp.Name} | {emp.Role} | {emp.Department}");
        }

    }

    private void Log(string message)
    {
        File.AppendAllText(LogFile,
        $"{DateTime.Now}: {message}{Environment.NewLine}");
    }

    public void AddEmployee(string name, string role, string department)
    {
        int nextId = employees.Count == 0 ? 1 : employees.Max(e => e.Id) + 1;

        Employee emp = new Employee
        {
            Id = nextId,
            Name = name,
            Role = role,
            Department = department
        };

        employees.Add(emp);
        SaveEmployees();
        Log($"Added employee: {emp.Name} (Id: {emp.Id})");
    }

    public void DisplayEmployees()
    {
        DisplayEmployeeList(employees);
    }

    public void LoadEmployees()
    {
        if (!File.Exists(FilePath))
        {
            Console.WriteLine("No employee data found.");
            return;
        }

        string json = File.ReadAllText(FilePath);
        employees = JsonSerializer.Deserialize<List<Employee>>(json) ?? new List<Employee>();
    }

    public void DeleteEmployee(int id)
    {
        Employee emp = employees.FirstOrDefault(e => e.Id == id);

        if (emp != null)
        {
            employees.Remove(emp);
            SaveEmployees();
            Console.WriteLine($"Employee with Id: {id} deleted.");
        }
        else
        {
            Console.WriteLine($"Employee with Id: {id} not found.");
        }

        Log($"Deleted employee with Id: {id}");
    }

    public void EditEmployee(int id, string newName, string newRole, string newDepartment)
    {
        Employee emp = employees.FirstOrDefault(e => e.Id == id);

        if (emp != null)
        {
            emp.Name = newName;
            emp.Role = newRole;
            emp.Department = newDepartment;
            SaveEmployees();
            Console.WriteLine($"Employee with Id: {id} updated.");
        }
        else
        {
            Console.WriteLine($"Employee with Id: {id} not found.");
        }

        Log($"Edited employee: {newName} (Id: {id})");
    }

    public void SearchEmployees(string keyword)
    {
        var results = employees.Where(e =>
        e.Name.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
        e.Role.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
        e.Department.Contains(keyword, StringComparison.OrdinalIgnoreCase));

        DisplayEmployeeList(results);
    }

}