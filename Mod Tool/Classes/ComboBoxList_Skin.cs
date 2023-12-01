namespace ModTool.Classes
{
    public class ComboBoxList_Skin
    {
        public string Name, Size, Game;
        public int Texture;
        public bool SizeEditor;

        public ComboBoxList_Skin(string Name, int Texture, string Size, string Game, bool SizeEditor)
        {
            this.Name = Name;
            this.Texture = Texture;
            this.Size = Size;
            this.Game = Game;
            this.SizeEditor = SizeEditor;
        }
    }
}
