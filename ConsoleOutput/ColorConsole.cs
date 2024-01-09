using ConsoleColor = System.ConsoleColor;

namespace alfadva.ConsoleOutput;

public class ColorConsole
{

    public static void Wh()
    {
        Console.ForegroundColor = ConsoleColor.White;
    }
    
    public static void Bl()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
    }

    public static void Gr()
    {
        Console.ForegroundColor = ConsoleColor.Green;
    }
    
    public static void Gy()
    {
        Console.ForegroundColor = ConsoleColor.Gray;
    }
    
    public static void Rd()
    {
        Console.ForegroundColor = ConsoleColor.Red;
    }

    public static void Yl()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
    }
}