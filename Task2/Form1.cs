using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
namespace Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Dictionary<string, string> db;
        string acc_login;
        private void Form1_Load(object sender, EventArgs e)
        {
            db = new Dictionary<string, string>();
            string json = File.ReadAllText("db.json");
            db = (Dictionary<string, string>)JsonConvert.DeserializeObject(json);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (db.ContainsKey(this.logintxtbox.Text))
            {
                if (db[this.logintxtbox.Text] == this.passtxtbox.Text)
                {
                    acc_login = this.logintxtbox.Text;
                    MessageBox.Show($"You logined as {acc_login}");
                }
            }
            else
            {
                MessageBox.Show("Incorrect login");
                this.logintxtbox.Focus();
            }
        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
            
        }
    }
}
