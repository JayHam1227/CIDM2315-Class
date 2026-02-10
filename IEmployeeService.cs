namespace AppFolder;

interface IEmployeeService
{
    void AddEmployee(string name, string role, string department);
    void DisplayEmployees();
    void LoadEmployees();

    void DeleteEmployee(int id);
    void EditEmployee(int id, string newName, string newRole, string newDepartment);
    void SearchEmployees(string Keyword);
}