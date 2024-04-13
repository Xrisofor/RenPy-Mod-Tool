using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ModTool.Forms;

namespace ModTool
{
    public static class Program
    {
        public static List<Project> Projects = new List<Project>();

        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }

        public static SplashScreen SplashScreen;

        [STAThread]
        public static void StartSplashScreen()
        {
            SplashScreen = new SplashScreen();
            Application.Run(SplashScreen);
        }
    }
}
