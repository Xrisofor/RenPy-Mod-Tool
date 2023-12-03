using Newtonsoft.Json;
using System;
using System.IO;
using System.Windows.Forms;

namespace ModTool.Forms
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            if (!Directory.Exists($@"{AppDomain.CurrentDomain.BaseDirectory}\..\game\mods\"))
                Directory.CreateDirectory($@"{AppDomain.CurrentDomain.BaseDirectory}\..\game\mods\");

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
            if (addProject.ShowDialog() == DialogResult.OK && addProject.ModType != ModType.ModeVisualScript)
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

                    default:
                        Directory.CreateDirectory($@"{FManager.GetProjectFolder(project)}\image");
                        Directory.CreateDirectory($@"{FManager.GetProjectFolder(project)}\audio");
                        Directory.CreateDirectory($@"{FManager.GetProjectFolder(project)}\video");
                        break;
                }

                ResetProjectList();
            }
            else if (addProject.ModType == ModType.ModeVisualScript)
                MessageBox.Show(Config.GetText("warning_vs_message"), $"{Config.GameName} - Mod Tool", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        
        private void Main_Shown(object sender, EventArgs e)
        {
            ResetProjectList();

            Steam.Init();
        }

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
