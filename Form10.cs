using System;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;
using System.Net.NetworkInformation;
using System.Net;
using System.Net.Http;
using separate_app;
using System.Security.Policy;
using Microsoft.Web.Administration;
using System.Collections.Generic;
using Site = Microsoft.Web.Administration.Site;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using System.Threading.Tasks;

namespace WindowsFormsApp
{
    public partial class Form10 : Form
    {
        private string Software_Name; 
        public Form10(string softwareName)
        {
            InitializeComponent();
            Software_Name = softwareName;
            
        }

        private async void btnSendData_Click(object sender, EventArgs e)
        {

            btnSendData.Enabled = false;
            guna2ProgressIndicator1.Visible = true;
            guna2ProgressIndicator1.Start();

            string hostUrl = GetHostUrl();
            string macAddress = GetMacAddress();
            string licenseKeyInput = GetLicenseKey();
        

            




            txtHostUrl.Text = hostUrl;
            txtMacAddress.Text = macAddress;
            licenseKey.Text = licenseKeyInput;


            
            var data = new PostDataModel
            {
                hostUrl = hostUrl,
                macAddress = macAddress,
                licenceKey = licenseKeyInput,
                SoftwareName = Software_Name





            };
         
       
                await SendDataToUrl(data);


            guna2ProgressIndicator1.Stop();
            guna2ProgressIndicator1.Visible = false;
            btnSendData.Enabled = true;







        }

        private string GetHostUrl()
        {
            string hostName = Dns.GetHostName();
            string hostUrl = "http://" + hostName; // Assuming HTTP, change to HTTPS if needed
            return hostUrl;
        }
            
        private string GetLicenseKey()
        {
            //read the licensekey.txt propaty file and retern the license key
            if(File.Exists("licensekey.txt"))
            {
                using (StreamReader SR = new StreamReader("licensekey.txt"))
                {
                    return SR.ReadLine();
                }
            }
            else
            {
                MessageBox.Show("License Key File Not Found");
                return null;
            }
        }
        private string GetMacAddress()
        {
            string macAddresses = "";

            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                // Only consider physical interfaces
                if (nic.NetworkInterfaceType == NetworkInterfaceType.Ethernet ||
                    nic.NetworkInterfaceType == NetworkInterfaceType.Wireless80211)
                {
                    macAddresses = BitConverter.ToString(nic.GetPhysicalAddress().GetAddressBytes());
                    break; // Only need the first MAC address
                }
            }

            return macAddresses;
        }

        private async Task SendDataToUrl(PostDataModel data)
        {
            using (var client = new HttpClient())
            {
                var json = JsonConvert.SerializeObject(data);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                try
                {
                    var response = await client.PostAsync("https://localhost:7295/api/LogingValidateInfo/AddClientServerDetails", content);
                    if (response.IsSuccessStatusCode)
                    {
                     
                        if (response.StatusCode == HttpStatusCode.OK) { 
                            if (response.Content.ReadAsStringAsync().Result == "Invalid Licence Key")
                            {
                                MessageBox.Show("Invalid Licence Key.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            }
                            if (response.Content.ReadAsStringAsync().Result == "Don't have access this software")
                            {
                                MessageBox.Show("Don't have access this software", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            }
                            if (response.Content.ReadAsStringAsync().Result == "Expired")
                            {
                                MessageBox.Show("Licence key is Expired", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            }
                            if (response.Content.ReadAsStringAsync().Result == "Invalid Mac Address")
                            {
                                MessageBox.Show("Invalid Mac Address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            }
                            if (response.Content.ReadAsStringAsync().Result == "Invalid Host URL")
                     
                            {
                                MessageBox.Show("Invalid Host Url.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            }
                            if (response.Content.ReadAsStringAsync().Result == "Invalid Mac Address and Host Url")
                            {
                                MessageBox.Show("Invalid Mac Address and Host Url.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            }
                            if (response.Content.ReadAsStringAsync().Result == "Valid Loging")
                            {
                                MessageBox.Show("Valid Loging.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            
                            }
                        }


                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void home_Click(object sender, EventArgs e)
        {
            Form12 form12 = new Form12();
            form12.Show();
            this.Hide();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void progressBar1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void guna2ProgressIndicator1_Click(object sender, EventArgs e)
        {

        }
    }
}
