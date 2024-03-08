using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SPOSAPIDemo.API_Helper;
using SPOSAPIDemo.Model;

namespace SPOSAPIDemo
{
    public partial class SubmitCheckIn : Form
    {
        private static string token;
        public SubmitCheckIn(string Token)
        {
            InitializeComponent();
            token = Token;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string[] paxDetailsArray = txt3.Text.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            List<PaxId> paxDetailsList = new List<PaxId>();

            foreach (string value in paxDetailsArray)
            {
                if (int.TryParse(value, out int intValue))
                {
                    paxDetailsList.Add(new PaxId { pax_id = intValue});
                }
            }

            var response = await Helper.SubmitCheckIn(token, txt1.Text, txt2.Text, paxDetailsList);
            if (!string.IsNullOrEmpty(response.error))
            {
                MessageBox.Show(response.error);
            }
            else
            {
                foreach (var dt in response.data)
                {
                    dataGridView2.Rows.Add(dt.out_num, dt.out_str, dt.boarding_pass_number, dt.pax_id);
                }
                txterr_msg.Text = response.err_msg;
                txterr_num.Text = response.err_num;
            }
        }
    }
}
