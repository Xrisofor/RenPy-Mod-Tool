using System;
using Steamworks;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace Mod_Tool.Forms
{
    public partial class UploadWorskhopItem : Form
    {
        public PublishedFileId_t publishedFileID;
        public bool update = false;

        public string ModID, ModName, ModFolder;

        public UploadWorskhopItem()
        {
            InitializeComponent();
            Text = $"{Config.GameName} (Mod Tool)";
            Translation(); 
        }

        private void Translation()
        {
            ModIDLabel.Text = Config.Translation("ModID");
            ModNameLabel.Text = Config.Translation("ModName");
            ModDescLabel.Text = Config.Translation("ModDesc");
            MainFolderLabel.Text = Config.Translation("MainFolder");
            ModHeaderLabel.Text = Config.Translation("ModHeader");
            ListChangesLabel.Text = Config.Translation("ListChanges");
            AcceptLabel.Text = Config.Translation("Accept");
            ModName_CheckBox.Text = Config.Translation("DoNotChange");
            ModDisc_CheckBox.Text = Config.Translation("DoNotChange");
            UploadButton.Text = Config.Translation("UploadButton");
            ModPath_Button.Text = Config.Translation("ReviewButton");
            ModImg_Button.Text = Config.Translation("ReviewButton");
            GetSteamInfoButton.Text = Config.Translation("GetItemSteamInfo");
            TagsLabel.Text = Config.Translation("Tags");
            NewStoryMT.Text = Config.Translation("NewStoryMT");
            NewFeaturesMT.Text = Config.Translation("NewFeaturesMT");
            NewGraphicsMT.Text = Config.Translation("NewGraphicsMT");
            NewCharactersMT.Text = Config.Translation("NewCharactersMT");
        }

        IList<string> tags = new List<string>();

        private void UpdateItem()
        {
            var updateHandle = SteamUGC.StartItemUpdate(SteamUtils.GetAppID(), publishedFileID);

            if (ModDisc_CheckBox.Checked == false)
            {
                SteamUGC.SetItemTitle(updateHandle, ModName_TextBox.Text);
            }
            if (ModDisc_CheckBox.Checked == false)
            {
                SteamUGC.SetItemDescription(updateHandle, ModDisc_TextBox.Text);
            }
            SteamUGC.SetItemContent(updateHandle, $"{Environment.CurrentDirectory}/temp/");
            SteamUGC.SetItemTags(updateHandle, tags);
            SteamUGC.SetItemPreview(updateHandle, ModImg_TextBox.Text);
            SteamUGC.SetItemVisibility(updateHandle, ERemoteStoragePublishedFileVisibility.k_ERemoteStoragePublishedFileVisibilityPublic);

            var steamAPICall = SteamUGC.SubmitItemUpdate(updateHandle, ModUpdate_TextBox.Text);
            var steamAPICallResult = CallResult<SubmitItemUpdateResult_t>.Create();
            steamAPICallResult.Set(steamAPICall, UpdateItemResult);
        }

        private void UpdateItemResult(SubmitItemUpdateResult_t param, bool bIOFailure)
        {
            if (param.m_eResult == EResult.k_EResultOK)
            {
                MessageBox.Show(Config.Translation("ModUpdated"), $"{Config.GameName} (Mod Tool)", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else if (param.m_eResult == EResult.k_EResultLimitExceeded)
            {
                MessageBox.Show("Result Limit Exceeded!", $"{Config.GameName} (Mod Tool)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (param.m_eResult == EResult.k_EResultInvalidParam)
            {
                MessageBox.Show($"Invalid Param!", $"{Config.GameName} (Mod Tool)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(Config.Translation("ModUpdatedError"), $"{Config.GameName} (Mod Tool)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Directory.Delete($"{Environment.CurrentDirectory}/temp", true);
        }

        private void UploadWorskhopItem_Load(object sender, EventArgs e)
        {
            ModID_TextBox.Text = ModID;
            ModName_TextBox.Text = ModName;
            ModPath_TextBox.Text = ModFolder;

            if (update == true)
            {
                ModID_TextBox.Enabled = true;
                ModDisc_CheckBox.Enabled = true;
                ModName_CheckBox.Enabled = true;
            }
            else
            {
                publishedFileID = new PublishedFileId_t(Convert.ToUInt32(ModID_TextBox.Text));
            }
        }

        private void UploadButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Config.Translation("ModUpdatedWarn"), $"{Config.GameName} (Mod Tool)", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            switch(Config.Engine)
            {
                case Engine.RenPy:
                    if (!Directory.Exists($"{Environment.CurrentDirectory}/temp/mods"))
                        Directory.CreateDirectory($"{Environment.CurrentDirectory}/temp/mods");
                    Directory.CreateDirectory($"{Environment.CurrentDirectory}/temp/mods/{ModName}");
                    CopyDir.Copy(ModFolder, $"{Environment.CurrentDirectory}/temp/mods/{ModName}/");
                    break;
            }

            UpdateItem();
        }

        private void ModPath_Button_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            ModPath_TextBox.Text = folderBrowserDialog1.SelectedPath;
            ModFolder = ModPath_TextBox.Text;
        }

        private void ModImg_Button_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            ModImg_TextBox.Text = openFileDialog1.FileName;
        }

        private void ModID_TextBox_TextChanged(object sender, EventArgs e)
        {
            if (ModID_TextBox.Text == string.Empty)
            {
                UploadButton.Enabled = false;
                GetSteamInfoButton.Enabled = false;
            }
            else
            {
                UploadButton.Enabled = true;
                GetSteamInfoButton.Enabled = true;
            }

            if (update == true)
            {
                if (ModID_TextBox.Text != string.Empty)
                    publishedFileID = new PublishedFileId_t(Convert.ToUInt32(ModID_TextBox.Text));
                ModID = ModID_TextBox.Text;
            }
        }

        private void ModID_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)Keys.Back) { }
            else e.Handled = true;
        }

        private void AcceptLabel_Click(object sender, EventArgs e)
        {
            Process.Start("https://steamcommunity.com/sharedfiles/workshoplegalagreement");
        }

        //Tags
        private void NewStoryMT_CheckedChanged(object sender, EventArgs e)
        {
            if (NewStoryMT.Checked)
                tags.Add("New Story");
            else tags.Remove("New Story");
        }

        private void NewFeaturesMT_CheckedChanged(object sender, EventArgs e)
        {
            if (NewFeaturesMT.Checked)
                tags.Add("New Features");
            else tags.Remove("New Features");
        }

        private void ModName_TextBox_TextChanged(object sender, EventArgs e)
        {
            ModName = ModName_TextBox.Text;
        }

        private void NewGraphicsMT_CheckedChanged(object sender, EventArgs e)
        {
            if (NewGraphicsMT.Checked)
                tags.Add("New Graphics");
            else tags.Remove("New Graphics");
        }

        private void NewCharactersMT_CheckedChanged(object sender, EventArgs e)
        {
            if (NewCharactersMT.Checked)
                tags.Add("New Characters");
            else tags.Remove("New Characters");
        }
    }
}
