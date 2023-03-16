using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Authentication_System
{
    public partial class Form1 : Form
    {
        private string username;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Signup f1= new Signup();
            f1.Show();
            this.Hide();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            string file = "";
            bool flg1 = false, flg2 = false;
            if (File.Exists(file))
            {
                string[] lines = File.ReadAllLines(file);
                int i = 1;
                foreach (string line in lines)
                {
                    if (i % 3 == 2 && line == un.Text) flg1 = true;
                    if (i % 3 == 0 && line == pass.Text) flg2 = true;
                    i++;
                }
                if (flg1 && flg2)
                {
                    username = un.Text;
                    Form3 f3 = new Form3();
                    f3.Show();
                    this.Hide();
                }
            }

        }
    }
}
