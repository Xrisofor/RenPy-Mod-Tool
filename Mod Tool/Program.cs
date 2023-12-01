using System;
using System.Collections.Generic;
using System.Windows.Forms;

using ModTool.Forms;

namespace ModTool
{
    public static class Program
    {
        public static List<Project> Projects = new List<Project>();

        public static List<Item> Sprites { get; private set; } = new List<Item>();
        public static List<Item> Audio { get; private set; } = new List<Item>();

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}
