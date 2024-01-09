using System.Configuration;
using alfadva.FileManagement;

namespace alfadva.ConsoleOutput;

/// <summary>
///    Class for printing out to the console.
/// </summary>
public class Printer
{
    private static string _errorMessage = "";

    /// <summary>
    /// Starts the User Input and returns the input and output file paths.
    /// </summary>
    /// <returns>input/output files</returns>
    /// <exception cref="Exception"></exception>
    public static (string?, string?) Start()
    {
        while (true)
        {
            Console.Clear();
            if (_errorMessage != null)
            {
                ColorConsole.Rd();
                Console.WriteLine(_errorMessage);
            }

            ColorConsole.Wh();
            Console.Write("[ Menu ]\n" +
                          "[1] Load data from .config file\n" +
                          "[2] Load data from arguments\n" +
                          "[3] Enter custom data\n" +
                          "[4] Print out log\n" +
                          "[5] Help\n" +
                          "[0] Exit\n");
            try
            {
                ColorConsole.Yl();
                var input = Console.ReadKey();
                switch (input.Key)
                {
                    case ConsoleKey.NumPad1 or ConsoleKey.D1:
                        return (ConfigurationManager.AppSettings["InputFile"],
                            ConfigurationManager.AppSettings["OutputFile"]);
                    case ConsoleKey.NumPad2 or ConsoleKey.D2:
                        return ("arg//", "arg//");
                    case ConsoleKey.NumPad3 or ConsoleKey.D3:
                        return (EnterInputFile(), EnterOutputFile());
                    case ConsoleKey.NumPad4 or ConsoleKey.D4:
                        PrintLog();
                        break;
                    case ConsoleKey.NumPad5 or ConsoleKey.D5:
                        Console.Clear();
                        ColorConsole.Wh();
                        Console.WriteLine("[ Help ]\n" +
                                          "!! THE PROGRAM PROCESSES ONLY THE TEXT WRITTEN IN CZECH !!\n" +
                                          "In the menu press any key from 1-5 and 0 to select an option.\n" +
                                          "1. - loads data from .config file\n" +
                                          "2. - loads data from arguments\n" +
                                          "3. - enter custom data (input & output files)\n" +
                                          "4. - prints log, in menu you can select time and date\n" +
                                          "5. - help -> this menu\n" +
                                          "0. - Exit the program\n");
                        ColorConsole.Gy();
                        Console.WriteLine("Press any key to go back to the menu...");
                        Console.ReadKey();
                        break;
                    case ConsoleKey.NumPad0 or ConsoleKey.D0:
                        Environment.Exit(0);
                        return ("", "");
                    default:
                        throw new Exception("There's no such option.");
                }
            }
            catch (Exception e)
            {
                _errorMessage = e.Message;
            }
        }
    }

    /// <summary>
    /// Enter the input file path.
    /// </summary>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    public static string EnterInputFile()
    {
        while (true)
        {
            Console.Clear();
            if (_errorMessage != null)
            {
                ColorConsole.Rd();
                Console.WriteLine(_errorMessage);
            }

            ColorConsole.Wh();
            Console.Write("Enter file path [.txt]: ");
            try
            {
                ColorConsole.Yl();
                var input = Console.ReadLine();
                if (input != null && input.Contains(".txt") && File.Exists(input))
                {
                    return input;
                    _errorMessage = null;
                    break;
                }
                else throw new Exception("File does not exist or is not a .txt file.");
            }
            catch (Exception e)
            {
                _errorMessage = e.Message;
            }
        }
    }

    /// <summary>
    /// Enter the output file path.
    /// </summary>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    public static string EnterOutputFile()
    {
        while (true)
        {
            Console.Clear();
            ColorConsole.Wh();
            Console.Write("Enter output file path [.txt]: ");
            try
            {
                ColorConsole.Yl();
                var input = Console.ReadLine();
                if (input != null && input.Contains(".txt"))
                {
                    return input;
                    _errorMessage = null;
                    break;
                }
                else throw new Exception("File must be a .txt file.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

    /// <summary>
    /// Prints out the input and output file paths.
    /// </summary>
    /// <param name="inputFile"></param>
    /// <param name="outputFile"></param>
    public static void FilePathLoaded(string inputFile, string outputFile)
    {
        Console.Clear();
        ColorConsole.Wh();
        Console.WriteLine(
            $"{inputFile} ({((double)new FileInfo(inputFile).Length / 1024).ToString("0.000")} KB)  >>>  {outputFile}");
        ColorConsole.Gy();
        Console.Write("Press any key to start compression...");
        Console.ReadKey();
    }

    /// <summary>
    /// Prints out the log.
    /// </summary>
    public static void PrintLog()
    {
        Console.Clear();
        ColorConsole.Wh();
        Console.WriteLine(FileManager.Read("log/log.txt"));
        ColorConsole.Gy();
        Console.WriteLine("\nPress any key to go back to the menu...");
        Console.ReadKey();
    }

    /// <summary>
    /// Prints out the compression has finished message.
    /// </summary>
    /// <param name="inputFile"></param>
    /// <param name="outputFile"></param>
    public static void Finish(string inputFile, string outputFile)
    {
        Console.Clear();
        ColorConsole.Gr();
        Console.WriteLine("Compression has finished!");
        ColorConsole.Wh();
        Console.WriteLine("-------------------------");
        Console.WriteLine($"File: {inputFile}\n" +
                          $"Length: {FileManager.Read(inputFile).Length} chrs\n" +
                          $"Size: {((double)new FileInfo(inputFile).Length / 1024).ToString("0.000")} KB\n\n" +
                          $"File: {outputFile}\n" +
                          $"Length: {FileManager.Read(outputFile).Length} chrs\n" +
                          $"Size: {((double)new FileInfo(outputFile).Length / 1024).ToString("0.000")} KB");
        Console.WriteLine("-------------------------");
        ColorConsole.Gy();
        Console.Write("Press any key to exit...");
        Console.ReadKey();
    }

    /// <summary>
    /// Prints out the file does not exist message.
    /// </summary>
    public static void FileDoesntExist()
    {
        Console.Clear();
        ColorConsole.Rd();
        Console.WriteLine("Input file does not exist.\n");
        ColorConsole.Gy();
        Console.Write("Press any key to go back to the menu...");
        Console.ReadKey();
    }
}