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
using WindowsFormsApp1.API_Helper;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1
{
    public partial class GetTripInfo : Form
    {
        private static string token;
        public GetTripInfo(string Token)
        {
            InitializeComponent();
            token = Token;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string apiUrl = $"{Helper.BaseURLdcs}/{"information/get-trip-info?trip_id=" + txt1.Text + "&voyage_date=" + txt2.Text + ""}";
            string result = await GetTripIn(apiUrl);
        }
        private async Task<string> GetTripIn(string apiUrl)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    using (HttpClient client = new HttpClient())
                    {

                        client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
                        HttpResponseMessage response = await client.GetAsync(apiUrl);

                        if (response.IsSuccessStatusCode)
                        {
                            string jsonResponse = await response.Content.ReadAsStringAsync();
                            JObject json = JObject.Parse(jsonResponse);
                            txterr_msg.Text = json["err_msg"].ToString();
                            txterr_num.Text = json["err_num"].ToString();
                            TripInfo[] data = JsonConvert.DeserializeObject<TripInfo[]>(json["data"].ToString());
                            foreach (TripInfo a in data)
                            {
                                dataGridView2.Rows.Add(a.trip_id, a.origin, a.destination,
                                                       a.gate_id, a.departure_status, a.arrival_status
                                                       , a.checkin_status, a.pre_imm_status, a.boarding_status
                                                       , a.boarding_time, a.boarding_close_time, a.pre_imm_time
                                                       , a.pontoon_status, a.trip_date, a.stb
                                                       , a.stu, a.atb, a.atu
                                                       , a.etb, a.etu, a.vessel_id
                                                       , a.vessel_name, a.checked_in, a.total_checked_in
                                                       , a.pre_imm, a.total_pre_imm, a.boarding
                                                       , a.total_boarding, a.pontoon, a.total_pontoon);
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
