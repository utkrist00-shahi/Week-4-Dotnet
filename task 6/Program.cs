using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter marks: ");
        int marks;
        int.TryParse(Console.ReadLine(), out marks);

        Console.Write("Enter total: ");
        int total;
        int.TryParse(Console.ReadLine(), out total);

        double percentage = (double)marks / total* 100.0;  

        Console.WriteLine("Percentage = " + percentage);
        Console.ReadLine();
    }
}