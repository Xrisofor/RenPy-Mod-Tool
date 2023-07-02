namespace Mod_Tool.Forms
{
    partial class UploadWorskhopItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UploadWorskhopItem));
            this.TagsLabel = new System.Windows.Forms.Label();
            this.NewCharactersMT = new System.Windows.Forms.CheckBox();
            this.NewGraphicsMT = new System.Windows.Forms.CheckBox();
            this.NewStoryMT = new System.Windows.Forms.CheckBox();
            this.GetSteamInfoButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.NewFeaturesMT = new System.Windows.Forms.CheckBox();
            this.AcceptLabel = new System.Windows.Forms.Label();
            this.UploadButton = new System.Windows.Forms.Button();
            this.ModID_TextBox = new System.Windows.Forms.TextBox();
            this.ModIDLabel = new System.Windows.Forms.Label();
            this.ListChangesLabel = new System.Windows.Forms.Label();
            this.ModUpdate_TextBox = new System.Windows.Forms.TextBox();
            this.ModImg_Button = new System.Windows.Forms.Button();
            this.ModImg_TextBox = new System.Windows.Forms.TextBox();
            this.ModHeaderLabel = new System.Windows.Forms.Label();
            this.ModPath_Button = new System.Windows.Forms.Button();
            this.ModPath_TextBox = new System.Windows.Forms.TextBox();
            this.MainFolderLabel = new System.Windows.Forms.Label();
            this.ModDisc_CheckBox = new System.Windows.Forms.CheckBox();
            this.ModDescLabel = new System.Windows.Forms.Label();
            this.ModDisc_TextBox = new System.Windows.Forms.TextBox();
            this.ModName_CheckBox = new System.Windows.Forms.CheckBox();
            this.ModName_TextBox = new System.Windows.Forms.TextBox();
            this.ModNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TagsLabel
            // 
            this.TagsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TagsLabel.Location = new System.Drawing.Point(15, 495);
            this.TagsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TagsLabel.Name = "TagsLabel";
            this.TagsLabel.Size = new System.Drawing.Size(178, 72);
            this.TagsLabel.TabIndex = 48;
            this.TagsLabel.Text = "Метки";
            this.TagsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NewCharactersMT
            // 
            this.NewCharactersMT.Location = new System.Drawing.Point(353, 537);
            this.NewCharactersMT.Margin = new System.Windows.Forms.Padding(4);
            this.NewCharactersMT.Name = "NewCharactersMT";
            this.NewCharactersMT.Size = new System.Drawing.Size(162, 30);
            this.NewCharactersMT.TabIndex = 46;
            this.NewCharactersMT.Text = "New Characters";
            this.NewCharactersMT.UseVisualStyleBackColor = true;
            this.NewCharactersMT.CheckedChanged += new System.EventHandler(this.NewCharactersMT_CheckedChanged);
            // 
            // NewGraphicsMT
            // 
            this.NewGraphicsMT.Location = new System.Drawing.Point(353, 499);
            this.NewGraphicsMT.Margin = new System.Windows.Forms.Padding(4);
            this.NewGraphicsMT.Name = "NewGraphicsMT";
            this.NewGraphicsMT.Size = new System.Drawing.Size(162, 30);
            this.NewGraphicsMT.TabIndex = 45;
            this.NewGraphicsMT.Text = "New Graphics";
            this.NewGraphicsMT.UseVisualStyleBackColor = true;
            this.NewGraphicsMT.CheckedChanged += new System.EventHandler(this.NewGraphicsMT_CheckedChanged);
            // 
            // NewStoryMT
            // 
            this.NewStoryMT.Location = new System.Drawing.Point(201, 499);
            this.NewStoryMT.Margin = new System.Windows.Forms.Padding(4);
            this.NewStoryMT.Name = "NewStoryMT";
            this.NewStoryMT.Size = new System.Drawing.Size(144, 30);
            this.NewStoryMT.TabIndex = 44;
            this.NewStoryMT.Text = "Новая история";
            this.NewStoryMT.UseVisualStyleBackColor = true;
            this.NewStoryMT.CheckedChanged += new System.EventHandler(this.NewStoryMT_CheckedChanged);
            // 
            // GetSteamInfoButton
            // 
            this.GetSteamInfoButton.Enabled = false;
            this.GetSteamInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GetSteamInfoButton.Location = new System.Drawing.Point(268, 575);
            this.GetSteamInfoButton.Margin = new System.Windows.Forms.Padding(4);
            this.GetSteamInfoButton.Name = "GetSteamInfoButton";
            this.GetSteamInfoButton.Size = new System.Drawing.Size(247, 33);
            this.GetSteamInfoButton.TabIndex = 43;
            this.GetSteamInfoButton.Text = "Взять данные из Steam";
            this.GetSteamInfoButton.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Image Files (*.bmp, *.jpg, *.png, *.gif)|*.bmp;*.jpg;*.png;*.gif";
            // 
            // NewFeaturesMT
            // 
            this.NewFeaturesMT.Location = new System.Drawing.Point(201, 537);
            this.NewFeaturesMT.Margin = new System.Windows.Forms.Padding(4);
            this.NewFeaturesMT.Name = "NewFeaturesMT";
            this.NewFeaturesMT.Size = new System.Drawing.Size(144, 30);
            this.NewFeaturesMT.TabIndex = 47;
            this.NewFeaturesMT.Text = "New Features";
            this.NewFeaturesMT.UseVisualStyleBackColor = true;
            this.NewFeaturesMT.CheckedChanged += new System.EventHandler(this.NewFeaturesMT_CheckedChanged);
            // 
            // AcceptLabel
            // 
            this.AcceptLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AcceptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AcceptLabel.Location = new System.Drawing.Point(13, 612);
            this.AcceptLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AcceptLabel.Name = "AcceptLabel";
            this.AcceptLabel.Size = new System.Drawing.Size(502, 44);
            this.AcceptLabel.TabIndex = 42;
            this.AcceptLabel.Text = "By submitting the mod to the Workshop, you accept the terms of use of the Steam W" +
    "orkshop!";
            this.AcceptLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AcceptLabel.Click += new System.EventHandler(this.AcceptLabel_Click);
            // 
            // UploadButton
            // 
            this.UploadButton.Enabled = false;
            this.UploadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UploadButton.Location = new System.Drawing.Point(13, 575);
            this.UploadButton.Margin = new System.Windows.Forms.Padding(4);
            this.UploadButton.Name = "UploadButton";
            this.UploadButton.Size = new System.Drawing.Size(247, 33);
            this.UploadButton.TabIndex = 41;
            this.UploadButton.Text = "Загрузить";
            this.UploadButton.UseVisualStyleBackColor = true;
            this.UploadButton.Click += new System.EventHandler(this.UploadButton_Click);
            // 
            // ModID_TextBox
            // 
            this.ModID_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            this.ModID_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ModID_TextBox.Enabled = false;
            this.ModID_TextBox.ForeColor = System.Drawing.Color.White;
            this.ModID_TextBox.Location = new System.Drawing.Point(13, 41);
            this.ModID_TextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ModID_TextBox.Name = "ModID_TextBox";
            this.ModID_TextBox.Size = new System.Drawing.Size(180, 22);
            this.ModID_TextBox.TabIndex = 40;
            this.ModID_TextBox.TextChanged += new System.EventHandler(this.ModID_TextBox_TextChanged);
            this.ModID_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ModID_TextBox_KeyPress);
            // 
            // ModIDLabel
            // 
            this.ModIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ModIDLabel.Location = new System.Drawing.Point(8, 9);
            this.ModIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ModIDLabel.Name = "ModIDLabel";
            this.ModIDLabel.Size = new System.Drawing.Size(185, 28);
            this.ModIDLabel.TabIndex = 39;
            this.ModIDLabel.Text = "Mod ID";
            this.ModIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ListChangesLabel
            // 
            this.ListChangesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ListChangesLabel.Location = new System.Drawing.Point(315, 364);
            this.ListChangesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ListChangesLabel.Name = "ListChangesLabel";
            this.ListChangesLabel.Size = new System.Drawing.Size(200, 123);
            this.ListChangesLabel.TabIndex = 38;
            this.ListChangesLabel.Text = "Список изменений";
            this.ListChangesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ModUpdate_TextBox
            // 
            this.ModUpdate_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            this.ModUpdate_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ModUpdate_TextBox.ForeColor = System.Drawing.Color.White;
            this.ModUpdate_TextBox.Location = new System.Drawing.Point(13, 364);
            this.ModUpdate_TextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ModUpdate_TextBox.Multiline = true;
            this.ModUpdate_TextBox.Name = "ModUpdate_TextBox";
            this.ModUpdate_TextBox.Size = new System.Drawing.Size(296, 123);
            this.ModUpdate_TextBox.TabIndex = 37;
            // 
            // ModImg_Button
            // 
            this.ModImg_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModImg_Button.Location = new System.Drawing.Point(268, 311);
            this.ModImg_Button.Margin = new System.Windows.Forms.Padding(4);
            this.ModImg_Button.Name = "ModImg_Button";
            this.ModImg_Button.Size = new System.Drawing.Size(247, 28);
            this.ModImg_Button.TabIndex = 36;
            this.ModImg_Button.Text = "Обзор";
            this.ModImg_Button.UseVisualStyleBackColor = true;
            this.ModImg_Button.Click += new System.EventHandler(this.ModImg_Button_Click);
            // 
            // ModImg_TextBox
            // 
            this.ModImg_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            this.ModImg_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ModImg_TextBox.ForeColor = System.Drawing.Color.White;
            this.ModImg_TextBox.Location = new System.Drawing.Point(268, 281);
            this.ModImg_TextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ModImg_TextBox.Name = "ModImg_TextBox";
            this.ModImg_TextBox.Size = new System.Drawing.Size(247, 22);
            this.ModImg_TextBox.TabIndex = 35;
            // 
            // ModHeaderLabel
            // 
            this.ModHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ModHeaderLabel.Location = new System.Drawing.Point(268, 249);
            this.ModHeaderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ModHeaderLabel.Name = "ModHeaderLabel";
            this.ModHeaderLabel.Size = new System.Drawing.Size(243, 28);
            this.ModHeaderLabel.TabIndex = 34;
            this.ModHeaderLabel.Text = "Обложка мода";
            this.ModHeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ModPath_Button
            // 
            this.ModPath_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModPath_Button.Location = new System.Drawing.Point(13, 311);
            this.ModPath_Button.Margin = new System.Windows.Forms.Padding(4);
            this.ModPath_Button.Name = "ModPath_Button";
            this.ModPath_Button.Size = new System.Drawing.Size(247, 28);
            this.ModPath_Button.TabIndex = 33;
            this.ModPath_Button.Text = "Обзор";
            this.ModPath_Button.UseVisualStyleBackColor = true;
            this.ModPath_Button.Click += new System.EventHandler(this.ModPath_Button_Click);
            // 
            // ModPath_TextBox
            // 
            this.ModPath_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            this.ModPath_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ModPath_TextBox.ForeColor = System.Drawing.Color.White;
            this.ModPath_TextBox.Location = new System.Drawing.Point(13, 281);
            this.ModPath_TextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ModPath_TextBox.Name = "ModPath_TextBox";
            this.ModPath_TextBox.Size = new System.Drawing.Size(247, 22);
            this.ModPath_TextBox.TabIndex = 32;
            // 
            // MainFolderLabel
            // 
            this.MainFolderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.MainFolderLabel.Location = new System.Drawing.Point(13, 249);
            this.MainFolderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MainFolderLabel.Name = "MainFolderLabel";
            this.MainFolderLabel.Size = new System.Drawing.Size(247, 28);
            this.MainFolderLabel.TabIndex = 31;
            this.MainFolderLabel.Text = "Оснавная папка";
            this.MainFolderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ModDisc_CheckBox
            // 
            this.ModDisc_CheckBox.Enabled = false;
            this.ModDisc_CheckBox.Location = new System.Drawing.Point(31, 190);
            this.ModDisc_CheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.ModDisc_CheckBox.Name = "ModDisc_CheckBox";
            this.ModDisc_CheckBox.Size = new System.Drawing.Size(162, 30);
            this.ModDisc_CheckBox.TabIndex = 30;
            this.ModDisc_CheckBox.Text = "Не изменять";
            this.ModDisc_CheckBox.UseVisualStyleBackColor = true;
            // 
            // ModDescLabel
            // 
            this.ModDescLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ModDescLabel.Location = new System.Drawing.Point(15, 109);
            this.ModDescLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ModDescLabel.Name = "ModDescLabel";
            this.ModDescLabel.Size = new System.Drawing.Size(178, 111);
            this.ModDescLabel.TabIndex = 29;
            this.ModDescLabel.Text = "Описания мода";
            this.ModDescLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ModDisc_TextBox
            // 
            this.ModDisc_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            this.ModDisc_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ModDisc_TextBox.ForeColor = System.Drawing.Color.White;
            this.ModDisc_TextBox.Location = new System.Drawing.Point(201, 109);
            this.ModDisc_TextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ModDisc_TextBox.Multiline = true;
            this.ModDisc_TextBox.Name = "ModDisc_TextBox";
            this.ModDisc_TextBox.Size = new System.Drawing.Size(310, 123);
            this.ModDisc_TextBox.TabIndex = 28;
            // 
            // ModName_CheckBox
            // 
            this.ModName_CheckBox.Enabled = false;
            this.ModName_CheckBox.Location = new System.Drawing.Point(201, 71);
            this.ModName_CheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.ModName_CheckBox.Name = "ModName_CheckBox";
            this.ModName_CheckBox.Size = new System.Drawing.Size(310, 30);
            this.ModName_CheckBox.TabIndex = 27;
            this.ModName_CheckBox.Text = "Не изменять";
            this.ModName_CheckBox.UseVisualStyleBackColor = true;
            // 
            // ModName_TextBox
            // 
            this.ModName_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            this.ModName_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ModName_TextBox.ForeColor = System.Drawing.Color.White;
            this.ModName_TextBox.Location = new System.Drawing.Point(201, 41);
            this.ModName_TextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ModName_TextBox.Name = "ModName_TextBox";
            this.ModName_TextBox.Size = new System.Drawing.Size(310, 22);
            this.ModName_TextBox.TabIndex = 26;
            this.ModName_TextBox.TextChanged += new System.EventHandler(this.ModName_TextBox_TextChanged);
            // 
            // ModNameLabel
            // 
            this.ModNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ModNameLabel.Location = new System.Drawing.Point(201, 8);
            this.ModNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ModNameLabel.Name = "ModNameLabel";
            this.ModNameLabel.Size = new System.Drawing.Size(310, 30);
            this.ModNameLabel.TabIndex = 25;
            this.ModNameLabel.Text = "Название мода";
            this.ModNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UploadWorskhopItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(527, 665);
            this.Controls.Add(this.TagsLabel);
            this.Controls.Add(this.NewCharactersMT);
            this.Controls.Add(this.NewGraphicsMT);
            this.Controls.Add(this.NewStoryMT);
            this.Controls.Add(this.GetSteamInfoButton);
            this.Controls.Add(this.NewFeaturesMT);
            this.Controls.Add(this.AcceptLabel);
            this.Controls.Add(this.UploadButton);
            this.Controls.Add(this.ModID_TextBox);
            this.Controls.Add(this.ModIDLabel);
            this.Controls.Add(this.ListChangesLabel);
            this.Controls.Add(this.ModUpdate_TextBox);
            this.Controls.Add(this.ModImg_Button);
            this.Controls.Add(this.ModImg_TextBox);
            this.Controls.Add(this.ModHeaderLabel);
            this.Controls.Add(this.ModPath_Button);
            this.Controls.Add(this.ModPath_TextBox);
            this.Controls.Add(this.MainFolderLabel);
            this.Controls.Add(this.ModDisc_CheckBox);
            this.Controls.Add(this.ModDescLabel);
            this.Controls.Add(this.ModDisc_TextBox);
            this.Controls.Add(this.ModName_CheckBox);
            this.Controls.Add(this.ModName_TextBox);
            this.Controls.Add(this.ModNameLabel);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UploadWorskhopItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UploadWorskhopItem";
            this.Load += new System.EventHandler(this.UploadWorskhopItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TagsLabel;
        private System.Windows.Forms.CheckBox NewCharactersMT;
        private System.Windows.Forms.CheckBox NewGraphicsMT;
        private System.Windows.Forms.CheckBox NewStoryMT;
        private System.Windows.Forms.Button GetSteamInfoButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.CheckBox NewFeaturesMT;
        private System.Windows.Forms.Label AcceptLabel;
        private System.Windows.Forms.Button UploadButton;
        private System.Windows.Forms.TextBox ModID_TextBox;
        private System.Windows.Forms.Label ModIDLabel;
        private System.Windows.Forms.Label ListChangesLabel;
        private System.Windows.Forms.TextBox ModUpdate_TextBox;
        private System.Windows.Forms.Button ModImg_Button;
        private System.Windows.Forms.TextBox ModImg_TextBox;
        private System.Windows.Forms.Label ModHeaderLabel;
        private System.Windows.Forms.Button ModPath_Button;
        private System.Windows.Forms.TextBox ModPath_TextBox;
        private System.Windows.Forms.Label MainFolderLabel;
        private System.Windows.Forms.CheckBox ModDisc_CheckBox;
        private System.Windows.Forms.Label ModDescLabel;
        private System.Windows.Forms.TextBox ModDisc_TextBox;
        private System.Windows.Forms.CheckBox ModName_CheckBox;
        private System.Windows.Forms.TextBox ModName_TextBox;
        private System.Windows.Forms.Label ModNameLabel;
    }
}