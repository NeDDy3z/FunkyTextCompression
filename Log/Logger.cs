using alfadva.FileManagement;

namespace alfadva.Log;

public class Logger
{
    public static void WriteToLog(string action)
    {
        FileManager.Write("Log/Log.txt", FileManager.Read("Log/Log.txt") + "\n" + DateTime.Now + " - " + action);
    }
}