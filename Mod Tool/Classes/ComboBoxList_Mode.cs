namespace ModTool.Classes
{
    public class ComboBoxList_Mode
    {
        public string Name, Default, Game;
        public bool NumberEditor, TextEditor, BoolEditor;

        public ComboBoxList_Mode(string Name, string Default, string Game, bool NumberEditor, bool TextEditor, bool BoolEditor)
        {
            this.Name = Name;
            this.Default = Default;
            this.Game = Game;
            this.NumberEditor = NumberEditor;
            this.TextEditor = TextEditor;
            this.BoolEditor = BoolEditor;
        }
    }
}
