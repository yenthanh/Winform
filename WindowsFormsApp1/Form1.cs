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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private static string Token;
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                string apiUrl = "https://api-spos-new.sqiva.com/ws/v1/auth/login";

                // Gọi API bất đồng bộ và xử lý kết quả
                string result = await CallApiAsync(apiUrl, textBox1.Text, textBox2.Text);

                MessageBox.Show(result);
                Form2 form2 = new Form2(Token);
                form2.ShowDialog();
                this.Close();

            }
            else
                MessageBox.Show("Please enter values for both fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }
        private async Task<string> CallApiAsync(string apiUrl, string username, string password)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    MultipartFormDataContent formData = new MultipartFormDataContent();

                    formData.Add(new StringContent(username), "username");

                    formData.Add(new StringContent(password), "password");

                    // Gửi yêu cầu POST đến API với dữ liệu form-data
                    HttpResponseMessage response = await httpClient.PostAsync(apiUrl, formData);

                    if (response.IsSuccessStatusCode)
                    {
                        string jsonResponse = await response.Content.ReadAsStringAsync();
                        JObject json = JObject.Parse(jsonResponse);
                        string token = json["data"]["token"].ToString();
                        Token = token;
                        return await response.Content.ReadAsStringAsync();
                    }
                    else
                    {
                        return $"Error: {response.StatusCode}";
                    }
                }
                catch (Exception ex)
                {
                    return $"Exception: {ex.Message}";
                }
            }
        }
    }
}
