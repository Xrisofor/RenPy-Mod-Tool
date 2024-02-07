namespace ModTool.Forms
{
    partial class SpriteManager
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpriteManager));
            this.AddButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.ReloadButton = new System.Windows.Forms.Button();
            this.ObjectsListView = new System.Windows.Forms.ListView();
            this.SpritesList = new System.Windows.Forms.ImageList(this.components);
            this.SelectImageFile = new System.Windows.Forms.OpenFileDialog();
            this.SelectAudioFile = new System.Windows.Forms.OpenFileDialog();
            this.OtherList = new System.Windows.Forms.ImageList(this.components);
            this.PlayButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Location = new System.Drawing.Point(12, 12);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(155, 29);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveButton.Location = new System.Drawing.Point(173, 12);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(155, 29);
            this.RemoveButton.TabIndex = 1;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // ReloadButton
            // 
            this.ReloadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReloadButton.Location = new System.Drawing.Point(334, 12);
            this.ReloadButton.Name = "ReloadButton";
            this.ReloadButton.Size = new System.Drawing.Size(155, 29);
            this.ReloadButton.TabIndex = 2;
            this.ReloadButton.Text = "Reload";
            this.ReloadButton.UseVisualStyleBackColor = true;
            this.ReloadButton.Click += new System.EventHandler(this.ReloadButton_Click);
            // 
            // ObjectsListView
            // 
            this.ObjectsListView.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.ObjectsListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ObjectsListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ObjectsListView.ForeColor = System.Drawing.Color.White;
            this.ObjectsListView.HideSelection = false;
            this.ObjectsListView.LargeImageList = this.SpritesList;
            this.ObjectsListView.Location = new System.Drawing.Point(12, 47);
            this.ObjectsListView.MultiSelect = false;
            this.ObjectsListView.Name = "ObjectsListView";
            this.ObjectsListView.Size = new System.Drawing.Size(965, 628);
            this.ObjectsListView.TabIndex = 3;
            this.ObjectsListView.UseCompatibleStateImageBehavior = false;
            this.ObjectsListView.SelectedIndexChanged += new System.EventHandler(this.ObjectsListView_SelectedIndexChanged);
            // 
            // SpritesList
            // 
            this.SpritesList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.SpritesList.ImageSize = new System.Drawing.Size(185, 185);
            this.SpritesList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // SelectImageFile
            // 
            this.SelectImageFile.Filter = "Images|*.png;*.jpg";
            // 
            // SelectAudioFile
            // 
            this.SelectAudioFile.Filter = "Audio|*.wav; *.ogg;*.mp3";
            // 
            // OtherList
            // 
            this.OtherList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("OtherList.ImageStream")));
            this.OtherList.TransparentColor = System.Drawing.Color.Transparent;
            this.OtherList.Images.SetKeyName(0, "audio");
            // 
            // PlayButton
            // 
            this.PlayButton.Enabled = false;
            this.PlayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayButton.Location = new System.Drawing.Point(822, 12);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(155, 29);
            this.PlayButton.TabIndex = 4;
            this.PlayButton.Text = "Play";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Enabled = false;
            this.StopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StopButton.Location = new System.Drawing.Point(661, 12);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(155, 29);
            this.StopButton.TabIndex = 5;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // SpriteManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(989, 687);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.ObjectsListView);
            this.Controls.Add(this.ReloadButton);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.AddButton);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SpriteManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sprite Manager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button ReloadButton;
        private System.Windows.Forms.ListView ObjectsListView;
        private System.Windows.Forms.OpenFileDialog SelectImageFile;
        public System.Windows.Forms.ImageList SpritesList;
        private System.Windows.Forms.OpenFileDialog SelectAudioFile;
        private System.Windows.Forms.ImageList OtherList;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Button StopButton;
    }
}