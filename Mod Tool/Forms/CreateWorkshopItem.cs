using System;
using Steamworks;
using System.Windows.Forms;
using Mod_Tool.Workshop;
using System.Security.Cryptography;

namespace Mod_Tool.Forms
{
    public partial class CreateWorkshopItem : Form
    {
        private SteamWorkshopItem currentSteamWorkshopItem;
        public PublishedFileId_t publishedFileID;
        public string ModNameCF;

        public CreateWorkshopItem()
        {
            InitializeComponent();
            Text = $"{Config.GameName} (Mod Tool)";
            Translation();
        }

        private void Translation()
        {
            ModCreatedLabel.Text = Config.Translation("ModCreated");
            CopyButton.Text = Config.Translation("Copy");
            ConWaitButton.Text = Config.Translation("ModCreatedWait");
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(IDTextBox.Text);
        }

        public void UploadContent(string itemTitle, string itemDescription, string contentFolderPath, string previewImagePath)
        {
            currentSteamWorkshopItem = new SteamWorkshopItem
            {
                Title = itemTitle,
                Description = itemDescription,
                ContentFolderPath = contentFolderPath,
                PreviewImagePath = previewImagePath
            };
            
            CreateItem();
        }

        private void CreateItem()
        {
            EWorkshopFileType FileType = EWorkshopFileType.k_EWorkshopFileTypeCommunity;

            var steamAPICall = SteamUGC.CreateItem(SteamUtils.GetAppID(), FileType);
            var steamAPICallResult = CallResult<CreateItemResult_t>.Create(CreateItemResult);
            steamAPICallResult.Set(steamAPICall);
        }

        private void UpdateItem()
        {
            var updateHandle = SteamUGC.StartItemUpdate(SteamUtils.GetAppID(), publishedFileID);

            SteamUGC.SetItemTitle(updateHandle, currentSteamWorkshopItem.Title);
            SteamUGC.SetItemDescription(updateHandle, currentSteamWorkshopItem.Description);
            SteamUGC.SetItemContent(updateHandle, currentSteamWorkshopItem.ContentFolderPath);
            //SteamUGC.SetItemTags(updateHandle, currentSteamWorkshopItem.Tags);
            SteamUGC.SetItemPreview(updateHandle, currentSteamWorkshopItem.PreviewImagePath);
            SteamUGC.SetItemVisibility(updateHandle, ERemoteStoragePublishedFileVisibility.k_ERemoteStoragePublishedFileVisibilityPrivate);

            var steamAPICall = SteamUGC.SubmitItemUpdate(updateHandle, "");
            var steamAPICallResult = CallResult<SubmitItemUpdateResult_t>.Create();
            steamAPICallResult.Set(steamAPICall, UpdateItemResult);
        }

        private void CreateItemResult(CreateItemResult_t param, bool bIOFailure)
        {
            if (param.m_eResult == EResult.k_EResultOK)
            {
                publishedFileID = param.m_nPublishedFileId;
                IDTextBox.Text = publishedFileID.ToString();
                CopyButton.Enabled = true;
                UpdateItem();
            }
            else
            {
                ConWaitButton.Text = Config.Translation("ModCreatedError");
            }
        }

        private void UpdateItemResult(SubmitItemUpdateResult_t param, bool bIOFailure)
        {
            if (param.m_eResult == EResult.k_EResultOK)
            {
                ConWaitButton.Enabled = true;
                ConWaitButton.Text = Config.Translation("Continue");
            }
            else if (param.m_eResult == EResult.k_EResultLimitExceeded)
            {
                ConWaitButton.Text = Config.Translation("ModCreatedError");
                MessageBox.Show(Config.Translation("ResultLimit"), $"{Config.GameName} (Mod Tool)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ConWaitButton.Text = Config.Translation("ModCreatedError");
            }
        }

        private void CreateWorkshopItem_Load(object sender, EventArgs e)
        {
            MessageBox.Show(Config.Translation("ModCreatedWarn"), $"{Config.GameName} (Mod Tool)", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            if (ModNameCF != string.Empty)
            {
                UploadContent(ModNameCF, Config.Translation("ItemDesc"), "",  $"{Environment.CurrentDirectory}/previmg.png");
            }
            else
            {
                UploadContent("Mod Name", Config.Translation("ItemDesc"), "", $"{Environment.CurrentDirectory}/previmg.png");
            }
        }
    }
}
