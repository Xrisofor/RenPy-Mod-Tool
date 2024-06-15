using Steamworks;
using System;
using System.Windows.Forms;

namespace ModTool
{
    public class Steam
    {
        public static AppId_t m_AppID;
        public static WorkshopEULAStatus_t m_WorkshopEULAStatus;
        public static Timer CallbackTimer = new Timer();

        public static void Init(uint appID = 1595380)
        {
            Environment.SetEnvironmentVariable("SteamAppID", appID.ToString());
            m_AppID = new AppId_t(appID);

            if (!SteamAPI.IsSteamRunning())
            {
                MessageBox.Show(Config.GetText("warning_steam_running_message"), $"{Config.GameName} - Mod Tool", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                throw new Exception();
            }

            SteamAPI.Init();

            CallbackTimer.Interval = 1000;
            CallbackTimer.Enabled = true;
            CallbackTimer.Tick += (s, e) => { SteamAPI.RunCallbacks(); };

            var steamAPICall = SteamUGC.GetWorkshopEULAStatus();
            var steamAPICallResult = CallResult<WorkshopEULAStatus_t>.Create();
            steamAPICallResult.Set(steamAPICall, UpdateWorkshopEULAStatus);

            SteamUserStats.StoreStats();
        }

        public static bool IsSteamInit()
        {
            if (!SteamAPI.IsSteamRunning())
                return false;

            return SteamAPI.Init();
        }

        private static void UpdateWorkshopEULAStatus(WorkshopEULAStatus_t temp_WorkshopEULAStatus, bool bIOFailure) =>
            m_WorkshopEULAStatus = temp_WorkshopEULAStatus;

        public static void GrantAchievement(string achApiName)
        {
            SteamUserStats.SetAchievement(achApiName);
            SteamUserStats.StoreStats(); 
        }
    }
}
