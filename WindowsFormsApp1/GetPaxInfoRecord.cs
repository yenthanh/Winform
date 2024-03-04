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
using static System.Net.WebRequestMethods;

namespace WindowsFormsApp1
{
    public partial class GetPaxInfoRecord : Form
    {
        private static string token;
        public GetPaxInfoRecord(string Token)
        {
            InitializeComponent();
            token = Token;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string apiUrl = $"{Helper.BaseURLdcs}/{"information/get-pax-info?last_name=" + txt1.Text + "&voyage_date=" + txt2.Text + "&trip_id=" + txt3.Text + "&first_name=" + txt4.Text + "&passport_number=" + txt5.Text + "&dcs_booking_code=" + txt6.Text + "&customer_booking_code=" + txt7.Text + "&destination=" + txt8.Text + "&boarding_sequence=" + txt9.Text + "&include_cancel=" + txt10.Text + ""}";
             string result = await GetTripLi(apiUrl);   
        }
        private async Task<string> GetTripLi(string apiUrl)
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
                            GetPaxList[] data = JsonConvert.DeserializeObject<GetPaxList[]>(json["data"].ToString());
                            foreach (GetPaxList a in data)
                            {
                                dataGridView2.Rows.Add(a.pax_id, a.passport_number, a.ticket_number,
                                                       a.last_name, a.first_name, a.customer_booking_code
                                                       , a.dcs_booking_code, a.cabin, a.passport_type
                                                       , a.boarding_sequence, a.boarding_pass_number, a.gender
                                                       , a.pax_type, a.dob, a.nationality
                                                       , a.membership_no, a.travel_document_issuing_country, a.travel_document_expiry_date
                                                       , a.country_residence, a.bag_allowance, a.ssr, a.tag_number
                                                       , a.baggage_type, a.checkin, a.pre_imm
                                                       , a.boarding, a.pontoon, a.destination
                                                       , a.security_program_flag, a.group_travel_flag, a.immigration
                                                       , a.source_check_in, a.last_min_pax, a.ntl_flag
                                                       , a.transfer_from, a.remarks, a.cancelled
                                                       , a.date_created, a.create_by, a.date_updated
                                                       , a.updated_by);

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

        private void txterr_num_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void trip_id_Click(object sender, EventArgs e)
        {

        }

        private void txt2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txterr_msg_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void voyage_date_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txt8_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txt5_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txt9_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}