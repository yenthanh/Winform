using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}
