namespace Practice5;

class Program 
{
    //Excercise 1
    static void Main(string[] args)
    {
        double CallThree = ThreeNumAvg(a: 1.5, b: 5.5, c: 6.5);
        Console.WriteLine("Average of three given Values: " + CallThree);

        double CallTwo = ThreeNumAvg(a: 1.5, c: 5.5);
        Console.WriteLine("Average of two given Values: " + CallTwo);
    }

    static double ThreeNumAvg(double a, double c, double b = 3.5)
    {
        double avg = (a + b + c) / 3;

        return avg;
    }

}
