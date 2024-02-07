using System;
using System.Collections.Generic;

namespace ModTool.Classes
{
    public class ModG
    {
        public int Mode;

        public List<ComboBoxList_Mode> List;

        public ModG(int Mode, List<ComboBoxList_Mode> List)
        {
            this.Mode = Mode;
            this.List = List;
        }
    }
}
