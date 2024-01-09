namespace alfadva.FileManagement;

/// <summary>
/// FileManager class is used for reading and writing to files.
/// </summary>
public class FileManager
{
    /// <summary>
    /// Reads the file from the given path.
    /// </summary>
    /// <param name="path"></param>
    /// <returns></returns>
    public static string Read(string path)
    {
        try
        {
            return File.ReadAllText(path);
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error has occured while trying to read the file:\n {e.Message}");
            return "";
        }
    }

    /// <summary>
    /// Writes the given content to the file on the given path.
    /// </summary>
    /// <param name="path"></param>
    /// <param name="content"></param>
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