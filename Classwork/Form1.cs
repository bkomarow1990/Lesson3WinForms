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
        Color paintColor=Color.Black;
        int paintThickness=10;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
                Label lbl = new Label();
                lbl.BackColor = this.paintColor;
                lbl.Size = new Size(paintThickness,paintThickness);
                lbl.Location = e.Location;
                this.panel1.Controls.Add(lbl);
            }
            
        }


        private void clearbtn_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            this.paintThickness = Int32.Parse(this.comboBox1.SelectedItem.ToString());
        }
    }
}
