using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp;

namespace separate_app
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }


        private void Home_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();

            this.Hide();
        }

      

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10("HRO");
            form10.Show();

            this.Hide();
        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10("Tracking System");
            form10.Show();

            this.Hide();
        }

        private void guna2HtmlLabel5_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10("PeopleHR");
            form10.Show();

            this.Hide();
        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10("Juura");
            form10.Show();

            this.Hide();
        }

        private void guna2HtmlLabel6_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10("HREnterprise");
            form10.Show();

            this.Hide();
        }

        private void guna2HtmlLabel7_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10("People HR");
            form10.Show();

            this.Hide();

        }

        private void guna2HtmlLabel8_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel9_Click(object sender, EventArgs e)
        {

        }
    }
}

