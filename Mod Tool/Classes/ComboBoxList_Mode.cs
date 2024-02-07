namespace ModTool.Classes
{
    public class ComboBoxList_Mode
    {
        public string Name, Default, Game;
        public bool NumberEditor, TextEditor, BoolEditor;
        public decimal Increment;

        public ComboBoxList_Mode(string Name, string Default, string Game, decimal Increment, bool NumberEditor = false, bool TextEditor = false, bool BoolEditor = false)
        {
            this.Name = Name;
            this.Default = Default;
            this.Game = Game;
            this.Increment = Increment;
            this.NumberEditor = NumberEditor;
            this.TextEditor = TextEditor;
            this.BoolEditor = BoolEditor;
        }
    }
}
