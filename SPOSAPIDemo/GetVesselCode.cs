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
using System.Net;
using System.Web.UI.WebControls;

namespace SPOSAPIDemo
{
    public partial class GetVesselCode : Form
    {
        private static string token;
        public GetVesselCode(string Token)
        {
            InitializeComponent();
            token = Token;
        }

        private async void btnClickGetVesselCode_Click(object sender, EventArgs e)
        {
            string apiUrl = $"{Helper.BaseURL}/{"information/get-vessel-code"}";
            string result = await GetVessel(apiUrl);
        }
        private async Task<string> GetVessel(string apiUrl)
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
                            VesselPaxCode[] data = JsonConvert.DeserializeObject<VesselPaxCode[]>(json["data"].ToString());
                            foreach (VesselPaxCode a in data)
                            {
                                dataGridView2.Rows.Add(a.vessel_id, a.reg_country, a.vessel_name,
                                                        a.vessel_owner, a.insurance_company, a.insurance_policy_no,
                                                        a.vessel_type,
                                                        a.insurance_expiry_date,
                                                        a.eids_short_name,
                                                        a.vessel_call_sign_type,
                                                        a.grt,
                                                        a.vessel_length,
                                                        a.vessel_width,
                                                        a.insurance_reminder_date,
                                                        a.date_created,
                                                        a.create_by,
                                                        a.date_updated,
                                                        a.update_by,
                                                        a.remark,
                                                        a.crew_cap,
                                                        a.pax_cap,
                                                        a.total_cap,
                                                        a.status);
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
