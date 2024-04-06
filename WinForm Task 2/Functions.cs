using System.Xml.Linq;
using System.Text.Json;

namespace WinForm_Task_2;

public static class Functions
{
    public static void WriteUserToJson(User u)
    {
        JsonSerializerOptions op = new()
        {
            WriteIndented = true
        };
        string json = JsonSerializer.Serialize(u, op);
        File.WriteAllText(u._name, json);
    }
    public static User ReadUserToJson(string name)
    {
        JsonSerializerOptions options = new JsonSerializerOptions
        {
            WriteIndented = true
        };
        string jsonstring = "";
        jsonstring = File.ReadAllText(name);
        return JsonSerializer.Deserialize<User>(jsonstring, options);
    }
}
