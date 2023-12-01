using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using Newtonsoft.Json;
using WMPLib;

namespace ModTool.Forms
{
    public enum ManagerType
    {
        Audio,
        Sprite,
        Video
    }

    public partial class SpriteManager : Form
    {
        public int SelectedIndex { get; private set; }

        private ManagerType ManagerType;
        private int ModID;
        private WindowsMediaPlayer WMP = new WindowsMediaPlayer();

        public SpriteManager(ManagerType Type, int ModID)
        {
            InitializeComponent();
            ManagerType = Type;
            this.ModID = ModID;

            switch (Type)
            {
                case ManagerType.Sprite:
                    Text = "Sprite Manager";
                    ObjectsListView.LargeImageList = SpritesList;
                    foreach (Item sprite in Program.Sprites)
                    {
                        SpritesList.Images.Add(Path.GetFileName(sprite.Path), Image.FromFile(sprite.Path));
                        ObjectsListView.Items.Add(Path.GetFileName(sprite.Path), Path.GetFileName(sprite.Path));
                    }

                    if (File.Exists(Program.Projects[ModID].SpriteManager))
                        ReloadButton_Click(this, EventArgs.Empty);

                    break;

                case ManagerType.Audio:
                    Text = "Audio Manager";
                    ObjectsListView.LargeImageList = OtherList;
                    foreach (Item audio in Program.Audio)
                    {
                        ObjectsListView.Items.Add(Path.GetFileName(audio.Path), "audio");
                    }

                    if(File.Exists(Program.Projects[ModID].AudioManager))
                        ReloadButton_Click(this, EventArgs.Empty);

                    StopButton.Enabled = true;

                    break;
            }
        }

        private void Save()
        {
            switch (ManagerType)
            {
                case ManagerType.Sprite:
                    File.Create($@"..\game\mods\{Program.Projects[ModID].Name}\image\sprites.json").Close();
                    using (StreamWriter file = File.CreateText($@"..\game\mods\{Program.Projects[ModID].Name}\image\sprites.json"))
                    {
                        JsonSerializer serializer = new JsonSerializer();
                        serializer.Formatting = Formatting.Indented;
                        serializer.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                        serializer.Serialize(file, Program.Sprites);
                    }
                    break;
                case ManagerType.Audio:
                    File.Create($@"..\game\mods\{Program.Projects[ModID].Name}\audio\audios.json").Close();
                    using (StreamWriter file = File.CreateText($@"..\game\mods\{Program.Projects[ModID].Name}\audio\audios.json"))
                    {
                        JsonSerializer serializer = new JsonSerializer();
                        serializer.Formatting = Formatting.Indented;
                        serializer.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                        serializer.Serialize(file, Program.Audio);
                    }
                    break;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            switch (ManagerType)
            {
                case ManagerType.Sprite:
                    if (SelectImageFile.ShowDialog() == DialogResult.OK)
                    {
                        SpritesList.Images.Add(SelectImageFile.SafeFileName, Image.FromFile(SelectImageFile.FileName));
                        ObjectsListView.Items.Add(SelectImageFile.SafeFileName, SelectImageFile.SafeFileName);
                        File.Copy(SelectImageFile.FileName, $@"..\game\mods\{Program.Projects[ModID].Name}/image/{SelectImageFile.SafeFileName}", true);
                        Program.Sprites.Add(new Item($@"..\game\mods\{Program.Projects[ModID].Name}/image/{SelectImageFile.SafeFileName}"));
                        Save();
                    }
                    break;
                case ManagerType.Audio:
                    if (SelectAudioFile.ShowDialog() == DialogResult.OK)
                    {
                        ObjectsListView.Items.Add(SelectAudioFile.SafeFileName, "audio");
                        File.Copy(SelectAudioFile.FileName, $@"..\game\mods\{Program.Projects[ModID].Name}/audio/{SelectAudioFile.SafeFileName}", true);
                        Program.Audio.Add(new Item($@"..\game\mods\{Program.Projects[ModID].Name}/audio/{SelectAudioFile.SafeFileName}"));
                        Save();
                    }
                    break;
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (ObjectsListView.SelectedItems.Count != 0)
            {
                switch (ManagerType)
                {
                    case ManagerType.Sprite:
                        File.Delete($@"..\game\mods\{Program.Projects[ModID].Name}/image/{ObjectsListView.SelectedItems[0].Text}");
                        Program.Sprites.RemoveAt(ObjectsListView.SelectedIndices[0]);
                        SpritesList.Images.RemoveByKey(ObjectsListView.SelectedItems[0].Text);
                        ObjectsListView.Items.Remove(ObjectsListView.SelectedItems[0]);
                        Save();
                        break;
                    case ManagerType.Audio:
                        File.Delete($@"..\game\mods\{Program.Projects[ModID].Name}/audio/{ObjectsListView.SelectedItems[0].Text}");
                        Program.Audio.RemoveAt(ObjectsListView.SelectedIndices[0]);
                        ObjectsListView.Items.Remove(ObjectsListView.SelectedItems[0]);
                        Save();
                        break;
                }
            }
        }

        private void ReloadButton_Click(object sender, EventArgs e)
        {
            ObjectsListView.Items.Clear();
            SpritesList.Images.Clear();

            switch (ManagerType)
            {
                case ManagerType.Sprite:
                    Program.Sprites.Clear();
                    string allSpritesData = File.ReadAllText(Program.Projects[ModID].SpriteManager);
                    dynamic jsonSpritesData = JsonConvert.DeserializeObject(allSpritesData);

                    foreach (var spritesData in jsonSpritesData)
                    {
                        string Path = spritesData.Path;
                        Program.Sprites.Add(new Item(Path));
                    }

                    foreach (Item sprite in Program.Sprites)
                    {
                        SpritesList.Images.Add(Path.GetFileName(sprite.Path), Image.FromFile(sprite.Path));
                        ObjectsListView.Items.Add(Path.GetFileName(sprite.Path), Path.GetFileName(sprite.Path));
                    }
                    break;
                case ManagerType.Audio:
                    Program.Audio.Clear();
                    string allAudioData = File.ReadAllText(Program.Projects[ModID].AudioManager);
                    dynamic jsonAudioData = JsonConvert.DeserializeObject(allAudioData);

                    foreach (var audioData in jsonAudioData)
                    {
                        string Path = audioData.Path;
                        Program.Audio.Add(new Item(Path));
                    }

                    foreach (Item audio in Program.Audio)
                    {
                        ObjectsListView.Items.Add(Path.GetFileName(audio.Path), "audio");
                    }
                    break;
            }
        }

        private void ObjectsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ObjectsListView.SelectedItems.Count != 0)
            {
                SelectedIndex = ObjectsListView.SelectedIndices[0];

                if(ManagerType == ManagerType.Audio)
                    PlayButton.Enabled = true;
            }
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            if (ObjectsListView.SelectedItems.Count != 0)
            {
                WMP.URL = Path.GetFullPath(Program.Audio[SelectedIndex].Path);
                WMP.controls.play();
            }
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            WMP.controls.stop();
        }
    }
}
