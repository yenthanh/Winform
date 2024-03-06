using System;
using System.Windows.Forms;
using SPOSAPIDemo.API_Helper;
using SPOSAPIDemo.Model;

namespace SPOSAPIDemo
{
    public partial class CancelPax : Form
    {
        private static string token;
        public CancelPax(string Token)
        {
            InitializeComponent();
            token = Token;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var response = await Helper.CancelPax(token, txttrip_id.Text, txtvoyage_date.Text, txtboarding_pass_number.Text, Convert.ToInt32(txtpax_id.Text));
      

            if (!string.IsNullOrEmpty(response.error))
            {
                MessageBox.Show(response.error);
            }
            else
            {
                txterr_msg.Text = response.err_msg;
                txterr_num.Text = response.err_num;
            }
        }
    }
}