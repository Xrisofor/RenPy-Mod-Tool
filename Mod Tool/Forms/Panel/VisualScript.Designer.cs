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
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Микки: Тест");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Label", new System.Windows.Forms.TreeNode[] {
            treeNode5});
            this.ScriptTreeView = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TableButton = new System.Windows.Forms.Button();
            this.SaveAsButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.NewFileButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ScriptTreeView
            // 
            this.ScriptTreeView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ScriptTreeView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ScriptTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScriptTreeView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ScriptTreeView.ForeColor = System.Drawing.Color.White;
            this.ScriptTreeView.LineColor = System.Drawing.Color.White;
            this.ScriptTreeView.Location = new System.Drawing.Point(0, 0);
            this.ScriptTreeView.Name = "ScriptTreeView";
            treeNode5.ImageKey = "text.png";
            treeNode5.Name = "Микки: Тест";
            treeNode5.SelectedImageKey = "text.png";
            treeNode5.Text = "Микки: Тест";
            treeNode6.ImageKey = "tag.png";
            treeNode6.Name = "Label";
            treeNode6.SelectedImageKey = "tag.png";
            treeNode6.Text = "Label";
            this.ScriptTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6});
            this.ScriptTreeView.Size = new System.Drawing.Size(974, 673);
            this.ScriptTreeView.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.TableButton);
            this.panel1.Controls.Add(this.SaveAsButton);
            this.panel1.Controls.Add(this.SaveButton);
            this.panel1.Controls.Add(this.OpenFileButton);
            this.panel1.Controls.Add(this.NewFileButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(942, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(32, 673);
            this.panel1.TabIndex = 8;
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
            // 
            // SaveAsButton
            // 
            this.SaveAsButton.BackgroundImage = global::ModTool.Properties.Resources.save_as;
            this.SaveAsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SaveAsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.SaveAsButton.FlatAppearance.BorderSize = 0;
            this.SaveAsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveAsButton.Location = new System.Drawing.Point(0, 96);
            this.SaveAsButton.Name = "SaveAsButton";
            this.SaveAsButton.Size = new System.Drawing.Size(30, 32);
            this.SaveAsButton.TabIndex = 3;
            this.SaveAsButton.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            this.SaveButton.BackgroundImage = global::ModTool.Properties.Resources.save_2;
            this.SaveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SaveButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.SaveButton.FlatAppearance.BorderSize = 0;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Location = new System.Drawing.Point(0, 64);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(30, 32);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.BackgroundImage = global::ModTool.Properties.Resources.open_file;
            this.OpenFileButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.OpenFileButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.OpenFileButton.FlatAppearance.BorderSize = 0;
            this.OpenFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenFileButton.Location = new System.Drawing.Point(0, 32);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(30, 32);
            this.OpenFileButton.TabIndex = 1;
            this.OpenFileButton.UseVisualStyleBackColor = true;
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
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView ScriptTreeView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button TableButton;
        private System.Windows.Forms.Button SaveAsButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button OpenFileButton;
        private System.Windows.Forms.Button NewFileButton;
    }
}