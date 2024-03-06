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

    public partial class SubmitCheckIn : Form
    {
        private static string token;
        public SubmitCheckIn(string Token)
        {
            InitializeComponent();
            token = Token;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string apiUrl = $"{Helper.BaseURLdcs}/{"check-in/submit-check-in"}";
            string[] paxDetailsArray = txt3.Text.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            List<int> paxDetailsList = new List<int>();

            foreach (string value in paxDetailsArray)
            {
                if (int.TryParse(value, out int intValue))
                {
                    paxDetailsList.Add(intValue);
                }
            }

            await SubmitCheckInn(apiUrl, txt1.Text, txt2.Text, paxDetailsList);
        }
        private async Task<string> SubmitCheckInn(string apiUrl, string trip_id, string voyage_date, List<int> pax_details)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    var a = new object[] { };
                    using (HttpClient client = new HttpClient())
                    { 
                        SmCheckIn submitCheckIn = new SmCheckIn();
                        client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
                        var requestData = new
                        {
                            trip_id = trip_id,
                            voyage_date = voyage_date,
                            pax_details = submitCheckIn
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

                            ResponseArrayFull[] datares = JsonConvert.DeserializeObject<ResponseArrayFull[]>(json["data"].ToString());
                            foreach (var dt in datares)
                            {
                                dataGridView2.Rows.Add(dt.out_num, dt.out_str, dt.boarding_pass_number, dt.pax_id);
                            }
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
