namespace ModTool.Forms.Panel
{
    partial class Skin
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
            this.label1 = new System.Windows.Forms.Label();
            this.ExampleTexture = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ExampleLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.UserTexture = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ExampleComboBox = new System.Windows.Forms.ComboBox();
            this.UserChangeButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.UserClearButton = new System.Windows.Forms.Button();
            this.SelectImageFile = new System.Windows.Forms.OpenFileDialog();
            this.TextureWidthNum = new System.Windows.Forms.NumericUpDown();
            this.TextureHeightNum = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.ExampleTexture)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserTexture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextureWidthNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextureHeightNum)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(950, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Skin creation insturment";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ExampleTexture
            // 
            this.ExampleTexture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ExampleTexture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExampleTexture.Location = new System.Drawing.Point(3, 49);
            this.ExampleTexture.Name = "ExampleTexture";
            this.ExampleTexture.Size = new System.Drawing.Size(419, 373);
            this.ExampleTexture.TabIndex = 1;
            this.ExampleTexture.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ExampleTexture);
            this.groupBox1.Controls.Add(this.ExampleLabel);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(17, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 425);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Example";
            // 
            // ExampleLabel
            // 
            this.ExampleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ExampleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExampleLabel.Location = new System.Drawing.Point(3, 18);
            this.ExampleLabel.Name = "ExampleLabel";
            this.ExampleLabel.Size = new System.Drawing.Size(419, 31);
            this.ExampleLabel.TabIndex = 2;
            this.ExampleLabel.Text = "The size of the original image is 0x0";
            this.ExampleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.UserTexture);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(532, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(425, 425);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Your Version";
            // 
            // UserTexture
            // 
            this.UserTexture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.UserTexture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserTexture.Location = new System.Drawing.Point(3, 49);
            this.UserTexture.Name = "UserTexture";
            this.UserTexture.Size = new System.Drawing.Size(419, 373);
            this.UserTexture.TabIndex = 1;
            this.UserTexture.TabStop = false;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(419, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Your Texture";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExampleComboBox
            // 
            this.ExampleComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ExampleComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExampleComboBox.ForeColor = System.Drawing.Color.White;
            this.ExampleComboBox.FormattingEnabled = true;
            this.ExampleComboBox.IntegralHeight = false;
            this.ExampleComboBox.Location = new System.Drawing.Point(17, 473);
            this.ExampleComboBox.Name = "ExampleComboBox";
            this.ExampleComboBox.Size = new System.Drawing.Size(425, 24);
            this.ExampleComboBox.TabIndex = 4;
            this.ExampleComboBox.Text = "Select a category";
            this.ExampleComboBox.SelectedIndexChanged += new System.EventHandler(this.ExampleComboBox_SelectedIndexChanged);
            // 
            // UserChangeButton
            // 
            this.UserChangeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.UserChangeButton.Enabled = false;
            this.UserChangeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserChangeButton.Location = new System.Drawing.Point(532, 622);
            this.UserChangeButton.Name = "UserChangeButton";
            this.UserChangeButton.Size = new System.Drawing.Size(425, 39);
            this.UserChangeButton.TabIndex = 5;
            this.UserChangeButton.Text = "Change / Select";
            this.UserChangeButton.UseVisualStyleBackColor = true;
            this.UserChangeButton.Click += new System.EventHandler(this.UserChangeButton_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(532, 473);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(425, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Your texture may be different";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserClearButton
            // 
            this.UserClearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.UserClearButton.Enabled = false;
            this.UserClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserClearButton.Location = new System.Drawing.Point(17, 622);
            this.UserClearButton.Name = "UserClearButton";
            this.UserClearButton.Size = new System.Drawing.Size(425, 39);
            this.UserClearButton.TabIndex = 7;
            this.UserClearButton.Text = "Clear / Remove";
            this.UserClearButton.UseVisualStyleBackColor = true;
            this.UserClearButton.Click += new System.EventHandler(this.UserClearButton_Click);
            // 
            // SelectImageFile
            // 
            this.SelectImageFile.Filter = "Images|*.png;*.jpg";
            // 
            // TextureWidthNum
            // 
            this.TextureWidthNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TextureWidthNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.TextureWidthNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextureWidthNum.Enabled = false;
            this.TextureWidthNum.ForeColor = System.Drawing.Color.White;
            this.TextureWidthNum.Location = new System.Drawing.Point(17, 587);
            this.TextureWidthNum.Maximum = new decimal(new int[] {
            1920,
            0,
            0,
            0});
            this.TextureWidthNum.Name = "TextureWidthNum";
            this.TextureWidthNum.Size = new System.Drawing.Size(425, 22);
            this.TextureWidthNum.TabIndex = 8;
            this.TextureWidthNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextureHeightNum
            // 
            this.TextureHeightNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TextureHeightNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.TextureHeightNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextureHeightNum.Enabled = false;
            this.TextureHeightNum.ForeColor = System.Drawing.Color.White;
            this.TextureHeightNum.Location = new System.Drawing.Point(532, 587);
            this.TextureHeightNum.Maximum = new decimal(new int[] {
            1920,
            0,
            0,
            0});
            this.TextureHeightNum.Name = "TextureHeightNum";
            this.TextureHeightNum.Size = new System.Drawing.Size(425, 22);
            this.TextureHeightNum.TabIndex = 9;
            this.TextureHeightNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Skin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(974, 673);
            this.Controls.Add(this.TextureHeightNum);
            this.Controls.Add(this.TextureWidthNum);
            this.Controls.Add(this.UserClearButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UserChangeButton);
            this.Controls.Add(this.ExampleComboBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Skin";
            this.Text = "Skin";
            ((System.ComponentModel.ISupportInitialize)(this.ExampleTexture)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UserTexture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextureWidthNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextureHeightNum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ExampleTexture;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label ExampleLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox UserTexture;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ExampleComboBox;
        private System.Windows.Forms.Button UserChangeButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button UserClearButton;
        private System.Windows.Forms.OpenFileDialog SelectImageFile;
        private System.Windows.Forms.NumericUpDown TextureWidthNum;
        private System.Windows.Forms.NumericUpDown TextureHeightNum;
    }
}