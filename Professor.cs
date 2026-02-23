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