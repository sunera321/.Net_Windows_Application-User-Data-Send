using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace separate_app
{
    public partial class Form11 : Form
    {
        private const string Url = "https://licence-management.free.beeceptor.com";
        public Form11()
        {
            InitializeComponent();
        }

       

        private void home_Click(object sender, EventArgs e)
         {
             Form1 form1 = new Form1();
             form1.Show();
             this.Hide();
         }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string userInput = textBox1.Text;

            if (string.IsNullOrWhiteSpace(userInput))
            {
                MessageBox.Show("Please Enter Your License Key.");
                return;
            }

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.PostAsync(Url, new StringContent(userInput));

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Text sent successfully!");
                    }
                    else
                    {
                        MessageBox.Show($"Error: {response.ReasonPhrase}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }

        }
    }
}
