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
using WindowsFormsApp1.API_Helper;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1
{
    public partial class GetTerminalList : Form
    {
        private static string token;
        public GetTerminalList(string Token)
        {
            InitializeComponent();
            token = Token;
        }

        private async void btnClickTelminalList_Click(object sender, EventArgs e)
        {
            string apiUrl = $"{Helper.BaseURLdcs}/{"information/get-terminal-list"}";
            string result = await GetTerminalLi(apiUrl);
        }
        private async Task<string> GetTerminalLi(string apiUrl)
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
                            TerminalList[] data = JsonConvert.DeserializeObject<TerminalList[]>(json["data"].ToString());
                            foreach (TerminalList a in data)
                            {
                                dataGridView2.Rows.Add(a.code, a.name, a.city_code,a.country_code);
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
