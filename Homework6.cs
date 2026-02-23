namespace Homewowrk6;

class Program
{
    static void Main(string[] args) 
    {
        // Answer Q1 and Q2
        Professor professor1 = new Professor();
        professor1.profName = "Alice";
        professor1.classTeach = "Java";
        professor1.SetSalary(9000);

        Professor professor2 = new Professor();
        professor2.profName = "Bob";
        professor2.classTeach = "Math";
        professor2.SetSalary(8000);

        Student student1 = new Student();
        student1.studentName = "Lisa";
        student1.classEnroll = "Java"; 
        student1.SetGrade(90);

        Student student2 = new Student();
        student2.studentName = "Tom";
        student2.classEnroll = "Math";
        student2.SetGrade(80);

        professor1.PrintProfessorsInfo();
        professor2.PrintProfessorsInfo();

        student1.PrintStudentInfo();
        student2.PrintStudentInfo();

        professor1.SalaryDifference(professor2);
        student1.TotalGrade(student2);
    }
}

//Code for Professor class
class Professor
{
    public string profName;
    public string classTeach;
    private double salary;

    public void SetSalary(double salary_amount)
    {
        salary = salary_amount; 
    }

    public double GetSalary()
    {
        return salary;
    }

    public void SalaryDifference(Professor otherProfessor)
    {
        double difference = Math.Abs(this.GetSalary() - otherProfessor.GetSalary());
        Console.WriteLine($"The salary difference between Professor {this.profName} and Professor {otherProfessor.profName} is: {difference}");
    }

    public void PrintProfessorsInfo()
    {
        Console.WriteLine($"Professor {profName} teaches {classTeach}, and their salary is: {GetSalary()}");
    }
}

// Code for Student class
class Student
{
    public string studentName;
    public string classEnroll;
    private double studentGrade;

    public void SetGrade(double newGrade)
    {
        studentGrade = newGrade; 
    }

    public double GetGrade()
    {
        return studentGrade;
    }

    public void TotalGrade(Student otherStudent)
    {
        double total = this.GetGrade() + otherStudent.GetGrade();
        Console.WriteLine($"The total grade of Student {this.studentName} and Student {otherStudent.studentName} is: {total}");
    }

    public void PrintStudentInfo()
    {
        Console.WriteLine($"Student {studentName} enrolled in {classEnroll}, and their grade is: {GetGrade()}");
    }
}

/* use "dotnet new console -o [wanted name] --use-program-main true" to create new projects

  use "cd [folder name]" to enter the project folder

  use "dotnet run" to run the project */