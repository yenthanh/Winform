﻿using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using SPOSAPIDemo.API_Helper;
using SPOSAPIDemo.Model;

namespace SPOSAPIDemo
{
    public partial class GetTripList : Form
    {
        private static string token;
        public GetTripList(string Token)
        {
            InitializeComponent();
            token = Token;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var response = await Helper.GetTripList(token, txt1.Text, txt2.Text);
            foreach (var a in response.data)
            {
                dataGridView2.Rows.Add(a.trip_code, a.origin, a.destination,
                                       a.gate_id, a.departure_status, a.arrival_status
                                       , a.checkin_status, a.pre_imm_status, a.boarding_status
                                       , a.boarding_time, a.boarding_close_time, a.pre_imm_time
                                       , a.pontoon_status, a.trip_date, a.stb
                                       , a.stu, a.atb, a.atu
                                       , a.etb, a.etu, a.checked_in, a.total_checked_in
                                       , a.pre_imm, a.total_pre_imm, a.boarding
                                       , a.total_boarding, a.pontoon, a.total_pontoon);

            }
            txterr_msg.Text = response.err_msg;
            txterr_num.Text = response.err_num;

            if (!string.IsNullOrEmpty(response.error))
            {
                MessageBox.Show(response.error);
            }

        }
    }
}

