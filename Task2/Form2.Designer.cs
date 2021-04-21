
namespace Task2
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
            this.logintextbox = new System.Windows.Forms.TextBox();
            this.passtextbox = new System.Windows.Forms.TextBox();
            this.loginlbl = new System.Windows.Forms.Label();
            this.passlbl = new System.Windows.Forms.Label();
            this.registerbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // logintextbox
            // 
            this.logintextbox.Location = new System.Drawing.Point(263, 81);
            this.logintextbox.Name = "logintextbox";
            this.logintextbox.Size = new System.Drawing.Size(206, 23);
            this.logintextbox.TabIndex = 0;
            // 
            // passtextbox
            // 
            this.passtextbox.Location = new System.Drawing.Point(263, 148);
            this.passtextbox.Name = "passtextbox";
            this.passtextbox.Size = new System.Drawing.Size(206, 23);
            this.passtextbox.TabIndex = 1;
            // 
            // loginlbl
            // 
            this.loginlbl.AutoSize = true;
            this.loginlbl.Location = new System.Drawing.Point(263, 60);
            this.loginlbl.Name = "loginlbl";
            this.loginlbl.Size = new System.Drawing.Size(40, 15);
            this.loginlbl.TabIndex = 2;
            this.loginlbl.Text = "Login:";
            // 
            // passlbl
            // 
            this.passlbl.AutoSize = true;
            this.passlbl.Location = new System.Drawing.Point(263, 130);
            this.passlbl.Name = "passlbl";
            this.passlbl.Size = new System.Drawing.Size(60, 15);
            this.passlbl.TabIndex = 3;
            this.passlbl.Text = "Password:";
            // 
            // registerbtn
            // 
            this.registerbtn.Location = new System.Drawing.Point(329, 198);
            this.registerbtn.Name = "registerbtn";
            this.registerbtn.Size = new System.Drawing.Size(75, 23);
            this.registerbtn.TabIndex = 4;
            this.registerbtn.Text = "Register";
            this.registerbtn.UseVisualStyleBackColor = true;
            this.registerbtn.Click += new System.EventHandler(this.registerbtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.registerbtn);
            this.Controls.Add(this.passlbl);
            this.Controls.Add(this.loginlbl);
            this.Controls.Add(this.passtextbox);
            this.Controls.Add(this.logintextbox);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox logintextbox;
        private System.Windows.Forms.TextBox passtextbox;
        private System.Windows.Forms.Label loginlbl;
        private System.Windows.Forms.Label passlbl;
        private System.Windows.Forms.Button registerbtn;
    }
}