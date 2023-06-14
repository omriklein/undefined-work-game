using System.IO;
using System.Text;
using UnityEngine;

public class GetStringFromFile : MonoBehaviour
{
    private const string _path = @"c:\temp\MyTest.txt";
    private const string _fileName = @"TextFiles\Testing";

    private string readText;
    public static string GetTextFromResources(string fileName="")
    {
        print("Getting Text From Resources");
        string path = fileName == "" ? _fileName : fileName;
        var textFile = Resources.Load<TextAsset>(path);
        if (textFile == null)
        {
            Debug.LogError("File not found in the Resources/TextFiles folder");
            return "";
        }
        Debug.Log("the text that was loaded \n" + textFile.text);
        return textFile.text;
    }
    
    public static string GetTextFromFile(string path = "")
    {
        print("Getting text from a file");
        path = path == "" ? _path : path;
        string readText = "";
        // This text is added only once to the file.
        if (!File.Exists(path))
        {
            // Open the file to read from.
            readText = File.ReadAllText(path);
            Debug.Log("The text that was loaded: \n" + readText);
        }
        else
        {
            Debug.LogError("could not find the file in path " + path);
        }

        return readText;
    }
}