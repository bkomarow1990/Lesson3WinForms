
namespace Classwork
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.redbtn = new System.Windows.Forms.Button();
            this.blackbtn = new System.Windows.Forms.Button();
            this.yellowbtn = new System.Windows.Forms.Button();
            this.bluebtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.clearbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Location = new System.Drawing.Point(253, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(614, 424);
            this.panel1.TabIndex = 0;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // redbtn
            // 
            this.redbtn.BackColor = System.Drawing.Color.Red;
            this.redbtn.Location = new System.Drawing.Point(12, 12);
            this.redbtn.Name = "redbtn";
            this.redbtn.Size = new System.Drawing.Size(72, 67);
            this.redbtn.TabIndex = 0;
            this.redbtn.UseVisualStyleBackColor = false;
            this.redbtn.Click += new System.EventHandler(this.redbtn_Click);
            // 
            // blackbtn
            // 
            this.blackbtn.BackColor = System.Drawing.Color.Black;
            this.blackbtn.Location = new System.Drawing.Point(137, 12);
            this.blackbtn.Name = "blackbtn";
            this.blackbtn.Size = new System.Drawing.Size(72, 67);
            this.blackbtn.TabIndex = 1;
            this.blackbtn.UseVisualStyleBackColor = false;
            this.blackbtn.Click += new System.EventHandler(this.blackbtn_Click);
            // 
            // yellowbtn
            // 
            this.yellowbtn.BackColor = System.Drawing.Color.Yellow;
            this.yellowbtn.Location = new System.Drawing.Point(137, 103);
            this.yellowbtn.Name = "yellowbtn";
            this.yellowbtn.Size = new System.Drawing.Size(72, 67);
            this.yellowbtn.TabIndex = 3;
            this.yellowbtn.UseVisualStyleBackColor = false;
            this.yellowbtn.Click += new System.EventHandler(this.yellowbtn_Click);
            // 
            // bluebtn
            // 
            this.bluebtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.bluebtn.Location = new System.Drawing.Point(12, 103);
            this.bluebtn.Name = "bluebtn";
            this.bluebtn.Size = new System.Drawing.Size(72, 67);
            this.bluebtn.TabIndex = 2;
            this.bluebtn.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBox1.Location = new System.Drawing.Point(45, 201);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(138, 23);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.Text = "10";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // clearbtn
            // 
            this.clearbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.clearbtn.Location = new System.Drawing.Point(75, 230);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(75, 23);
            this.clearbtn.TabIndex = 0;
            this.clearbtn.Text = "CLEAR";
            this.clearbtn.UseVisualStyleBackColor = true;
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(902, 520);
            this.Controls.Add(this.clearbtn);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.yellowbtn);
            this.Controls.Add(this.bluebtn);
            this.Controls.Add(this.blackbtn);
            this.Controls.Add(this.redbtn);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "YoptaPaint";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button redbtn;
        private System.Windows.Forms.Button blackbtn;
        private System.Windows.Forms.Button yellowbtn;
        private System.Windows.Forms.Button bluebtn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button clearbtn;
    }
}

