namespace Mod_Tool
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.CreateNewItemButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.InterfacelanguageLabel = new System.Windows.Forms.Label();
            this.LanguageComboBox = new System.Windows.Forms.ComboBox();
            this.PVersionLabel = new System.Windows.Forms.Label();
            this.DocumentationButton = new System.Windows.Forms.Button();
            this.UpdateItemButton = new System.Windows.Forms.Button();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateNewItemButton
            // 
            this.CreateNewItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateNewItemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.CreateNewItemButton.Location = new System.Drawing.Point(10, 10);
            this.CreateNewItemButton.Name = "CreateNewItemButton";
            this.CreateNewItemButton.Size = new System.Drawing.Size(250, 34);
            this.CreateNewItemButton.TabIndex = 1;
            this.CreateNewItemButton.Text = "Create a new mod";
            this.CreateNewItemButton.UseVisualStyleBackColor = true;
            this.CreateNewItemButton.Click += new System.EventHandler(this.CreateNewItemButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.InterfacelanguageLabel);
            this.panel1.Controls.Add(this.LanguageComboBox);
            this.panel1.Controls.Add(this.PVersionLabel);
            this.panel1.Controls.Add(this.DocumentationButton);
            this.panel1.Controls.Add(this.UpdateItemButton);
            this.panel1.Controls.Add(this.CreateNewItemButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(392, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 414);
            this.panel1.TabIndex = 2;
            // 
            // InterfacelanguageLabel
            // 
            this.InterfacelanguageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.InterfacelanguageLabel.Location = new System.Drawing.Point(7, 139);
            this.InterfacelanguageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.InterfacelanguageLabel.Name = "InterfacelanguageLabel";
            this.InterfacelanguageLabel.Size = new System.Drawing.Size(253, 31);
            this.InterfacelanguageLabel.TabIndex = 7;
            this.InterfacelanguageLabel.Text = "Interface language";
            this.InterfacelanguageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LanguageComboBox
            // 
            this.LanguageComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.LanguageComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.LanguageComboBox.ForeColor = System.Drawing.Color.White;
            this.LanguageComboBox.FormattingEnabled = true;
            this.LanguageComboBox.Location = new System.Drawing.Point(10, 173);
            this.LanguageComboBox.Name = "LanguageComboBox";
            this.LanguageComboBox.Size = new System.Drawing.Size(250, 28);
            this.LanguageComboBox.TabIndex = 6;
            this.LanguageComboBox.Text = "English";
            this.LanguageComboBox.SelectedIndexChanged += new System.EventHandler(this.LanguageComboBox_SelectedIndexChanged);
            // 
            // PVersionLabel
            // 
            this.PVersionLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PVersionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PVersionLabel.Location = new System.Drawing.Point(0, 383);
            this.PVersionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PVersionLabel.Name = "PVersionLabel";
            this.PVersionLabel.Size = new System.Drawing.Size(269, 31);
            this.PVersionLabel.TabIndex = 5;
            this.PVersionLabel.Text = "Mod Tool Version: 1.0.0 Beta";
            this.PVersionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DocumentationButton
            // 
            this.DocumentationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DocumentationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.DocumentationButton.Location = new System.Drawing.Point(10, 94);
            this.DocumentationButton.Name = "DocumentationButton";
            this.DocumentationButton.Size = new System.Drawing.Size(250, 34);
            this.DocumentationButton.TabIndex = 3;
            this.DocumentationButton.Text = "Documentation";
            this.DocumentationButton.UseVisualStyleBackColor = true;
            this.DocumentationButton.Click += new System.EventHandler(this.DocumentationButton_Click);
            // 
            // UpdateItemButton
            // 
            this.UpdateItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateItemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.UpdateItemButton.Location = new System.Drawing.Point(10, 52);
            this.UpdateItemButton.Name = "UpdateItemButton";
            this.UpdateItemButton.Size = new System.Drawing.Size(250, 34);
            this.UpdateItemButton.TabIndex = 2;
            this.UpdateItemButton.Text = "Update an existing one";
            this.UpdateItemButton.UseVisualStyleBackColor = true;
            this.UpdateItemButton.Click += new System.EventHandler(this.UpdateItemButton_Click);
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WelcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WelcomeLabel.Location = new System.Drawing.Point(9, 10);
            this.WelcomeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(376, 160);
            this.WelcomeLabel.TabIndex = 3;
            this.WelcomeLabel.Text = "Welcome, {SteamUserName}!\r\nDo you want to create a new or update an old modificat" +
    "ion for Steam?";
            this.WelcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(661, 414);
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreateNewItemButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button UpdateItemButton;
        private System.Windows.Forms.Button DocumentationButton;
        private System.Windows.Forms.Label PVersionLabel;
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.ComboBox LanguageComboBox;
        private System.Windows.Forms.Label InterfacelanguageLabel;
    }
}

