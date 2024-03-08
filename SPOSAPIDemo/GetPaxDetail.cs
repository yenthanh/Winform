﻿using Newtonsoft.Json.Linq;
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
    public partial class GetPaxDetail : Form
    {
        private static string token;
        public GetPaxDetail(string Token)
        {
            InitializeComponent();
            token = Token;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var response = await Helper.GetPaxDetail(token, txt1.Text, txt2.Text, txt3.Text, txt4.Text, txt5.Text);
            if (!string.IsNullOrEmpty(response.error))
            {
                MessageBox.Show(response.error);
            }
            else
            {
                foreach (Model.GetPaxList a in response.data)


                {
                    Debug.WriteLine("gender: " + a.baggage_type);
                    Debug.WriteLine("gender: " + a.boarding_sequence);
                    Debug.WriteLine("gender: " + a.dcs_booking_code);
                    Debug.WriteLine("gender: " + a.cabin);




                    // Trước khi thêm dữ liệu vào DataGridView, kiểm tra giá trị null hoặc rỗng
                    //dataGridView2.Rows.Add(a.pax_id, a.passport_number, a.ticket_number,
                    //                       a.last_name, a.first_name, a.gender, a.nationality, a.dob, a.travel_document_expiry_date, a.travel_document_issuing_country, a.country_residence, a.destination
                    //                       , a.group_travel_flag, a.date_created, a.create_by, a.date_updated, a.updated_by, a.checkin, a.pre_imm, a.immigration, a.boarding, a.pontoon, a.cancelled, a.remarks, a.transfer_from,
                    //                       , a.tag_number, a.ntl_flag, a.last_min_pax
                    //                       , a.customer_booking_code, a.pax_type, a.security_program_flag, a.bag_allowance, a.membership_no, a.source_check_in, a.ssr, a.passport_type, a.boarding_pass_number


                    //                       , a.dcs_booking_code, a.cabin
                    //                       , a.boarding_sequence


                    //                       , a.baggage_type



                    //                       );

                    txterr_msg.Text = response.err_msg;
                    txterr_num.Text = response.err_num;
                }

            }
        }

    }
}
