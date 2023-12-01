using System.Collections.Generic;

namespace ModTool.Classes
{
    public class VisualScript
    {
        public int Type = 0;
        public string Text = string.Empty;
        public Dictionary<string, string> Params = new Dictionary<string, string>();

        public VisualScript(string Text, int Type = 0)
        {
            this.Text = Text;
            this.Type = Type;
        }
    }
}
