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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.LanguageComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ScriptEditorComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PixelSampleColorMaxNum = new System.Windows.Forms.NumericUpDown();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PixelSampleColorMaxNum)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.LanguageComboBox);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.ScriptEditorComboBox);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.PixelSampleColorMaxNum);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Language";
            // 
            // LanguageComboBox
            // 
            this.LanguageComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LanguageComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.LanguageComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LanguageComboBox.ForeColor = System.Drawing.Color.White;
            this.LanguageComboBox.FormattingEnabled = true;
            this.LanguageComboBox.Location = new System.Drawing.Point(10, 43);
            this.LanguageComboBox.Margin = new System.Windows.Forms.Padding(10, 10, 3, 3);
            this.LanguageComboBox.Name = "LanguageComboBox";
            this.LanguageComboBox.Size = new System.Drawing.Size(270, 24);
            this.LanguageComboBox.TabIndex = 1;
            this.LanguageComboBox.Text = "English";
            this.LanguageComboBox.SelectedIndexChanged += new System.EventHandler(this.LanguageComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(10, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 25, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Script Editor";
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
            this.ScriptEditorComboBox.Location = new System.Drawing.Point(10, 128);
            this.ScriptEditorComboBox.Margin = new System.Windows.Forms.Padding(10, 10, 3, 3);
            this.ScriptEditorComboBox.Name = "ScriptEditorComboBox";
            this.ScriptEditorComboBox.Size = new System.Drawing.Size(270, 24);
            this.ScriptEditorComboBox.TabIndex = 4;
            this.ScriptEditorComboBox.Text = "Internal Editor";
            this.ScriptEditorComboBox.SelectedIndexChanged += new System.EventHandler(this.ScriptEditorComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(10, 180);
            this.label3.Margin = new System.Windows.Forms.Padding(10, 25, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(270, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Max. num. of pixelation colors";
            // 
            // PixelSampleColorMaxNum
            // 
            this.PixelSampleColorMaxNum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PixelSampleColorMaxNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.PixelSampleColorMaxNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PixelSampleColorMaxNum.ForeColor = System.Drawing.Color.White;
            this.PixelSampleColorMaxNum.Location = new System.Drawing.Point(10, 213);
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
            this.PixelSampleColorMaxNum.Size = new System.Drawing.Size(270, 22);
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
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Settings_FormClosed);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PixelSampleColorMaxNum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ComboBox LanguageComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ScriptEditorComboBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown PixelSampleColorMaxNum;
    }
}