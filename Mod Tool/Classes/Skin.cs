using System;
using System.Collections.Generic;

namespace ModTool.Classes
{
    public class Skin
    {
        public int Mode;

        public List<ComboBoxList_Skin> List;

        public Skin(int Mode, List<ComboBoxList_Skin> List)
        {
            this.Mode = Mode;
            this.List = List;
        }
    }
}
