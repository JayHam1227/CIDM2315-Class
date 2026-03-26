namespace Homework9;

class Program
{
    static void Main(string[] args)
    {
        Student student1 = new Student("111", "Alice");
        Student student2 = new Student("222", "Bob");
        Student student3 = new Student("333", "Cathy");
        Student student4 = new Student("444", "David");

        Dictionary<string, double> gradebook = new Dictionary<string, double>();
        
        gradebook.Add("Alice", 4.0);
        gradebook.Add("Bob", 3.6);
        gradebook.Add("Cathy", 2.5);
        gradebook.Add("David", 1.8);

        if (gradebook.ContainsKey("Tom"))
        {
            gradebook["Tom"] = 3.3;
        }
        else
        {
            gradebook.Add("Tom", 3.3);
        }

        double average = 0;

        foreach (KeyValuePair<string, double> entry in gradebook)
        {
            average += (double)entry.Value;
        }
        average /= gradebook.Count;
        Console.WriteLine($"The average GPA is: {average}");

        Student.studentList(new List<Student> { student1, student2, student3, student4 });
    }
}

class Student
{
    private int studentID { get; set; }
    private string studentName { get; set; }
    public void PrintInfo()
    {
        Console.Write($"Student ID: {studentID}");
        Console.Write($", Student Name: {studentName}");
    }

    public static void studentList(List<Student> students)
    {
        foreach (Student student in students)
        {
            student.PrintInfo();
            Console.WriteLine();
        }
    }

    public Student(string studentID, string studentName)
    {
        this.studentID = int.Parse(studentID);
        this.studentName = studentName;
    }
}

/* use "dotnet new console -o [wanted name] --use-program-main true" to create new projects

  use "cd [folder name]" to enter the project folder

  use "dotnet run" to run the project */