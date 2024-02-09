using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System;
using ModTool.Forms;

namespace ModTool.Classes
{

    public class RenPyNode
    {
        public string Type { get; set; }
        public string Content { get; set; }
        public string Character { get; set; } = string.Empty;
        public List<RenPyNode> Children { get; set; }

        public RenPyNode(string type, string content, string character = null)
        {
            Type = type;
            Content = content;
            Character = character;
            Children = new List<RenPyNode>();
        }

        public void AddChild(RenPyNode child) => Children.Add(child);

        public void RemoveChild(int index) => Children.RemoveAt(index);

        public void RemoveChild(RenPyNode node) => Children.Remove(node);

        public void SaveToJson(string filePath)
        {
            string json = JsonConvert.SerializeObject(this, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }

        public static RenPyNode LoadFromJson(string filePath)
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                return JsonConvert.DeserializeObject<RenPyNode>(json);
            }
            return null;
        }
    }

    public class RenPyTreeNode : TreeNode
    {
        public RenPyNode RenPyNode { get; }

        public RenPyTreeNode(RenPyNode renPyNode)
        {
            RenPyNode = renPyNode;
            Tag = renPyNode;
            UpdateText();

            foreach (var child in renPyNode.Children)
            {
                Nodes.Add(new RenPyTreeNode(child));
            }
        }

        public void UpdateTreeNode()
        {
            Nodes.Clear();

            foreach (var child in RenPyNode.Children)
            {
                Nodes.Add(new RenPyTreeNode(child));
            }

            UpdateText();
        }

        private void UpdateText()
        {
            if (RenPyNode.Type == "say" && !string.IsNullOrEmpty(RenPyNode.Character) && RenPyNode.Character != "node")
            {
                Text = $"{RenPyNode.Type} {RenPyNode.Character} {RenPyNode.Content}";
            }
            else
            {
                Text = $"{RenPyNode.Type} {RenPyNode.Content}";
            }
        }

        public void MoveUp()
        {
            RenPyNode parentNode = (RenPyNode)this.Parent.Tag;
            int index = this.Index;

            if (index > 0)
            {
                RenPyNode currentNode = parentNode.Children[index];
                parentNode.Children.RemoveAt(index);
                parentNode.Children.Insert(index - 1, currentNode);
            }
        }

        public void MoveDown()
        {
            RenPyNode parentNode = (RenPyNode)this.Parent.Tag;
            int index = this.Index;

            if (index < parentNode.Children.Count - 1)
            {
                RenPyNode currentNode = parentNode.Children[index];
                parentNode.Children.RemoveAt(index);
                parentNode.Children.Insert(index + 1, currentNode);
            }
        }
    }


    public static class RenPyConverter
    {
        private const string Indentation = "    ";

        public static string ConvertToRenPyCode(RenPyNode node, int indentationLevel = 0, bool newLine = false)
        {
            StringBuilder sb = new StringBuilder();

            string indentation = new string(' ', indentationLevel * Indentation.Length);

            switch(node.Type)
            {
                case "label":
                    sb.AppendLine($"{indentation}{node.Type} {node.Content}:");
                    break;
                case "menu":
                    sb.AppendLine($"{indentation}{node.Type}:");
                    break;

                case "say":
                    if (!string.IsNullOrEmpty(node.Character) && node.Character != "node")
                        sb.AppendLine($"{indentation}{node.Character} \"{node.Content}\"");
                    else
                        sb.AppendLine($"{indentation}\"{node.Content}\"");
                    break;

                case "play sound":
                    sb.AppendLine($"{indentation}play sound sound_list[\"{node.Content}\"]");
                    break;

                case "play music":
                    sb.AppendLine($"{indentation}play music music_list[\"{node.Content}\"]");
                    break;

                case "comment":
                    sb.AppendLine($"{indentation}# {node.Content}");
                    break;

                case "discord":
                    sb.AppendLine($"{indentation}$ discord.update (details = \"{node.Content}\")");
                    break;

                case "snake_game":
                    sb.AppendLine($"{indentation}$ snake_game_lbl = \"{node.Content}\"");
                    sb.AppendLine($"{indentation}call screen snake_game_menu_screen()");
                    break;

                case "flappy_bird_game":
                    sb.AppendLine($"{indentation}$ flappy_bird_lbl = \"{node.Content}\"");
                    sb.AppendLine($"{indentation}call screen flappy_bird_game_menu_screen()");
                    break;

                default:
                    sb.AppendLine($"{indentation}{node.Type} {node.Content}");
                    break;

            }

            foreach (var child in node.Children)
            {
                if (node.Type == "menu" && child.Type != "label")
                {
                    sb.AppendLine($"{indentation}{Indentation}\"{child.Type}\":");
                    sb.AppendLine($"{indentation}{Indentation}{Indentation}{child.Content}");
                }
                else
                {
                    sb.Append(ConvertToRenPyCode(child, indentationLevel + 1));
                }
            }

            if (newLine) sb.Append(Environment.NewLine);
            return sb.ToString();
        }
    }

}
