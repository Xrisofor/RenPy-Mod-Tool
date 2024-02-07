using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ModTool.Forms.Explorer
{
    public partial class Pixelation : Form
    {
        private Bitmap btm = new Bitmap(1, 1);
        private Bitmap bBt = new Bitmap(1, 1);

        private Color[] clrs = new Color[1];
        private Graphics g = null;

        public Pixelation()
        {
            InitializeComponent();
        }

        public Pixelation(string folderPath)
        {
            InitializeComponent();

            openFileDialog.InitialDirectory = folderPath;
            saveFileDialog.InitialDirectory = folderPath;
        }

        private void Pixelation_Load(object sender, EventArgs e)
        {
            OpenButton.Text = Config.GetText("open_button");
            SaveButton.Text = Config.GetText("save_button");
            ConvertButton.Text = Config.GetText("convert_button");
            label1.Text = Config.GetText("pixelation_spacing_title");
            Text = Config.GetText("pixelation_title");
            AddColorButton.Text = Config.GetText("add_color_button");
            SampleColorsButton.Text = Config.GetText("sample_colors_button");
        }

        private Color Clr(Color[] cs)
        {
            Color c = Color.Black;

            int r = 0;
            int g = 0;
            int b = 0;

            for (int i = 0; i < cs.Length; i++)
            {
                r += cs[i].R;
                g += cs[i].G;
                b += cs[i].B;
            }

            r /= cs.Length;
            g /= cs.Length;
            b /= cs.Length;

            int near = 1000;
            int ind = 0;

            for (int cl = 0; cl < clrs.Length; cl++)
            {
                int valR = (clrs[cl].R - r);
                int valG = (clrs[cl].G - g);
                int valB = (clrs[cl].B - b);

                if (valR < 0) valR = -valR;
                if (valG < 0) valG = -valG;
                if (valB < 0) valB = -valB;

                int total = valR + valG + valB;

                if (total < near)
                {
                    ind = cl;
                    near = total;
                }
            }

            c = clrs[ind];

            return c;
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                btm = new Bitmap(openFileDialog.FileName);
                ExamplePictureBox.Image = btm;
                ConvertButton.Enabled = true;
                SaveButton.Enabled = false;
                ConvertPictureBox.Image = null;
                SampleColorsButton.Enabled = true;
                SampleColorsButton_Click(sender, e);
            }
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            OpenButton.Enabled = false;
            SaveButton.Enabled = false;
            SpacingUpDown.ReadOnly = true;

            clrs = new Color[ColorRichTextBox.Lines.Length];

            for (int v = 0; v < ColorRichTextBox.Lines.Length; v++)
            {
                try
                {
                    clrs[v] = ColorTranslator.FromHtml(ColorRichTextBox.Lines[v]);
                }
                catch
                {
                    clrs[v] = Color.Transparent;
                }
            }

            int num = (int)SpacingUpDown.Value;

            btm = (Bitmap)ExamplePictureBox.Image;
            bBt = new Bitmap(btm.Width, btm.Height);

            using (g = Graphics.FromImage(bBt))
            {
                List<Color> block = new List<Color>();
                Rectangle rec = new Rectangle();
                SolidBrush sb = new SolidBrush(Color.Black);
                Color final = Color.Black;

                for (int x = 0; x < btm.Width; x += num)
                {
                    for (int y = 0; y < btm.Height; y += num)
                    {
                        block = new List<Color>();

                        for (int v = 0; v < num; v++)
                        {
                            for (int c = 0; c < num; c++)
                            {
                                if (x + v < btm.Width && y + c < btm.Height)
                                {
                                    Color pixelColor = btm.GetPixel(x + v, y + c);

                                    if (pixelColor.A > 0)
                                    {
                                        block.Add(pixelColor);
                                    }
                                }
                            }
                        }

                        if (block.Count > 0)
                        {
                            final = Clr(block.ToArray());

                            sb.Color = final;

                            rec.X = x;
                            rec.Y = y;
                            rec.Width = num;
                            rec.Height = num;

                            g.FillRectangle(sb, rec);
                        }
                    }
                }

                ConvertPictureBox.Image = bBt;

                OpenButton.Enabled = true;
                SaveButton.Enabled = true;
                SpacingUpDown.ReadOnly = false;
            }
        }

        private void SampleColorsButton_Click(object sender, EventArgs e)
        {
            if (btm != null)
            {
                if (btm.Width > 1)
                {
                    ColorRichTextBox.Text = "#FFFFFF\r\n#000000\r\n";

                    Random r = new Random(DateTime.Now.Millisecond);

                    for (int i = 0; i < Config.UserSettings.PixelationSampleColors; i++)
                    {
                        int x = r.Next(0, btm.Width);
                        int y = r.Next(0, btm.Height);
                        ColorRichTextBox.Text += ColorTranslator.ToHtml(btm.GetPixel(x, y));
                        ColorRichTextBox.Text += "\r\n";
                    }
                }
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
                bBt.Save(saveFileDialog.FileName);
        }

        private void AddColorButton_Click(object sender, EventArgs e)
        {
            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                ColorRichTextBox.Text += ColorTranslator.ToHtml(colorDialog.Color);
                ColorRichTextBox.Text += "\r\n";
            }
        }
    }
}
