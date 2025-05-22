using ConsoleAppTestProj;

public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("This is first line!");

        MathOperation mp = new MathOperation();
        Console.WriteLine("2+3="+ mp.addition(2, 3));
        Console.WriteLine("4*6="+ mp.multi(4, 6));
        Console.WriteLine("5/3="+ mp.divide(5, 3));
        Console.ReadLine();
    }
}