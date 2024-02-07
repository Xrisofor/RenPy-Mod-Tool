namespace ModTool.Forms
{
    partial class TagsEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TagsEditor));
            this.newCharactersCheckBox = new System.Windows.Forms.CheckBox();
            this.newFeaturesCheckBox = new System.Windows.Forms.CheckBox();
            this.newGraphicsCheckBox = new System.Windows.Forms.CheckBox();
            this.newStoryCheckBox = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // newCharactersCheckBox
            // 
            this.newCharactersCheckBox.AutoSize = true;
            this.newCharactersCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newCharactersCheckBox.Location = new System.Drawing.Point(3, 123);
            this.newCharactersCheckBox.Name = "newCharactersCheckBox";
            this.newCharactersCheckBox.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.newCharactersCheckBox.Size = new System.Drawing.Size(162, 34);
            this.newCharactersCheckBox.TabIndex = 0;
            this.newCharactersCheckBox.Text = "New Characters";
            this.newCharactersCheckBox.UseVisualStyleBackColor = true;
            this.newCharactersCheckBox.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // newFeaturesCheckBox
            // 
            this.newFeaturesCheckBox.AutoSize = true;
            this.newFeaturesCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newFeaturesCheckBox.Location = new System.Drawing.Point(3, 83);
            this.newFeaturesCheckBox.Name = "newFeaturesCheckBox";
            this.newFeaturesCheckBox.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.newFeaturesCheckBox.Size = new System.Drawing.Size(145, 34);
            this.newFeaturesCheckBox.TabIndex = 1;
            this.newFeaturesCheckBox.Text = "New Features";
            this.newFeaturesCheckBox.UseVisualStyleBackColor = true;
            this.newFeaturesCheckBox.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // newGraphicsCheckBox
            // 
            this.newGraphicsCheckBox.AutoSize = true;
            this.newGraphicsCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newGraphicsCheckBox.Location = new System.Drawing.Point(3, 43);
            this.newGraphicsCheckBox.Name = "newGraphicsCheckBox";
            this.newGraphicsCheckBox.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.newGraphicsCheckBox.Size = new System.Drawing.Size(147, 34);
            this.newGraphicsCheckBox.TabIndex = 2;
            this.newGraphicsCheckBox.Text = "New Graphics";
            this.newGraphicsCheckBox.UseVisualStyleBackColor = true;
            this.newGraphicsCheckBox.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // newStoryCheckBox
            // 
            this.newStoryCheckBox.AutoSize = true;
            this.newStoryCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newStoryCheckBox.Location = new System.Drawing.Point(3, 3);
            this.newStoryCheckBox.Name = "newStoryCheckBox";
            this.newStoryCheckBox.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.newStoryCheckBox.Size = new System.Drawing.Size(118, 34);
            this.newStoryCheckBox.TabIndex = 3;
            this.newStoryCheckBox.Text = "New Story";
            this.newStoryCheckBox.UseVisualStyleBackColor = true;
            this.newStoryCheckBox.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.newStoryCheckBox);
            this.flowLayoutPanel1.Controls.Add(this.newGraphicsCheckBox);
            this.flowLayoutPanel1.Controls.Add(this.newFeaturesCheckBox);
            this.flowLayoutPanel1.Controls.Add(this.newCharactersCheckBox);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // TagsEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TagsEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tags Manager";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox newCharactersCheckBox;
        private System.Windows.Forms.CheckBox newFeaturesCheckBox;
        private System.Windows.Forms.CheckBox newGraphicsCheckBox;
        private System.Windows.Forms.CheckBox newStoryCheckBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}