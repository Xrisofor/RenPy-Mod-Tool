namespace ModTool.Forms
{
    partial class Editor
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editor));
            this.ChangeCoverButton = new System.Windows.Forms.Button();
            this.PublishButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BackButton = new System.Windows.Forms.Button();
            this.TagsButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.BuildButton = new System.Windows.Forms.Button();
            this.ModNameLabel = new System.Windows.Forms.Label();
            this.CoverPictureBox = new System.Windows.Forms.PictureBox();
            this.IconsList = new System.Windows.Forms.ImageList(this.components);
            this.DCPanel = new System.Windows.Forms.Panel();
            this.coverOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CoverPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ChangeCoverButton
            // 
            this.ChangeCoverButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangeCoverButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeCoverButton.Location = new System.Drawing.Point(12, 210);
            this.ChangeCoverButton.Name = "ChangeCoverButton";
            this.ChangeCoverButton.Size = new System.Drawing.Size(262, 35);
            this.ChangeCoverButton.TabIndex = 0;
            this.ChangeCoverButton.Text = "Change the cover";
            this.ChangeCoverButton.UseVisualStyleBackColor = true;
            this.ChangeCoverButton.Click += new System.EventHandler(this.ChangeCoverButton_Click);
            // 
            // PublishButton
            // 
            this.PublishButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PublishButton.Enabled = false;
            this.PublishButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PublishButton.Location = new System.Drawing.Point(11, 584);
            this.PublishButton.Name = "PublishButton";
            this.PublishButton.Size = new System.Drawing.Size(264, 35);
            this.PublishButton.TabIndex = 1;
            this.PublishButton.Text = "Publish";
            this.PublishButton.UseVisualStyleBackColor = true;
            this.PublishButton.Click += new System.EventHandler(this.PublishButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BackButton);
            this.panel1.Controls.Add(this.TagsButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.DescriptionTextBox);
            this.panel1.Controls.Add(this.BuildButton);
            this.panel1.Controls.Add(this.ModNameLabel);
            this.panel1.Controls.Add(this.ChangeCoverButton);
            this.panel1.Controls.Add(this.PublishButton);
            this.panel1.Controls.Add(this.CoverPictureBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(974, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 673);
            this.panel1.TabIndex = 2;
            // 
            // BackButton
            // 
            this.BackButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BackButton.Enabled = false;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Location = new System.Drawing.Point(11, 625);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(264, 35);
            this.BackButton.TabIndex = 6;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // TagsButton
            // 
            this.TagsButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TagsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TagsButton.Location = new System.Drawing.Point(11, 543);
            this.TagsButton.Name = "TagsButton";
            this.TagsButton.Size = new System.Drawing.Size(264, 35);
            this.TagsButton.TabIndex = 5;
            this.TagsButton.Text = "Tags";
            this.TagsButton.UseVisualStyleBackColor = true;
            this.TagsButton.Click += new System.EventHandler(this.TagsButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Description";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DescriptionTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.DescriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DescriptionTextBox.ForeColor = System.Drawing.Color.White;
            this.DescriptionTextBox.Location = new System.Drawing.Point(11, 282);
            this.DescriptionTextBox.MaxLength = 8000;
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(264, 210);
            this.DescriptionTextBox.TabIndex = 3;
            this.DescriptionTextBox.TextChanged += new System.EventHandler(this.DescriptionTextBox_TextChanged);
            // 
            // BuildButton
            // 
            this.BuildButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BuildButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuildButton.Location = new System.Drawing.Point(11, 502);
            this.BuildButton.Name = "BuildButton";
            this.BuildButton.Size = new System.Drawing.Size(264, 35);
            this.BuildButton.TabIndex = 2;
            this.BuildButton.Text = "Build";
            this.BuildButton.UseVisualStyleBackColor = true;
            this.BuildButton.Click += new System.EventHandler(this.BuildButton_Click);
            // 
            // ModNameLabel
            // 
            this.ModNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ModNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModNameLabel.Location = new System.Drawing.Point(14, 9);
            this.ModNameLabel.Name = "ModNameLabel";
            this.ModNameLabel.Size = new System.Drawing.Size(260, 23);
            this.ModNameLabel.TabIndex = 1;
            this.ModNameLabel.Text = "My Mod";
            this.ModNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CoverPictureBox
            // 
            this.CoverPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CoverPictureBox.BackgroundImage = global::ModTool.Properties.Resources.previmg;
            this.CoverPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CoverPictureBox.Location = new System.Drawing.Point(12, 39);
            this.CoverPictureBox.Name = "CoverPictureBox";
            this.CoverPictureBox.Size = new System.Drawing.Size(262, 165);
            this.CoverPictureBox.TabIndex = 0;
            this.CoverPictureBox.TabStop = false;
            // 
            // IconsList
            // 
            this.IconsList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("IconsList.ImageStream")));
            this.IconsList.TransparentColor = System.Drawing.Color.Transparent;
            this.IconsList.Images.SetKeyName(0, "audio.png");
            this.IconsList.Images.SetKeyName(1, "choice.png");
            this.IconsList.Images.SetKeyName(2, "document.png");
            this.IconsList.Images.SetKeyName(3, "picture_2.png");
            this.IconsList.Images.SetKeyName(4, "tag.png");
            this.IconsList.Images.SetKeyName(5, "text.png");
            // 
            // DCPanel
            // 
            this.DCPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DCPanel.Location = new System.Drawing.Point(0, 0);
            this.DCPanel.Name = "DCPanel";
            this.DCPanel.Size = new System.Drawing.Size(974, 673);
            this.DCPanel.TabIndex = 3;
            // 
            // coverOpenFileDialog
            // 
            this.coverOpenFileDialog.Filter = "Image|*.png;*.jpg";
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.DCPanel);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Editor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mod Tool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Editor_FormClosing);
            this.Shown += new System.EventHandler(this.Editor_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CoverPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ChangeCoverButton;
        private System.Windows.Forms.Button PublishButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox CoverPictureBox;
        private System.Windows.Forms.Label ModNameLabel;
        private System.Windows.Forms.Button BuildButton;
        private System.Windows.Forms.ImageList IconsList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.Panel DCPanel;
        private System.Windows.Forms.OpenFileDialog coverOpenFileDialog;
        private System.Windows.Forms.Button TagsButton;
        private System.Windows.Forms.Button BackButton;
    }
}

