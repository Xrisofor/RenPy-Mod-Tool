namespace ModTool.Forms.Panel
{
    partial class RenPyScript
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RenPyScript));
            this.fastColoredTextBox1 = new FastColoredTextBoxNS.FastColoredTextBox();
            this.RenpyAutoComplete = new AutocompleteMenuNS.AutocompleteMenu();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rpyOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.rpySaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.PixelationButton = new System.Windows.Forms.Button();
            this.RenPyDocButton = new System.Windows.Forms.Button();
            this.rpaExpButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.TableButton = new System.Windows.Forms.Button();
            this.FindAndReplaceButton = new System.Windows.Forms.Button();
            this.FindButton = new System.Windows.Forms.Button();
            this.SaveAsButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.NewFileButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fastColoredTextBox1
            // 
            this.fastColoredTextBox1.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.RenpyAutoComplete.SetAutocompleteMenu(this.fastColoredTextBox1, this.RenpyAutoComplete);
            this.fastColoredTextBox1.AutoIndentCharsPatterns = "^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;=]+);\r\n^\\s*(case|default)\\s*[^:]*" +
    "(?<range>:)\\s*(?<range>[^;]+);";
            this.fastColoredTextBox1.AutoScrollMinSize = new System.Drawing.Size(39, 26);
            this.fastColoredTextBox1.BackBrush = null;
            this.fastColoredTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.fastColoredTextBox1.CharHeight = 26;
            this.fastColoredTextBox1.CharWidth = 14;
            this.fastColoredTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fastColoredTextBox1.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fastColoredTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fastColoredTextBox1.Font = new System.Drawing.Font("Courier New", 13.8F);
            this.fastColoredTextBox1.IndentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.fastColoredTextBox1.IsReplaceMode = false;
            this.fastColoredTextBox1.LineNumberColor = System.Drawing.Color.White;
            this.fastColoredTextBox1.Location = new System.Drawing.Point(0, 0);
            this.fastColoredTextBox1.Name = "fastColoredTextBox1";
            this.fastColoredTextBox1.Paddings = new System.Windows.Forms.Padding(0);
            this.fastColoredTextBox1.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fastColoredTextBox1.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fastColoredTextBox1.ServiceColors")));
            this.fastColoredTextBox1.Size = new System.Drawing.Size(942, 673);
            this.fastColoredTextBox1.TabIndex = 0;
            this.fastColoredTextBox1.Zoom = 100;
            this.fastColoredTextBox1.TextChanged += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.fastColoredTextBox1_TextChanged);
            // 
            // RenpyAutoComplete
            // 
            this.RenpyAutoComplete.Colors = ((AutocompleteMenuNS.Colors)(resources.GetObject("RenpyAutoComplete.Colors")));
            this.RenpyAutoComplete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.RenpyAutoComplete.ImageList = null;
            this.RenpyAutoComplete.Items = new string[0];
            this.RenpyAutoComplete.TargetControlWrapper = null;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.PixelationButton);
            this.panel1.Controls.Add(this.RenPyDocButton);
            this.panel1.Controls.Add(this.rpaExpButton);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.TableButton);
            this.panel1.Controls.Add(this.FindAndReplaceButton);
            this.panel1.Controls.Add(this.FindButton);
            this.panel1.Controls.Add(this.SaveAsButton);
            this.panel1.Controls.Add(this.SaveButton);
            this.panel1.Controls.Add(this.OpenFileButton);
            this.panel1.Controls.Add(this.NewFileButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(942, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(32, 673);
            this.panel1.TabIndex = 1;
            // 
            // rpyOpenFileDialog
            // 
            this.rpyOpenFileDialog.Filter = "RenPy / RPY|*.rpy";
            // 
            // rpySaveFileDialog
            // 
            this.rpySaveFileDialog.Filter = "RenPy / RPY|*.rpy";
            // 
            // PixelationButton
            // 
            this.PixelationButton.BackgroundImage = global::ModTool.Properties.Resources.paint;
            this.PixelationButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PixelationButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PixelationButton.FlatAppearance.BorderSize = 0;
            this.PixelationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PixelationButton.Location = new System.Drawing.Point(0, 471);
            this.PixelationButton.Name = "PixelationButton";
            this.PixelationButton.Size = new System.Drawing.Size(30, 40);
            this.PixelationButton.TabIndex = 10;
            this.PixelationButton.UseVisualStyleBackColor = true;
            this.PixelationButton.Click += new System.EventHandler(this.PixelationButton_Click);
            // 
            // RenPyDocButton
            // 
            this.RenPyDocButton.BackgroundImage = global::ModTool.Properties.Resources.document2;
            this.RenPyDocButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RenPyDocButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.RenPyDocButton.FlatAppearance.BorderSize = 0;
            this.RenPyDocButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RenPyDocButton.Location = new System.Drawing.Point(0, 511);
            this.RenPyDocButton.Name = "RenPyDocButton";
            this.RenPyDocButton.Size = new System.Drawing.Size(30, 40);
            this.RenPyDocButton.TabIndex = 9;
            this.RenPyDocButton.UseVisualStyleBackColor = true;
            this.RenPyDocButton.Click += new System.EventHandler(this.RenPyDocButton_Click);
            // 
            // rpaExpButton
            // 
            this.rpaExpButton.BackgroundImage = global::ModTool.Properties.Resources.lunacy;
            this.rpaExpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rpaExpButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rpaExpButton.FlatAppearance.BorderSize = 0;
            this.rpaExpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rpaExpButton.Location = new System.Drawing.Point(0, 551);
            this.rpaExpButton.Name = "rpaExpButton";
            this.rpaExpButton.Size = new System.Drawing.Size(30, 40);
            this.rpaExpButton.TabIndex = 8;
            this.rpaExpButton.UseVisualStyleBackColor = true;
            this.rpaExpButton.Click += new System.EventHandler(this.rpaExpButton_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::ModTool.Properties.Resources.tag2;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(0, 591);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 40);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TableButton
            // 
            this.TableButton.BackgroundImage = global::ModTool.Properties.Resources.table;
            this.TableButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.TableButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TableButton.FlatAppearance.BorderSize = 0;
            this.TableButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TableButton.Location = new System.Drawing.Point(0, 631);
            this.TableButton.Name = "TableButton";
            this.TableButton.Size = new System.Drawing.Size(30, 40);
            this.TableButton.TabIndex = 6;
            this.TableButton.UseVisualStyleBackColor = true;
            this.TableButton.Click += new System.EventHandler(this.TableButton_Click);
            // 
            // FindAndReplaceButton
            // 
            this.FindAndReplaceButton.BackgroundImage = global::ModTool.Properties.Resources.replace;
            this.FindAndReplaceButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FindAndReplaceButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.FindAndReplaceButton.FlatAppearance.BorderSize = 0;
            this.FindAndReplaceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FindAndReplaceButton.Location = new System.Drawing.Point(0, 200);
            this.FindAndReplaceButton.Name = "FindAndReplaceButton";
            this.FindAndReplaceButton.Size = new System.Drawing.Size(30, 40);
            this.FindAndReplaceButton.TabIndex = 5;
            this.FindAndReplaceButton.UseVisualStyleBackColor = true;
            this.FindAndReplaceButton.Click += new System.EventHandler(this.FindAndReplaceButton_Click);
            // 
            // FindButton
            // 
            this.FindButton.BackgroundImage = global::ModTool.Properties.Resources.find;
            this.FindButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FindButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.FindButton.FlatAppearance.BorderSize = 0;
            this.FindButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FindButton.Location = new System.Drawing.Point(0, 160);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(30, 40);
            this.FindButton.TabIndex = 4;
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // SaveAsButton
            // 
            this.SaveAsButton.BackgroundImage = global::ModTool.Properties.Resources.save_as;
            this.SaveAsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SaveAsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.SaveAsButton.FlatAppearance.BorderSize = 0;
            this.SaveAsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveAsButton.Location = new System.Drawing.Point(0, 120);
            this.SaveAsButton.Name = "SaveAsButton";
            this.SaveAsButton.Size = new System.Drawing.Size(30, 40);
            this.SaveAsButton.TabIndex = 3;
            this.SaveAsButton.UseVisualStyleBackColor = true;
            this.SaveAsButton.Click += new System.EventHandler(this.SaveAsButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.BackgroundImage = global::ModTool.Properties.Resources.save_2;
            this.SaveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SaveButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.SaveButton.FlatAppearance.BorderSize = 0;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Location = new System.Drawing.Point(0, 80);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(30, 40);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.BackgroundImage = global::ModTool.Properties.Resources.open_file;
            this.OpenFileButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.OpenFileButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.OpenFileButton.FlatAppearance.BorderSize = 0;
            this.OpenFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenFileButton.Location = new System.Drawing.Point(0, 40);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(30, 40);
            this.OpenFileButton.TabIndex = 1;
            this.OpenFileButton.UseVisualStyleBackColor = true;
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // NewFileButton
            // 
            this.NewFileButton.BackgroundImage = global::ModTool.Properties.Resources.new_file;
            this.NewFileButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.NewFileButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.NewFileButton.FlatAppearance.BorderSize = 0;
            this.NewFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewFileButton.Location = new System.Drawing.Point(0, 0);
            this.NewFileButton.Name = "NewFileButton";
            this.NewFileButton.Size = new System.Drawing.Size(30, 40);
            this.NewFileButton.TabIndex = 0;
            this.NewFileButton.UseVisualStyleBackColor = true;
            this.NewFileButton.Click += new System.EventHandler(this.NewFileButton_Click);
            // 
            // RenPyScript
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(974, 673);
            this.Controls.Add(this.fastColoredTextBox1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RenPyScript";
            this.Text = "RenPyScript";
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FastColoredTextBoxNS.FastColoredTextBox fastColoredTextBox1;
        private AutocompleteMenuNS.AutocompleteMenu RenpyAutoComplete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button NewFileButton;
        private System.Windows.Forms.Button OpenFileButton;
        private System.Windows.Forms.OpenFileDialog rpyOpenFileDialog;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.SaveFileDialog rpySaveFileDialog;
        private System.Windows.Forms.Button SaveAsButton;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.Button FindAndReplaceButton;
        private System.Windows.Forms.Button TableButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button rpaExpButton;
        private System.Windows.Forms.Button RenPyDocButton;
        private System.Windows.Forms.Button PixelationButton;
    }
}