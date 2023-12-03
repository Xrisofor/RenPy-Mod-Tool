using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using ModTool.Forms;
using Newtonsoft.Json;

namespace ModTool
{
    public static class Program
    {
        public static List<Project> Projects = new List<Project>();

        public static List<Item> Sprites { get; private set; } = new List<Item>();
        public static List<Item> Audio { get; private set; } = new List<Item>();

        [STAThread]
        static void Main()
        {
            if( File.Exists($@"{FManager.GetJsonFolder()}\settings.json") )
            {
                Config.UserSettings = JsonConvert.DeserializeObject<Settings>( File.ReadAllText($@"{FManager.GetJsonFolder()}\settings.json") );
            }
            else
            {
                Config.UserSettings = new Settings();
                File.WriteAllText( $@"{FManager.GetJsonFolder()}\settings.json", JsonConvert.SerializeObject(Config.UserSettings) );
            }

            var allLanguage = Directory.GetFiles($@"{FManager.GetJsonFolder()}\language", "*.json", SearchOption.TopDirectoryOnly);

            foreach (string file in allLanguage)
            {
                if (Path.GetFileNameWithoutExtension(file) == Config.UserSettings.Language)
                    Config.Language = JsonConvert.DeserializeObject<Dictionary<string, string>>(File.ReadAllText(file));
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}
