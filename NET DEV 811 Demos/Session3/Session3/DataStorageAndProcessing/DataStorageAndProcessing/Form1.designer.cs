namespace DataStorageAndProcessing
{
    partial class Form1
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
            this.tabPageAccessModifiers = new System.Windows.Forms.TabPage();
            this.buttonTestAccessModifiers = new System.Windows.Forms.Button();
            this.tabPageDlls = new System.Windows.Forms.TabPage();
            this.buttonTestDll = new System.Windows.Forms.Button();
            this.labelTaskDesc = new System.Windows.Forms.Label();
            this.textBoxTaskDesc = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabPageAccessModifiers.SuspendLayout();
            this.tabPageDlls.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPageAccessModifiers
            // 
            this.tabPageAccessModifiers.Controls.Add(this.buttonTestAccessModifiers);
            this.tabPageAccessModifiers.Location = new System.Drawing.Point(4, 22);
            this.tabPageAccessModifiers.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageAccessModifiers.Name = "tabPageAccessModifiers";
            this.tabPageAccessModifiers.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageAccessModifiers.Size = new System.Drawing.Size(367, 258);
            this.tabPageAccessModifiers.TabIndex = 1;
            this.tabPageAccessModifiers.Text = "Access Modifiers";
            this.tabPageAccessModifiers.UseVisualStyleBackColor = true;
            // 
            // buttonTestAccessModifiers
            // 
            this.buttonTestAccessModifiers.Location = new System.Drawing.Point(21, 23);
            this.buttonTestAccessModifiers.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTestAccessModifiers.Name = "buttonTestAccessModifiers";
            this.buttonTestAccessModifiers.Size = new System.Drawing.Size(111, 24);
            this.buttonTestAccessModifiers.TabIndex = 0;
            this.buttonTestAccessModifiers.Text = "Test Access Modifiers";
            this.buttonTestAccessModifiers.UseVisualStyleBackColor = true;
            this.buttonTestAccessModifiers.Click += new System.EventHandler(this.buttonTestAccessModifiers_Click);
            // 
            // tabPageDlls
            // 
            this.tabPageDlls.Controls.Add(this.textBoxTaskDesc);
            this.tabPageDlls.Controls.Add(this.labelTaskDesc);
            this.tabPageDlls.Controls.Add(this.buttonTestDll);
            this.tabPageDlls.Location = new System.Drawing.Point(4, 22);
            this.tabPageDlls.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageDlls.Name = "tabPageDlls";
            this.tabPageDlls.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageDlls.Size = new System.Drawing.Size(359, 112);
            this.tabPageDlls.TabIndex = 0;
            this.tabPageDlls.Text = "Using Dlls";
            this.tabPageDlls.UseVisualStyleBackColor = true;
            // 
            // buttonTestDll
            // 
            this.buttonTestDll.Location = new System.Drawing.Point(9, 13);
            this.buttonTestDll.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTestDll.Name = "buttonTestDll";
            this.buttonTestDll.Size = new System.Drawing.Size(100, 21);
            this.buttonTestDll.TabIndex = 0;
            this.buttonTestDll.Text = "Test Dll";
            this.buttonTestDll.UseVisualStyleBackColor = true;
            this.buttonTestDll.Click += new System.EventHandler(this.buttonTestDll_Click);
            // 
            // labelTaskDesc
            // 
            this.labelTaskDesc.AutoSize = true;
            this.labelTaskDesc.Location = new System.Drawing.Point(6, 45);
            this.labelTaskDesc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTaskDesc.Name = "labelTaskDesc";
            this.labelTaskDesc.Size = new System.Drawing.Size(87, 13);
            this.labelTaskDesc.TabIndex = 1;
            this.labelTaskDesc.Text = "Task Description";
            // 
            // textBoxTaskDesc
            // 
            this.textBoxTaskDesc.Location = new System.Drawing.Point(9, 60);
            this.textBoxTaskDesc.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTaskDesc.Name = "textBoxTaskDesc";
            this.textBoxTaskDesc.Size = new System.Drawing.Size(273, 20);
            this.textBoxTaskDesc.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(21, 189);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 55);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(25, 256);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 46);
            this.panel1.TabIndex = 4;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageDlls);
            this.tabControl1.Controls.Add(this.tabPageAccessModifiers);
            this.tabControl1.Location = new System.Drawing.Point(21, 39);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(367, 138);
            this.tabControl1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(9, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 341);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabPageAccessModifiers.ResumeLayout(false);
            this.tabPageDlls.ResumeLayout(false);
            this.tabPageDlls.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPageAccessModifiers;
        private System.Windows.Forms.Button buttonTestAccessModifiers;
        private System.Windows.Forms.TabPage tabPageDlls;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxTaskDesc;
        private System.Windows.Forms.Label labelTaskDesc;
        private System.Windows.Forms.Button buttonTestDll;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;

    }
}

