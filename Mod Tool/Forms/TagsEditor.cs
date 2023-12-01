using Newtonsoft.Json;
using System;
using System.IO;
using System.Windows.Forms;

namespace ModTool.Forms
{
    public partial class TagsEditor : Form
    {
        private int ModID;

        public TagsEditor(int ModID)
        {
            InitializeComponent();
            this.ModID = ModID;

            newStoryCheckBox.Checked = Program.Projects[ModID].Tags.Contains("New Story");
            newGraphicsCheckBox.Checked = Program.Projects[ModID].Tags.Contains("New Graphics");
            newFeaturesCheckBox.Checked = Program.Projects[ModID].Tags.Contains("New Features");
            newCharactersCheckBox.Checked = Program.Projects[ModID].Tags.Contains("New Characters");
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            switch( ((CheckBox)sender).Name )
            {
                case "newStoryCheckBox":

                    if(newStoryCheckBox.Checked)
                    {
                        if(!Program.Projects[ModID].Tags.Contains("New Story"))
                            Program.Projects[ModID].Tags.Add("New Story");
                    }
                    else
                    {
                        if (Program.Projects[ModID].Tags.Contains("New Story"))
                            Program.Projects[ModID].Tags.Remove("New Story");
                    }

                    break;

                case "newGraphicsCheckBox":

                    if (newGraphicsCheckBox.Checked)
                    {
                        if (!Program.Projects[ModID].Tags.Contains("New Graphics"))
                            Program.Projects[ModID].Tags.Add("New Graphics");
                    }
                    else
                    {
                        if (Program.Projects[ModID].Tags.Contains("New Graphics"))
                            Program.Projects[ModID].Tags.Remove("New Graphics");
                    }

                    break;

                case "newFeaturesCheckBox":

                    if (newFeaturesCheckBox.Checked)
                    {
                        if (!Program.Projects[ModID].Tags.Contains("New Features"))
                            Program.Projects[ModID].Tags.Add("New Features");
                    }
                    else
                    {
                        if (Program.Projects[ModID].Tags.Contains("New Features"))
                            Program.Projects[ModID].Tags.Remove("New Features");
                    }

                    break;

                case "newCharactersCheckBox":

                    if (newCharactersCheckBox.Checked)
                    {
                        if (!Program.Projects[ModID].Tags.Contains("New Characters"))
                            Program.Projects[ModID].Tags.Add("New Characters");
                    }
                    else
                    {
                        if (Program.Projects[ModID].Tags.Contains("New Characters"))
                            Program.Projects[ModID].Tags.Remove("New Characters");
                    }

                    break;
            }

            var json = JsonConvert.SerializeObject(Program.Projects[ModID]);
            File.WriteAllText($@"{FManager.GetProjectFolder(ModID)}\project.json", json);
        }
    }
}
