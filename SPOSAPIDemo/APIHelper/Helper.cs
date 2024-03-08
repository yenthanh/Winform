using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SPOSAPIDemo.Model;

namespace SPOSAPIDemo.API_Helper
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
        public static async Task<AddPaxRecordResponseModel> AddPax(string token, string trip_id, string voyage_date, PaxDetailsAdd[] pax_details)
        {
            string apiUrl = $"{Helper.BaseURL}/{"booking/add-pax-record"}";
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var data = new ResponseArray[] { };
                    client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
                    var requestData = new
                    {
                        trip_id,
                        voyage_date,
                        pax_details
                    };

                    string jsonRequestData = JsonConvert.SerializeObject(requestData);

                    var content = new StringContent(jsonRequestData, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PostAsync(apiUrl, content);

                    if (response.IsSuccessStatusCode)
                    {
                        string jsonResponse = await response.Content.ReadAsStringAsync();
                        JObject json = JObject.Parse(jsonResponse);
                        ResponseArrayFull[] datares = JsonConvert.DeserializeObject<ResponseArrayFull[]>(json["data"].ToString());
                        return new AddPaxRecordResponseModel
                        {
                            data = datares,
                            err_msg = json["err_msg"].ToString(),
                            err_num = json["err_num"].ToString()
                        };
                    }
                    else
                    {
                        string error = await response.Content.ReadAsStringAsync();
                        return new AddPaxRecordResponseModel
                        {
                            error = error
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                return new AddPaxRecordResponseModel
                {
                    error = $"An error occurred: {ex.Message}",
                };
            }
        }
        public static async Task<CancelPaxRecordResponseModel> CancelPax(string token, string trip_id, string voyage_date, string boarding_pass_number, int pax_id)
        {
            string apiUrl = $"{Helper.BaseURL}/{"booking/cancel-pax"}";
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    PaxDetails details = new PaxDetails();
                    client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
                    var requestData = new
                    {
                        trip_id,
                        voyage_date,
                        boarding_pass_number,
                        pax_id,
                        pax_details = details
                    };

                    string jsonRequestData = Newtonsoft.Json.JsonConvert.SerializeObject(requestData);

                    var content = new StringContent(jsonRequestData, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PostAsync(apiUrl, content);

                    if (response.IsSuccessStatusCode)
                    {
                        string jsonResponse = await response.Content.ReadAsStringAsync();
                        JObject json = JObject.Parse(jsonResponse);

                        ResponseArray[] datares = JsonConvert.DeserializeObject<ResponseArray[]>(json["data"].ToString());
                        return new CancelPaxRecordResponseModel
                        {
                            data = datares,
                            err_msg = json["err_msg"].ToString(),
                            err_num = json["err_num"].ToString()
                        };
                    }
                    else
                    {
                        string error = await response.Content.ReadAsStringAsync();
                        return new CancelPaxRecordResponseModel
                        {
                            data = null,
                            error = error
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                return new CancelPaxRecordResponseModel
                {
                    error = $"An error occurred: {ex.Message}",
                };
            }
        }
        public static async Task<GetPaxResponseModel> GetPaxDetail(string token, string trip_id, string voyage_date, string boarding_pass_number, string pax_id, string include_cancel)
        {
            string apiUrl = $"{Helper.BaseURLdcs}/{"information/get-pax-detail?trip_id=" + trip_id + "&voyage_date=" + voyage_date + "&boarding_pass_number=" + boarding_pass_number + "&pax_id=" + pax_id + "&include_cancel=" + include_cancel + ""}";

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
                        Model.GetPaxList[] data = JsonConvert.DeserializeObject<Model.GetPaxList[]>(json["data"].ToString());
                        return new GetPaxResponseModel
                        {
                            data = data,
                            err_msg = json["err_msg"].ToString(),
                            err_num = json["err_num"].ToString()
                        };
                    }
                    else
                    {
                        string error = await response.Content.ReadAsStringAsync();
                        return new GetPaxResponseModel
                        {
                            error = error,
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                return new GetPaxResponseModel
                {
                    error = $"An error occurred: {ex.Message}",
                };
            }

        }
        public static async Task<GetPaxResponseModel> GetPaxInfo(string token, string last_name, string voyage_date, string trip_id, string first_name, string passport_number, string dcs_booking_code, string customer_booking_code, string destination, string boarding_sequence, string include_cancel)
        {
            string apiUrl = $"{Helper.BaseURLdcs}/{"information/get-pax-info?last_name=" + last_name + "&voyage_date=" + voyage_date + "&trip_id=" + trip_id + "&first_name=" + first_name + "&passport_number=" + passport_number + "&dcs_booking_code=" + dcs_booking_code + "&customer_booking_code=" + customer_booking_code + "&destination=" + destination + "&boarding_sequence=" + boarding_sequence + "&include_cancel=" + include_cancel + ""}";
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
                        Model.GetPaxList[] data = JsonConvert.DeserializeObject<Model.GetPaxList[]>(json["data"].ToString());
                        return new GetPaxResponseModel
                        {
                            data = data,
                            err_msg = json["err_msg"].ToString(),
                            err_num = json["err_num"].ToString()
                        };
                    }
                    else
                    {
                        string error = await response.Content.ReadAsStringAsync();
                        return new GetPaxResponseModel
                        {
                            error = error,
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                return new GetPaxResponseModel
                {
                    error = $"An error occurred: {ex.Message}",
                };
            }
        }
        public static async Task<GetPaxResponseModel> GetPaxList(string token, string trip_id, string voyage_date, string include_cancel)
        {
            string apiUrl = $"{Helper.BaseURLdcs}/information/get-pax-list?trip_id={trip_id}&voyage_date={voyage_date}&include_cancel={include_cancel}";

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
                        Model.GetPaxList[] data = JsonConvert.DeserializeObject<Model.GetPaxList[]>(json["data"].ToString());
                        return new GetPaxResponseModel
                        {
                            data = data,
                            err_msg = json["err_msg"].ToString(),
                            err_num = json["err_num"].ToString()
                        };
                    }
                    else
                    {
                        string error = await response.Content.ReadAsStringAsync();
                        return new GetPaxResponseModel
                        {
                            error = error,
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                return new GetPaxResponseModel
                {
                    error = $"An error occurred: {ex.Message}",
                };
            }

        }
        public static async Task<GetTerminalListResponseModel> GetTerminalList(string token)
        {
            string apiUrl = $"{Helper.BaseURLdcs}/{"information/get-terminal-list"}";
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
                        TerminalList[] data = JsonConvert.DeserializeObject<TerminalList[]>(json["data"].ToString());
                        return new GetTerminalListResponseModel
                        {
                            data = data,
                            err_msg = json["err_msg"].ToString(),
                            err_num = json["err_num"].ToString()
                        };
                    }
                    else
                    {
                        string error = await response.Content.ReadAsStringAsync();
                        return new GetTerminalListResponseModel
                        {
                            error = error
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                return new GetTerminalListResponseModel
                {
                    error = $"An error occurred: {ex.Message}",
                };
            }
        }
        public static async Task<TripInfoResponseModel> GetTripInfo(string token, string trip_id, string voyage_date)
        {
            string apiUrl = $"{Helper.BaseURLdcs}/{"information/get-trip-info?trip_id=" + trip_id + "&voyage_date=" + voyage_date + ""}";
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
                        TripInfo[] data = JsonConvert.DeserializeObject<TripInfo[]>(json["data"].ToString());
                        return new TripInfoResponseModel
                        {
                            data = data,
                            err_msg = json["err_msg"].ToString(),
                            err_num = json["err_num"].ToString()
                        };
                    }
                    else
                    {
                        string error = await response.Content.ReadAsStringAsync(); return new TripInfoResponseModel
                        {
                            error = error,
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                return new TripInfoResponseModel
                {
                    error = $"An error occurred: {ex.Message}",
                };
            }
        }
        public static async Task<TripListResponseModel> GetTripList(string token, string terminal, string voyage_date)
        {
            string apiUrl = $"{Helper.BaseURLdcs}/{"information/get-trip-list?terminal=" + terminal + "&voyage_date=" + voyage_date + ""}";
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
                        TripList[] data = JsonConvert.DeserializeObject<TripList[]>(json["data"].ToString());
                        return new TripListResponseModel
                        {
                            data = data,
                            err_msg = json["err_msg"].ToString(),
                            err_num = json["err_num"].ToString()
                        };
                    }
                    else
                    {
                        string error = await response.Content.ReadAsStringAsync();
                        return new TripListResponseModel
                        {
                            error = error,
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                return new TripListResponseModel
                {
                    error = $"An error occurred: {ex.Message}",
                };
            }

        }
        public static async Task<VesselPaxCodeResponseModel> GetVesselCode(string token)
        {
            string apiUrl = $"{Helper.BaseURL}/{"information/get-vessel-code"}";
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
                        VesselPaxCode[] data = JsonConvert.DeserializeObject<VesselPaxCode[]>(json["data"].ToString());
                        return new VesselPaxCodeResponseModel
                        {
                            data = data,
                            err_msg = json["err_msg"].ToString(),
                            err_num = json["err_num"].ToString()
                        };
                    }
                    else
                    {
                        string error = await response.Content.ReadAsStringAsync();
                        return new VesselPaxCodeResponseModel
                        {
                            error = error,
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                return new VesselPaxCodeResponseModel
                {
                    error = $"An error occurred: {ex.Message}",
                };
            }

        }
        public static async Task<LoginResponseModel> Login(string username, string password)
        {
            string apiUrl = $"{Helper.BaseURL}/{"auth/login"}";
            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    MultipartFormDataContent formData = new MultipartFormDataContent();

                    formData.Add(new StringContent(username), "username");

                    formData.Add(new StringContent(password), "password");

                    HttpResponseMessage response = await httpClient.PostAsync(apiUrl, formData);

                    if (response.IsSuccessStatusCode)
                    {
                        string jsonResponse = await response.Content.ReadAsStringAsync();
                        JObject json = JObject.Parse(jsonResponse);
                        return new LoginResponseModel
                        {
                            data = json["data"]["token"].ToString()
                        };
                    }
                    else
                    {
                        return new LoginResponseModel
                        {
                            error = $"Error: {response.StatusCode}"
                        };
                    }
                }
                catch (Exception ex)
                {
                    return new LoginResponseModel
                    {
                        error = $"Exception: {ex.Message}"
                    };
                }
            }
        }
        public static async Task<AddPaxRecordResponseModel> SubmitCheckIn(string token, string trip_id, string voyage_date, List<PaxId> pax_details)
        {
            string apiUrl = $"{Helper.BaseURLdcs}/{"check-in/submit-check-in"}";
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
                    var requestData = new
                    {
                        trip_id,
                        voyage_date,
                        pax_details
                    };

                    string jsonRequestData = JsonConvert.SerializeObject(requestData);
                    var content = new StringContent(jsonRequestData, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PostAsync(apiUrl, content);

                    if (response.IsSuccessStatusCode)
                    {
                        string jsonResponse = await response.Content.ReadAsStringAsync();
                        JObject json = JObject.Parse(jsonResponse);
                        ResponseArrayFull[] datares = JsonConvert.DeserializeObject<ResponseArrayFull[]>(json["data"].ToString());
                        return new AddPaxRecordResponseModel
                        {
                            data = datares,
                            err_msg = json["err_msg"].ToString(),
                            err_num = json["err_num"].ToString()
                        };
                    }
                    else
                    {
                        string error = await response.Content.ReadAsStringAsync();
                        return new AddPaxRecordResponseModel
                        {
                            error = error,
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                return new AddPaxRecordResponseModel
                {
                    error = $"An error occurred: {ex.Message}",
                };
            }
        }
        public static async Task<UpdatePaxRecordResponseModel> UpdatePax(string token, PaxDetails details, string trip_id, string voyage_date, string boarding_pass_number, int pax_id)
        {
            string apiUrl = $"{Helper.BaseURL}/{"booking/update-pax-record"}";
            try
            {
                var a = new object();
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
                    var requestData = new
                    {
                        trip_id,
                        voyage_date,
                        boarding_pass_number,
                        pax_id,
                        pax_details = details
                    };

                    string jsonRequestData = JsonConvert.SerializeObject(requestData);

                    var content = new StringContent(jsonRequestData, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PostAsync(apiUrl, content);

                    if (response.IsSuccessStatusCode)
                    {
                        string jsonResponse = await response.Content.ReadAsStringAsync();
                        JObject json = JObject.Parse(jsonResponse);
                        ResponseArray data = JsonConvert.DeserializeObject<ResponseArray>(json["data"].ToString());
                        return new UpdatePaxRecordResponseModel
                        {
                            data = data,
                            err_msg = json["err_msg"].ToString(),
                            err_num = json["err_num"].ToString()
                        };
                    }
                    else
                    {
                        string error = await response.Content.ReadAsStringAsync();
                        return new UpdatePaxRecordResponseModel
                        {
                            error = error
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                return new UpdatePaxRecordResponseModel
                {
                    error = $"An error occurred: {ex.Message}",
                };
            }
        }
    }
}
