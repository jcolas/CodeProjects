namespace WinFormCalculator
{
    partial class Form2
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
            this.IgnoreArmorCheck = new System.Windows.Forms.CheckBox();
            this.IgnoreToughnessCheck = new System.Windows.Forms.CheckBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.DamageTextBox = new System.Windows.Forms.TextBox();
            this.DamageFieldLabel = new System.Windows.Forms.Label();
            this.PenetrationTextBox = new System.Windows.Forms.TextBox();
            this.PenetrationFieldLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IgnoreArmorCheck
            // 
            this.IgnoreArmorCheck.AutoSize = true;
            this.IgnoreArmorCheck.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IgnoreArmorCheck.Location = new System.Drawing.Point(12, 89);
            this.IgnoreArmorCheck.Name = "IgnoreArmorCheck";
            this.IgnoreArmorCheck.Size = new System.Drawing.Size(115, 15);
            this.IgnoreArmorCheck.TabIndex = 0;
            this.IgnoreArmorCheck.Text = "Ignores Armor";
            this.IgnoreArmorCheck.UseVisualStyleBackColor = true;
            this.IgnoreArmorCheck.CheckedChanged += new System.EventHandler(this.IgnoreArmorCheck_CheckedChanged);
            // 
            // IgnoreToughnessCheck
            // 
            this.IgnoreToughnessCheck.AutoSize = true;
            this.IgnoreToughnessCheck.Font = new System.Drawing.Font("Lucida Console", 8.25F);
            this.IgnoreToughnessCheck.Location = new System.Drawing.Point(12, 110);
            this.IgnoreToughnessCheck.Name = "IgnoreToughnessCheck";
            this.IgnoreToughnessCheck.Size = new System.Drawing.Size(143, 15);
            this.IgnoreToughnessCheck.TabIndex = 1;
            this.IgnoreToughnessCheck.Text = "Ignores Toughness";
            this.IgnoreToughnessCheck.UseVisualStyleBackColor = true;
            this.IgnoreToughnessCheck.CheckedChanged += new System.EventHandler(this.IgnoreToughnessCheck_CheckedChanged);
            // 
            // CalculateButton
            // 
            this.CalculateButton.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateButton.Location = new System.Drawing.Point(36, 131);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 2;
            this.CalculateButton.Text = "Apply";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // DamageTextBox
            // 
            this.DamageTextBox.Location = new System.Drawing.Point(102, 22);
            this.DamageTextBox.MaxLength = 2;
            this.DamageTextBox.Name = "DamageTextBox";
            this.DamageTextBox.Size = new System.Drawing.Size(37, 20);
            this.DamageTextBox.TabIndex = 3;
            this.DamageTextBox.TextChanged += new System.EventHandler(this.DamageTextBox_TextChanged);
            // 
            // DamageFieldLabel
            // 
            this.DamageFieldLabel.AutoSize = true;
            this.DamageFieldLabel.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DamageFieldLabel.Location = new System.Drawing.Point(12, 28);
            this.DamageFieldLabel.Name = "DamageFieldLabel";
            this.DamageFieldLabel.Size = new System.Drawing.Size(47, 11);
            this.DamageFieldLabel.TabIndex = 4;
            this.DamageFieldLabel.Text = "Damage";
            this.DamageFieldLabel.Click += new System.EventHandler(this.DamageFieldLabel_Click);
            // 
            // PenetrationTextBox
            // 
            this.PenetrationTextBox.Location = new System.Drawing.Point(102, 48);
            this.PenetrationTextBox.MaxLength = 2;
            this.PenetrationTextBox.Name = "PenetrationTextBox";
            this.PenetrationTextBox.Size = new System.Drawing.Size(37, 20);
            this.PenetrationTextBox.TabIndex = 5;
            this.PenetrationTextBox.TextChanged += new System.EventHandler(this.PenetrationTextBox_TextChanged);
            // 
            // PenetrationFieldLabel
            // 
            this.PenetrationFieldLabel.AutoSize = true;
            this.PenetrationFieldLabel.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PenetrationFieldLabel.Location = new System.Drawing.Point(10, 57);
            this.PenetrationFieldLabel.Name = "PenetrationFieldLabel";
            this.PenetrationFieldLabel.Size = new System.Drawing.Size(82, 11);
            this.PenetrationFieldLabel.TabIndex = 6;
            this.PenetrationFieldLabel.Text = "Penetration";
            this.PenetrationFieldLabel.Click += new System.EventHandler(this.PenetrationFieldLabel_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(164, 175);
            this.Controls.Add(this.PenetrationFieldLabel);
            this.Controls.Add(this.PenetrationTextBox);
            this.Controls.Add(this.DamageFieldLabel);
            this.Controls.Add(this.DamageTextBox);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.IgnoreToughnessCheck);
            this.Controls.Add(this.IgnoreArmorCheck);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox IgnoreArmorCheck;
        private System.Windows.Forms.CheckBox IgnoreToughnessCheck;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.TextBox DamageTextBox;
        private System.Windows.Forms.Label DamageFieldLabel;
        private System.Windows.Forms.TextBox PenetrationTextBox;
        private System.Windows.Forms.Label PenetrationFieldLabel;
    }
}