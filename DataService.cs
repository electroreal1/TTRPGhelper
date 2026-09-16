using System.IO;
using System.Text.Json;

namespace TTRPGhelper
{
    public static class DataService
    {
        private const string DefaultFilePath = "save_data.json";

        public static void SaveCharacter(Character character)
        {
            ExportCharacter(character, DefaultFilePath);
        }

        public static Character LoadCharacter()
        {
            if (File.Exists(DefaultFilePath))
            {
                return ImportCharacter(DefaultFilePath);
            }
            return new Character();
        }

        public static void ExportCharacter(Character character, string filePath)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(character, options);
            File.WriteAllText(filePath, jsonString);
        }

        public static Character ImportCharacter(string filePath)
        {
            if (File.Exists(filePath))
            {
                string jsonString = File.ReadAllText(filePath);
                return JsonSerializer.Deserialize<Character>(jsonString);
            }
            return null;
        }
    }
}