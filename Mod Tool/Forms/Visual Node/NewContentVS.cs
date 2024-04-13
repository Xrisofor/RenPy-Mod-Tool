using System;
using System.IO;
using System.Windows.Forms;

namespace ModTool.Forms
{
    public partial class NewContentVS : Form
    {
        int ModID;

        public NewContentVS(int ModID)
        {
            InitializeComponent();

            this.ModID = ModID;

            AddButton.Text = Config.GetText("add_button");
            RemoveButton.Text = Config.GetText("delete_button");
            ReloadButton.Text = Config.GetText("reload_button");
            Text = Config.GetText("add_visual_content_title");

            LoadContentItems();
        }

        private void LoadContentItems()
        {
            listView1.Items.Clear();
            string contentFolderPath = $@"{FManager.GetProjectFolder(ModID)}/content";

            if (Directory.Exists(contentFolderPath))
            {
                string[] files = Directory.GetFiles(contentFolderPath);

                foreach (string file in files)
                {
                    string fileName = Path.GetFileName(file);
                    int imageIndex = GetImageIndex(file);
                    listView1.Items.Add(new ListViewItem() { Text = fileName, ImageIndex = imageIndex });
                }
            }
        }

        public static int GetImageIndex(string filePath)
        {
            int imageIndex = -1;

            switch (Path.GetExtension(filePath).ToLower())
            {
                case ".png":
                case ".jpg":
                case ".jpeg":
                    imageIndex = 1;
                    break;

                case ".mp3":
                case ".wav":
                case ".ogg":
                    imageIndex = 0;
                    break;

                default:
                    break;
            }

            return imageIndex;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName = Path.GetFileName(openFileDialog1.FileName);
                string filePath = openFileDialog1.FileName;

                string contentFolderPath = $@"{FManager.GetProjectFolder(ModID)}/content";
                if (!Directory.Exists(contentFolderPath))
                    Directory.CreateDirectory(contentFolderPath);

                string destinationFilePath = Path.Combine(contentFolderPath, fileName);
                File.Copy(filePath, destinationFilePath, true);

                int imageIndex = GetImageIndex(openFileDialog1.FileName);
                listView1.Items.Add( new ListViewItem() { Text = fileName, ImageIndex = imageIndex } );

                saveRenPyFile();
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            try
            {
                File.Delete($@"{FManager.GetProjectFolder(ModID)}/content/{listView1.SelectedItems[0].Text}");
                listView1.Items.RemoveAt(listView1.SelectedIndices[0]);
                saveRenPyFile();
            }
            catch { }
        }

        private void ReloadButton_Click(object sender, EventArgs e) => LoadContentItems();
    
        private void saveRenPyFile()
        {
            if (listView1.Items.Count != 0)
            {
                string finalFileString = $"init 2:{Environment.NewLine}";

                foreach (ListViewItem fileList in listView1.Items)
                {

                    int keyIndex = GetImageIndex($@"{FManager.GetProjectFolder(ModID)}/content/{fileList.Text}");

                    if (keyIndex == 1)
                        finalFileString += $"   image {StringExtension.CyrilicToLatin(Path.GetFileNameWithoutExtension($@"{FManager.GetProjectFolder(ModID)}/content/{fileList.Text}"))} = \"mods/{Program.Projects[ModID].Name}/content/{fileList.Text}\"{Environment.NewLine}";
                    else
                    {
                        finalFileString += $"   $ sound_list[\"{StringExtension.CyrilicToLatin(Path.GetFileNameWithoutExtension($@"{FManager.GetProjectFolder(ModID)}/content/{fileList.Text}").ToLower().Replace(" ", "_").Replace(",", "_").Replace("-", "_").Replace(".", "_"))}\"] = \"mods/{Program.Projects[ModID].Name}/content/{fileList.Text}\"{Environment.NewLine}";
                        finalFileString += $"   $ music_list[\"{StringExtension.CyrilicToLatin(Path.GetFileNameWithoutExtension($@"{FManager.GetProjectFolder(ModID)}/content/{fileList.Text}").ToLower().Replace(" ", "_").Replace(",", "_").Replace("-", "_").Replace(".", "_"))}\"] = \"mods/{Program.Projects[ModID].Name}/content/{fileList.Text}\"{Environment.NewLine}";
                    }

                }

                File.WriteAllText($@"{FManager.GetProjectFolder(ModID)}/{StringExtension.CyrilicToLatin(Program.Projects[ModID].Name)}_Content.rpy", finalFileString);
            }
            else
                File.Delete($@"{FManager.GetProjectFolder(ModID)}/{StringExtension.CyrilicToLatin(Program.Projects[ModID].Name)}_Content.rpy");
        }
    }
}
