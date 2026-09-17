using System.IO;
using Newtonsoft.Json;

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
            string jsonString = JsonConvert.SerializeObject(character, Formatting.Indented);
            File.WriteAllText(filePath, jsonString);
        }

        public static Character ImportCharacter(string filePath)
        {
            if (File.Exists(filePath))
            {
                string jsonString = File.ReadAllText(filePath);
                return JsonConvert.DeserializeObject<Character>(jsonString);
            }
            return null;
        }
    }
}