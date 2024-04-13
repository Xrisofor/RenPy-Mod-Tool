using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ModTool.Forms
{
    public partial class NewCharacterVS : Form
    {
        int ModID;

        Dictionary<string, string> customCharacters = new Dictionary<string, string>();

        public NewCharacterVS(int ModID)
        {
            InitializeComponent();
            this.ModID = ModID;

            label2.Text = Config.GetText("character_manager_list");
            label3.Text = Config.GetText("add_project_name");
            label1.Text = Config.GetText("character_manager_var");
            Text = Config.GetText("character_manager_title");
            button1.Text = Config.GetText("add_button");
            button2.Text = Config.GetText("edit_button");
            button3.Text = Config.GetText("delete_button");

            if ( File.Exists($"{FManager.GetProjectFolder(ModID)}/{Program.Projects[ModID].Name}_Characters.json") )
            {
                customCharacters = JsonConvert.DeserializeObject<Dictionary<string, string>>( File.ReadAllText($"{FManager.GetProjectFolder(ModID)}/{Program.Projects[ModID].Name}_Characters.json") );
                
                foreach( var cusChar in customCharacters)
                {
                    listBox1.Items.Add($"{cusChar.Key} = {cusChar.Value}");
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count != 0)
            {
                button3.Enabled = true;
                button2.Enabled = true;

                textBox1.Text = customCharacters.ElementAt(listBox1.SelectedIndex).Key;
                textBox2.Text = customCharacters.ElementAt(listBox1.SelectedIndex).Value;
            }
            else
            {
                button3.Enabled = false; button2.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != string.Empty && textBox2.Text != string.Empty)
                {
                    string cleanedText = Regex.Replace(textBox1.Text, @"[^\w\s]", "").Replace(" ", "_");

                    customCharacters.Add(cleanedText, textBox2.Text);
                    textBox1.Text = string.Empty; textBox2.Text = string.Empty;

                    listBox1.Items.Clear();
                    foreach (var cusChar in customCharacters)
                    {
                        listBox1.Items.Add($"{cusChar.Key} = {cusChar.Value}");
                    }

                    saveCharactersFile();
                }
                else
                    MessageBox.Show(Config.GetText("error_text_none_message"), $"{Config.GameName} - Mod Tool", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show(Config.GetText("error_list_create_message"), $"{Config.GameName} - Mod Tool", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            customCharacters.Remove(textBox1.Text);
            textBox1.Text = string.Empty; textBox2.Text = string.Empty;

            listBox1.Items.Clear();
            foreach (var cusChar in customCharacters)
            {
                listBox1.Items.Add($"{cusChar.Key} = {cusChar.Value}");
            }

            saveCharactersFile();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var selectedKeyValuePair = customCharacters.ElementAt(listBox1.SelectedIndex);
            customCharacters.Remove(selectedKeyValuePair.Key);
            customCharacters.Add(textBox1.Text, textBox2.Text);
            textBox1.Text = string.Empty; textBox2.Text = string.Empty;

            listBox1.Items.Clear();
            foreach (var cusChar in customCharacters)
            {
                listBox1.Items.Add($"{cusChar.Key} = {cusChar.Value}");
            }

            saveCharactersFile();
        }

        private void saveCharactersFile() {

            string renPyCode = string.Empty;

            foreach (var character in customCharacters)
            {
                renPyCode += $"define {character.Key} = Character(\"{character.Value}\", color=\"#01A2D9\", what_color=\"#01A2D9\"){Environment.NewLine}";
            }

            File.WriteAllText($"{FManager.GetProjectFolder(ModID)}/{Program.Projects[ModID].Name}_Characters.rpy", renPyCode);
            File.WriteAllText($"{FManager.GetProjectFolder(ModID)}/{Program.Projects[ModID].Name}_Characters.json", JsonConvert.SerializeObject(customCharacters));

        } 
    }
}
