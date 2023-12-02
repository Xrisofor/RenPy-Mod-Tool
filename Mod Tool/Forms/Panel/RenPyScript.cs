using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using ModTool.Forms.Explorer;

namespace ModTool.Forms.Panel
{
    public partial class RenPyScript : Form
    {
        private int ModID;
        private string OpenFilePath = string.Empty;
        
        public RenPyScript(int ModID)
        {
            InitializeComponent();
            this.ModID = ModID;

            rpyOpenFileDialog.InitialDirectory = FManager.GetProjectFolder(ModID);
            rpySaveFileDialog.InitialDirectory = FManager.GetProjectFolder(ModID);
        }

        public RenPyScript(int ModID, string openFilePath)
        {
            InitializeComponent();

            this.ModID = ModID;
            this.OpenFilePath = openFilePath;

            fastColoredTextBox1.Text = File.ReadAllText(OpenFilePath);

            rpyOpenFileDialog.InitialDirectory = FManager.GetProjectFolder(ModID);
            rpySaveFileDialog.InitialDirectory = FManager.GetProjectFolder(ModID);
        }

        private string ReplaceFCTB()
        {
            fastColoredTextBox1.Text = fastColoredTextBox1.Text.Replace("[mod_folder]", $"mods/{Program.Projects[ModID].Name}");

            fastColoredTextBox1.Text = fastColoredTextBox1.Text.Replace("[new_character]", $"define (name) = Character(\"CharacterName\")");
            fastColoredTextBox1.Text = fastColoredTextBox1.Text.Replace("[new_image]", $"image (name) = \"mods/{Program.Projects[ModID].Name}\"");
            fastColoredTextBox1.Text = fastColoredTextBox1.Text.Replace("[new_define]", $"define (name) = \"mods/{Program.Projects[ModID].Name}\"");

            fastColoredTextBox1.Text = fastColoredTextBox1.Text.Replace("[new_scene]", $"scene (name)");
            fastColoredTextBox1.Text = fastColoredTextBox1.Text.Replace("[show_image]", $"show (name)");
            fastColoredTextBox1.Text = fastColoredTextBox1.Text.Replace("[hide_image]", $"hide (name)");

            fastColoredTextBox1.Text = fastColoredTextBox1.Text.Replace("[new_menu]", $"menu:\r\n\r\n        \"Chouse\"\r\n\r\n        \"1\":\r\n            \"Hello\"\r\n\r\n        \"2\":\r\n            \"World!\"");

            fastColoredTextBox1.Text = fastColoredTextBox1.Text.Replace("[play_sound]", $"play sound (you_file)");
            fastColoredTextBox1.Text = fastColoredTextBox1.Text.Replace("[play_music]", $"play music (you_file)");
            fastColoredTextBox1.Text = fastColoredTextBox1.Text.Replace("[play_ambiences]", $"play ambiences (you_file)");

            fastColoredTextBox1.Text = fastColoredTextBox1.Text.Replace("[phone_incoming]", "$ phone_call_dn_lbl = \"(label_name)\"\r\n\r\n    call screen phone_incoming(\"(character_name)\")");
            fastColoredTextBox1.Text = fastColoredTextBox1.Text.Replace("[phone_incoming_f]", "call screen phone_incoming(\"(character_name)\", interactive=False)");
            fastColoredTextBox1.Text = fastColoredTextBox1.Text.Replace("[phone_incoming_h]", "hide screen phone_home_screen");

            fastColoredTextBox1.Text = fastColoredTextBox1.Text.Replace("[new_movie]", "$ renpy.movie_cutscene(\"mods/Мой мод/(you_file)\")");
            fastColoredTextBox1.Text = fastColoredTextBox1.Text.Replace("[new_video]", "$ renpy.movie_cutscene(\"mods/Мой мод/(you_file)\")");

            return fastColoredTextBox1.Text;
        }

        private void fastColoredTextBox1_TextChanged(object sender, FastColoredTextBoxNS.TextChangedEventArgs e)
        {
            e.ChangedRange.ClearFoldingMarkers();

            FCT_RenPy.ChangedRange(e);
        }

        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            if(rpyOpenFileDialog.ShowDialog() == DialogResult.OK)
                OpenFilePath = rpyOpenFileDialog.FileName;

            fastColoredTextBox1.Text = File.ReadAllText(OpenFilePath);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if(OpenFilePath != string.Empty)
            {
                File.WriteAllText(OpenFilePath, ReplaceFCTB());
            }
            else
            {
                if(rpySaveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    OpenFilePath = rpySaveFileDialog.FileName;
                    File.WriteAllText(OpenFilePath, ReplaceFCTB());
                }
            }
        }

        private void SaveAsButton_Click(object sender, EventArgs e)
        {
            if (rpySaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                OpenFilePath = rpySaveFileDialog.FileName;
                File.WriteAllText(OpenFilePath, ReplaceFCTB());
            }
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.ShowFindDialog();
        }

        private void FindAndReplaceButton_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.ShowReplaceDialog();
        }

        private void NewFileButton_Click(object sender, EventArgs e)
        {
            if (rpySaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                OpenFilePath = rpySaveFileDialog.FileName;
                File.Create(OpenFilePath).Close();
                fastColoredTextBox1.Clear();
            }
        }

        private void TableButton_Click(object sender, EventArgs e)
        {
            GameResourceTable gameResourceTable = new GameResourceTable();
            gameResourceTable.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GameSpTag gameSpTag = new GameSpTag();
            gameSpTag.Show();
        }

        private void rpaExpButton_Click(object sender, EventArgs e)
        {
            Rpa_Explorer rpa_Explorer = new Rpa_Explorer();
            rpa_Explorer.Show();
        }

        private void RenPyDocButton_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.renpy.org/doc/html/quickstart.html#a-simple-game");
        }
    }
}
