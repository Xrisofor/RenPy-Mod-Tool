using System;
using Steamworks;
using System.Windows.Forms;
using Mod_Tool.Forms;
using System.Diagnostics;
using System.IO;

namespace Mod_Tool
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            Config.Init(0); //GameAppID
            InitializeComponent();

            Text = $"{Config.GameName} (Mod Tool)";
            WelcomeLabel.Text = Config.ReplaceSteamVar(WelcomeLabel.Text);

            foreach(Language lang in Config.Languages)
            {
                LanguageComboBox.Items.Add(lang.Name);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Config.Shutdown();
        }

        private void CreateNewItemButton_Click(object sender, EventArgs e)
        {
            if (!Config.m_WorkshopEULAStatus.m_bAccepted)
                SteamUGC.ShowWorkshopEULA();

            switch(Config.Engine)
            {
                case Engine.RenPy:
                    Forms.CreateModFilesRenpy createModRenPy = new Forms.CreateModFilesRenpy();
                    Forms.CreateWorkshopItem createWorkshopItem = new Forms.CreateWorkshopItem();
                    if (createModRenPy.ShowDialog() == DialogResult.OK) {
                        createWorkshopItem.ModNameCF = createModRenPy.ModName;
                        if (createWorkshopItem.ShowDialog() == DialogResult.OK) {
                            Forms.UploadWorskhopItem uploadWorskhopItem = new Forms.UploadWorskhopItem();
                            uploadWorskhopItem.update = false;
                            uploadWorskhopItem.ModName = createModRenPy.ModName;
                            uploadWorskhopItem.ModFolder = createModRenPy.ModFolder;
                            uploadWorskhopItem.ModID = createWorkshopItem.publishedFileID.ToString();
                            if (uploadWorskhopItem.ShowDialog() == DialogResult.OK) { }
                        }
                    }
                    break;
            }
        }

        private void UpdateItemButton_Click(object sender, EventArgs e)
        {
            if (!Config.m_WorkshopEULAStatus.m_bAccepted)
                SteamUGC.ShowWorkshopEULA();

            Forms.UploadWorskhopItem uploadWorskhopItem = new Forms.UploadWorskhopItem();
            uploadWorskhopItem.update = true;
            if (uploadWorskhopItem.ShowDialog() == DialogResult.OK) { }
        }

        private void LanguageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Config.LanguageIndex = LanguageComboBox.SelectedIndex;
            Translation();
        }

        private void Translation()
        {
            WelcomeLabel.Text = Config.Translation("Welcome");
            CreateNewItemButton.Text = Config.Translation("NewMD");
            UpdateItemButton.Text = Config.Translation("UpdateMD");
            DocumentationButton.Text = Config.Translation("Documentation");
            InterfacelanguageLabel.Text = Config.Translation("Interfacelanguage");
            PVersionLabel.Text = Config.Translation("PVersion");
        }

        private void DocumentationButton_Click(object sender, EventArgs e)
        {
            if (Config.DocURL != string.Empty)
                Process.Start(Config.DocURL);
            else MessageBox.Show(Config.Translation("DocumentationNone"), $"{Config.GameName} (Mod Tool)", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
