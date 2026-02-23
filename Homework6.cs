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

/* use "dotnet new console -o [wanted name] --use-program-main true" to create new projects

  use "cd [folder name]" to enter the project folder

  use "dotnet run" to run the project */