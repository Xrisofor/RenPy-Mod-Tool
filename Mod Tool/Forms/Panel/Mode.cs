using Newtonsoft.Json;
using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Threading;

namespace ModTool.Forms.Panel
{
    public partial class Mode : Form
    {
        private int ModID, ID;

        private List<Classes.ModG> Modes = new List<Classes.ModG>();
        private Dictionary<string, string> UserParam = new Dictionary<string, string>();

        public Mode(int ModID, int ID)
        {
            InitializeComponent();

            this.ModID = ModID;
            this.ID = ID;

            var allModes = FManager.GetAllModesFiles();

            foreach (string file in allModes)
            {
                var jsonFile = File.ReadAllText(file);
                Classes.ModG modeTP = JsonConvert.DeserializeObject<Classes.ModG>(jsonFile);
                Modes.Add(modeTP);
            }

            if (File.Exists($@"{FManager.GetProjectFolder(ModID)}\mode_info.json"))
            {
                var jsonFile = File.ReadAllText($@"{FManager.GetProjectFolder(ModID)}\mode_info.json");

                UserParam = JsonConvert.DeserializeObject<Dictionary<string, string>>(jsonFile);
            }

            LoadComboBox();
        }

        int EditorType = -1;
        private void ExampleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var modeInfo = Modes.Find(id => id.Mode == ID).List[ExampleComboBox.SelectedIndex];

            NumEditor.Enabled = modeInfo.NumberEditor;
            TextEditor.Enabled = modeInfo.TextEditor;
            BoolEditor.Enabled = modeInfo.BoolEditor;

            if(modeInfo.NumberEditor)
            {
                EditorType = 0;

                NumEditor.Focus();

                if (UserParam.ContainsKey(modeInfo.Game))
                    NumEditor.Value = Convert.ToDecimal(UserParam[modeInfo.Game].Replace(".", ","));
                else
                    NumEditor.Value = Convert.ToDecimal(modeInfo.Default);

                TextEditor.Text = string.Empty;
                BoolEditor.Checked = false;
            }

            else if (modeInfo.TextEditor)
            {
                EditorType = 1;

                TextEditor.Focus();

                if (UserParam.ContainsKey(modeInfo.Game))
                    TextEditor.Text = UserParam[modeInfo.Game];
                else
                    TextEditor.Text = modeInfo.Default;

                NumEditor.Value = 0;
                BoolEditor.Checked = false;
            }

            else if (modeInfo.BoolEditor)
            {
                EditorType = 2;

                BoolEditor.Focus();

                if (UserParam.ContainsKey(modeInfo.Game))
                    BoolEditor.Checked = Convert.ToBoolean(UserParam[modeInfo.Game]);
                else
                    BoolEditor.Checked = Convert.ToBoolean(modeInfo.Default);

                NumEditor.Value = 0;
                TextEditor.Text = string.Empty;
            }

            else
            {
                MessageBox.Show("It was not possible to find an editor for this type.", "Game Mod Tool", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NumEditor_ValueChanged(object sender, EventArgs e)
        {
            if(EditorType == 0)
            {
                var modeInfo = Modes.Find(id => id.Mode == ID).List[ExampleComboBox.SelectedIndex];

                if (UserParam.ContainsKey(modeInfo.Game))
                    UserParam[modeInfo.Game] = NumEditor.Value.ToString().Replace(",", ".");
                else
                    UserParam.Add(modeInfo.Game, NumEditor.Value.ToString().Replace(",", "."));

                SaveJson();
            }
        }

        private void TextEditor_TextChanged(object sender, EventArgs e)
        {
            if (EditorType == 1)
            {
                var modeInfo = Modes.Find(id => id.Mode == ID).List[ExampleComboBox.SelectedIndex];

                if (UserParam.ContainsKey(modeInfo.Game))
                    UserParam[modeInfo.Game] = TextEditor.Text;
                else
                    UserParam.Add(modeInfo.Game, TextEditor.Text);

                SaveJson();
            }
        }

        private void BoolEditor_CheckedChanged(object sender, EventArgs e)
        {
            if (EditorType == 2)
            {
                var modeInfo = Modes.Find(id => id.Mode == ID).List[ExampleComboBox.SelectedIndex];

                if (UserParam.ContainsKey(modeInfo.Game))
                    UserParam[modeInfo.Game] = BoolEditor.Checked.ToString();
                else
                    UserParam.Add(modeInfo.Game, BoolEditor.Checked.ToString());

                SaveJson();
            }
        }

        private void LoadComboBox()
        {

            ExampleComboBox.Items.Clear();

            foreach (Classes.ComboBoxList_Mode comboBoxList in Modes.Find(id => id.Mode == ID).List)
            {
                ExampleComboBox.Items.Add(comboBoxList.Name);
            }

        }

        private void SaveJson()
        {
            File.Create($@"{FManager.GetProjectFolder(ModID)}\mode_info.json").Close();
            using (StreamWriter file = File.CreateText($@"{FManager.GetProjectFolder(ModID)}\mode_info.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Formatting = Formatting.Indented;
                serializer.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                serializer.Serialize(file, UserParam);
            }
        }
    }
}
