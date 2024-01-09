namespace alfadva.FileManagement;

public class FileManager
{
    public static string Read(string path)
    {
        try
        {
            return File.ReadAllText(path);
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error has occured while trying to read the file:\n {e.Message}");
            return null;
        }
    }

    public static void Write(string path, string content)
    {
        try
        {
            File.WriteAllText(path, content);
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error has occured while trying to write to the file:\n {e.Message}");
        }
    }
}