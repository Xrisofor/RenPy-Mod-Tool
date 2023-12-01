using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModTool.Forms
{
    public partial class NewObjectVS : Form
    {
        public int SelectedIndex { get; private set; }
        public string TextNumCheck { get; private set; }

        public NewObjectVS()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedIndex = comboBox1.SelectedIndex;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != string.Empty)
            {
                if (comboBox1.SelectedIndex != -1)
                    DialogResult = DialogResult.OK;
                else
                    MessageBox.Show("To create a new item, select it from the drop-down list!", "Game Mod Tool", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("To continue enter text / number / check in the text box!", "Game Mod Tool", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextNumCheck = textBox1.Text;
        }
    }
}
