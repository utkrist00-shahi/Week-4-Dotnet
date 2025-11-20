class Program
{
    static void Main(string[] args)
    {
        Player p1 = new Player();

        Player p2 = new Player("Utkrist", 30, 100);

        p1.PrintInfo();
        p2.PrintInfo();

        Console.ReadLine();
    }
}