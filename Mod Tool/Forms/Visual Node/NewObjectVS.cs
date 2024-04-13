using ModTool.Classes;
using Newtonsoft.Json;
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ModTool.Forms
{
    public enum VSObject
    {
        // Dialog
        say,
        menu,
        jump,
        comment,
        pause,

        // Images
        show,
        hide,
        scene,
        with,

        // Audio
        play_sound,
        play_music,
        stop,

        // Other
        discord,
        snake_game,
        flappy_bird_game
    }

    public partial class NewObjectVS : Form
    {
        public VSObject SelectedEnum { get; private set; }
        public string TextNumCheck { get; private set; }
        public object AdditionallyEnum { get; private set; } = -1;

        private bool TextOnly, Editing; private int ModID;

        public NewObjectVS(int ModID, bool textOnly = false)
        {
            InitializeComponent();

            this.ModID = ModID;
            TextOnly = textOnly;
            typeComboBox.DataSource = Enum.GetNames(typeof(VSObject));

            if (textOnly)
            {
                typeComboBox.Enabled = false;
                additionallyComboBox.Enabled = false;
                textBox1.Enabled = true;
            }

            label2.Text = Config.GetText("add_project_type");
            label3.Text = Config.GetText("add_visual_object_additionally");
            label1.Text = Config.GetText("add_visual_object_text");
            AddButton.Text = Config.GetText("add_button");
            Text = Config.GetText("add_visual_object_title");

        }

        public void EditItem(RenPyNode node)
        {
            Editing = true; Text = Config.GetText("edit_visual_object_title");
            VSObject[] enumValues = (VSObject[])Enum.GetValues(typeof(VSObject));
            SelectedEnum = (VSObject)Enum.Parse(typeof(VSObject), node.Type);

            typeComboBox.SelectedIndex = Array.IndexOf(enumValues, SelectedEnum);

            AddButton.Text = Config.GetText("save_button");

            switch (SelectedEnum)
            {
                case VSObject.say:
                    try { additionallyComboBox.SelectedItem = node.Character; }
                    catch { additionallyComboBox.SelectedItem = "none"; }
                    textBox1.Text = node.Content;
                    break;

                case VSObject.jump:
                case VSObject.comment:
                case VSObject.pause:
                case VSObject.discord:
                case VSObject.snake_game:
                case VSObject.flappy_bird_game:
                    textBox1.Text = node.Content;
                    break;

                default:
                    additionallyComboBox.SelectedItem = node.Content;
                    break;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Enum.TryParse(typeComboBox.SelectedValue?.ToString(), out VSObject selectedEnum);
            SelectedEnum = selectedEnum;

            switch (SelectedEnum)
            {
                // Dialog
                case VSObject.say:
                    additionallyComboBox.Enabled = true;
                    textBox1.Enabled = true;

                    List<string[]> charactersDataSource = new List<string[]>();

                    if (File.Exists($@"{FManager.GetProjectFolder(ModID)}\{Program.Projects[ModID].Name}_Characters.json"))
                    {
                        Dictionary<string, string> customCharactersStrings = JsonConvert.DeserializeObject<Dictionary<string, string>>(File.ReadAllText($@"{FManager.GetProjectFolder(ModID)}\{Program.Projects[ModID].Name}_Characters.json"));
                        charactersDataSource.Add(customCharactersStrings.Keys.ToArray());
                    }

                    List<string> charactersStrings = JsonConvert.DeserializeObject<List<string>>(File.ReadAllText($@"{FManager.GetTableFolder()}\characters.json"));
                    charactersStrings.Add("none"); charactersDataSource.Add(charactersStrings.ToArray());

                    additionallyComboBox.DataSource = charactersDataSource.SelectMany(arr => arr).ToArray();

                    break;
                case VSObject.menu:
                    additionallyComboBox.Enabled = false;
                    textBox1.Enabled = false;
                    break;

                // Image
                case VSObject.show:
                    additionallyComboBox.Enabled = true;
                    textBox1.Enabled = false;
                    List<string> showImages = new List<string>();

                    if (Directory.Exists($@"{FManager.GetProjectFolder(ModID)}/content"))
                    {
                        string[] files = Directory.GetFiles($@"{FManager.GetProjectFolder(ModID)}/content");
                        foreach (string file in files)
                        {
                            if (NewContentVS.GetImageIndex(file) == 1)
                                showImages.Add(StringExtension.CyrilicToLatin(Path.GetFileNameWithoutExtension(file)));
                        }
                    }

                    Dictionary<string, string> imgShowStrings = JsonConvert.DeserializeObject<Dictionary<string, string>>(File.ReadAllText($@"{FManager.GetTableFolder()}\sprites.json"));
                    showImages.AddRange( imgShowStrings.Keys );

                    additionallyComboBox.DataSource = showImages;
                    break;
                case VSObject.hide:
                    additionallyComboBox.Enabled = true;
                    textBox1.Enabled = false;
                    List<string> hideImages = new List<string>();

                    if (Directory.Exists($@"{FManager.GetProjectFolder(ModID)}/content"))
                    {
                        string[] files = Directory.GetFiles($@"{FManager.GetProjectFolder(ModID)}/content");
                        foreach (string file in files)
                        {
                            if (NewContentVS.GetImageIndex(file) == 1)
                                hideImages.Add(StringExtension.CyrilicToLatin(Path.GetFileNameWithoutExtension(file)));
                        }
                    }

                    Dictionary<string, string> imgHideStrings = JsonConvert.DeserializeObject<Dictionary<string, string>>(File.ReadAllText($@"{FManager.GetTableFolder()}\sprites.json"));
                    hideImages.AddRange(imgHideStrings.Keys);

                    additionallyComboBox.DataSource = hideImages;
                    break;
                case VSObject.scene:
                    additionallyComboBox.Enabled = true;
                    textBox1.Enabled = false;
                    List<string> sceneImages = new List<string>();

                    if (Directory.Exists($@"{FManager.GetProjectFolder(ModID)}/content"))
                    {
                        string[] files = Directory.GetFiles($@"{FManager.GetProjectFolder(ModID)}/content");
                        foreach (string file in files)
                        {
                            if (NewContentVS.GetImageIndex(file) == 1)
                                sceneImages.Add(StringExtension.CyrilicToLatin(Path.GetFileNameWithoutExtension(file)));
                        }
                    }

                    Dictionary<string, string> backgroundStrings = JsonConvert.DeserializeObject<Dictionary<string, string>>(File.ReadAllText($@"{FManager.GetTableFolder()}\backgrounds.json"));
                    sceneImages.AddRange(backgroundStrings.Keys);

                    additionallyComboBox.DataSource = sceneImages;
                    break;
                case VSObject.with:
                    additionallyComboBox.Enabled = true;
                    textBox1.Enabled = false;

                    additionallyComboBox.DataSource = new string[] { "dissolve", "fade", "pixellate", "moveinright", "moveinleft", "moveintop", "moveinbottom", "moveoutright", "moveoutleft", "moveouttop", "moveoutbottom",
                    "easeinright", "easeinleft", "easeintop", "easeinbottom", "easeoutright", "easeoutleft", "easeouttop", "easeoutbottom" };
                    break;

                // Sound
                case VSObject.play_sound:
                    additionallyComboBox.Enabled = true;
                    textBox1.Enabled = false;
                    List<string> soundList = new List<string>();

                    if (Directory.Exists($@"{FManager.GetProjectFolder(ModID)}/content"))
                    {
                        string[] files = Directory.GetFiles($@"{FManager.GetProjectFolder(ModID)}/content");
                        foreach (string file in files)
                        {
                            if (NewContentVS.GetImageIndex(file) == 0)
                                soundList.Add(StringExtension.CyrilicToLatin( Path.GetFileNameWithoutExtension(file).ToLower().Replace(" ", "_").Replace(",", "_").Replace("-", "_").Replace(".", "_") ));
                        }
                    }

                    Dictionary<string, string> audioStrings = JsonConvert.DeserializeObject<Dictionary<string, string>>(File.ReadAllText($@"{FManager.GetTableFolder()}\sounds.json"));
                    soundList.AddRange(audioStrings.Keys);

                    additionallyComboBox.DataSource = soundList;
                    break;
                case VSObject.play_music:
                    additionallyComboBox.Enabled = true;
                    textBox1.Enabled = false;
                    List<string> musicList = new List<string>();

                    if (Directory.Exists($@"{FManager.GetProjectFolder(ModID)}/content"))
                    {
                        string[] files = Directory.GetFiles($@"{FManager.GetProjectFolder(ModID)}/content");
                        foreach (string file in files)
                        {
                            if (NewContentVS.GetImageIndex(file) == 0)
                                musicList.Add(StringExtension.CyrilicToLatin( Path.GetFileNameWithoutExtension(file).ToLower().Replace(" ", "_").Replace(",", "_").Replace("-", "_").Replace(".", "_") ));
                        }
                    }

                    Dictionary<string, string> musicStrings = JsonConvert.DeserializeObject<Dictionary<string, string>>(File.ReadAllText($@"{FManager.GetTableFolder()}\musics.json"));
                    musicList.AddRange(musicStrings.Keys);

                    additionallyComboBox.DataSource = musicList;
                    break;
                case VSObject.stop:
                    additionallyComboBox.Enabled = true;
                    textBox1.Enabled = false;

                    additionallyComboBox.DataSource = new string[] { "music", "sound", "ambiences" };
                    break;

                default:
                    additionallyComboBox.Enabled = false;
                    textBox1.Enabled = true;
                    break;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            switch(SelectedEnum)
            {
                case VSObject.show:
                case VSObject.hide:
                case VSObject.scene:
                case VSObject.play_music:
                case VSObject.play_sound:
                case VSObject.stop:
                case VSObject.with:
                case VSObject.menu:
                    DialogResult = DialogResult.OK; break;

                default:

                    if (textBox1.Text != string.Empty)
                    {
                        if (typeComboBox.SelectedIndex != -1 || TextOnly || Editing)
                            DialogResult = DialogResult.OK;
                        else
                            MessageBox.Show("To create a new item, select it from the drop-down list!", "Game Mod Tool", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        MessageBox.Show("To continue enter text / number / check in the text box!", "Game Mod Tool", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    break;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e) => TextNumCheck = textBox1.Text;

        private void additionallyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (SelectedEnum)
            {
                case VSObject.say:
                case VSObject.show:
                case VSObject.hide:
                case VSObject.scene:
                case VSObject.play_music:
                case VSObject.play_sound:
                case VSObject.stop:
                case VSObject.with:
                    AdditionallyEnum = additionallyComboBox.Items[additionallyComboBox.SelectedIndex];
                    break;

                default:
                    AdditionallyEnum = additionallyComboBox.SelectedIndex;
                    break;
            }
        }
    }
}