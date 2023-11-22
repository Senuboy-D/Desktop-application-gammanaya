using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homeorg
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void sm1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 =new Form2();
            f2.Show();

        }

        private void sm2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void menu_Click(object sender, EventArgs e)
        {

        }

        private void sm3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f4 = new Form4();
            f4.Show();
        }

        private void home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void sm4_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form5 f5 = new Form5();
            f5.Show();
        }

        private void sm5_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form6 f6 = new Form6();
            f6.Show();
        }

        private void sm6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 f7 = new Form7();
            f7.Show();
        }

        private void about_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 f8 = new Form8();
            f8.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://facebook.com/gammanaya");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://intagram.com");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://whatsapp.com");
        }

        private void button3login_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form10 f10 = new Form10();
            f10.Show();
        }

        private void button2register_Click(object sender, EventArgs e, )
        {
           
            this.Hide();
            Form9 f9 = new Form9();
            f9.Show();
        }
    }
    
}
