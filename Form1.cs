using System;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;
using System.Net.NetworkInformation;
using System.Net;
using separate_app;
using System.Security.Policy;
using Microsoft.Web.Administration;
using System.Collections.Generic;
using Site = Microsoft.Web.Administration.Site;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSendData_Click(object sender, EventArgs e)
        {
           
            string hostUrl = GetHostUrl();
            string macAddress = GetMacAddress();
            string[] siteNames = GetSiteNames();

            txtHostUrl.Text = hostUrl;
            txtMacAddress.Text = macAddress;
            txtSiteNames.Text = string.Join(Environment.NewLine, siteNames);


            var data = new PostDataModel
            {
                HostUrl = hostUrl,
                MacAddress = macAddress,
                SiteNames = siteNames
            };

           
            SendDataToUrl(data);
            
        }

        private string GetHostUrl()
        {
            string hostName = Dns.GetHostName();
            string hostUrl = "http://" + hostName; // Assuming HTTP, change to HTTPS if needed
            return hostUrl;
        }

        private string[] GetSiteNames()
        {
            var serverManager = new ServerManager();
            List<string> siteNamesList = new List<string>();

            foreach (Site site in serverManager.Sites)
            {
                siteNamesList.Add(site.Name);
            }

            return siteNamesList.ToArray();
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
                    macAddresses += nic.GetPhysicalAddress().ToString();
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
                    var response = await client.PostAsync("https://licence-management.free.beeceptor.com", content);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Data sent successfully..");
                    }
                    else
                    {
                        MessageBox.Show($"Error sending data: {response.StatusCode}");
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
    }
}
