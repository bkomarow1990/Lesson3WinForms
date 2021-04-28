using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classwork
{
    public partial class Form1 : Form
    {

        Graphics graphics;
        Image stampImage;
        public enum Mods { Paint,Stamp, Rectangle}
        Mods mode;
        Point rectPoint;
        Color paintColor=Color.Black;
        int paintThickness=10;
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             graphics = panel1.CreateGraphics();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = $"Location: {e.Location} Buttons : {e.Button}";
              
            
        }

        private void redbtn_Click(object sender, EventArgs e)
        {
            this.paintColor = Color.Red;
        }

        private void blackbtn_Click(object sender, EventArgs e)
        {
            this.paintColor = Color.Black;
        }

        private void yellowbtn_Click(object sender, EventArgs e)
        {
            this.paintColor = Color.Yellow;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (mode == Mods.Paint)
                {
                    Label lbl = new Label();
                    lbl.BackColor = this.paintColor;
                    lbl.Size = new Size(paintThickness, paintThickness);
                    lbl.Location = e.Location;
                    this.panel1.Controls.Add(lbl);
                }
                else if (mode == Mods.Stamp)
                {
                    PictureBox pb = new PictureBox();
                    pb.Image = this.stampImage;
                    //Image.FromFile("../../../Resources/1.png"); 
                    pb.Size = new Size(paintThickness, paintThickness);
                    pb.Location = e.Location;
                    this.panel1.Controls.Add(pb);
                }
                else if(mode == Mods.Rectangle)
                {
                    Point p = e.Location;
                    int x = Math.Min(rectPoint.X, p.X);
                    int y = Math.Min(rectPoint.Y, p.Y);
                    int width = Math.Abs(p.X - rectPoint.X);
                    int height = Math.Abs(p.Y - rectPoint.Y);
                    Rectangle rect = new Rectangle(rectPoint.X, rectPoint.Y, width, height);
                    graphics.DrawRectangle(new Pen(new SolidBrush(paintColor)),rect);
                    graphics.FillRectangle(new SolidBrush(paintColor),rect);
                    //Rectangle rect;
                    //graphics.FillRectangle(new SolidBrush(paintColor), rect);

                    //this.panel1.Controls.Add(rect);
                    this.Invalidate();
                    // mRect = new Rectangle(e.X, e.Y, 0, 0);
                    //this.Invalidate();

                }
                else
                {
                    MessageBox.Show("Select Tool","Info",MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            
        }


        private void clearbtn_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
        }

        private void bluebtn_Click(object sender, EventArgs e)
        {
            this.paintColor = Color.Blue;
        }

        private void stamp1Button_Click(object sender, EventArgs e)
        {
            this.mode = Mods.Stamp;
            this.stampImage = Classwork.Properties.Resources._1;
        }

        private void stamp2Button_Click(object sender, EventArgs e)
        {
            this.mode = Mods.Stamp;
            this.stampImage = Classwork.Properties.Resources._2;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            this.paintThickness = (int)this.numericUpDown1.Value;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (mode == Mods.Rectangle)
            {
                rectPoint = e.Location;
            }
            
        }

        private void rectBtn_Click(object sender, EventArgs e)
        {
            this.mode = Mods.Rectangle;
        }

        private void penBtn_Click(object sender, EventArgs e)
        {
            this.mode = Mods.Paint;
        }
    }
}
