namespace ModTool.Forms.Panel
{
    partial class Mode
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
            this.label1 = new System.Windows.Forms.Label();
            this.ExampleComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BoolEditor = new System.Windows.Forms.CheckBox();
            this.TextEditor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NumEditor = new System.Windows.Forms.NumericUpDown();
            this.ExampleLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumEditor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(950, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tool for creating mini modes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ExampleComboBox
            // 
            this.ExampleComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ExampleComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExampleComboBox.ForeColor = System.Drawing.Color.White;
            this.ExampleComboBox.FormattingEnabled = true;
            this.ExampleComboBox.IntegralHeight = false;
            this.ExampleComboBox.Location = new System.Drawing.Point(6, 21);
            this.ExampleComboBox.Name = "ExampleComboBox";
            this.ExampleComboBox.Size = new System.Drawing.Size(412, 24);
            this.ExampleComboBox.TabIndex = 5;
            this.ExampleComboBox.Text = "Select a category";
            this.ExampleComboBox.SelectedIndexChanged += new System.EventHandler(this.ExampleComboBox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.ExampleComboBox);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(17, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 425);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mode";
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(419, 364);
            this.label4.TabIndex = 6;
            this.label4.Text = "Description";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.BoolEditor);
            this.groupBox2.Controls.Add(this.TextEditor);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.NumEditor);
            this.groupBox2.Controls.Add(this.ExampleLabel);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(532, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(425, 425);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Customizations";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(7, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(412, 31);
            this.label3.TabIndex = 15;
            this.label3.Text = "Boolean";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BoolEditor
            // 
            this.BoolEditor.Enabled = false;
            this.BoolEditor.Location = new System.Drawing.Point(10, 202);
            this.BoolEditor.Name = "BoolEditor";
            this.BoolEditor.Size = new System.Drawing.Size(404, 24);
            this.BoolEditor.TabIndex = 14;
            this.BoolEditor.Text = "Boolean";
            this.BoolEditor.UseVisualStyleBackColor = true;
            this.BoolEditor.CheckedChanged += new System.EventHandler(this.BoolEditor_CheckedChanged);
            // 
            // TextEditor
            // 
            this.TextEditor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextEditor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.TextEditor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextEditor.Enabled = false;
            this.TextEditor.ForeColor = System.Drawing.Color.White;
            this.TextEditor.Location = new System.Drawing.Point(11, 127);
            this.TextEditor.Name = "TextEditor";
            this.TextEditor.Size = new System.Drawing.Size(404, 22);
            this.TextEditor.TabIndex = 13;
            this.TextEditor.TextChanged += new System.EventHandler(this.TextEditor_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(412, 31);
            this.label2.TabIndex = 12;
            this.label2.Text = "Text";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NumEditor
            // 
            this.NumEditor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NumEditor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.NumEditor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumEditor.DecimalPlaces = 4;
            this.NumEditor.Enabled = false;
            this.NumEditor.ForeColor = System.Drawing.Color.White;
            this.NumEditor.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NumEditor.Location = new System.Drawing.Point(10, 52);
            this.NumEditor.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NumEditor.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.NumEditor.Name = "NumEditor";
            this.NumEditor.Size = new System.Drawing.Size(404, 22);
            this.NumEditor.TabIndex = 9;
            this.NumEditor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumEditor.ValueChanged += new System.EventHandler(this.NumEditor_ValueChanged);
            // 
            // ExampleLabel
            // 
            this.ExampleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExampleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExampleLabel.Location = new System.Drawing.Point(6, 18);
            this.ExampleLabel.Name = "ExampleLabel";
            this.ExampleLabel.Size = new System.Drawing.Size(412, 31);
            this.ExampleLabel.TabIndex = 10;
            this.ExampleLabel.Text = "Number";
            this.ExampleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Mode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(974, 673);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Mode";
            this.Text = "Mode";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumEditor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ExampleComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown NumEditor;
        private System.Windows.Forms.Label ExampleLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextEditor;
        private System.Windows.Forms.CheckBox BoolEditor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}