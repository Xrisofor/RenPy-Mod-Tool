using System;
using System.Windows.Forms;
using Newtonsoft.Json;
using Steamworks;
using System.IO;
using System.Collections.Generic;
using ModTool.Workshop;

namespace ModTool
{
    public class Publish
    {
        private int ModID;
        private SteamWorkshopItem publishedItemInfo;

        public Publish(int ModID)
        {
            this.ModID = ModID;

            foreach (string dirPath in Directory.GetDirectories(FManager.GetTempFolder(), "*", SearchOption.TopDirectoryOnly))
                Directory.Delete(dirPath, true);

            Directory.CreateDirectory($@"{FManager.GetTempFolder()}\mods\{Program.Projects[ModID].Name}");

            foreach (string dirPath in Directory.GetDirectories(FManager.GetProjectFolder(ModID), "*", SearchOption.AllDirectories))
                Directory.CreateDirectory(dirPath.Replace(FManager.GetProjectFolder(ModID), $@"{FManager.GetTempFolder()}\mods\{Program.Projects[ModID].Name}"));

            foreach (string newPath in Directory.GetFiles(FManager.GetProjectFolder(ModID), "*.*", SearchOption.AllDirectories))
                File.Copy(newPath, newPath.Replace(FManager.GetProjectFolder(ModID), $@"{FManager.GetTempFolder()}\mods\{Program.Projects[ModID].Name}"), true);

            foreach (string newPath in Directory.GetFiles($@"{FManager.GetTempFolder()}\mods\{Program.Projects[ModID].Name}", "*.json", SearchOption.AllDirectories))
                File.Delete(newPath);

            publishedItemInfo = new SteamWorkshopItem
            {
                Title = Program.Projects[ModID].Name,
                Description = Program.Projects[ModID].Description,
                ContentFolderPath = FManager.GetTempFolder(),
                PreviewImagePath = Program.Projects[ModID].Image,
                Tags = Program.Projects[ModID].Tags,
            };
        }

        public void CheckWorkshopEULA()
        {
            if (Steam.m_WorkshopEULAStatus.m_bAccepted)
                SteamUGC.ShowWorkshopEULA();
        }

        public void CreateItem()
        {
            Application.UseWaitCursor = true;

            var steamAPICall = SteamUGC.CreateItem(Steam.m_AppID, EWorkshopFileType.k_EWorkshopFileTypeCommunity);
            var steamAPICallResult = CallResult<CreateItemResult_t>.Create(CreateItemResult);
            steamAPICallResult.Set(steamAPICall);
        }

        private void CreateItemResult(CreateItemResult_t param, bool bIOFailure)
        {
            if (param.m_bUserNeedsToAcceptWorkshopLegalAgreement)
                CheckWorkshopEULA();

            if (param.m_eResult == EResult.k_EResultOK)
            {
                if( uint.TryParse(param.m_nPublishedFileId.ToString(), out uint value) )
                    Program.Projects[ModID].SteamID = value;
                else
                {
                    Application.UseWaitCursor = false;
                    MessageBox.Show(Config.GetText("error_steam_itemid_message"), $"{Config.GameName} - Mod Tool", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                var json = JsonConvert.SerializeObject(Program.Projects[ModID]);
                File.WriteAllText($@"{FManager.GetProjectFolder(ModID)}\project.json", json);

                UpdateItem(param.m_nPublishedFileId);
            }
            else
            {
                Application.UseWaitCursor = false;
                MessageBox.Show(Config.GetText("error_steam_create_message"), $"{Config.GameName} - Mod Tool", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UpdateItem(PublishedFileId_t publishedFileID)
        {
            Application.UseWaitCursor = true;

            var updateHandle = SteamUGC.StartItemUpdate(Steam.m_AppID, publishedFileID);

            SteamUGC.SetItemTitle(updateHandle, publishedItemInfo.Title);
            SteamUGC.SetItemDescription(updateHandle, publishedItemInfo.Description);
            SteamUGC.SetItemContent(updateHandle, publishedItemInfo.ContentFolderPath);

            if (publishedItemInfo.PreviewImagePath != null && publishedItemInfo.PreviewImagePath != string.Empty)
                SteamUGC.SetItemPreview(updateHandle, publishedItemInfo.PreviewImagePath);
            else
                SteamUGC.SetItemPreview(updateHandle, $"{FManager.GetResourcesFolder()}/previmg.png");
            
            SteamUGC.SetItemTags(updateHandle, publishedItemInfo.Tags);
            SteamUGC.SetItemVisibility(updateHandle, ERemoteStoragePublishedFileVisibility.k_ERemoteStoragePublishedFileVisibilityPublic);

            var steamAPICall = SteamUGC.SubmitItemUpdate(updateHandle, "");
            var steamAPICallResult = CallResult<SubmitItemUpdateResult_t>.Create();
            steamAPICallResult.Set(steamAPICall, UpdateItemResult);
        }

        private void UpdateItemResult(SubmitItemUpdateResult_t param, bool bIOFailure)
        {
            Application.UseWaitCursor = false;

            if (param.m_bUserNeedsToAcceptWorkshopLegalAgreement)
                CheckWorkshopEULA();

            if (param.m_eResult == EResult.k_EResultOK)
            {
                MessageBox.Show(Config.GetText("info_steam_success_message"), $"{Config.GameName} - Mod Tool", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (param.m_eResult == EResult.k_EResultLimitExceeded)
            {
                MessageBox.Show(Config.GetText("error_steam_limit_message"), $"{Config.GameName} - Mod Tool", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (param.m_eResult == EResult.k_EResultFileNotFound)
            {
                MessageBox.Show(Config.GetText("error_steam_filenotfound_message"), $"{Config.GameName} - Mod Tool", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(Config.GetText("error_steam_create_message"), $"{Config.GameName} - Mod Tool", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
