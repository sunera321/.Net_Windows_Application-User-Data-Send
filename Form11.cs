using Newtonsoft.Json;
using System;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace separate_app
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void home_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
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
                await SendDataToUrl(userInput);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private static async Task SendDataToUrl(string licenseKey)
        {
            using (var client = new HttpClient())
            {
                var activationData = new ActivateKey
                {
                    Clint_License_Key = licenseKey
                };

                var json = JsonConvert.SerializeObject(activationData);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                try
                {
                    var response = await client.PostAsync("https://localhost:7295/api/ActivateKey", content);

                    if (response.IsSuccessStatusCode)
                    {
                        if (response.StatusCode == System.Net.HttpStatusCode.OK)
                        {
                            if(response.Content.ReadAsStringAsync().Result == "Activated")
                            {
                                MessageBox.Show("License Key Activated Successfully.", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                using (StreamWriter sw = new StreamWriter("LicenseKey.txt"))
                                {
                                    sw.WriteLine(licenseKey);
                                }

                            }
                            if (response.Content.ReadAsStringAsync().Result == "Key Already Activated")
                            {
                                MessageBox.Show("License Key Already Activated.","Error",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                            }
                            if (response.Content.ReadAsStringAsync().Result == "Expired")
                            {
                                MessageBox.Show("Expired", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                //clear the licensekey.text file
                                using (StreamWriter sw = new StreamWriter("LicenseKey.txt"))
                                {
                                    sw.WriteLine("");
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("License Key Invalid.Please Try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void Form11_Load(object sender, EventArgs e)
        {

        }
    }

    public class ActivateKey
    {
        public string Clint_License_Key { get; set; }
    }
}
