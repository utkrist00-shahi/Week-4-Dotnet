using task_2;

public class Program
{

    public static void Main(string[] args)
    {
        Calculator cal = new Calculator();
        cal.PrintWelcome();
        int add = cal.Add(1, 2);
        int multi = cal.Multiply(5);
        Console.WriteLine(add);
        Console.WriteLine(multi);
         
    }


    
    }

