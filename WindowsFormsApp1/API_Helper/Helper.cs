using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.API_Helper
{
    public class Helper
    {
        private static string _baseURL = "https://api-spos-new.sqiva.com/ws/v1";
        public static string BaseURL
        {
            get { return _baseURL; }
            set { _baseURL = value; }
        }
        public static void SetBaseURL(string baseURL)
        {
            _baseURL = baseURL;
        }
        private static string _baseURLdcs = "https://api-spos-new.sqiva.com/ws/dcs/v1";
        public static string BaseURLdcs
        {
            get { return _baseURLdcs; }
            set { _baseURLdcs = value; }
        }
        public static void SetBaseURLdcs(string baseURL)
        {
            _baseURL = baseURL;
        }
        public static async Task<ResponseModel> AddPax(string token, string trip_id, string voyage_date, PaxDetailsAdd[] pax_details)
        {
            string apiUrl = $"{Helper.BaseURL}/{"booking/add-pax-record"}";

            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    using (HttpClient client = new HttpClient())
                    {
                        var data = new ResponseArray[] { };
                        Array.Resize(ref pax_details, pax_details.Length - 1);
                        client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
                        var requestData = new
                        {
                            trip_id = trip_id,
                            voyage_date = voyage_date,
                            pax_details = pax_details
                        };

                        string jsonRequestData = Newtonsoft.Json.JsonConvert.SerializeObject(requestData);

                        var content = new StringContent(jsonRequestData, Encoding.UTF8, "application/json");
                        HttpResponseMessage response = await client.PostAsync(apiUrl, content);

                        if (response.IsSuccessStatusCode)
                        {
                            string jsonResponse = await response.Content.ReadAsStringAsync();
                            JObject json = JObject.Parse(jsonResponse);
                            ResponseArrayFull[] datares = JsonConvert.DeserializeObject<ResponseArrayFull[]>(json["data"].ToString());
                            return new ResponseModel
                            {
                                data = datares,
                                err_msg = json["err_msg"].ToString(),
                                err_num = json["err_num"].ToString()
                            };
                        }
                        else
                        {
                            string error = await response.Content.ReadAsStringAsync();
                            return new ResponseModel
                            {
                                error = error
                            };
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
