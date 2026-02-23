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