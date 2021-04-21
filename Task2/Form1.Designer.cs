
namespace Task2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.logintxtbox = new System.Windows.Forms.TextBox();
            this.passtxtbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.registerbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // logintxtbox
            // 
            this.logintxtbox.Location = new System.Drawing.Point(276, 55);
            this.logintxtbox.Name = "logintxtbox";
            this.logintxtbox.Size = new System.Drawing.Size(176, 23);
            this.logintxtbox.TabIndex = 0;
            this.logintxtbox.Text = "Enter login";
            // 
            // passtxtbox
            // 
            this.passtxtbox.Location = new System.Drawing.Point(276, 120);
            this.passtxtbox.Name = "passtxtbox";
            this.passtxtbox.Size = new System.Drawing.Size(176, 23);
            this.passtxtbox.TabIndex = 1;
            this.passtxtbox.Text = "Enter password";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(327, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // registerbtn
            // 
            this.registerbtn.Location = new System.Drawing.Point(27, 363);
            this.registerbtn.Name = "registerbtn";
            this.registerbtn.Size = new System.Drawing.Size(75, 23);
            this.registerbtn.TabIndex = 3;
            this.registerbtn.Text = "Register";
            this.registerbtn.UseVisualStyleBackColor = true;
            this.registerbtn.Click += new System.EventHandler(this.registerbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.registerbtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.passtxtbox);
            this.Controls.Add(this.logintxtbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox logintxtbox;
        private System.Windows.Forms.TextBox passtxtbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button registerbtn;
    }
}

