// See https://aka.ms/new-console-template for more information
using JsonSamples.Models;
using System.Text.Json;

Console.WriteLine("Hello, World!");

var files = new Dictionary<string, Root?>
{
    {"C800W14", null},
    {"C801P46", null},
    {"C806S54", null},
    {"C806S60", null},
    {"C806Y26", null},
    {"I801G30", null},
    {"I804G68-0", null},
    {"I804G68-2", null},
    {"I805D98", null},
    {"I805G58", null},
    {"M800K41", null},
    {"M800N06", null},
    {"M800S03-0", null},
    {"M800S03-2", null}
};


foreach (KeyValuePair<string,Root> kvp in files)
{
    string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), $"code/json/{kvp.Key}.json");
    string json = File.ReadAllText(path);
    Root? root = JsonSerializer.Deserialize<Root>(json, JsonSerializerOptions.Default);

    if (root is not null)
    {
        files[kvp.Key] = root;
    }
}

Console.ReadLine();