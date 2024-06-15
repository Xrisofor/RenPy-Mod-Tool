using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ModTool.Forms;

namespace ModTool
{
    public static class Program
    {
        // Starting Screen
        public static SplashScreen SplashScreen;

        // All Projects List
        public static List<Project> Projects = new List<Project>();

        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }

        [STAThread]
        public static void StartSplashScreen()
        {
            SplashScreen = new SplashScreen();
            Application.Run(SplashScreen);
        }
    }
}
