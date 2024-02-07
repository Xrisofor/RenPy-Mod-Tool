using System;
using System.Windows.Forms;

namespace ModTool.Forms
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreen_Shown(object sender, EventArgs e)
        {
            label1.Text = $"{Config.GameName} - Mod Tool";
        }

        private void SplashScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Close();
        }
    }
}
