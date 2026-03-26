namespace Practice9;

class Program
{
    static void Main(string[] args)
    {
        // Exercise 1
        int[] int_arr = {1, 23, 44, 552, 34, 88, 91, 256, 22, 31, 45 };

        Exercise1(int_arr);

    }

    static void Exercise1( int[] arr)
    {
        Console.WriteLine($"The lenght of array is: {arr.Length}");
        Console.WriteLine($"The dimension of array is: {arr.Rank}");
        Console.WriteLine($"Max value: {arr.Max()}");
        Console.WriteLine($"Min value: {arr.Min()}");
        Console.WriteLine($"Sum value: {arr.Sum()}");

        Array.Sort(arr);
        Console.WriteLine("Sorted array: ");
        foreach (int i in arr)
        {
            Console.Write($"{i} ");
        }
        
        Console.WriteLine();
        Console.WriteLine($"The index of 45 is: {Array.IndexOf(arr, 45)}");
    }
}
 