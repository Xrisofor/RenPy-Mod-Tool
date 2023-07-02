namespace Mod_Tool.Forms
{
    partial class CreateWorkshopItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateWorkshopItem));
            this.ModCreatedLabel = new System.Windows.Forms.Label();
            this.CopyButton = new System.Windows.Forms.Button();
            this.ConWaitButton = new System.Windows.Forms.Button();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ModCreatedLabel
            // 
            this.ModCreatedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ModCreatedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ModCreatedLabel.Location = new System.Drawing.Point(7, 9);
            this.ModCreatedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ModCreatedLabel.Name = "ModCreatedLabel";
            this.ModCreatedLabel.Size = new System.Drawing.Size(347, 97);
            this.ModCreatedLabel.TabIndex = 7;
            this.ModCreatedLabel.Text = "A new mod has been created. Write down this ID so that you can update it later!";
            this.ModCreatedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CopyButton
            // 
            this.CopyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CopyButton.Enabled = false;
            this.CopyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CopyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CopyButton.Location = new System.Drawing.Point(244, 107);
            this.CopyButton.Margin = new System.Windows.Forms.Padding(4);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(110, 27);
            this.CopyButton.TabIndex = 6;
            this.CopyButton.Text = "Copy";
            this.CopyButton.UseVisualStyleBackColor = true;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // ConWaitButton
            // 
            this.ConWaitButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConWaitButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ConWaitButton.Enabled = false;
            this.ConWaitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConWaitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConWaitButton.Location = new System.Drawing.Point(12, 142);
            this.ConWaitButton.Margin = new System.Windows.Forms.Padding(4);
            this.ConWaitButton.Name = "ConWaitButton";
            this.ConWaitButton.Size = new System.Drawing.Size(342, 40);
            this.ConWaitButton.TabIndex = 5;
            this.ConWaitButton.Text = "Wait...";
            this.ConWaitButton.UseVisualStyleBackColor = true;
            // 
            // IDTextBox
            // 
            this.IDTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            this.IDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IDTextBox.ForeColor = System.Drawing.Color.White;
            this.IDTextBox.Location = new System.Drawing.Point(12, 107);
            this.IDTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.IDTextBox.Multiline = true;
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(224, 27);
            this.IDTextBox.TabIndex = 4;
            // 
            // CreateWorkshopItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(367, 193);
            this.Controls.Add(this.ModCreatedLabel);
            this.Controls.Add(this.CopyButton);
            this.Controls.Add(this.ConWaitButton);
            this.Controls.Add(this.IDTextBox);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CreateWorkshopItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateWorkshopItem";
            this.Load += new System.EventHandler(this.CreateWorkshopItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ModCreatedLabel;
        private System.Windows.Forms.Button CopyButton;
        private System.Windows.Forms.Button ConWaitButton;
        private System.Windows.Forms.TextBox IDTextBox;
    }
}