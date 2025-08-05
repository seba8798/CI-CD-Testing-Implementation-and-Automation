using MainApp.Logic;

internal class Program
{
    private static void Main(string[] args)
    {
        var logic = new Class1();
        Console.WriteLine($"2 + 3 = {logic.Add(2, 3)}");
    }
}