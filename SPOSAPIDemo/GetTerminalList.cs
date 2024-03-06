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
using SPOSAPIDemo.API_Helper;
using SPOSAPIDemo.Model;

namespace SPOSAPIDemo
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
            var response = await Helper.GetTerminalList(token);
            if (!string.IsNullOrEmpty(response.error))
            {
                MessageBox.Show(response.error);
            }
            else
            {
                foreach (var a in response.data)
                {
                    dataGridView2.Rows.Add(a.code, a.name, a.city_code, a.country_code);
                }
                txterr_msg.Text = response.err_msg;
                txterr_num.Text = response.err_num;
            }
        }
    }
}
