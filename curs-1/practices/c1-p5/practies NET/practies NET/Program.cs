 
   namespace Tests
{




class Program
{
    static void Main()
    {
        Console.WriteLine("+-+");

        Console.Write("|");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("0");
        Console.ResetColor();
        Console.Write("|");
        Console.WriteLine();

        Console.Write("|");
        Console.Write("0");
        Console.Write("|");
        Console.WriteLine();

        Console.Write("|");
        Console.Write("0");
        Console.Write("|");
        Console.WriteLine();


        Console.WriteLine("+-+");
        Thread.Sleep(3000);
        Console.Clear();


        Console.WriteLine("+-+");
        Console.Write("|");
        Console.Write("0");
        Console.Write("|");
        Console.WriteLine();

        Console.Write("|");
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.Write("0");
        Console.ResetColor();
        Console.Write("|");
        Console.WriteLine();

        Console.Write("|");
        Console.Write("0");
        Console.Write("|");
        Console.WriteLine();


        Console.WriteLine("+-+");
        Thread.Sleep(3000);
        Console.Clear();

        Console.WriteLine("+-+");

        Console.Write("|");
        Console.Write("0");

        Console.Write("|");
        Console.WriteLine();
        Console.Write("|");
        Console.Write("0");
        Console.Write("|");
        Console.WriteLine();

        Console.Write("|");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("0");
        Console.ResetColor();
        Console.Write("|");
        Console.WriteLine();


        Console.WriteLine("+-+");
        Thread.Sleep(3000);
        Console.Clear();
    }
}
}