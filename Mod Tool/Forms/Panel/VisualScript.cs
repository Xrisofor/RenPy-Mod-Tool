using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ModTool.Forms.Panel
{
    public partial class VisualScript : Form
    {
        private int NodeIndex, ModID;
        private List<Classes.VisualScript> visualScriptsNodes = new List<Classes.VisualScript>();

        public VisualScript(int ModID)
        {
            InitializeComponent();
            this.ModID = ModID;

            ReDrawTreeView();
        }

        private void ReDrawTreeView()
        {
            ScriptTreeView.Nodes.Clear();

            foreach(Classes.VisualScript node in visualScriptsNodes)
            {
                var nodeType = string.Empty;

                switch(node.Type)
                {
                    case 0:
                        nodeType = "Label";
                        break;
                }

                TreeNode treeNode = new TreeNode($"{nodeType}: {node.Text}");

                if(node.Params.Count > 0 )
                {
                    for(int i = 0; i < node.Params.Count; i++)
                    {
                        treeNode.Nodes.Add(node.Params.ElementAt(i).Value);
                    }
                    
                }

                ScriptTreeView.Nodes.Add(treeNode);
            }
        }

        private void SpriteManagerButton_Click(object sender, EventArgs e)
        {
            SpriteManager manager = new SpriteManager(ManagerType.Audio, ModID);
            manager.ShowDialog();
        }

        private void NewFileButton_Click(object sender, EventArgs e)
        {
            NewObjectVS newObjectVS = new NewObjectVS();

            if(newObjectVS.ShowDialog() == DialogResult.OK)
            {
                switch(newObjectVS.SelectedIndex)
                {
                    case 0:

                        if(ScriptTreeView.SelectedNode != null)
                        {
                            visualScriptsNodes[ScriptTreeView.SelectedNode.Index].Params.Add("label", newObjectVS.TextNumCheck);
                        }
                        else
                        {
                            visualScriptsNodes.Add(new Classes.VisualScript(newObjectVS.TextNumCheck, 0));
                        }

                        break;
                }

                ReDrawTreeView();
            }
        }

        private void AudioManagerButton_Click(object sender, EventArgs e)
        {
            SpriteManager manager = new SpriteManager(ManagerType.Sprite, ModID);
            manager.ShowDialog();
        }
    }
}
