using alfadva.FileManagement;

namespace alfadva.Log;

/// <summary>
///    Class for logging actions
/// </summary>
public class Logger
{
    /// <summary>
    ///   Writes action to log file
    /// </summary>
    /// <param name="action"></param>
    public static void WriteToLog(string action)
    {
        FileManager.Write("Log/Log.txt", FileManager.Read("Log/Log.txt") + "\n" + DateTime.Now + " - " + action);
    }
}