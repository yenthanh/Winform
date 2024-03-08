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
using System.Diagnostics;

namespace SPOSAPIDemo
{
    public partial class GetPaxList : Form
    {
        private static string token;
        public GetPaxList(string Token)
        {
            InitializeComponent();
            token = Token;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("txt1.Text: " + txt1.Text); // In giá trị của txt3.Text ra Output window
            Debug.WriteLine("txt2.Text: " + txt2.Text); // In giá trị của txt3.Text ra Output window
            Debug.WriteLine("txt3.Text: " + txt3.Text); // In giá trị của txt3.Text ra Output window
            var includeCancel = txt3.Text.Trim();

            var response = await Helper.GetPaxList(token, txt1.Text, txt2.Text, includeCancel);
            if (!string.IsNullOrEmpty(response.error))
            {
                MessageBox.Show(response.error);
            }
            else
            {
                foreach (Model.GetPaxList a in response.data)
                {
                    dataGridView2.Rows.Add(a.pax_id, a.passport_number, a.ticket_number,
                                           a.last_name, a.first_name, a.gender, a.nationality, a.dob, a.travel_document_exp_date, a.country_issue, a.country_residence
                                           , a.destination, a.group_travel_flag, a.date_created, a.create_by, a.date_updated, a.updated_by
                                           , a.checkin, a.pre_imm, a.immigration, a.boarding, a.pontoon, a.cancelled, a.remarks
                                           , a.transfer_from, a.baggage_tag_number, a.ntl_flag, a.last_min_pax, a.customer_booking_code
                                           , a.pax_class, a.pax_type, a.security_program_flag, a.bag_allowance, a.additional_baggage_allowance
                                           , a.membership_no, a.source_check_in, a.ssr, a.passport_type, a.boarding_pass_number
                                           );

                }
                txterr_msg.Text = response.err_msg;
                txterr_num.Text = response.err_num;
            }
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}