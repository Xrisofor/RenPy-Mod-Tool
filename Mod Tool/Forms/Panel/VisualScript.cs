using ModTool.Classes;
using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using ModTool.Forms.Explorer;

namespace ModTool.Forms.Panel
{
    public partial class VisualScript : Form
    {
        private int ModID; private bool isMainFile = true; private string openFileName, convertFileName;

        private RenPyTreeNode rootTreeNode;

        public VisualScript(int ModID)
        {
            InitializeComponent();
            this.ModID = ModID;

            ScriptTreeView.Nodes.Clear();

            if (File.Exists($"{FManager.GetProjectFolder(ModID)}/{StringExtension.CyrilicToLatin(Program.Projects[ModID].Name)}.json"))
                rootTreeNode = new RenPyTreeNode(RenPyNode.LoadFromJson($"{FManager.GetProjectFolder(ModID)}/{StringExtension.CyrilicToLatin(Program.Projects[ModID].Name)}.json"));
            else
            {
                RenPyNode rootNode = new RenPyNode("label", StringExtension.CyrilicToLatin(Program.Projects[ModID].Name.ToLower().Replace(" ", "_").Replace("  ", "__").Replace("-", "_")));
                rootTreeNode = new RenPyTreeNode(rootNode);
            }

            openFileName = $"{FManager.GetProjectFolder(ModID)}/{StringExtension.CyrilicToLatin(Program.Projects[ModID].Name)}.json";
            convertFileName = $"{FManager.GetProjectFolder(ModID)}/{StringExtension.CyrilicToLatin(Program.Projects[ModID].Name)}.rpy";

            ScriptTreeView.Nodes.Add(rootTreeNode);

            addToolStripMenuItem.Text = Config.GetText("add_button");
            editToolStripMenuItem.Text = Config.GetText("edit_button");
            removeToolStripMenuItem.Text = Config.GetText("delete_button");
            upToolStripMenuItem.Text = Config.GetText("up_button");
            downToolStripMenuItem.Text = Config.GetText("down_button");

            if (!File.Exists($"{FManager.GetGameFolder()}/archive.rpa"))
                rpaExpButton.Visible = false;

            ReDrawTreeView();
        }

        private void ReDrawTreeView()
        {
            RenPyTreeNode selectedNode = (RenPyTreeNode)ScriptTreeView.SelectedNode;
            int selectedIndex = ScriptTreeView.SelectedNode?.Index ?? -1;

            rootTreeNode.UpdateTreeNode();

            if (selectedIndex != -1 && selectedIndex < ScriptTreeView.Nodes[0].Nodes.Count)
            {
                ScriptTreeView.SelectedNode = ScriptTreeView.Nodes[0].Nodes[selectedIndex];
                ScriptTreeView.SelectedNode.Expand();
            }

            ScriptTreeView.ExpandAll();
        }

        private void NewFileButton_Click(object sender, EventArgs e)
        {
            NewObjectVS newObjectVS = new NewObjectVS(ModID);

            if (newObjectVS.ShowDialog() == DialogResult.OK)
            {
                RenPyNode rootNode = rootTreeNode.RenPyNode;

                if (ScriptTreeView.SelectedNode != null && ScriptTreeView.SelectedNode.Tag is RenPyNode selectedNode)
                {
                    if (selectedNode.Type == "menu" || selectedNode.Type == "var_if")
                        rootNode = selectedNode.Children[ScriptTreeView.SelectedNode.Index];
                }

                switch (newObjectVS.SelectedEnum)
                {
                    // Dialog
                    case VSObject.say:
                        if ((string)newObjectVS.AdditionallyEnum != "none")
                            rootNode.AddChild(new RenPyNode(newObjectVS.SelectedEnum.ToString(), newObjectVS.TextNumCheck, (string)newObjectVS.AdditionallyEnum));
                        else
                            rootNode.AddChild(new RenPyNode(newObjectVS.SelectedEnum.ToString(), newObjectVS.TextNumCheck));
                        break;
                    case VSObject.pause:
                        rootNode.AddChild(new RenPyNode(newObjectVS.SelectedEnum.ToString(), $"({newObjectVS.TextNumCheck})"));
                        break;
                    case VSObject.menu:
                        rootNode.AddChild(new RenPyNode(newObjectVS.SelectedEnum.ToString(), string.Empty));
                        break;

                    // Screens
                    case VSObject.show_screen:
                        rootNode.AddChild(new RenPyNode(newObjectVS.SelectedEnum.ToString().Replace("_", " "), $"{(string)newObjectVS.AdditionallyEnum}({newObjectVS.TextNumCheck})"));
                        break;

                    // Images
                    case VSObject.show:
                    case VSObject.hide:
                    case VSObject.scene:
                    case VSObject.with:

                    // Screens
                    case VSObject.hide_screen:

                    // Audio
                    case VSObject.play_music:
                    case VSObject.play_sound:
                    case VSObject.stop:
                        rootNode.AddChild(new RenPyNode(newObjectVS.SelectedEnum.ToString().Replace("_", " "), (string)newObjectVS.AdditionallyEnum));
                        break;

                    case VSObject.discord:
                    case VSObject.snake_game:
                    case VSObject.flappy_bird_game:
                        rootNode.AddChild(new RenPyNode(newObjectVS.SelectedEnum.ToString(), newObjectVS.TextNumCheck));
                        break;

                    default:
                        rootNode.AddChild(new RenPyNode(newObjectVS.SelectedEnum.ToString(), newObjectVS.TextNumCheck));
                        break;
                }

                ReDrawTreeView();
            }
        }

        private void RpyExportButton_Click(object sender, EventArgs e)
        {
            if (isMainFile)
            {
                string convertRpy = $"init python:\n    mods['{StringExtension.CyrilicToLatin(Program.Projects[ModID].Name.ToLower().Replace(" ", "_").Replace("  ", "__").Replace("-", "_"))}'] = \"{Program.Projects[ModID].Name}\"\n\n";
                convertRpy += RenPyConverter.ConvertToRenPyCode(rootTreeNode.RenPyNode);
                convertRpy += $"    return";

                File.WriteAllText(convertFileName, convertRpy);
            }
            else
            {
                string convertRpy = RenPyConverter.ConvertToRenPyCode(rootTreeNode.RenPyNode);
                convertRpy += $"    return";

                File.WriteAllText(convertFileName, convertRpy);
            }

            SaveButton_Click(sender, e);
        }

        private void SaveButton_Click(object sender, EventArgs e) => rootTreeNode.RenPyNode.SaveToJson(openFileName);

        private void TableButton_Click(object sender, EventArgs e)
        {
            GameResourceTable gameResourceTable = new GameResourceTable();
            gameResourceTable.Show();
        }

        private void ScriptTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (ScriptTreeView.SelectedNode != null)
            {

                if (!ScriptTreeView.SelectedNode.Text.StartsWith("label", StringComparison.OrdinalIgnoreCase))
                {
                    RenPyNode selectNode = ScriptTreeView.SelectedNode.Tag as RenPyNode;
                    RenPyNode selectParentNode = ScriptTreeView.SelectedNode.Parent.Tag as RenPyNode;

                    if (selectNode.Type == "menu")
                    {
                        editToolStripMenuItem.Enabled = false;
                        removeToolStripMenuItem.Enabled = true;
                        addToolStripMenuItem.Enabled = true;
                    }
                    else if (selectParentNode.Type == "menu")
                    {
                        editToolStripMenuItem.Enabled = false;
                        removeToolStripMenuItem.Enabled = true;
                        addToolStripMenuItem.Enabled = false;
                    }
                    else
                    {
                        addToolStripMenuItem.Enabled = false;
                        editToolStripMenuItem.Enabled = true;
                        removeToolStripMenuItem.Enabled = true;
                    }

                    upToolStripMenuItem.Enabled = true;
                    downToolStripMenuItem.Enabled = true;
                }
                else
                {
                    editToolStripMenuItem.Enabled = false;
                    removeToolStripMenuItem.Enabled = false;
                    addToolStripMenuItem.Enabled = true;
                    upToolStripMenuItem.Enabled = false;
                    downToolStripMenuItem.Enabled = false;
                }

            }
        }

        private void NewLabelButtom_Click(object sender, EventArgs e)
        {
            rpySaveFileDialog.InitialDirectory = FManager.GetProjectFolder(ModID);

            if (rpySaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                RenPyNode newFileNode = new RenPyNode("label", StringExtension.CyrilicToLatin(Path.GetFileNameWithoutExtension(rpySaveFileDialog.FileName).ToLower().Replace(" ", "_").Replace("  ", "__").Replace("-", "_")));
                newFileNode.SaveToJson($@"{Path.GetDirectoryName(rpySaveFileDialog.FileName)}/{Path.GetFileName(StringExtension.CyrilicToLatin(rpySaveFileDialog.FileName))}");

                isMainFile = false;

                RenPyNode loadedNode = RenPyNode.LoadFromJson($@"{Path.GetDirectoryName(rpySaveFileDialog.FileName)}/{Path.GetFileName(StringExtension.CyrilicToLatin(rpySaveFileDialog.FileName))}");

                openFileName = $@"{Path.GetDirectoryName(rpySaveFileDialog.FileName)}/{Path.GetFileName(StringExtension.CyrilicToLatin(rpySaveFileDialog.FileName))}";
                convertFileName = $"{FManager.GetProjectFolder(ModID)}/{Path.GetFileNameWithoutExtension(StringExtension.CyrilicToLatin(rpySaveFileDialog.FileName))}.rpy";

                if (loadedNode != null)
                {
                    rootTreeNode = new RenPyTreeNode(loadedNode);
                    ScriptTreeView.Nodes.Clear();
                    ScriptTreeView.Nodes.Add(rootTreeNode);
                    ReDrawTreeView();
                }
            }
        }

        private void AddCharacterButton_Click(object sender, EventArgs e)
        {
            NewCharacterVS newCharacterVS = new NewCharacterVS(ModID);
            newCharacterVS.Show();
        }

        private void AddContentButton_Click(object sender, EventArgs e)
        {
            NewContentVS newContentVS = new NewContentVS(ModID);
            newContentVS.Show();
        }

        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            rpyOpenFileDialog.InitialDirectory = FManager.GetProjectFolder(ModID);

            if (rpyOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (Path.GetFileNameWithoutExtension(rpyOpenFileDialog.FileName) == StringExtension.CyrilicToLatin(Program.Projects[ModID].Name))
                    isMainFile = true;
                else if (Path.GetFileNameWithoutExtension(rpyOpenFileDialog.FileName) == "project")
                {
                    MessageBox.Show(Config.GetText("loading_error"), $"{Config.GameName} - Mod Tool", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                    isMainFile = false;

                RenPyNode loadedNode = RenPyNode.LoadFromJson(rpyOpenFileDialog.FileName);

                openFileName = rpyOpenFileDialog.FileName;
                convertFileName = $"{FManager.GetProjectFolder(ModID)}/{Path.GetFileNameWithoutExtension(rpyOpenFileDialog.FileName)}.rpy";

                if (loadedNode != null)
                {
                    rootTreeNode = new RenPyTreeNode(loadedNode);
                    ScriptTreeView.Nodes.Clear();
                    ScriptTreeView.Nodes.Add(rootTreeNode);
                    ReDrawTreeView();
                }
            }
        }

        #region Tool Strip Menu

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ScriptTreeView.SelectedNode.Text.StartsWith("menu", StringComparison.OrdinalIgnoreCase))
            {
                string randomStr = StringExtension.RandomString(20);

                RenPyNode rootNode = rootTreeNode.RenPyNode.Children[ScriptTreeView.SelectedNode.Index];
                NewObjectVS newObjectVS = new NewObjectVS(ModID, true);

                if (newObjectVS.ShowDialog() == DialogResult.OK)
                {
                    rootNode.AddChild(new RenPyNode(newObjectVS.TextNumCheck, $"jump {randomStr}"));

                    RenPyNode newFileNode = new RenPyNode("label", randomStr);
                    newFileNode.SaveToJson($"{FManager.GetProjectFolder(ModID)}/{randomStr}.json");
                }
            }
            else
                NewFileButton_Click(sender, e);

            ReDrawTreeView();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ScriptTreeView.SelectedNode != null)
            {
                RenPyNode editNode = ScriptTreeView.SelectedNode.Tag as RenPyNode;
                editNode.Type = editNode.Type.Replace(" ", "_");
                NewObjectVS newObjectVS = new NewObjectVS(ModID);
                newObjectVS.EditItem(editNode);

                if (newObjectVS.ShowDialog() == DialogResult.OK)
                {

                    editNode.Type = newObjectVS.SelectedEnum.ToString();

                    switch (newObjectVS.SelectedEnum)
                    {
                        case VSObject.say:
                            if ((string)newObjectVS.AdditionallyEnum != "none")
                            {
                                editNode.Content = newObjectVS.TextNumCheck;
                                editNode.Character = (string)newObjectVS.AdditionallyEnum;
                            }
                            else
                                editNode.Content = newObjectVS.TextNumCheck;
                            break;

                        case VSObject.pause:
                            editNode.Content = $"({newObjectVS.TextNumCheck})";
                            break;

                        case VSObject.jump:
                        case VSObject.comment:
                        case VSObject.discord:
                        case VSObject.snake_game:
                        case VSObject.flappy_bird_game:
                            editNode.Content = newObjectVS.TextNumCheck;
                            break;
                        
                        case VSObject.show_screen:
                            editNode.Type = newObjectVS.SelectedEnum.ToString().Replace("_", " ");
                            editNode.Content = $"{(string)newObjectVS.AdditionallyEnum}({newObjectVS.TextNumCheck})";
                            break;

                        case VSObject.hide_screen:
                        case VSObject.play_music:
                        case VSObject.play_sound:
                            editNode.Type = newObjectVS.SelectedEnum.ToString().Replace("_", " ");
                            editNode.Content = (string)newObjectVS.AdditionallyEnum;
                            break;

                        default:
                            editNode.Content = (string)newObjectVS.AdditionallyEnum;
                            break;
                    }

                }

                ReDrawTreeView();
            }
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ScriptTreeView.SelectedNode != null)
            {
                RenPyNode nodeToRemove = ScriptTreeView.SelectedNode.Parent.Tag as RenPyNode;

                if (nodeToRemove.Type == "menu")
                    nodeToRemove.RemoveChild(ScriptTreeView.SelectedNode.Index);
                else
                    rootTreeNode.RenPyNode.RemoveChild(ScriptTreeView.SelectedNode.Index);

                ReDrawTreeView();
            }
        }

        private void upToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ScriptTreeView.SelectedNode != null)
            {
                RenPyTreeNode selectedNode = (RenPyTreeNode)ScriptTreeView.SelectedNode;
                selectedNode.MoveUp();
                ReDrawTreeView();
            }
        }

        private void downToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ScriptTreeView.SelectedNode != null)
            {
                RenPyTreeNode selectedNode = (RenPyTreeNode)ScriptTreeView.SelectedNode;
                selectedNode.MoveDown();
                ReDrawTreeView();
            }
        }

        private void rpaExpButton_Click(object sender, EventArgs e)
        {
            Rpa_Explorer rpa_Explorer = new Rpa_Explorer();
            rpa_Explorer.Show();
        }

        private void toolStripSeparator1_Paint(object sender, PaintEventArgs e)
        {
            ToolStripSeparator sep = (ToolStripSeparator)sender;
            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(22, 25, 32)), 0, 0, sep.Width, sep.Height);
            e.Graphics.DrawLine(new Pen(Color.White), 30, sep.Height / 2, sep.Width - 4, sep.Height / 2);
        }

        #endregion
    }
}
