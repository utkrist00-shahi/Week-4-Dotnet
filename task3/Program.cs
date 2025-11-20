 class Program
{
    static void Main(string[] args)
    {
        ParameterDemo demo = new ParameterDemo();

        int value = 10;
        Console.WriteLine("Before Increase: " + value);
        demo.Increase(ref value);
        Console.WriteLine("After Increase: " + value);

        string name;
        demo.GetFullName(out name);
        Console.WriteLine("Full Name: " + name);

        int sum = demo.SumAll(10, 20, 30, 40, 50, 5, 15);
        Console.WriteLine("Sum of numbers: " + sum);

        Console.ReadLine();
    }
}
