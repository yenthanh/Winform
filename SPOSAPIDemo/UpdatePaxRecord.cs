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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WindowsFormsApp1
{
    public partial class UpdatePaxRecord : Form
    {
        private static string token;
        public UpdatePaxRecord(string Token)
        {
            InitializeComponent();
            token = Token;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string apiUrl = $"{Helper.BaseURL}/{"booking/update-pax-record"}";
            string result = await UpdatePax(apiUrl, txttrip_id.Text, txtvoyage_date.Text, txtboarding_pass_number.Text, Convert.ToInt32(txtpax_id.Text));
        }
        private async Task<string> UpdatePax(string apiUrl, string trip_id, string voyage_date, string boarding_pass_number, int pax_id)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    var a = new object();
                    using (HttpClient client = new HttpClient())
                    {
                        PaxDetails details = new PaxDetails();
                        details.passport_no = dataGridView1.Rows[0].Cells["Column1"].Value?.ToString();
                        details.passport_type = dataGridView1.Rows[0].Cells["Column2"].Value?.ToString();
                        details.last_name = dataGridView1.Rows[0].Cells["Column3"].Value?.ToString();
                        details.first_name = dataGridView1.Rows[0].Cells["Column4"].Value?.ToString();
                        details.gender = dataGridView1.Rows[0].Cells["Column5"].Value?.ToString();
                        details.nationality = dataGridView1.Rows[0].Cells["Column6"].Value?.ToString();
                        details.dob = dataGridView1.Rows[0].Cells["Column7"].Value?.ToString();
                        details.country_of_birth = dataGridView1.Rows[0].Cells["Column8"].Value?.ToString();
                        details.travel_doc_exp_date = dataGridView1.Rows[0].Cells["Column9"].Value?.ToString();
                        details.country_of_issue = dataGridView1.Rows[0].Cells["Column10"].Value?.ToString();
                        details.country_of_residence = dataGridView1.Rows[0].Cells["Column11"].Value?.ToString();
                        details.destination = dataGridView1.Rows[0].Cells["Column12"].Value?.ToString();
                        details.ticket_no = dataGridView1.Rows[0].Cells["Column13"].Value?.ToString();
                        details.remarks = dataGridView1.Rows[0].Cells["Column14"].Value?.ToString();
                        details.cabin = dataGridView1.Rows[0].Cells["Column16"].Value?.ToString();
                        details.pax_type = dataGridView1.Rows[0].Cells["Column17"].Value?.ToString();
                        details.bag_allowance = Convert.ToInt32(dataGridView1.Rows[0].Cells["Column18"].Value);
                        details.additional_bag_allowance = Convert.ToInt32(dataGridView1.Rows[0].Cells["Column19"].Value);
                        details.security_program_flag = dataGridView1.Rows[0].Cells["Column20"].Value?.ToString();
                        details.membership_no = dataGridView1.Rows[0].Cells["Column21"].Value?.ToString();
                        details.ssr = new List<string>();
                        if (dataGridView1.Rows[0].Cells["Column24"].Value != null)
                        {
                            string[] values = dataGridView1.Rows[0].Cells["Column24"].Value?.ToString().Split(',').Select(value => value.Trim()).ToArray();
                                foreach (string value in values)
                                {
                                    details.ssr.Add(value);
                                }
                        }
                        
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

                            ResponseArray datares = JsonConvert.DeserializeObject<ResponseArray>(json["data"].ToString());
                            dataGridView2.Rows.Add(datares.out_num, datares.out_str);
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
