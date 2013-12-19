namespace _811Assignment03
{
    partial class CalculatorForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.CalculatorTab = new System.Windows.Forms.TabPage();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ConfigureTab = new System.Windows.Forms.TabPage();
            this.SavePathLabel = new System.Windows.Forms.Label();
            this.savePathTextBox = new System.Windows.Forms.TextBox();
            this.UpdateSaveLocationButton = new System.Windows.Forms.Button();
            this.TabControl.SuspendLayout();
            this.CalculatorTab.SuspendLayout();
            this.ConfigureTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Value 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Value 2";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(56, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(56, 42);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Solutions";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(9, 93);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(227, 187);
            this.textBox3.TabIndex = 5;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(161, 16);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 6;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.CalculatorTab);
            this.TabControl.Controls.Add(this.ConfigureTab);
            this.TabControl.Location = new System.Drawing.Point(12, 12);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(261, 376);
            this.TabControl.TabIndex = 7;
            // 
            // CalculatorTab
            // 
            this.CalculatorTab.Controls.Add(this.SaveButton);
            this.CalculatorTab.Controls.Add(this.CalculateButton);
            this.CalculatorTab.Controls.Add(this.label3);
            this.CalculatorTab.Controls.Add(this.textBox3);
            this.CalculatorTab.Controls.Add(this.label1);
            this.CalculatorTab.Controls.Add(this.textBox1);
            this.CalculatorTab.Controls.Add(this.textBox2);
            this.CalculatorTab.Controls.Add(this.label2);
            this.CalculatorTab.Location = new System.Drawing.Point(4, 22);
            this.CalculatorTab.Name = "CalculatorTab";
            this.CalculatorTab.Padding = new System.Windows.Forms.Padding(3);
            this.CalculatorTab.Size = new System.Drawing.Size(253, 350);
            this.CalculatorTab.TabIndex = 0;
            this.CalculatorTab.Text = "Calculator";
            this.CalculatorTab.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(161, 42);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 7;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ConfigureTab
            // 
            this.ConfigureTab.Controls.Add(this.UpdateSaveLocationButton);
            this.ConfigureTab.Controls.Add(this.savePathTextBox);
            this.ConfigureTab.Controls.Add(this.SavePathLabel);
            this.ConfigureTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfigureTab.Location = new System.Drawing.Point(4, 22);
            this.ConfigureTab.Name = "ConfigureTab";
            this.ConfigureTab.Padding = new System.Windows.Forms.Padding(3);
            this.ConfigureTab.Size = new System.Drawing.Size(253, 350);
            this.ConfigureTab.TabIndex = 1;
            this.ConfigureTab.Text = "Configure";
            this.ConfigureTab.UseVisualStyleBackColor = true;
            // 
            // SavePathLabel
            // 
            this.SavePathLabel.AutoSize = true;
            this.SavePathLabel.Location = new System.Drawing.Point(47, 17);
            this.SavePathLabel.Name = "SavePathLabel";
            this.SavePathLabel.Size = new System.Drawing.Size(149, 17);
            this.SavePathLabel.TabIndex = 1;
            this.SavePathLabel.Text = "Current Save Location";
            // 
            // savePathTextBox
            // 
            this.savePathTextBox.Location = new System.Drawing.Point(9, 37);
            this.savePathTextBox.Name = "savePathTextBox";
            this.savePathTextBox.Size = new System.Drawing.Size(241, 23);
            this.savePathTextBox.TabIndex = 2;
            this.savePathTextBox.Text = "C:\\temp\\text.txt";
            // 
            // UpdateSaveLocationButton
            // 
            this.UpdateSaveLocationButton.Location = new System.Drawing.Point(74, 66);
            this.UpdateSaveLocationButton.Name = "UpdateSaveLocationButton";
            this.UpdateSaveLocationButton.Size = new System.Drawing.Size(75, 29);
            this.UpdateSaveLocationButton.TabIndex = 3;
            this.UpdateSaveLocationButton.Text = "Update";
            this.UpdateSaveLocationButton.UseVisualStyleBackColor = true;
            this.UpdateSaveLocationButton.Click += new System.EventHandler(this.UpdateSaveLocationButton_Click);
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 415);
            this.Controls.Add(this.TabControl);
            this.Name = "CalculatorForm";
            this.Text = "Form1";
            this.TabControl.ResumeLayout(false);
            this.CalculatorTab.ResumeLayout(false);
            this.CalculatorTab.PerformLayout();
            this.ConfigureTab.ResumeLayout(false);
            this.ConfigureTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        public System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage CalculatorTab;
        private System.Windows.Forms.TabPage ConfigureTab;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label SavePathLabel;
        private System.Windows.Forms.Button UpdateSaveLocationButton;
        private System.Windows.Forms.TextBox savePathTextBox;
    }
}

