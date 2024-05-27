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

namespace WindowsFormsApp
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void btnSendData_Click(object sender, EventArgs e)
        {
           
            string hostUrl = GetHostUrl();
            string macAddress = GetMacAddress();
         

            string licenseKeyInput = licenseKey.Text;

            if (string.IsNullOrWhiteSpace(licenseKeyInput))
            {
                MessageBox.Show("Please Enter Your License Key.");
                return;
            }



            txtHostUrl.Text = hostUrl;
            txtMacAddress.Text = macAddress;
            licenseKey.Text = licenseKeyInput;



            var data = new PostDataModel
            {
                hostUrl = hostUrl,
                macAddress = macAddress,
                licenceKey = licenseKeyInput


            };

           
            SendDataToUrl(data);
            
        }

        private string GetHostUrl()
        {
            string hostName = Dns.GetHostName();
            string hostUrl = "http://" + hostName; // Assuming HTTP, change to HTTPS if needed
            return hostUrl;
        }
        /*
                private string[] GetSiteNames()
                {
                    var serverManager = new ServerManager();
                    List<string> siteNamesList = new List<string>();

                    foreach (Site site in serverManager.Sites)
                    {
                        siteNamesList.Add(site.Name);
                    }

                    return siteNamesList.ToArray();
                }*/

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

        private async void SendDataToUrl(PostDataModel data)
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
                                MessageBox.Show("Invalid Licence Key.");
                            }
                            if (response.Content.ReadAsStringAsync().Result == "Invalid Mac Address")
                            {
                                MessageBox.Show("Invalid Mac Address.");
                            }
                            if (response.Content.ReadAsStringAsync().Result == "Invalid Host Url")
                            {
                                MessageBox.Show("Invalid Host Url.");
                            }
                            if (response.Content.ReadAsStringAsync().Result == "Invalid Mac Address and Host Url")
                            {
                                MessageBox.Show("Invalid Mac Address and Host Url.");
                            }
                            if (response.Content.ReadAsStringAsync().Result == "Valid_Loging")
                            {
                                MessageBox.Show("Valid Loging.");
                            
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
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

    }
}
