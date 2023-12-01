using System.Collections.Generic;

namespace ModTool.Workshop
{
    internal struct SteamWorkshopItem
    {
        public string Title;
        public string Description;
        public string ContentFolderPath;
        public string PreviewImagePath;
        public IList<string> Tags;
    }
}
