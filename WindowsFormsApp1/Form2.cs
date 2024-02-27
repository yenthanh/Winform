using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
using WindowsFormsApp1.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        private static string token;
        public Form2(string Token)
        {
            InitializeComponent();
            token = Token;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string apiUrl = $"{BaseURL.apibaseURL}/{"booking/add-pax-record"}";

            // Gọi API bất đồng bộ và xử lý kết quả
            string result = await CallApiAsync(apiUrl, textBox1.Text, textBox2.Text,textBox3.Text);
            textBox4.Text = result;
        }
        private async Task<string> CallApiAsync(string apiUrl, string trip_id, string voyage_date, string Pax_Details)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    using (HttpClient client = new HttpClient())
                    {
                        var result = JsonConvert.DeserializeObject<PaxDetails>(Pax_Details);
                        client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
                        var requestData = new 
                        {
                            trip_id = trip_id,
                            voyage_date = voyage_date,
                            pax_details = new object[] {result }
                        };

                        string jsonRequestData = Newtonsoft.Json.JsonConvert.SerializeObject(requestData);

                        var content = new StringContent(jsonRequestData, Encoding.UTF8, "application/json");
                        HttpResponseMessage response = await client.PostAsync(apiUrl, content);

                        if (response.IsSuccessStatusCode)
                        {
                            return await response.Content.ReadAsStringAsync();
                        }
                        else
                        {
                            return await response.Content.ReadAsStringAsync();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
            }
    }
}
