using System;
using System.IO;

namespace ModTool
{
    public class FManager
    {
        public static string GetGameFolder()
        {
            return Path.GetFullPath($@"{AppDomain.CurrentDomain.BaseDirectory}..\game");
        }

        public static string GetLibFolder()
        {
            return Path.GetFullPath($@"{AppDomain.CurrentDomain.BaseDirectory}..\lib\py3-windows-x86_64");
        }

        public static string GetProjectFolder(int modID)
        {
            return Path.GetFullPath($@"{AppDomain.CurrentDomain.BaseDirectory}..\game\mods\{Program.Projects[modID].Name}");
        }

        public static string GetProjectFolder(Project project)
        {
            return Path.GetFullPath($@"{AppDomain.CurrentDomain.BaseDirectory}..\game\mods\{project.Name}");
        }

        public static string GetTempFolder()
        {
            return $@"{AppDomain.CurrentDomain.BaseDirectory}\temp\";
        }

        public static string GetExampleFolder()
        {
            return $@"{AppDomain.CurrentDomain.BaseDirectory}\rpy";
        }

        public static string GetJsonFolder()
        {
            return $@"{AppDomain.CurrentDomain.BaseDirectory}\json";
        }

        public static string GetSkinFolder()
        {
            return $@"{AppDomain.CurrentDomain.BaseDirectory}\json\skin";
        }

        public static string GetTableFolder()
        {
            return $@"{AppDomain.CurrentDomain.BaseDirectory}\json\table";
        }

        public static string GetModeFolder()
        {
            return $@"{AppDomain.CurrentDomain.BaseDirectory}\json\mode";
        }

        public static string GetResourcesFolder()
        {
            return $@"{AppDomain.CurrentDomain.BaseDirectory}\resources";
        }

        public static string[] GetAllSkinsFiles(string search = "*.json")
        {
            return Directory.GetFiles(GetSkinFolder(), search, SearchOption.AllDirectories);
        }

        public static string[] GetAllModesFiles(string search = "*.json")
        {
            return Directory.GetFiles(GetModeFolder(), search, SearchOption.AllDirectories);
        }

        public static string[] GetAllResourcesFiles(string search = "*.json")
        {
            return Directory.GetFiles(GetResourcesFolder(), search, SearchOption.AllDirectories);
        }
    }
}
