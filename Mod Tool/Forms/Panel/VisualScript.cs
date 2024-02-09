using ModTool.Classes;
using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

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

            if( File.Exists($"{FManager.GetProjectFolder(ModID)}/{StringExtension.CyrilicToLatin(Program.Projects[ModID].Name)}.json") )
                rootTreeNode = new RenPyTreeNode(RenPyNode.LoadFromJson($"{FManager.GetProjectFolder(ModID)}/{StringExtension.CyrilicToLatin(Program.Projects[ModID].Name)}.json"));
            else
            {
                RenPyNode rootNode = new RenPyNode("label", StringExtension.CyrilicToLatin( Program.Projects[ModID].Name.ToLower().Replace(" ", "_").Replace("  ", "__").Replace("-", "_") ));
                rootTreeNode = new RenPyTreeNode(rootNode);
            }

            openFileName = $"{FManager.GetProjectFolder(ModID)}/{StringExtension.CyrilicToLatin(Program.Projects[ModID].Name)}.json";
            convertFileName = $"{FManager.GetProjectFolder(ModID)}/{StringExtension.CyrilicToLatin(Program.Projects[ModID].Name)}.rpy";

            ScriptTreeView.Nodes.Add(rootTreeNode);

            ReDrawTreeView();
        }

        private void ReDrawTreeView()
        {
            rootTreeNode.UpdateTreeNode();

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
                    if (selectedNode.Type == "menu")
                        rootNode = selectedNode.Children[ScriptTreeView.SelectedNode.Index];
                }

                switch (newObjectVS.SelectedEnum)
                {
                    case VSObject.say:

                        if ((string)newObjectVS.AdditionallyEnum != "none")
                            rootNode.AddChild(new RenPyNode("say", newObjectVS.TextNumCheck, (string)newObjectVS.AdditionallyEnum));
                        else
                            rootNode.AddChild(new RenPyNode("say", newObjectVS.TextNumCheck));
                        
                        break;

                    case VSObject.show:
                        rootNode.AddChild(new RenPyNode("show", $"{(string)newObjectVS.AdditionallyEnum}"));
                        break;

                    case VSObject.hide:
                        rootNode.AddChild(new RenPyNode("hide", $"{(string)newObjectVS.AdditionallyEnum}"));
                        break;

                    case VSObject.scene:
                        rootNode.AddChild(new RenPyNode("scene", (string)newObjectVS.AdditionallyEnum));
                        break;

                    case VSObject.play_music:
                        rootNode.AddChild(new RenPyNode("play music", (string)newObjectVS.AdditionallyEnum));
                        break;

                    case VSObject.play_sound:
                        rootNode.AddChild(new RenPyNode("play sound", (string)newObjectVS.AdditionallyEnum));
                        break;

                    case VSObject.stop:
                        rootNode.AddChild(new RenPyNode("stop", (string)newObjectVS.AdditionallyEnum));
                        break;

                    case VSObject.pause:
                        rootNode.AddChild(new RenPyNode("pause", $"({newObjectVS.TextNumCheck})"));
                        break;

                    case VSObject.with:
                        rootTreeNode.RenPyNode.AddChild(new RenPyNode("with", (string)newObjectVS.AdditionallyEnum));
                        break;

                    case VSObject.menu:
                        rootNode.AddChild(new RenPyNode("menu", ""));
                        break;

                    case VSObject.discord:
                        rootNode.AddChild(new RenPyNode("discord", newObjectVS.TextNumCheck));
                        break;

                    case VSObject.snake_game:
                        rootNode.AddChild(new RenPyNode("snake_game", newObjectVS.TextNumCheck));
                        break;
                    case VSObject.flappy_bird_game:
                        rootNode.AddChild(new RenPyNode("flappy_bird_game", newObjectVS.TextNumCheck));
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
                string convertRpy = $"init python:\n    mods['{StringExtension.CyrilicToLatin( Program.Projects[ModID].Name.ToLower().Replace(" ", "_").Replace("  ", "__").Replace("-", "_") )}'] = \"{Program.Projects[ModID].Name}\"\n\n";
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
            if( ScriptTreeView.SelectedNode != null )
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
                    downToolStripMenuItem.Enabled= false;
                }

            }
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ScriptTreeView.SelectedNode != null)
            {
                RenPyNode nodeToRemove = ScriptTreeView.SelectedNode.Parent.Tag as RenPyNode;

                if (nodeToRemove.Type == "menu" )
                    nodeToRemove.RemoveChild(ScriptTreeView.SelectedNode.Index);
                else
                    rootTreeNode.RenPyNode.RemoveChild(ScriptTreeView.SelectedNode.Index);

                ReDrawTreeView();
            } 
        }

        private void toolStripSeparator1_Paint(object sender, PaintEventArgs e)
        {
            ToolStripSeparator sep = (ToolStripSeparator)sender;
            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(22, 25, 32)), 0, 0, sep.Width, sep.Height);
            e.Graphics.DrawLine(new Pen(Color.White), 30, sep.Height / 2, sep.Width - 4, sep.Height / 2);
        }

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
                NewObjectVS newObjectVS = new NewObjectVS(ModID);
                newObjectVS.EditItem(editNode);

                if (newObjectVS.ShowDialog() == DialogResult.OK)
                {
                    
                    editNode.Type = newObjectVS.SelectedEnum.ToString();
                    
                    switch(newObjectVS.SelectedEnum)
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

                        case VSObject.jump:
                            editNode.Content = newObjectVS.TextNumCheck;
                            break;

                        case VSObject.comment:
                            editNode.Content = newObjectVS.TextNumCheck;
                            break;

                        case VSObject.pause:
                            editNode.Content = $"({newObjectVS.TextNumCheck})";
                            break;

                        case VSObject.discord:
                            editNode.Content = newObjectVS.TextNumCheck;
                            break;

                        case VSObject.snake_game:
                            editNode.Content = newObjectVS.TextNumCheck;
                            break;

                        case VSObject.flappy_bird_game:
                            editNode.Content = newObjectVS.TextNumCheck;
                            break;

                        default:
                            editNode.Content = (string)newObjectVS.AdditionallyEnum;
                            break;
                    }

                }

                ReDrawTreeView();
            }
        }

        private void NewLabelButtom_Click(object sender, EventArgs e)
        {
            rpySaveFileDialog.InitialDirectory = FManager.GetProjectFolder(ModID);

            if (rpySaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                RenPyNode newFileNode = new RenPyNode("label", StringExtension.CyrilicToLatin( Path.GetFileNameWithoutExtension(rpySaveFileDialog.FileName).ToLower().Replace(" ", "_").Replace("  ", "__").Replace("-", "_") ));
                newFileNode.SaveToJson($@"{Path.GetDirectoryName(rpySaveFileDialog.FileName)}/{Path.GetFileName(StringExtension.CyrilicToLatin(rpySaveFileDialog.FileName))}");
                
                isMainFile = false;

                RenPyNode loadedNode = RenPyNode.LoadFromJson($@"{Path.GetDirectoryName(rpySaveFileDialog.FileName)}/{Path.GetFileName(StringExtension.CyrilicToLatin(rpySaveFileDialog.FileName))}");

                openFileName = $@"{Path.GetDirectoryName(rpySaveFileDialog.FileName)}/{Path.GetFileName(StringExtension.CyrilicToLatin(rpySaveFileDialog.FileName))}";
                convertFileName = $"{FManager.GetProjectFolder(ModID)}/{Path.GetFileNameWithoutExtension( StringExtension.CyrilicToLatin(rpySaveFileDialog.FileName) )}.rpy";

                if (loadedNode != null)
                {
                    rootTreeNode = new RenPyTreeNode(loadedNode);
                    ScriptTreeView.Nodes.Clear();
                    ScriptTreeView.Nodes.Add(rootTreeNode);
                    ReDrawTreeView();
                }
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
    }
}
