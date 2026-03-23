namespace Practice8;

class Program
{
    static void Main(string[] args)
    {
        //Exercise 1
        string[] name_array = new string[5] { "Alice", "Bob", "Cathy", "Tom", "Jack" };

        Console.WriteLine(
            "the second name is: {0}, the fourth name is: {1}.", 
            name_array[1], name_array[3]
        );

        name_array[4] = "David";

        foreach (string name in name_array)
        {
            Console.Write(name + " ");
        }

        Console.WriteLine();

        //Exercise 2
        int[,] arr_2d =
        {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };
        Array(arr_2d);

        //Exercise 3
        Food food1 = new Food("Juice", 3.49, "Drink");
        Food food2 = new Food("Orange", 0.99, "Fruit");
        Food food3 = new Food("Chicken", 8.99, "Meat");
        Food food4 = new Food("Broccoli", 2.49, "Vegetable");
        Food food5 = new Food("Banana", 0.59, "Fruit");
        Food food6 = new Food("Beef", 14.99, "Meat");
        Food food7 = new Food("Carrot", 1.29, "Vegetable");
        Food food8 = new Food("Soda", 2.99, "Drink");

        Food[] shopping_list = { food1, food2, food3, food4, food5, food6, food7, food8 };

        TotalPrice(shopping_list);
        TotalFruitPrice(shopping_list);
        AveragePrice(shopping_list);
    }

    static void Array(int[,] arr_2d)
    {
        for (int row = 0; row < 3; row++)
        {
            for (int col = 0; col <= 2; col++)
            {
                if(arr_2d[row, col] % 2 == 0)
                {
                    Console.Write(arr_2d[row, col] + " ");
                }
            }
        }
    }

    static void TotalPrice(Food[] shopping_list)
    {
        double total_price = 0.0;
        foreach (Food food in shopping_list)
        {
            total_price += food.foodPrice;
        }
        Console.WriteLine("The total price of all food items is: {0}.", total_price);
    }

    static void TotalFruitPrice(Food[] shopping_list)
    {
        double total_fruit_price = 0.0;
        foreach (Food food in shopping_list)
        {
            if (food.foodType == "Fruit")
            {
                total_fruit_price += food.foodPrice;
            }
        }
        Console.WriteLine("The total price of all fruit items is: {0}.", total_fruit_price);
    }

    static void AveragePrice(Food[] shopping_list)
    {
        double total_price = 0.0;
        foreach (Food food in shopping_list)
        {
            total_price += food.foodPrice;
        }
        double average_price = total_price / shopping_list.Length;
        Console.WriteLine("The average price of all food items is: {0}.", average_price);
    }
}

class Food
{
    public string foodName { get; set; } = string.Empty;
    public double foodPrice { get; set; } = 0.0;
    public string foodType { get; set; } = string.Empty;

    public Food(string name, double price, string type)
    {
        this.foodName = name;
        this.foodPrice = price;
        this.foodType = type;
    }
}

/* use "dotnet new console -o [wanted name] --use-program-main true" to create new projects

  use "cd [folder name]" to enter the project folder

  use "dotnet run" to run the project */