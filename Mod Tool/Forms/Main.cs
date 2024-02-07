using Newtonsoft.Json;
using System;
using System.IO;
using System.Windows.Forms;
using System.Threading;
using System.Collections.Generic;

namespace ModTool.Forms
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            Thread thread = new Thread(new ThreadStart(Program.StartSplashScreen));
            thread.Start();

            #region Loading | Region
            try
            {
                if (!Directory.Exists($@"{AppDomain.CurrentDomain.BaseDirectory}\..\game\mods\"))
                    Directory.CreateDirectory($@"{AppDomain.CurrentDomain.BaseDirectory}\..\game\mods\");

                if (File.Exists($@"{FManager.GetJsonFolder()}\settings.json"))
                {
                    Config.UserSettings = JsonConvert.DeserializeObject<ModTool.Settings>(File.ReadAllText($@"{FManager.GetJsonFolder()}\settings.json"));
                }
                else
                {
                    Config.UserSettings = new ModTool.Settings();
                    File.WriteAllText($@"{FManager.GetJsonFolder()}\settings.json", JsonConvert.SerializeObject(Config.UserSettings));
                }

                var allLanguage = Directory.GetFiles($@"{FManager.GetJsonFolder()}\language", "*.json", SearchOption.TopDirectoryOnly);

                foreach (string file in allLanguage)
                {
                    if (Path.GetFileNameWithoutExtension(file) == Config.UserSettings.Language)
                        Config.Language = JsonConvert.DeserializeObject<Dictionary<string, string>>(File.ReadAllText(file));
                }

                Program.SplashScreen.LoadingLabel.Text = Config.GetText("loading_settings");

                Thread.Sleep(2000);

                Program.SplashScreen.LoadingLabel.Text = Config.GetText("loading_steam");

                Thread.Sleep(2000);

                try { Steam.Init(); } catch { Program.SplashScreen.LoadingLabel.Text = Config.GetText("loading_steam_error"); }

                Thread.Sleep(2000);

                Program.SplashScreen.LoadingLabel.Text = Config.GetText("loading_projects");
                ResetProjectList();

                Thread.Sleep(2000);

                Program.SplashScreen.LoadingLabel.Text = Config.GetText("loading_confirm");
            }
            catch
            {
                Program.SplashScreen.LoadingLabel.Text = Config.GetText("loading_error");
            }
            #endregion

            Thread.Sleep(2000);
            thread.Abort();

            NewButton.Text = Config.GetText("new_button");
            OpenButton.Text = Config.GetText("open_button");
            DeleteButton.Text = Config.GetText("delete_button");
            SettingsButton.Text = Config.GetText("settings_button");
            label1.Text = $"{Config.GameName} - Mod Tool";
        }

        private void ResetProjectList()
        {
            var allProject = Directory.GetFiles($@"{AppDomain.CurrentDomain.BaseDirectory}\..\game\mods\", "project.json", SearchOption.AllDirectories);
            ProjectListView.Clear();
            Program.Projects.Clear();

            foreach (string file in allProject)
            {
                var jsonFile = File.ReadAllText(file);
                Project project = JsonConvert.DeserializeObject<Project>(jsonFile);

                Program.Projects.Add(project);
                ProjectListView.Items.Add(project.Name, 0);
            }
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            AddProject addProject = new AddProject();
            if (addProject.ShowDialog() == DialogResult.OK)
            {
                Project project = new Project(addProject.ModName, addProject.ModType);
                var json = JsonConvert.SerializeObject(project);

                Directory.CreateDirectory(FManager.GetProjectFolder(project));

                File.WriteAllText($@"{FManager.GetProjectFolder(project)}\project.json", json);

                switch (project.Type)
                {
                    case ModType.SnakeSkin:
                        Directory.CreateDirectory($@"{FManager.GetProjectFolder(project)}\image");
                        break;

                    case ModType.FlappyBirdSkin:
                        Directory.CreateDirectory($@"{FManager.GetProjectFolder(project)}\image");
                        break;

                    case ModType.SnakeMode:
                        break;

                    case ModType.FlappyBirdMode:
                        break;

                    case ModType.ModRenPy:
                        var rpaFile = File.ReadAllText($@"{FManager.GetExampleFolder()}\base.rpy");

                        rpaFile = rpaFile.Replace("{label}", project.Name.ToLower().Replace(" ", "_").Replace("  ", "__").Replace("-", "_"));
                        rpaFile = rpaFile.Replace("{name}", project.Name);

                        File.WriteAllText($@"{FManager.GetProjectFolder(project)}\{project.Name}.rpy", rpaFile);
                        break;

                    case ModType.ModeVisualScript:
                        break;

                    default:
                        Directory.CreateDirectory($@"{FManager.GetProjectFolder(project)}\image");
                        Directory.CreateDirectory($@"{FManager.GetProjectFolder(project)}\audio");
                        Directory.CreateDirectory($@"{FManager.GetProjectFolder(project)}\video");
                        break;
                }

                ResetProjectList();
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Directory.Delete($@"{AppDomain.CurrentDomain.BaseDirectory}\..\game\mods\{Program.Projects[ProjectListView.SelectedIndices[0]].Name}", true);
            ResetProjectList();
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            Editor editor = new Editor(ProjectListView.SelectedIndices[0]);
            editor.Show();
            Hide();
        }

        private void ProjectListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Editor editor = new Editor(ProjectListView.SelectedIndices[0], this);
            editor.Show();
            Hide();
        }

        private void Main_Shown(object sender, EventArgs e) { }  

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            Forms.Settings settings = new Settings();
            if(settings.ShowDialog() == DialogResult.OK)
            {
                NewButton.Text = Config.GetText("new_button");
                OpenButton.Text = Config.GetText("open_button");
                DeleteButton.Text = Config.GetText("delete_button");
                SettingsButton.Text = Config.GetText("settings_button");
            }
        }
    }
}
