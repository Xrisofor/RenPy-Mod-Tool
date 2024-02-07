namespace ModTool.Forms.Explorer
{
    partial class Pixelation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pixelation));
            this.OpenButton = new System.Windows.Forms.Button();
            this.ConvertButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SaveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SpacingUpDown = new System.Windows.Forms.NumericUpDown();
            this.AddColorButton = new System.Windows.Forms.Button();
            this.SampleColorsButton = new System.Windows.Forms.Button();
            this.ColorRichTextBox = new System.Windows.Forms.RichTextBox();
            this.ExamplePictureBox = new System.Windows.Forms.PictureBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ConvertPictureBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpacingUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExamplePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConvertPictureBox)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpenButton
            // 
            this.OpenButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenButton.Location = new System.Drawing.Point(13, 15);
            this.OpenButton.Margin = new System.Windows.Forms.Padding(13, 15, 3, 3);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(212, 35);
            this.OpenButton.TabIndex = 0;
            this.OpenButton.Text = "Open";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // ConvertButton
            // 
            this.ConvertButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConvertButton.Enabled = false;
            this.ConvertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConvertButton.Location = new System.Drawing.Point(13, 68);
            this.ConvertButton.Margin = new System.Windows.Forms.Padding(13, 15, 3, 3);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(212, 35);
            this.ConvertButton.TabIndex = 1;
            this.ConvertButton.Text = "Convert";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.OpenButton);
            this.flowLayoutPanel1.Controls.Add(this.ConvertButton);
            this.flowLayoutPanel1.Controls.Add(this.SaveButton);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.SpacingUpDown);
            this.flowLayoutPanel1.Controls.Add(this.AddColorButton);
            this.flowLayoutPanel1.Controls.Add(this.SampleColorsButton);
            this.flowLayoutPanel1.Controls.Add(this.ColorRichTextBox);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1022, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(15, 15, 3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(240, 673);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.Enabled = false;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Location = new System.Drawing.Point(13, 121);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(13, 15, 3, 3);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(212, 35);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 179);
            this.label1.Margin = new System.Windows.Forms.Padding(13, 20, 3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Spacing:";
            // 
            // SpacingUpDown
            // 
            this.SpacingUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SpacingUpDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.SpacingUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SpacingUpDown.ForeColor = System.Drawing.Color.White;
            this.SpacingUpDown.Location = new System.Drawing.Point(13, 210);
            this.SpacingUpDown.Margin = new System.Windows.Forms.Padding(13, 5, 3, 3);
            this.SpacingUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SpacingUpDown.Name = "SpacingUpDown";
            this.SpacingUpDown.Size = new System.Drawing.Size(212, 22);
            this.SpacingUpDown.TabIndex = 4;
            this.SpacingUpDown.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // AddColorButton
            // 
            this.AddColorButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddColorButton.Location = new System.Drawing.Point(13, 260);
            this.AddColorButton.Margin = new System.Windows.Forms.Padding(13, 25, 3, 3);
            this.AddColorButton.Name = "AddColorButton";
            this.AddColorButton.Size = new System.Drawing.Size(212, 35);
            this.AddColorButton.TabIndex = 5;
            this.AddColorButton.Text = "Add Color";
            this.AddColorButton.UseVisualStyleBackColor = true;
            this.AddColorButton.Click += new System.EventHandler(this.AddColorButton_Click);
            // 
            // SampleColorsButton
            // 
            this.SampleColorsButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SampleColorsButton.Enabled = false;
            this.SampleColorsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SampleColorsButton.Location = new System.Drawing.Point(13, 313);
            this.SampleColorsButton.Margin = new System.Windows.Forms.Padding(13, 15, 3, 3);
            this.SampleColorsButton.Name = "SampleColorsButton";
            this.SampleColorsButton.Size = new System.Drawing.Size(212, 35);
            this.SampleColorsButton.TabIndex = 6;
            this.SampleColorsButton.Text = "Sample Colors";
            this.SampleColorsButton.UseVisualStyleBackColor = true;
            this.SampleColorsButton.Click += new System.EventHandler(this.SampleColorsButton_Click);
            // 
            // ColorRichTextBox
            // 
            this.ColorRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ColorRichTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ColorRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ColorRichTextBox.ForeColor = System.Drawing.Color.White;
            this.ColorRichTextBox.Location = new System.Drawing.Point(13, 366);
            this.ColorRichTextBox.Margin = new System.Windows.Forms.Padding(13, 15, 3, 3);
            this.ColorRichTextBox.Name = "ColorRichTextBox";
            this.ColorRichTextBox.Size = new System.Drawing.Size(212, 294);
            this.ColorRichTextBox.TabIndex = 7;
            this.ColorRichTextBox.Text = "#FFFFFF\n#000000\n";
            // 
            // ExamplePictureBox
            // 
            this.ExamplePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ExamplePictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExamplePictureBox.Location = new System.Drawing.Point(18, 18);
            this.ExamplePictureBox.Name = "ExamplePictureBox";
            this.ExamplePictureBox.Size = new System.Drawing.Size(480, 637);
            this.ExamplePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ExamplePictureBox.TabIndex = 3;
            this.ExamplePictureBox.TabStop = false;
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Image|*.png;*.jpg";
            // 
            // ConvertPictureBox
            // 
            this.ConvertPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.ConvertPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ConvertPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConvertPictureBox.Location = new System.Drawing.Point(523, 18);
            this.ConvertPictureBox.Name = "ConvertPictureBox";
            this.ConvertPictureBox.Size = new System.Drawing.Size(481, 637);
            this.ConvertPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ConvertPictureBox.TabIndex = 4;
            this.ConvertPictureBox.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.01961F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.960784F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.01961F));
            this.tableLayoutPanel1.Controls.Add(this.ExamplePictureBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ConvertPictureBox, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(15);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1022, 673);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(504, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 643);
            this.label2.TabIndex = 5;
            this.label2.Text = resources.GetString("label2.Text");
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Image|*.png;*.jpg";
            // 
            // Pixelation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pixelation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pixelation";
            this.Load += new System.EventHandler(this.Pixelation_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SpacingUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExamplePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConvertPictureBox)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.Button ConvertButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown SpacingUpDown;
        private System.Windows.Forms.Button AddColorButton;
        private System.Windows.Forms.Button SampleColorsButton;
        private System.Windows.Forms.PictureBox ExamplePictureBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.RichTextBox ColorRichTextBox;
        private System.Windows.Forms.PictureBox ConvertPictureBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ColorDialog colorDialog;
    }
}