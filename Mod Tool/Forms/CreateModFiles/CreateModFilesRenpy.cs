using System;
using System.IO;
using System.Windows.Forms;

namespace Mod_Tool.Forms
{
    public partial class CreateModFilesRenpy : Form
    {
        public string ModName, ModTrigger, ModFolder;

        public CreateModFilesRenpy()
        {
            InitializeComponent();
            Text = $"{Config.GameName} (Mod Tool)";
            Translation();
        }

        private void Translation()
        {
            GiveNameLabel.Text = Config.Translation("GiveName");
            GiveLabelLB.Text = Config.Translation("GiveLabel");
            CreateModButton.Text = Config.Translation("NewMD");
        }

        private void CreateModButton_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory($"{Config.DataFolder}/{ModNameTextBox.Text}");

            File.Create($"{Config.DataFolder}/{ModNameTextBox.Text}/{ModNameTextBox.Text}.rpy").Close();
            using (StreamWriter sw = new StreamWriter($"{Config.DataFolder}/{ModNameTextBox.Text}/{ModNameTextBox.Text}.rpy"))
            {
                sw.WriteLine("init python:");
                sw.WriteLine(@"    mods['" + ModTriggerTextBox.Text.Replace(" ", "_") + "'] = '" + ModNameTextBox.Text + "'");
                sw.WriteLine("");
                sw.WriteLine("label " + ModTriggerTextBox.Text.Replace(" ", "_") + ":");
                sw.WriteLine($"    \"{Config.Translation("ModTestText")}\"");
                sw.WriteLine("");
                sw.WriteLine($"    return");
            }

            ModFolder = $"{Environment.CurrentDirectory}/{Config.DataFolder}/{ModNameTextBox.Text}";
        }

        private void ModNameTextBox_TextChanged(object sender, EventArgs e)
        {
            ModName = ModNameTextBox.Text;

            if (ModNameTextBox.Text != string.Empty && ModTriggerTextBox.Text != string.Empty)
                CreateModButton.Enabled = true;
            else
                CreateModButton.Enabled = false;
        }

        private void ModTriggerTextBox_TextChanged(object sender, EventArgs e)
        {
            ModTrigger = ModTriggerTextBox.Text;

            if (ModNameTextBox.Text != string.Empty && ModTriggerTextBox.Text != string.Empty)
                CreateModButton.Enabled = true;
            else
                CreateModButton.Enabled = false;
        }

        private void ModTriggerTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '_' || e.KeyChar == (char)Keys.Back) { }
            else
            {
                e.Handled = true;
                MessageBox.Show(Config.Translation("LabelNameError"), $"{Config.GameName} (Mod Tool)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
