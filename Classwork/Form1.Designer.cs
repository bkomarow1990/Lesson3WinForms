
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
            this.clearbtn = new System.Windows.Forms.Button();
            this.stamp1Button = new System.Windows.Forms.Button();
            this.stamp2Button = new System.Windows.Forms.Button();
            this.thicknessLbl = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.rectBtn = new System.Windows.Forms.Button();
            this.penBtn = new System.Windows.Forms.Button();
            this.stampsLbl = new System.Windows.Forms.Label();
            this.toolsLbl = new System.Windows.Forms.Label();
            this.colorsLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Location = new System.Drawing.Point(289, 36);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(702, 565);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // redbtn
            // 
            this.redbtn.BackColor = System.Drawing.Color.Red;
            this.redbtn.Location = new System.Drawing.Point(14, 16);
            this.redbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.redbtn.Name = "redbtn";
            this.redbtn.Size = new System.Drawing.Size(82, 89);
            this.redbtn.TabIndex = 0;
            this.redbtn.UseVisualStyleBackColor = false;
            this.redbtn.Click += new System.EventHandler(this.redbtn_Click);
            // 
            // blackbtn
            // 
            this.blackbtn.BackColor = System.Drawing.Color.Black;
            this.blackbtn.Location = new System.Drawing.Point(157, 16);
            this.blackbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.blackbtn.Name = "blackbtn";
            this.blackbtn.Size = new System.Drawing.Size(82, 89);
            this.blackbtn.TabIndex = 1;
            this.blackbtn.UseVisualStyleBackColor = false;
            this.blackbtn.Click += new System.EventHandler(this.blackbtn_Click);
            // 
            // yellowbtn
            // 
            this.yellowbtn.BackColor = System.Drawing.Color.Yellow;
            this.yellowbtn.Location = new System.Drawing.Point(157, 137);
            this.yellowbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.yellowbtn.Name = "yellowbtn";
            this.yellowbtn.Size = new System.Drawing.Size(82, 89);
            this.yellowbtn.TabIndex = 3;
            this.yellowbtn.UseVisualStyleBackColor = false;
            this.yellowbtn.Click += new System.EventHandler(this.yellowbtn_Click);
            // 
            // bluebtn
            // 
            this.bluebtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.bluebtn.Location = new System.Drawing.Point(14, 137);
            this.bluebtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bluebtn.Name = "bluebtn";
            this.bluebtn.Size = new System.Drawing.Size(82, 89);
            this.bluebtn.TabIndex = 2;
            this.bluebtn.UseVisualStyleBackColor = false;
            this.bluebtn.Click += new System.EventHandler(this.bluebtn_Click);
            // 
            // clearbtn
            // 
            this.clearbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.clearbtn.Location = new System.Drawing.Point(86, 307);
            this.clearbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(86, 31);
            this.clearbtn.TabIndex = 0;
            this.clearbtn.Text = "CLEAR";
            this.clearbtn.UseVisualStyleBackColor = true;
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // stamp1Button
            // 
            this.stamp1Button.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.stamp1Button.BackgroundImage = global::Classwork.Properties.Resources._1;
            this.stamp1Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.stamp1Button.Location = new System.Drawing.Point(14, 359);
            this.stamp1Button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.stamp1Button.Name = "stamp1Button";
            this.stamp1Button.Size = new System.Drawing.Size(82, 89);
            this.stamp1Button.TabIndex = 5;
            this.stamp1Button.UseVisualStyleBackColor = false;
            this.stamp1Button.Click += new System.EventHandler(this.stamp1Button_Click);
            // 
            // stamp2Button
            // 
            this.stamp2Button.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.stamp2Button.BackgroundImage = global::Classwork.Properties.Resources._2;
            this.stamp2Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.stamp2Button.Location = new System.Drawing.Point(157, 359);
            this.stamp2Button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.stamp2Button.Name = "stamp2Button";
            this.stamp2Button.Size = new System.Drawing.Size(82, 89);
            this.stamp2Button.TabIndex = 6;
            this.stamp2Button.UseVisualStyleBackColor = false;
            this.stamp2Button.Click += new System.EventHandler(this.stamp2Button_Click);
            // 
            // thicknessLbl
            // 
            this.thicknessLbl.AutoSize = true;
            this.thicknessLbl.Location = new System.Drawing.Point(51, 244);
            this.thicknessLbl.Name = "thicknessLbl";
            this.thicknessLbl.Size = new System.Drawing.Size(74, 20);
            this.thicknessLbl.TabIndex = 7;
            this.thicknessLbl.Text = "Thickness:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(22, 273);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(150, 27);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // rectBtn
            // 
            this.rectBtn.BackColor = System.Drawing.Color.Transparent;
            this.rectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rectBtn.Font = new System.Drawing.Font("Bebas Neue Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rectBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rectBtn.Location = new System.Drawing.Point(14, 504);
            this.rectBtn.Name = "rectBtn";
            this.rectBtn.Size = new System.Drawing.Size(74, 77);
            this.rectBtn.TabIndex = 0;
            this.rectBtn.Text = "Rectangle";
            this.rectBtn.UseVisualStyleBackColor = false;
            this.rectBtn.Click += new System.EventHandler(this.rectBtn_Click);
            // 
            // penBtn
            // 
            this.penBtn.BackColor = System.Drawing.Color.Transparent;
            this.penBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.penBtn.Font = new System.Drawing.Font("Bebas Neue Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.penBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.penBtn.Location = new System.Drawing.Point(157, 504);
            this.penBtn.Name = "penBtn";
            this.penBtn.Size = new System.Drawing.Size(74, 77);
            this.penBtn.TabIndex = 8;
            this.penBtn.Text = "PEN";
            this.penBtn.UseVisualStyleBackColor = false;
            this.penBtn.Click += new System.EventHandler(this.penBtn_Click);
            // 
            // stampsLbl
            // 
            this.stampsLbl.AutoSize = true;
            this.stampsLbl.Location = new System.Drawing.Point(19, 335);
            this.stampsLbl.Name = "stampsLbl";
            this.stampsLbl.Size = new System.Drawing.Size(61, 20);
            this.stampsLbl.TabIndex = 9;
            this.stampsLbl.Text = "Stamps:";
            // 
            // toolsLbl
            // 
            this.toolsLbl.AutoSize = true;
            this.toolsLbl.Location = new System.Drawing.Point(19, 481);
            this.toolsLbl.Name = "toolsLbl";
            this.toolsLbl.Size = new System.Drawing.Size(47, 20);
            this.toolsLbl.TabIndex = 10;
            this.toolsLbl.Text = "Tools:";
            // 
            // colorsLbl
            // 
            this.colorsLbl.AutoSize = true;
            this.colorsLbl.Location = new System.Drawing.Point(97, 109);
            this.colorsLbl.Name = "colorsLbl";
            this.colorsLbl.Size = new System.Drawing.Size(54, 20);
            this.colorsLbl.TabIndex = 11;
            this.colorsLbl.Text = "Colors:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1019, 741);
            this.Controls.Add(this.colorsLbl);
            this.Controls.Add(this.toolsLbl);
            this.Controls.Add(this.stampsLbl);
            this.Controls.Add(this.penBtn);
            this.Controls.Add(this.rectBtn);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.thicknessLbl);
            this.Controls.Add(this.stamp2Button);
            this.Controls.Add(this.stamp1Button);
            this.Controls.Add(this.clearbtn);
            this.Controls.Add(this.yellowbtn);
            this.Controls.Add(this.bluebtn);
            this.Controls.Add(this.blackbtn);
            this.Controls.Add(this.redbtn);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "TipaPaint";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button redbtn;
        private System.Windows.Forms.Button blackbtn;
        private System.Windows.Forms.Button yellowbtn;
        private System.Windows.Forms.Button bluebtn;
        private System.Windows.Forms.Button clearbtn;
        private System.Windows.Forms.Button stamp1Button;
        private System.Windows.Forms.Button stamp2Button;
        private System.Windows.Forms.Label thicknessLbl;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button rectBtn;
        private System.Windows.Forms.Button penBtn;
        private System.Windows.Forms.Label stampsLbl;
        private System.Windows.Forms.Label toolsLbl;
        private System.Windows.Forms.Label colorsLbl;
    }
}

