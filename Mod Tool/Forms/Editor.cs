using Newtonsoft.Json;
using Steamworks;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ModTool.Forms
{
    public partial class Editor : Form
    {
        private int ModID;
        private Main Main;

        public Editor(int ModID)
        {
            InitializeComponent();
            this.ModID = ModID;

            Text = $"{Program.Projects[ModID].Name} - {Program.Projects[ModID].Type} - Mod Tool";
            ModNameLabel.Text = Program.Projects[ModID].Name;
            DescriptionTextBox.Text = Program.Projects[ModID].Description;
        }

        public Editor(int ModID, Main Main)
        {
            InitializeComponent();
            this.ModID = ModID;
            this.Main = Main;

            Text = $"{Program.Projects[ModID].Name} - {Program.Projects[ModID].Type} - Mod Tool";
            ModNameLabel.Text = Program.Projects[ModID].Name;
            DescriptionTextBox.Text = Program.Projects[ModID].Description;

            if (Main != null)
                BackButton.Enabled = true;
        }

        private void Editor_Shown(object sender, EventArgs e)
        {
            if ( Program.Projects[ModID].Image != null && Program.Projects[ModID].Image != string.Empty && File.Exists(Program.Projects[ModID].Image) )
                CoverPictureBox.BackgroundImage = Image.FromFile(Program.Projects[ModID].Image);

            switch (Program.Projects[ModID].Type)
            {
                case ModType.ModeVisualScript:

                    DCPanel.Controls.Clear();
                    Panel.VisualScript visualScriptForm = new Panel.VisualScript(ModID);
                    visualScriptForm.TopLevel = false;
                    DCPanel.Controls.Add(visualScriptForm);
                    visualScriptForm.FormBorderStyle = FormBorderStyle.None;
                    visualScriptForm.Dock = DockStyle.Fill;
                    visualScriptForm.Show();

                    break;

                case ModType.ModRenPy:

                    DCPanel.Controls.Clear();
                    Panel.RenPyScript renpyScriptForm = new Panel.RenPyScript(ModID, $@"{FManager.GetProjectFolder(ModID)}\{Program.Projects[ModID].Name}.rpy");
                    renpyScriptForm.TopLevel = false;
                    DCPanel.Controls.Add(renpyScriptForm);
                    renpyScriptForm.FormBorderStyle = FormBorderStyle.None;
                    renpyScriptForm.Dock = DockStyle.Fill;
                    renpyScriptForm.Show();

                    BuildButton.Enabled = false;
                    if(SteamAPI.IsSteamRunning())
                        PublishButton.Enabled = true;

                    break;

                case ModType.SnakeSkin:

                    DCPanel.Controls.Clear();
                    Panel.Skin shakeSkinForm = new Panel.Skin(ModID, 0);
                    shakeSkinForm.TopLevel = false;
                    DCPanel.Controls.Add(shakeSkinForm);
                    shakeSkinForm.FormBorderStyle = FormBorderStyle.None;
                    shakeSkinForm.Dock = DockStyle.Fill;
                    shakeSkinForm.Show();

                    break;

                case ModType.FlappyBirdSkin:

                    DCPanel.Controls.Clear();
                    Panel.Skin flappyBirdSkinForm = new Panel.Skin(ModID, 1);
                    flappyBirdSkinForm.TopLevel = false;
                    DCPanel.Controls.Add(flappyBirdSkinForm);
                    flappyBirdSkinForm.FormBorderStyle = FormBorderStyle.None;
                    flappyBirdSkinForm.Dock = DockStyle.Fill;
                    flappyBirdSkinForm.Show();

                    break;

                case ModType.SnakeMode:

                    DCPanel.Controls.Clear();
                    Panel.Mode shakeModeForm = new Panel.Mode(ModID, 0);
                    shakeModeForm.TopLevel = false;
                    DCPanel.Controls.Add(shakeModeForm);
                    shakeModeForm.FormBorderStyle = FormBorderStyle.None;
                    shakeModeForm.Dock = DockStyle.Fill;
                    shakeModeForm.Show();

                    break;

                case ModType.FlappyBirdMode:

                    DCPanel.Controls.Clear();
                    Panel.Mode flappyBirdModeForm = new Panel.Mode(ModID, 1);
                    flappyBirdModeForm.TopLevel = false;
                    DCPanel.Controls.Add(flappyBirdModeForm);
                    flappyBirdModeForm.FormBorderStyle = FormBorderStyle.None;
                    flappyBirdModeForm.Dock = DockStyle.Fill;
                    flappyBirdModeForm.Show();

                    break;
            }
        }

        private void Editor_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BuildButton_Click(object sender, EventArgs e)
        {
            Build build = new Build(ModID);
            PublishButton.Enabled = build.Compile();
        }

        private void ChangeCoverButton_Click(object sender, EventArgs e)
        {
            if(coverOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                if(new FileInfo(coverOpenFileDialog.FileName).Length >= 1048576)
                {
                    MessageBox.Show("The image is too big! The maximum file size is 1 megabyte.", "Game Mod Tool", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    CoverPictureBox.BackgroundImage = Image.FromFile(coverOpenFileDialog.FileName);
                    Program.Projects[ModID].Image = coverOpenFileDialog.FileName;

                    var json = JsonConvert.SerializeObject(Program.Projects[ModID]);
                    File.WriteAllText($@"{FManager.GetProjectFolder(ModID)}\project.json", json);
                }
            }
        }

        private void DescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            Program.Projects[ModID].Description = DescriptionTextBox.Text;

            var json = JsonConvert.SerializeObject(Program.Projects[ModID]);
            File.WriteAllText($@"{FManager.GetProjectFolder(ModID)}\project.json", json);
        }

        private void PublishButton_Click(object sender, EventArgs e)
        {
            Publish publish = new Publish(ModID);
            publish.CheckWorkshopEULA();

            if (Program.Projects[ModID].Type != ModType.ModRenPy)
            {
                Build build = new Build(ModID);
                build.Compile(false);
            }

            if (Program.Projects[ModID].SteamID != 0)
                publish.UpdateItem(new PublishedFileId_t(Program.Projects[ModID].SteamID));
            else
                publish.CreateItem();
        }

        private void TagsButton_Click(object sender, EventArgs e)
        {
            TagsEditor tagsEditor = new TagsEditor(ModID);
            tagsEditor.ShowDialog();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.FormClosing -= Editor_FormClosing;
            Main.Show();
            this.Close();
        }
    }
}
