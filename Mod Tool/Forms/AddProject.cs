using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ModTool.Forms
{
    public partial class AddProject : Form
    {
        public string ModName { get; private set; } = "My Project";
        public ModType ModType { get; private set; }

        public AddProject()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(TypeComboBox.SelectedIndex)
            {
                case 0:
                    ModType = ModType.ModRenPy;
                    break;
                case 1:
                    ModType = ModType.ModeVisualScript;
                    break;
                case 2:
                    ModType = ModType.SnakeSkin;
                    break;
                case 3:
                    ModType = ModType.SnakeMode;
                    break;
                case 4:
                    ModType = ModType.FlappyBirdSkin;
                    break;
                case 5:
                    ModType = ModType.FlappyBirdMode;
                    break;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ModName = NameTextBox.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(NameTextBox.Text != string.Empty)
            {
                if (TypeComboBox.SelectedIndex != -1)
                    DialogResult = DialogResult.OK;
                else
                    MessageBox.Show("You have not selected a project type!", "Game Mod Tool", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Enter the name of your modification!", "Game Mod Tool", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void NameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }
    }
}
