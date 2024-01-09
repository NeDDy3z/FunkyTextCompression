using ConsoleColor = System.ConsoleColor;

namespace alfadva.ConsoleOutput;

/// <summary>
/// Changes color of console output
/// </summary>
public class ColorConsole
{

    /// <summary>
    /// Changes color of console output
    /// </summary>
    public static void Wh()
    {
        Console.ForegroundColor = ConsoleColor.White;
    }
    
    /// <summary>
    /// Changes color of console output
    /// </summary>
    public static void Bl()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
    }

    /// <summary>
    /// Changes color of console output
    /// </summary>
    public static void Gr()
    {
        Console.ForegroundColor = ConsoleColor.Green;
    }
    
    /// <summary>
    /// Changes color of console output
    /// </summary>
    public static void Gy()
    {
        Console.ForegroundColor = ConsoleColor.Gray;
    }
    
    /// <summary>
    /// Changes color of console output
    /// </summary>
    public static void Rd()
    {
        Console.ForegroundColor = ConsoleColor.Red;
    }

    /// <summary>
    /// Changes color of console output
    /// </summary>
    public static void Yl()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
    }
}