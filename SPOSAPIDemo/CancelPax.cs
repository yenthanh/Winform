using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
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
using SPOSAPIDemo.API_Helper;
using SPOSAPIDemo.Model;

namespace SPOSAPIDemo
{
    public partial class CancelPax : Form
    {
        private static string token;
        public CancelPax(string Token)
        {
            InitializeComponent();
            token = Token;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string apiUrl = $"{Helper.BaseURL}/{"booking/cancel-pax"}";
            string result = await CancelPa(apiUrl, txttrip_id.Text, txtvoyage_date.Text, txtboarding_pass_number.Text, Convert.ToInt32(txtpax_id.Text));
        }
        private async Task<string> CancelPa(string apiUrl, string trip_id, string voyage_date, string boarding_pass_number, int pax_id)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    var a = new object();
                    using (HttpClient client = new HttpClient())
                    {
                        PaxDetails details = new PaxDetails();
                        client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
                        var requestData = new
                        {
                            trip_id = trip_id,
                            voyage_date = voyage_date,
                            boarding_pass_number = boarding_pass_number,
                            pax_id = pax_id,
                            pax_details = details
                        };

                        string jsonRequestData = Newtonsoft.Json.JsonConvert.SerializeObject(requestData);

                        var content = new StringContent(jsonRequestData, Encoding.UTF8, "application/json");
                        HttpResponseMessage response = await client.PostAsync(apiUrl, content);

                        if (response.IsSuccessStatusCode)
                        {
                            string jsonResponse = await response.Content.ReadAsStringAsync();
                            JObject json = JObject.Parse(jsonResponse);
                            txterr_msg.Text = json["err_msg"].ToString();
                            txterr_num.Text = json["err_num"].ToString();

                            ResponseArray[] datares = JsonConvert.DeserializeObject<ResponseArray[]>(json["data"].ToString());

                            return await response.Content.ReadAsStringAsync();
                        }
                        else
                        {
                            string error = await response.Content.ReadAsStringAsync();
                            MessageBox.Show(error);
                            return error;
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