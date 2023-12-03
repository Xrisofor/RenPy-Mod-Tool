using System.Collections.Generic;

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

        public int PixelationSampleColors = 16;

        public Dictionary<string, string> ScriptEditorList = new Dictionary<string, string>();
    }
}
