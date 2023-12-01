using Newtonsoft.Json;
using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;

namespace ModTool.Forms.Panel
{
    public partial class Skin : Form
    {
        private int ModID, ID;

        private List<Classes.Skin> Skins = new List<Classes.Skin>();
        private List<Classes.ExampleTexture> ExampleTextures = new List<Classes.ExampleTexture>();

        private Dictionary<int, string> UserTextures = new Dictionary<int, string>();

        public Skin(int ModID, int ID)
        {
            InitializeComponent();

            this.ModID = ModID;
            this.ID = ID;

            var allSkins = FManager.GetAllSkinsFiles();
            var allExampleTextures = FManager.GetAllResourcesFiles();

            foreach (string file in allSkins)
            {
                var jsonFile = File.ReadAllText(file);
                Classes.Skin skinTP = JsonConvert.DeserializeObject<Classes.Skin>(jsonFile);
                Skins.Add(skinTP);
            }

            foreach (string file in allExampleTextures)
            {
                var jsonFile = File.ReadAllText(file);

                ExampleTextures = JsonConvert.DeserializeObject<List<Classes.ExampleTexture>>(jsonFile);
            }

            if(File.Exists($@"{FManager.GetProjectFolder(ModID)}\image\skin_info.json"))
            {
                var jsonFile = File.ReadAllText($@"{FManager.GetProjectFolder(ModID)}\image\skin_info.json");

                UserTextures = JsonConvert.DeserializeObject<Dictionary<int, string>>(jsonFile);
            }

            LoadComboBox();
        }

        private void ExampleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ExampleComboBox.SelectedIndex != -1) { UserChangeButton.Enabled = true; UserClearButton.Enabled = true; };

            var skinInfo = Skins.Find(id => id.Mode == ID).List[ExampleComboBox.SelectedIndex];

            ExampleTexture.BackgroundImage = Image.FromFile($@"{AppDomain.CurrentDomain.BaseDirectory}\{ExampleTextures[skinInfo.Texture].Path}");

            if (UserTextures.ContainsKey(skinInfo.Texture))
                UserTexture.BackgroundImage = Image.FromFile(UserTextures[skinInfo.Texture]);
            else
                UserTexture.BackgroundImage = null;

            ExampleLabel.Text = $"The size of the original image is {skinInfo.Size}";
        
            if(skinInfo.SizeEditor)
            {
                TextureWidthNum.Enabled = true;
                TextureHeightNum.Enabled = true;
            }
            else
            {
                TextureWidthNum.Enabled = false;
                TextureHeightNum.Enabled = false;
            }

            string[] textureSize = skinInfo.Size.Split('x');
            TextureWidthNum.Value = Convert.ToInt32(textureSize[0]);
            TextureHeightNum.Value = Convert.ToInt32(textureSize[1]);
        }

        private void UserChangeButton_Click(object sender, EventArgs e)
        {
            if (SelectImageFile.ShowDialog() == DialogResult.OK)
            {
                string filePath = $@"{FManager.GetProjectFolder(ModID)}\image\{Guid.NewGuid()}{Path.GetExtension(SelectImageFile.SafeFileName)}";

                File.Copy(SelectImageFile.FileName, filePath, true);

                var skinInfo = Skins.Find(id => id.Mode == ID).List[ExampleComboBox.SelectedIndex];

                UserTexture.BackgroundImage = Image.FromFile(filePath);
                UserTextures.Add(ExampleTextures[skinInfo.Texture].ID, filePath);

                File.Create($@"{FManager.GetProjectFolder(ModID)}\image\skin_info.json").Close();
                using (StreamWriter file = File.CreateText($@"{FManager.GetProjectFolder(ModID)}\image\skin_info.json"))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Formatting = Formatting.Indented;
                    serializer.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                    serializer.Serialize(file, UserTextures);
                }
            }
        }

        private void UserClearButton_Click(object sender, EventArgs e)
        {
            var skinInfo = Skins.Find(id => id.Mode == ID).List[ExampleComboBox.SelectedIndex];

            UserTexture.BackgroundImage = null;
            UserTextures.Remove(ExampleTextures[skinInfo.Texture].ID);

            File.Create($@"{FManager.GetProjectFolder(ModID)}\image\skin_info.json").Close();
            using (StreamWriter file = File.CreateText($@"{FManager.GetProjectFolder(ModID)}\image\skin_info.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Formatting = Formatting.Indented;
                serializer.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                serializer.Serialize(file, UserTextures);
            }
        }

        private void LoadComboBox()
        {

            ExampleComboBox.Items.Clear();

            foreach(Classes.ComboBoxList_Skin comboBoxList in Skins.Find(id => id.Mode == ID).List)
            {
                ExampleComboBox.Items.Add(comboBoxList.Name);
            }

        }
    }
}
