namespace ModTool.Forms
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.label1 = new System.Windows.Forms.Label();
            this.LanguageComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ScriptEditorComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PixelSampleColorMaxNum = new System.Windows.Forms.NumericUpDown();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.restoreProjectsButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.showWarningCheckBox = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.devNameTextBox = new System.Windows.Forms.TextBox();
            this.restoreSettingsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PixelSampleColorMaxNum)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Language";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LanguageComboBox
            // 
            this.LanguageComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LanguageComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.LanguageComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LanguageComboBox.ForeColor = System.Drawing.Color.White;
            this.LanguageComboBox.FormattingEnabled = true;
            this.LanguageComboBox.Location = new System.Drawing.Point(16, 58);
            this.LanguageComboBox.Margin = new System.Windows.Forms.Padding(10, 10, 3, 3);
            this.LanguageComboBox.Name = "LanguageComboBox";
            this.LanguageComboBox.Size = new System.Drawing.Size(267, 24);
            this.LanguageComboBox.TabIndex = 1;
            this.LanguageComboBox.Text = "English";
            this.LanguageComboBox.SelectedIndexChanged += new System.EventHandler(this.LanguageComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 25, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Script Editor";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ScriptEditorComboBox
            // 
            this.ScriptEditorComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScriptEditorComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ScriptEditorComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ScriptEditorComboBox.ForeColor = System.Drawing.Color.White;
            this.ScriptEditorComboBox.FormattingEnabled = true;
            this.ScriptEditorComboBox.Items.AddRange(new object[] {
            "Internal Editor",
            "Add a custom editor"});
            this.ScriptEditorComboBox.Location = new System.Drawing.Point(16, 141);
            this.ScriptEditorComboBox.Margin = new System.Windows.Forms.Padding(10, 10, 3, 3);
            this.ScriptEditorComboBox.Name = "ScriptEditorComboBox";
            this.ScriptEditorComboBox.Size = new System.Drawing.Size(267, 24);
            this.ScriptEditorComboBox.TabIndex = 4;
            this.ScriptEditorComboBox.Text = "Internal Editor";
            this.ScriptEditorComboBox.SelectedIndexChanged += new System.EventHandler(this.ScriptEditorComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(13, 193);
            this.label3.Margin = new System.Windows.Forms.Padding(10, 25, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(270, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Max. num. of pixelation colors";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PixelSampleColorMaxNum
            // 
            this.PixelSampleColorMaxNum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PixelSampleColorMaxNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.PixelSampleColorMaxNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PixelSampleColorMaxNum.ForeColor = System.Drawing.Color.White;
            this.PixelSampleColorMaxNum.Location = new System.Drawing.Point(16, 226);
            this.PixelSampleColorMaxNum.Margin = new System.Windows.Forms.Padding(10, 10, 3, 3);
            this.PixelSampleColorMaxNum.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.PixelSampleColorMaxNum.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.PixelSampleColorMaxNum.Name = "PixelSampleColorMaxNum";
            this.PixelSampleColorMaxNum.Size = new System.Drawing.Size(267, 22);
            this.PixelSampleColorMaxNum.TabIndex = 6;
            this.PixelSampleColorMaxNum.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.PixelSampleColorMaxNum.ValueChanged += new System.EventHandler(this.PixelSampleColorMaxNum_ValueChanged);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Application|*.exe";
            // 
            // restoreProjectsButton
            // 
            this.restoreProjectsButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.restoreProjectsButton.Enabled = false;
            this.restoreProjectsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restoreProjectsButton.Location = new System.Drawing.Point(12, 404);
            this.restoreProjectsButton.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.restoreProjectsButton.Name = "restoreProjectsButton";
            this.restoreProjectsButton.Size = new System.Drawing.Size(333, 37);
            this.restoreProjectsButton.TabIndex = 0;
            this.restoreProjectsButton.Text = "Restore projects";
            this.restoreProjectsButton.UseVisualStyleBackColor = true;
            this.restoreProjectsButton.Click += new System.EventHandler(this.restoreProjectsButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.PixelSampleColorMaxNum);
            this.groupBox1.Controls.Add(this.LanguageComboBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ScriptEditorComboBox);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 379);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Main";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.devNameTextBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.showWarningCheckBox);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(364, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(333, 379);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dev";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(13, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(305, 51);
            this.label4.TabIndex = 1;
            this.label4.Text = "This checkbox on/off alert notifications. Critical errors and Steam do not apply!" +
    "";
            // 
            // showWarningCheckBox
            // 
            this.showWarningCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showWarningCheckBox.Location = new System.Drawing.Point(13, 25);
            this.showWarningCheckBox.Name = "showWarningCheckBox";
            this.showWarningCheckBox.Size = new System.Drawing.Size(305, 24);
            this.showWarningCheckBox.TabIndex = 0;
            this.showWarningCheckBox.Text = "Show a warning";
            this.showWarningCheckBox.UseVisualStyleBackColor = true;
            this.showWarningCheckBox.CheckedChanged += new System.EventHandler(this.showWarningCheckBox_CheckedChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(10, 108);
            this.label5.Margin = new System.Windows.Forms.Padding(10, 25, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(270, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Developer\'s name";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // devNameTextBox
            // 
            this.devNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.devNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.devNameTextBox.ForeColor = System.Drawing.Color.White;
            this.devNameTextBox.Location = new System.Drawing.Point(13, 141);
            this.devNameTextBox.Name = "devNameTextBox";
            this.devNameTextBox.Size = new System.Drawing.Size(267, 22);
            this.devNameTextBox.TabIndex = 8;
            this.devNameTextBox.TextChanged += new System.EventHandler(this.devNameTextBox_TextChanged);
            // 
            // restoreSettingsButton
            // 
            this.restoreSettingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.restoreSettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restoreSettingsButton.Location = new System.Drawing.Point(364, 404);
            this.restoreSettingsButton.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.restoreSettingsButton.Name = "restoreSettingsButton";
            this.restoreSettingsButton.Size = new System.Drawing.Size(333, 37);
            this.restoreSettingsButton.TabIndex = 9;
            this.restoreSettingsButton.Text = "Restore settings";
            this.restoreSettingsButton.UseVisualStyleBackColor = true;
            this.restoreSettingsButton.Click += new System.EventHandler(this.restoreSettingsButton_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(709, 450);
            this.Controls.Add(this.restoreSettingsButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.restoreProjectsButton);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Settings_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.PixelSampleColorMaxNum)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox LanguageComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ScriptEditorComboBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown PixelSampleColorMaxNum;
        private System.Windows.Forms.Button restoreProjectsButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox showWarningCheckBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox devNameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button restoreSettingsButton;
    }
}