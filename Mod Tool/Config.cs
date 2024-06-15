using Newtonsoft.Json;
using Steamworks;
using System.Collections.Generic;
using System.IO;

namespace ModTool
{
    public class Config
    {
        public static string GameName = "The Durka: YWND"; 

        public static Settings UserSettings;

        public static Dictionary<string, string> Language = new Dictionary<string, string>();
    
        public static string GetText(string key)
        {
            var value = string.Empty;

            if (Language.ContainsKey(key))
                Language.TryGetValue(key, out value);
            else
                value = "ERROR";

            return value;
        }

        public static string ToUpperFirstLetter(string source)
        {
            if (string.IsNullOrEmpty(source))
                return string.Empty;
            char[] letters = source.ToCharArray();
            letters[0] = char.ToUpper(letters[0]);
            return new string(letters);
        }
    }

    public class Settings
    {
        public string Language = "english";
        public string ScriptEditor = "default";
        public string DevName = SteamAPI.Init() ? SteamFriends.GetPersonaName() : string.Empty;

        public int PixelationSampleColors = 16;

        public bool ShowWarning = true;

        public Dictionary<string, string> ScriptEditorList = new Dictionary<string, string>();
    
        public void RestoreSettings()
        {
            ScriptEditor = "default";
            DevName = SteamAPI.Init() ? SteamFriends.GetPersonaName() : string.Empty;
            PixelationSampleColors = 16;
            ShowWarning = true;

            File.WriteAllText($@"{FManager.GetJsonFolder()}\settings.json", JsonConvert.SerializeObject(Config.UserSettings));
        }
    }
}
