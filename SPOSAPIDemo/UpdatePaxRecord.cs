using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using SPOSAPIDemo.API_Helper;
using SPOSAPIDemo.Model;

namespace SPOSAPIDemo
{
    public partial class UpdatePaxRecord : Form
    {
        private static string token;
        public UpdatePaxRecord(string Token)
        {
            InitializeComponent();
            token = Token;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            PaxDetails details = new PaxDetails();
            details.passport_no = dataGridView1.Rows[0].Cells["Column1"].Value?.ToString();
            details.passport_type = dataGridView1.Rows[0].Cells["Column2"].Value?.ToString();
            details.last_name = dataGridView1.Rows[0].Cells["Column3"].Value?.ToString();
            details.first_name = dataGridView1.Rows[0].Cells["Column4"].Value?.ToString();
            details.gender = dataGridView1.Rows[0].Cells["Column5"].Value?.ToString();
            details.nationality = dataGridView1.Rows[0].Cells["Column6"].Value?.ToString();
            details.dob = dataGridView1.Rows[0].Cells["Column7"].Value?.ToString();
            details.country_of_birth = dataGridView1.Rows[0].Cells["Column8"].Value?.ToString();
            details.travel_doc_exp_date = dataGridView1.Rows[0].Cells["Column9"].Value?.ToString();
            details.country_of_issue = dataGridView1.Rows[0].Cells["Column10"].Value?.ToString();
            details.country_of_residence = dataGridView1.Rows[0].Cells["Column11"].Value?.ToString();
            details.destination = dataGridView1.Rows[0].Cells["Column12"].Value?.ToString();
            details.ticket_no = dataGridView1.Rows[0].Cells["Column13"].Value?.ToString();
            details.remarks = dataGridView1.Rows[0].Cells["Column14"].Value?.ToString();
            details.cabin = dataGridView1.Rows[0].Cells["Column16"].Value?.ToString();
            details.pax_type = dataGridView1.Rows[0].Cells["Column17"].Value?.ToString();
            details.bag_allowance = Convert.ToInt32(dataGridView1.Rows[0].Cells["Column18"].Value);
            details.additional_bag_allowance = Convert.ToInt32(dataGridView1.Rows[0].Cells["Column19"].Value);
            details.security_program_flag = dataGridView1.Rows[0].Cells["Column20"].Value?.ToString();
            details.membership_no = dataGridView1.Rows[0].Cells["Column21"].Value?.ToString();
            details.ssr = new List<string>();
            if (dataGridView1.Rows[0].Cells["Column24"].Value != null)
            {
                string[] values = dataGridView1.Rows[0].Cells["Column24"].Value?.ToString().Split(',').Select(value => value.Trim()).ToArray();
                foreach (string value in values)
                {
                    details.ssr.Add(value);
                }
            }

            var response = await Helper.UpdatePax(token, details, txttrip_id.Text, txtvoyage_date.Text, txtboarding_pass_number.Text, Convert.ToInt32(txtpax_id.Text));
            if (!string.IsNullOrEmpty(response.error))
            {
                MessageBox.Show(response.error);
            }
            else
            {
                dataGridView2.Rows.Add(response.data.out_num, response.data.out_str);
                txterr_msg.Text = response.err_msg;
                txterr_num.Text = response.err_num;
            }
        }
    }
}
