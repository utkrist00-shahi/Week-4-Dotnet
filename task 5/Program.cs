class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the day: ");
        string inputDay = Console.ReadLine()?.Trim() ?? "";

        DayType dayType = (inputDay.Equals("Friday", StringComparison.OrdinalIgnoreCase) ||
                           inputDay.Equals("Saturday", StringComparison.OrdinalIgnoreCase))
                           ? DayType.Weekend : DayType.Weekday;

        Console.WriteLine($"It is: {dayType}");

        Book book1 = new Book("C# in Depth", "Jon Skeet", 500);

        Book book2 = book1 with { title = "C# Advanced Topics", price = 1000 };

        Console.WriteLine("\nFirst object:");
        Console.WriteLine(book1);

        var (title, author, price) = book2;

        Console.WriteLine("\nDeconstructed second object:");
        Console.WriteLine($"title: {title}");
        Console.WriteLine($"author: {author}");
        Console.WriteLine($"price: {price}");

        Console.ReadLine();
    }
}