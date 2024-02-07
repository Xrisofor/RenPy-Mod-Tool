namespace ModTool.Forms.Panel
{
    partial class VisualScript
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
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("say mickey hello world");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("label test", new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.ScriptTreeView = new System.Windows.Forms.TreeView();
            this.ScriptContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.upToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RpyExportButton = new System.Windows.Forms.Button();
            this.AddCharacterButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.TableButton = new System.Windows.Forms.Button();
            this.NewLabelButtom = new System.Windows.Forms.Button();
            this.NewFileButton = new System.Windows.Forms.Button();
            this.rpyOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.rpySaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.ScriptContextMenuStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ScriptTreeView
            // 
            this.ScriptTreeView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ScriptTreeView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ScriptTreeView.ContextMenuStrip = this.ScriptContextMenuStrip;
            this.ScriptTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScriptTreeView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ScriptTreeView.ForeColor = System.Drawing.Color.White;
            this.ScriptTreeView.LineColor = System.Drawing.Color.White;
            this.ScriptTreeView.Location = new System.Drawing.Point(0, 0);
            this.ScriptTreeView.Name = "ScriptTreeView";
            treeNode3.ImageKey = "text.png";
            treeNode3.Name = "Микки: Тест";
            treeNode3.SelectedImageKey = "text.png";
            treeNode3.Text = "say mickey hello world";
            treeNode4.ImageKey = "tag.png";
            treeNode4.Name = "label test";
            treeNode4.SelectedImageKey = "tag.png";
            treeNode4.Text = "label test";
            this.ScriptTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4});
            this.ScriptTreeView.Size = new System.Drawing.Size(974, 673);
            this.ScriptTreeView.TabIndex = 7;
            this.ScriptTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.ScriptTreeView_AfterSelect);
            // 
            // ScriptContextMenuStrip
            // 
            this.ScriptContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ScriptContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.removeToolStripMenuItem,
            this.toolStripSeparator1,
            this.upToolStripMenuItem,
            this.downToolStripMenuItem});
            this.ScriptContextMenuStrip.Name = "ScriptContextMenuStrip";
            this.ScriptContextMenuStrip.Size = new System.Drawing.Size(235, 130);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.addToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.addToolStripMenuItem.Size = new System.Drawing.Size(234, 24);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.editToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.editToolStripMenuItem.Size = new System.Drawing.Size(234, 24);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.removeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete)));
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(234, 24);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.toolStripSeparator1.ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(231, 6);
            this.toolStripSeparator1.Paint += new System.Windows.Forms.PaintEventHandler(this.toolStripSeparator1_Paint);
            // 
            // upToolStripMenuItem
            // 
            this.upToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.upToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.upToolStripMenuItem.Name = "upToolStripMenuItem";
            this.upToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Up)));
            this.upToolStripMenuItem.Size = new System.Drawing.Size(234, 24);
            this.upToolStripMenuItem.Text = "Up";
            this.upToolStripMenuItem.Click += new System.EventHandler(this.upToolStripMenuItem_Click);
            // 
            // downToolStripMenuItem
            // 
            this.downToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.downToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.downToolStripMenuItem.Name = "downToolStripMenuItem";
            this.downToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Down)));
            this.downToolStripMenuItem.Size = new System.Drawing.Size(234, 24);
            this.downToolStripMenuItem.Text = "Down";
            this.downToolStripMenuItem.Click += new System.EventHandler(this.downToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.RpyExportButton);
            this.panel1.Controls.Add(this.AddCharacterButton);
            this.panel1.Controls.Add(this.SaveButton);
            this.panel1.Controls.Add(this.OpenFileButton);
            this.panel1.Controls.Add(this.TableButton);
            this.panel1.Controls.Add(this.NewLabelButtom);
            this.panel1.Controls.Add(this.NewFileButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(942, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(32, 673);
            this.panel1.TabIndex = 8;
            // 
            // RpyExportButton
            // 
            this.RpyExportButton.BackgroundImage = global::ModTool.Properties.Resources.replace;
            this.RpyExportButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RpyExportButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.RpyExportButton.FlatAppearance.BorderSize = 0;
            this.RpyExportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RpyExportButton.Location = new System.Drawing.Point(0, 575);
            this.RpyExportButton.Name = "RpyExportButton";
            this.RpyExportButton.Size = new System.Drawing.Size(30, 32);
            this.RpyExportButton.TabIndex = 7;
            this.RpyExportButton.UseVisualStyleBackColor = true;
            this.RpyExportButton.Click += new System.EventHandler(this.RpyExportButton_Click);
            // 
            // AddCharacterButton
            // 
            this.AddCharacterButton.BackgroundImage = global::ModTool.Properties.Resources.character;
            this.AddCharacterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddCharacterButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AddCharacterButton.FlatAppearance.BorderSize = 0;
            this.AddCharacterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCharacterButton.Location = new System.Drawing.Point(0, 607);
            this.AddCharacterButton.Name = "AddCharacterButton";
            this.AddCharacterButton.Size = new System.Drawing.Size(30, 32);
            this.AddCharacterButton.TabIndex = 9;
            this.AddCharacterButton.UseVisualStyleBackColor = true;
            this.AddCharacterButton.Click += new System.EventHandler(this.AddCharacterButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.BackgroundImage = global::ModTool.Properties.Resources.save_2;
            this.SaveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SaveButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.SaveButton.FlatAppearance.BorderSize = 0;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Location = new System.Drawing.Point(0, 104);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(30, 32);
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
            this.OpenFileButton.Location = new System.Drawing.Point(0, 64);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(30, 40);
            this.OpenFileButton.TabIndex = 8;
            this.OpenFileButton.UseVisualStyleBackColor = true;
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // TableButton
            // 
            this.TableButton.BackgroundImage = global::ModTool.Properties.Resources.table;
            this.TableButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.TableButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TableButton.FlatAppearance.BorderSize = 0;
            this.TableButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TableButton.Location = new System.Drawing.Point(0, 639);
            this.TableButton.Name = "TableButton";
            this.TableButton.Size = new System.Drawing.Size(30, 32);
            this.TableButton.TabIndex = 6;
            this.TableButton.UseVisualStyleBackColor = true;
            this.TableButton.Click += new System.EventHandler(this.TableButton_Click);
            // 
            // NewLabelButtom
            // 
            this.NewLabelButtom.BackgroundImage = global::ModTool.Properties.Resources.file;
            this.NewLabelButtom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.NewLabelButtom.Dock = System.Windows.Forms.DockStyle.Top;
            this.NewLabelButtom.FlatAppearance.BorderSize = 0;
            this.NewLabelButtom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewLabelButtom.Location = new System.Drawing.Point(0, 32);
            this.NewLabelButtom.Name = "NewLabelButtom";
            this.NewLabelButtom.Size = new System.Drawing.Size(30, 32);
            this.NewLabelButtom.TabIndex = 10;
            this.NewLabelButtom.UseVisualStyleBackColor = true;
            this.NewLabelButtom.Click += new System.EventHandler(this.NewLabelButtom_Click);
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
            this.NewFileButton.Size = new System.Drawing.Size(30, 32);
            this.NewFileButton.TabIndex = 0;
            this.NewFileButton.UseVisualStyleBackColor = true;
            this.NewFileButton.Click += new System.EventHandler(this.NewFileButton_Click);
            // 
            // rpyOpenFileDialog
            // 
            this.rpyOpenFileDialog.Filter = "Visual Node|*.json";
            // 
            // rpySaveFileDialog
            // 
            this.rpySaveFileDialog.Filter = "Visual Node|*.json";
            // 
            // VisualScript
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(974, 673);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ScriptTreeView);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VisualScript";
            this.Text = "VisualScript";
            this.ScriptContextMenuStrip.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView ScriptTreeView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button TableButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button NewFileButton;
        private System.Windows.Forms.Button RpyExportButton;
        private System.Windows.Forms.ContextMenuStrip ScriptContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.Button OpenFileButton;
        private System.Windows.Forms.OpenFileDialog rpyOpenFileDialog;
        private System.Windows.Forms.Button AddCharacterButton;
        private System.Windows.Forms.Button NewLabelButtom;
        private System.Windows.Forms.SaveFileDialog rpySaveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem upToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downToolStripMenuItem;
    }
}