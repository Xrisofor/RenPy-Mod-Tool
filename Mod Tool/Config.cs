using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Steamworks;
using System.IO;
using System.Reflection;

namespace Mod_Tool
{
    public enum Engine
    {
        RenPy
    }

    public class Config
    {
        public static AppId_t m_AppID;

        public static string GameName = "The Durka: You will (not) die";

        public static string DataFolder = "../game/mods";

        public static WorkshopEULAStatus_t m_WorkshopEULAStatus;

        public static Engine Engine = Engine.RenPy;

        public static string DocURL = "https://steamcommunity.com/sharedfiles/filedetails/?id=2997567842";

        public static int LanguageIndex = 0;
        public static List<Language> Languages = new List<Language>();

        public static Timer CallbackTimer = new Timer();

        public static void Init(uint AppID)
        {
            Environment.SetEnvironmentVariable("SteamAppID", AppID.ToString());
            m_AppID = new AppId_t(AppID);

            if (!SteamAPI.IsSteamRunning()) {
                MessageBox.Show("Steam process not found, please open the Steam client!", $"{GameName} (Mod Tool)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            if (!Directory.Exists(DataFolder))
                Directory.CreateDirectory(DataFolder);

            string[] langFiles = Directory.GetFiles($"{Environment.CurrentDirectory}/languages", "*.ini", SearchOption.TopDirectoryOnly);

            foreach (string line in langFiles)
            {
                string langName = Path.GetFileNameWithoutExtension(line);
                langName = langName.Substring(0, 1).ToUpper() + langName.Substring(1);
                Languages.Add(new Language(langName, line));
            }

            SteamAPI.Init();

            CallbackTimer.Interval = 5000;
            CallbackTimer.Enabled = true;
            CallbackTimer.Tick += (s, e) => { SteamAPI.RunCallbacks(); };

            var steamAPICall = SteamUGC.GetWorkshopEULAStatus();
            var steamAPICallResult = CallResult<WorkshopEULAStatus_t>.Create();
            steamAPICallResult.Set(steamAPICall, UpdateWorkshopEULAStatus);
        }

        private static void UpdateWorkshopEULAStatus(WorkshopEULAStatus_t temp_WorkshopEULAStatus, bool bIOFailure)
        {
            m_WorkshopEULAStatus = temp_WorkshopEULAStatus;
        }

        public static void Shutdown()
        {
            CallbackTimer.Enabled = false;
            SteamAPI.Shutdown();
        }

        public static string ReplaceSteamVar(string Text)
        {
            Text = Text.Replace("{SteamUserName}", SteamFriends.GetPersonaName());
            return Text;
        }

        public static string Translation(string Name)
        {
            string transText = Languages[LanguageIndex].Text.Find(tx => tx.Name == Name).Text;
            transText = transText.Replace(@"\n", Environment.NewLine);
            transText = ReplaceSteamVar(transText);
            transText = transText.Replace("{ProgramVersion}", AssemblyInfo.AssemblyVersion);
            transText = transText.Replace("{GameName}", GameName);
            return transText;
        }
    }

    public class Language
    {
        public string Name;

        public List<LangText> Text = new List<LangText>();

        public Language(string Name, string Path)
        {
            this.Name = Name;

            string[] allLines = File.ReadAllLines(Path);

            foreach (string line in allLines)
            {
                string[] allTextSP = line.Split('=');
                Text.Add(new LangText(allTextSP[0], allTextSP[1]));
            }
        }
    }

    public class LangText
    {
        public string Name;
        public string Text;

        public LangText(string Name, string Text)
        {
            this.Name = Name;
            this.Text = Text;
        }
    }
}
