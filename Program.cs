using alfadva.Compression;
using alfadva.FileManagement;
using alfadva.ConsoleOutput;


namespace alfadva
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Declaration
            Compress cm = new Compress();
            var inputFile = "InputText.txt";
            var outputFile = "OutputText.txt";

            

            // User Input
            while (true)
            {
                var result = Printer.Start();
                inputFile = result.Item1;
                outputFile = result.Item2;

                if (inputFile == "arg//" && outputFile == "arg//")
                {
                    if (args.Length != 2 || args[0] == null || args[1] == null) continue;
                    inputFile = args[0];
                    outputFile = args[1];
                }

                if (!File.Exists(inputFile))
                {
                    Printer.FileDoesntExist();
                    continue;
                }

                break;
            }

            // Show loaded path and ask user to continue
            Printer.FilePathLoaded(inputFile, outputFile);

            // Read the file -> Compress -> Write to the file
            FileManager.Write(outputFile, cm.StartCompression(FileManager.Read(inputFile)));

            // Print results - done
            Printer.Finish(inputFile, outputFile);
        }
    }
}