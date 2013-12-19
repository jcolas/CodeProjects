namespace AsTimePermits
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
            this.buttonDelegates = new System.Windows.Forms.Button();
            this.buttonLambdas = new System.Windows.Forms.Button();
            this.buttonAnonymousTypes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDelegates
            // 
            this.buttonDelegates.Location = new System.Drawing.Point(12, 12);
            this.buttonDelegates.Name = "buttonDelegates";
            this.buttonDelegates.Size = new System.Drawing.Size(260, 23);
            this.buttonDelegates.TabIndex = 0;
            this.buttonDelegates.Text = "Delegates";
            this.buttonDelegates.UseVisualStyleBackColor = true;
            this.buttonDelegates.Click += new System.EventHandler(this.buttonDelegates_Click);
            // 
            // buttonLambdas
            // 
            this.buttonLambdas.Location = new System.Drawing.Point(12, 42);
            this.buttonLambdas.Name = "buttonLambdas";
            this.buttonLambdas.Size = new System.Drawing.Size(260, 23);
            this.buttonLambdas.TabIndex = 1;
            this.buttonLambdas.Text = "Lambdas";
            this.buttonLambdas.UseVisualStyleBackColor = true;
            this.buttonLambdas.Click += new System.EventHandler(this.buttonLambdas_Click);
            // 
            // buttonAnonymousTypes
            // 
            this.buttonAnonymousTypes.Location = new System.Drawing.Point(12, 71);
            this.buttonAnonymousTypes.Name = "buttonAnonymousTypes";
            this.buttonAnonymousTypes.Size = new System.Drawing.Size(260, 23);
            this.buttonAnonymousTypes.TabIndex = 2;
            this.buttonAnonymousTypes.Text = "Anonymous Types";
            this.buttonAnonymousTypes.UseVisualStyleBackColor = true;
            this.buttonAnonymousTypes.Click += new System.EventHandler(this.buttonAnonymousTypes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 116);
            this.Controls.Add(this.buttonAnonymousTypes);
            this.Controls.Add(this.buttonLambdas);
            this.Controls.Add(this.buttonDelegates);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDelegates;
        private System.Windows.Forms.Button buttonLambdas;
        private System.Windows.Forms.Button buttonAnonymousTypes;
    }
}

