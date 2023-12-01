namespace ModTool.Forms
{
    partial class GameResourceTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameResourceTable));
            this.SpritesButton = new System.Windows.Forms.Button();
            this.BackgroundButton = new System.Windows.Forms.Button();
            this.CharacterButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SoundListButton = new System.Windows.Forms.Button();
            this.MusicListButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SpritesButton
            // 
            this.SpritesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SpritesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SpritesButton.Location = new System.Drawing.Point(534, 12);
            this.SpritesButton.Name = "SpritesButton";
            this.SpritesButton.Size = new System.Drawing.Size(115, 29);
            this.SpritesButton.TabIndex = 1;
            this.SpritesButton.Text = "Sprites";
            this.SpritesButton.UseVisualStyleBackColor = true;
            this.SpritesButton.Click += new System.EventHandler(this.SpritesButton_Click);
            // 
            // BackgroundButton
            // 
            this.BackgroundButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BackgroundButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackgroundButton.Location = new System.Drawing.Point(655, 12);
            this.BackgroundButton.Name = "BackgroundButton";
            this.BackgroundButton.Size = new System.Drawing.Size(115, 29);
            this.BackgroundButton.TabIndex = 2;
            this.BackgroundButton.Text = "Background";
            this.BackgroundButton.UseVisualStyleBackColor = true;
            this.BackgroundButton.Click += new System.EventHandler(this.BackgroundButton_Click);
            // 
            // CharacterButton
            // 
            this.CharacterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CharacterButton.Location = new System.Drawing.Point(12, 12);
            this.CharacterButton.Name = "CharacterButton";
            this.CharacterButton.Size = new System.Drawing.Size(115, 29);
            this.CharacterButton.TabIndex = 3;
            this.CharacterButton.Text = "Character";
            this.CharacterButton.UseVisualStyleBackColor = true;
            this.CharacterButton.Click += new System.EventHandler(this.CharacterButton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 53);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(782, 400);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // SoundListButton
            // 
            this.SoundListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SoundListButton.Location = new System.Drawing.Point(133, 12);
            this.SoundListButton.Name = "SoundListButton";
            this.SoundListButton.Size = new System.Drawing.Size(115, 29);
            this.SoundListButton.TabIndex = 5;
            this.SoundListButton.Text = "Sound List";
            this.SoundListButton.UseVisualStyleBackColor = true;
            this.SoundListButton.Click += new System.EventHandler(this.SoundListButton_Click);
            // 
            // MusicListButton
            // 
            this.MusicListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MusicListButton.Location = new System.Drawing.Point(254, 12);
            this.MusicListButton.Name = "MusicListButton";
            this.MusicListButton.Size = new System.Drawing.Size(115, 29);
            this.MusicListButton.TabIndex = 6;
            this.MusicListButton.Text = "Music List";
            this.MusicListButton.UseVisualStyleBackColor = true;
            this.MusicListButton.Click += new System.EventHandler(this.MusicListButton_Click);
            // 
            // GameResourceTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.MusicListButton);
            this.Controls.Add(this.SoundListButton);
            this.Controls.Add(this.CharacterButton);
            this.Controls.Add(this.SpritesButton);
            this.Controls.Add(this.BackgroundButton);
            this.Controls.Add(this.flowLayoutPanel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameResourceTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Resource Table";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SpritesButton;
        private System.Windows.Forms.Button BackgroundButton;
        private System.Windows.Forms.Button CharacterButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button SoundListButton;
        private System.Windows.Forms.Button MusicListButton;
    }
}