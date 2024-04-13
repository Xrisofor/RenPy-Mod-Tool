using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ModTool.Forms
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();

            Translate();

            var allLanguage = Directory.GetFiles($@"{FManager.GetJsonFolder()}\language", "*.json", SearchOption.TopDirectoryOnly);
            foreach (string file in allLanguage)
            {
                LanguageComboBox.Items.Add( Config.ToUpperFirstLetter( Path.GetFileNameWithoutExtension(file) ) );
            }
            LanguageComboBox.SelectedItem = Config.ToUpperFirstLetter( Path.GetFileNameWithoutExtension(Config.UserSettings.Language) );

            ScriptEditorComboBox.Items.Clear();
            ScriptEditorComboBox.Items.Add("Internal Editor");
            for (int i = 0; i < Config.UserSettings.ScriptEditorList.Count; i++)
            {
                ScriptEditorComboBox.Items.Add(Config.UserSettings.ScriptEditorList.ElementAt(i).Key);
            }
            ScriptEditorComboBox.Items.Add("Add a custom editor");

            if(Config.UserSettings.ScriptEditor != "default")
                ScriptEditorComboBox.SelectedItem = Config.UserSettings.ScriptEditor;

            PixelSampleColorMaxNum.Value = Config.UserSettings.PixelationSampleColors;
        }

        private void LanguageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Config.UserSettings.Language = LanguageComboBox.Items[LanguageComboBox.SelectedIndex].ToString().ToLower();
            File.WriteAllText($@"{FManager.GetJsonFolder()}\settings.json", JsonConvert.SerializeObject(Config.UserSettings));

            var allLanguage = Directory.GetFiles($@"{FManager.GetJsonFolder()}\language", "*.json", SearchOption.TopDirectoryOnly);
            Config.Language.Clear();

            foreach (string file in allLanguage)
            {
                if (Path.GetFileNameWithoutExtension(file) == Config.UserSettings.Language)
                    Config.Language = JsonConvert.DeserializeObject<Dictionary<string, string>>(File.ReadAllText(file));
            }

            Translate();
        }

        private void Translate()
        {
            Text = Config.GetText("settings_button");
            label1.Text = Config.GetText("settings_language_title");
            label2.Text = Config.GetText("settings_script_editor_title");
            label3.Text = Config.GetText("settings_pixel_sc_max_title");
            restoreProjectsButton.Text = Config.GetText("settings_restore_projects_title");
        }

        private void Settings_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void ScriptEditorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)ScriptEditorComboBox.Items[ScriptEditorComboBox.SelectedIndex] != "Add a custom editor")
            {
                if((string)ScriptEditorComboBox.Items[ScriptEditorComboBox.SelectedIndex] != "Internal Editor")
                {
                    Config.UserSettings.ScriptEditor = (string)ScriptEditorComboBox.Items[ScriptEditorComboBox.SelectedIndex];
                }
                else
                {
                    Config.UserSettings.ScriptEditor = "default";
                }
                File.WriteAllText($@"{FManager.GetJsonFolder()}\settings.json", JsonConvert.SerializeObject(Config.UserSettings));
            }
            else
            {
                if(openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(openFileDialog.FileName))
                    {
                        Config.UserSettings.ScriptEditorList.Add(Path.GetFileNameWithoutExtension(openFileDialog.FileName), openFileDialog.FileName);
                        File.WriteAllText($@"{FManager.GetJsonFolder()}\settings.json", JsonConvert.SerializeObject(Config.UserSettings));

                        ScriptEditorComboBox.Items.Clear();
                        ScriptEditorComboBox.Items.Add("Internal Editor");
                        for (int i = 0; i < Config.UserSettings.ScriptEditorList.Count; i++)
                        {
                            ScriptEditorComboBox.Items.Add(Config.UserSettings.ScriptEditorList.ElementAt(i).Key);
                        }
                        ScriptEditorComboBox.Items.Add("Add a custom editor");
                    }
                    else
                        MessageBox.Show(Config.GetText("error_add_editor_message"), $"{Config.GameName} - Mod Tool", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                ScriptEditorComboBox.SelectedIndex = 0;
            }
        }

        private void PixelSampleColorMaxNum_ValueChanged(object sender, EventArgs e)
        {
            Config.UserSettings.PixelationSampleColors = (int)PixelSampleColorMaxNum.Value;
            File.WriteAllText($@"{FManager.GetJsonFolder()}\settings.json", JsonConvert.SerializeObject(Config.UserSettings));
        }

        private void restoreProjectsButton_Click(object sender, EventArgs e)
        {
            
            switch( MessageBox.Show(Config.GetText("restore_projects_message"), $"{Config.GameName} - Mod Tool", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) )
            {
                case DialogResult.Yes:

                    string[] allFoldersDel = Directory.GetDirectories($@"{AppDomain.CurrentDomain.BaseDirectory}\..\game\mods\");

                    foreach (string folder in allFoldersDel)
                    {
                        if (File.Exists($"{folder}/project.json"))
                            File.Delete($"{folder}/project.json");

                        File.WriteAllText($"{folder}/project.json", JsonConvert.SerializeObject( new Project(Path.GetDirectoryName(folder), ModType.ModRenPy)) );
                    }

                    break;

                case DialogResult.No:

                    string[] allFolders = Directory.GetDirectories($@"{AppDomain.CurrentDomain.BaseDirectory}\..\game\mods\");

                    foreach (string folder in allFolders)
                    {
                        File.WriteAllText($"{folder}/project.json", JsonConvert.SerializeObject(new Project(Path.GetDirectoryName(folder), ModType.ModRenPy)));
                    }

                    break;
            }
        
        }
    }
}
