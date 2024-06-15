using ModTool.Forms.Explorer;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ModTool.Forms
{
    public partial class GameResourceTable : Form
    {
        public GameResourceTable()
        {
            InitializeComponent();

            Text = Config.GetText("game_resource_table_title");
            CharacterButton.Text = Config.GetText("game_resource_table_character");
            SoundListButton.Text = Config.GetText("game_resource_table_sound_list");
            MusicListButton.Text = Config.GetText("game_resource_table_music_list");
            SpritesButton.Text = Config.GetText("game_resource_table_sprites");
            BackgroundButton.Text = Config.GetText("game_resource_table_background");

            string jsonFile = File.ReadAllText($@"{FManager.GetTableFolder()}\characters.json");
            List<string> strings = JsonConvert.DeserializeObject<List<string>>(jsonFile);

            flowLayoutPanel1.Controls.Clear();
            foreach (string line in strings)
            {
                Label label = new Label();
                label.Padding = new Padding(10, 10, 0, 10);
                label.Text = line;
                label.AutoSize = true;
                label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));

                flowLayoutPanel1.Controls.Add(label);
            }
        }

        private void CharacterButton_Click(object sender, EventArgs e)
        {
            string jsonFile = File.ReadAllText($@"{FManager.GetTableFolder()}\characters.json");
            List<string> strings = JsonConvert.DeserializeObject<List<string>>(jsonFile);

            flowLayoutPanel1.Controls.Clear();
            foreach (string line in strings)
            {
                Label label = new Label();
                label.Padding = new Padding(10, 10, 0, 10);
                label.Text = line;
                label.AutoSize = true;
                label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));

                flowLayoutPanel1.Controls.Add(label);
            }
        }

        private void SpritesButton_Click(object sender, EventArgs e)
        {
            string jsonFile = File.ReadAllText($@"{FManager.GetTableFolder()}\sprites.json");
            Dictionary<string, string> strings = JsonConvert.DeserializeObject<Dictionary<string, string>>(jsonFile);

            flowLayoutPanel1.Controls.Clear();
            for (int i = 0; i < strings.Count; i++)
            {
                if (strings.ElementAt(i).Value != string.Empty && File.Exists($"{FManager.GetGameFolder()}/archive.rpa"))
                {
                    LinkLabel linkLabel = new LinkLabel();
                    linkLabel.Padding = new Padding(10, 10, 0, 10);
                    linkLabel.Text = strings.ElementAt(i).Key;
                    linkLabel.AutoSize = true;
                    linkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                    linkLabel.Click += (s, eh) => { var ll_b = string.Empty; strings.TryGetValue( ((LinkLabel)s).Text, out ll_b);  Rpa_Explorer rpa_Explorer = new Rpa_Explorer(ll_b); rpa_Explorer.ShowDialog(); };

                    flowLayoutPanel1.Controls.Add(linkLabel);
                }
                else
                {
                    Label label = new Label();
                    label.Padding = new Padding(10, 10, 0, 10);
                    label.Text = strings.ElementAt(i).Key;
                    label.AutoSize = true;
                    label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));

                    flowLayoutPanel1.Controls.Add(label);
                }
            }
        }

        private void BackgroundButton_Click(object sender, EventArgs e)
        {
            string jsonFile = File.ReadAllText($@"{FManager.GetTableFolder()}\backgrounds.json");
            Dictionary<string, string> strings = JsonConvert.DeserializeObject<Dictionary<string, string>>(jsonFile);

            flowLayoutPanel1.Controls.Clear();
            for (int i = 0; i < strings.Count; i++)
            {
                if (strings.ElementAt(i).Value != string.Empty && File.Exists($"{FManager.GetGameFolder()}/archive.rpa"))
                {
                    LinkLabel linkLabel = new LinkLabel();
                    linkLabel.Padding = new Padding(10, 10, 0, 10);
                    linkLabel.Text = strings.ElementAt(i).Key;
                    linkLabel.AutoSize = true;
                    linkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                    linkLabel.Click += (s, eh) => { var ll_b = string.Empty; strings.TryGetValue(((LinkLabel)s).Text, out ll_b); Rpa_Explorer rpa_Explorer = new Rpa_Explorer(ll_b); rpa_Explorer.ShowDialog(); };

                    flowLayoutPanel1.Controls.Add(linkLabel);
                }
                else
                {
                    Label label = new Label();
                    label.Padding = new Padding(10, 10, 0, 10);
                    label.Text = strings.ElementAt(i).Key;
                    label.AutoSize = true;
                    label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));

                    flowLayoutPanel1.Controls.Add(label);
                }
            }
        }

        private void SoundListButton_Click(object sender, EventArgs e)
        {
            string jsonFile = File.ReadAllText($@"{FManager.GetTableFolder()}\sounds.json");
            Dictionary<string, string> strings = JsonConvert.DeserializeObject<Dictionary<string, string>>(jsonFile);

            flowLayoutPanel1.Controls.Clear();
            for (int i = 0; i < strings.Count; i++)
            {
                if (strings.ElementAt(i).Value != string.Empty && File.Exists($"{FManager.GetGameFolder()}/archive.rpa"))
                {
                    LinkLabel linkLabel = new LinkLabel();
                    linkLabel.Padding = new Padding(10, 10, 0, 10);
                    linkLabel.Text = strings.ElementAt(i).Key;
                    linkLabel.AutoSize = true;
                    linkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                    linkLabel.Click += (s, eh) => { var ll_b = string.Empty; strings.TryGetValue(((LinkLabel)s).Text, out ll_b); Rpa_Explorer rpa_Explorer = new Rpa_Explorer(ll_b); rpa_Explorer.ShowDialog(); };

                    flowLayoutPanel1.Controls.Add(linkLabel);
                }
                else
                {
                    Label label = new Label();
                    label.Padding = new Padding(10, 10, 0, 10);
                    label.Text = strings.ElementAt(i).Key;
                    label.AutoSize = true;
                    label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));

                    flowLayoutPanel1.Controls.Add(label);
                }
            }
        }

        private void MusicListButton_Click(object sender, EventArgs e)
        {
            string jsonFile = File.ReadAllText($@"{FManager.GetTableFolder()}\musics.json");
            Dictionary<string, string> strings = JsonConvert.DeserializeObject<Dictionary<string, string>>(jsonFile);

            flowLayoutPanel1.Controls.Clear();
            for (int i = 0; i < strings.Count; i++)
            {
                if (strings.ElementAt(i).Value != string.Empty && File.Exists($"{FManager.GetGameFolder()}/archive.rpa"))
                {
                    LinkLabel linkLabel = new LinkLabel();
                    linkLabel.Padding = new Padding(10, 10, 0, 10);
                    linkLabel.Text = strings.ElementAt(i).Key;
                    linkLabel.AutoSize = true;
                    linkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                    linkLabel.Click += (s, eh) => { var ll_b = string.Empty; strings.TryGetValue(((LinkLabel)s).Text, out ll_b); Rpa_Explorer rpa_Explorer = new Rpa_Explorer(ll_b); rpa_Explorer.ShowDialog(); };

                    flowLayoutPanel1.Controls.Add(linkLabel);
                }
                else
                {
                    Label label = new Label();
                    label.Padding = new Padding(10, 10, 0, 10);
                    label.Text = strings.ElementAt(i).Key;
                    label.AutoSize = true;
                    label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));

                    flowLayoutPanel1.Controls.Add(label);
                }
            }
        }
    }
}
