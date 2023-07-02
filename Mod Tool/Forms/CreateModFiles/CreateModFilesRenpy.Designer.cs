namespace Mod_Tool.Forms
{
    partial class CreateModFilesRenpy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateModFilesRenpy));
            this.GiveLabelLB = new System.Windows.Forms.Label();
            this.GiveNameLabel = new System.Windows.Forms.Label();
            this.CreateModButton = new System.Windows.Forms.Button();
            this.ModNameTextBox = new System.Windows.Forms.TextBox();
            this.ModTriggerTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // GiveLabelLB
            // 
            this.GiveLabelLB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GiveLabelLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GiveLabelLB.Location = new System.Drawing.Point(13, 92);
            this.GiveLabelLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GiveLabelLB.Name = "GiveLabelLB";
            this.GiveLabelLB.Size = new System.Drawing.Size(378, 74);
            this.GiveLabelLB.TabIndex = 12;
            this.GiveLabelLB.Text = "Give the name of your label that will trigger the modification";
            this.GiveLabelLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GiveNameLabel
            // 
            this.GiveNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GiveNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GiveNameLabel.Location = new System.Drawing.Point(13, 9);
            this.GiveNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GiveNameLabel.Name = "GiveNameLabel";
            this.GiveNameLabel.Size = new System.Drawing.Size(378, 53);
            this.GiveNameLabel.TabIndex = 11;
            this.GiveNameLabel.Text = "Give the name of your modification";
            this.GiveNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CreateModButton
            // 
            this.CreateModButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateModButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.CreateModButton.Enabled = false;
            this.CreateModButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateModButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.CreateModButton.Location = new System.Drawing.Point(13, 204);
            this.CreateModButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CreateModButton.Name = "CreateModButton";
            this.CreateModButton.Size = new System.Drawing.Size(378, 31);
            this.CreateModButton.TabIndex = 10;
            this.CreateModButton.Text = "Create a mod";
            this.CreateModButton.UseVisualStyleBackColor = true;
            this.CreateModButton.Click += new System.EventHandler(this.CreateModButton_Click);
            // 
            // ModNameTextBox
            // 
            this.ModNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ModNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            this.ModNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ModNameTextBox.ForeColor = System.Drawing.Color.White;
            this.ModNameTextBox.Location = new System.Drawing.Point(13, 64);
            this.ModNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ModNameTextBox.Name = "ModNameTextBox";
            this.ModNameTextBox.Size = new System.Drawing.Size(378, 22);
            this.ModNameTextBox.TabIndex = 9;
            this.ModNameTextBox.TextChanged += new System.EventHandler(this.ModNameTextBox_TextChanged);
            // 
            // ModTriggerTextBox
            // 
            this.ModTriggerTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ModTriggerTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            this.ModTriggerTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ModTriggerTextBox.ForeColor = System.Drawing.Color.White;
            this.ModTriggerTextBox.Location = new System.Drawing.Point(13, 168);
            this.ModTriggerTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ModTriggerTextBox.Name = "ModTriggerTextBox";
            this.ModTriggerTextBox.Size = new System.Drawing.Size(378, 22);
            this.ModTriggerTextBox.TabIndex = 8;
            this.ModTriggerTextBox.TextChanged += new System.EventHandler(this.ModTriggerTextBox_TextChanged);
            this.ModTriggerTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ModTriggerTextBox_KeyPress);
            // 
            // CreateModFilesRenpy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(409, 246);
            this.Controls.Add(this.GiveLabelLB);
            this.Controls.Add(this.GiveNameLabel);
            this.Controls.Add(this.CreateModButton);
            this.Controls.Add(this.ModNameTextBox);
            this.Controls.Add(this.ModTriggerTextBox);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CreateModFilesRenpy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateModFiles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GiveLabelLB;
        private System.Windows.Forms.Label GiveNameLabel;
        private System.Windows.Forms.Button CreateModButton;
        private System.Windows.Forms.TextBox ModNameTextBox;
        private System.Windows.Forms.TextBox ModTriggerTextBox;
    }
}