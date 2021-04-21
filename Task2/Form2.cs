using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using Newtonsoft.Json;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Task2
{
    public partial class Form2 : Form
    {
        Dictionary<string, string> db;
        public Form2()
        {
            InitializeComponent();
            db = new Dictionary<string, string>();
            string json = File.ReadAllText("db.json");
            db = (Dictionary<string, string>)JsonConvert.DeserializeObject(json);
        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            db.Add(this.logintextbox.Text, this.passtextbox.Text);
            File.WriteAllText("db.json",JsonConvert.SerializeObject(db));
        }
    }
}
