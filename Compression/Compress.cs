using alfadva.Log;

namespace alfadva.Compression;

/// <summary>
/// Compresses text by removing vowels
/// </summary>
public class Compress
{
    
    /// <summary>
    /// Compresses text by removing vowels
    /// </summary>
    /// <param name="inputText"></param>
    /// <returns>edited text</returns>
    public string StartCompression(string inputText)
    {
        var words = inputText.Split(new[] {' ', '\t', '\n', '\r'}, StringSplitOptions.RemoveEmptyEntries);
        char[] samohlasky = { 'a','e','i','y','o','u' };
        var outputText = "";
        
        foreach (var w in words)
        {
            if (w.Length > 2) outputText += new string(w.Select(c => samohlasky.Contains(c) ? ' ' : c).ToArray()).Replace(" ", "") + " ";
            else outputText += w + " ";
        }
        
        Logger.WriteToLog("Compressed file");
        return outputText;
    }
}