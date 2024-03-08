using System;
using System.Windows.Forms;
using SPOSAPIDemo.API_Helper;
using SPOSAPIDemo.Model;

namespace SPOSAPIDemo
{
    public partial class GetPaxInfo : Form
    {
        private static string token;
        public GetPaxInfo(string Token)
        {
            InitializeComponent();
            token = Token;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var response = await Helper.GetPaxInfo(token, txt1.Text, txt2.Text, txt3.Text, txt4.Text, txt5.Text, txt6.Text, txt7.Text, txt8.Text, txt9.Text, txt10.Text);
            if (!string.IsNullOrEmpty(response.error))
            {
                MessageBox.Show(response.error);
            }
            else
            {
                foreach (Model.GetPaxList a in response.data)
                {
                    dataGridView2.Rows.Add(a.pax_id, a.passport_number, a.ticket_number,
                                           a.last_name, a.first_name, a.customer_booking_code
                                           , a.dcs_booking_code, a.cabin, a.passport_type
                                           , a.boarding_sequence, a.boarding_pass_number, a.gender
                                           , a.pax_type, a.dob, a.nationality
                                           , a.membership_no, a.travel_document_issuing_country, a.travel_document_exp_date
                                           , a.country_residence, a.bag_allowance, a.ssr, a.baggage_tag_number
                                           , a.baggage_type, a.checkin, a.pre_imm
                                           , a.boarding, a.pontoon, a.destination
                                           , a.security_program_flag, a.group_travel_flag, a.immigration
                                           , a.source_check_in, a.last_min_pax, a.ntl_flag
                                           , a.transfer_from, a.remarks, a.cancelled
                                           , a.date_created, a.create_by, a.date_updated
                                           , a.updated_by);
                    txterr_msg.Text = response.err_msg;
                    txterr_num.Text = response.err_num;
                }
            }
        }
    }
}