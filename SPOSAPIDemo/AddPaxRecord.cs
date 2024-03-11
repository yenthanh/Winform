using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using SPOSAPIDemo.API_Helper;
using SPOSAPIDemo.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SPOSAPIDemo
{
    public partial class AddPaxRecord : Form
    {
        private static string token;
        public AddPaxRecord(string Token)
        {
            InitializeComponent();
            token = Token;
            AddDefaultValue();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            List<int> indexesToRemove = new List<int>();
            var pax_details = new PaxDetailsAdd[] { };
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                PaxDetailsAdd details = new PaxDetailsAdd();
                details.passport_no = row.Cells["Column1"].Value?.ToString();
                details.passport_type = row.Cells["Column2"].Value?.ToString();
                details.last_name = row.Cells["Column3"].Value?.ToString();
                details.first_name = row.Cells["Column4"].Value?.ToString();
                details.gender = row.Cells["Column5"].Value?.ToString();
                details.nationality = row.Cells["Column6"].Value?.ToString();
                details.dob = row.Cells["Column7"].Value?.ToString();
                details.country_of_birth = row.Cells["Column8"].Value?.ToString();
                details.travel_doc_exp_date = row.Cells["Column9"].Value?.ToString();
                details.country_of_issue = row.Cells["Column10"].Value?.ToString();
                details.country_of_residence = row.Cells["Column11"].Value?.ToString();
                details.destination = row.Cells["Column12"].Value?.ToString();
                details.ticket_no = row.Cells["Column13"].Value?.ToString();
                details.remarks = row.Cells["Column14"].Value?.ToString();
                details.customer_book_code = row.Cells["Column15"].Value?.ToString();
                details.cabin = row.Cells["Column16"].Value?.ToString();
                details.pax_type = row.Cells["Column17"].Value?.ToString();
                details.bag_allowance = Convert.ToInt32(row.Cells["Column18"].Value);
                details.additional_bag_allowance = Convert.ToInt32(row.Cells["Column19"].Value);
                details.security_program_flag = row.Cells["Column20"].Value?.ToString();
                details.membership_no = row.Cells["Column21"].Value?.ToString();
                details.check_in = Convert.ToInt32(row.Cells["Column22"].Value);
                details.source_check_in = row.Cells["Column23"].Value?.ToString();
                details.ssr = new List<string>();
                if (row.Cells["Column24"].Value != null)
                {
                    string[] values = row.Cells["Column24"].Value?.ToString().Split(',').Select(value => value.Trim()).ToArray();
                    foreach (string value in values)
                    {
                        details.ssr.Add(value);
                    }
                }

                pax_details = pax_details.Concat(new PaxDetailsAdd[] { details }).ToArray();
            }
            for (int i = dataGridView1.Rows.Count - 1; i >= 0; i--)
            {
                DataGridViewRow row = dataGridView1.Rows[i];
                bool shouldRemoveRow = false;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value == null || cell.Value == DBNull.Value)
                    {
                        shouldRemoveRow = true;
                        break;
                    }
                }

                if (row.IsNewRow || shouldRemoveRow)
                {
                    indexesToRemove.Add(i);
                }
            }
            Array.Resize(ref pax_details, pax_details.Length - indexesToRemove.Count);
            var response = await Helper.AddPax(token, textBox1.Text, textBox2.Text, pax_details);
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
        private void AddDefaultValue()
        {
            int rowIndex = 0;
            // passport_type
            dataGridView1.Rows[rowIndex].Cells["Column1"].Value = "ABC34501";
            //details.passport_type
            dataGridView1.Rows[rowIndex].Cells["Column2"].Value = "PA";
            //details.last_name
            dataGridView1.Rows[rowIndex].Cells["Column3"].Value = "Doe";
            //details.first_name
            dataGridView1.Rows[rowIndex].Cells["Column4"].Value = "John";
            //details.gender
            dataGridView1.Rows[rowIndex].Cells["Column5"].Value = "M";
            //details.nationality
            dataGridView1.Rows[rowIndex].Cells["Column6"].Value = "SGP";
            //details.dob
            dataGridView1.Rows[rowIndex].Cells["Column7"].Value = "19830219";
            //details.country_of_birth
            dataGridView1.Rows[rowIndex].Cells["Column8"].Value = "SGP";
            //details.travel_doc_exp_date
            dataGridView1.Rows[rowIndex].Cells["Column9"].Value = "20261104";
            //details.country_of_issue
            dataGridView1.Rows[rowIndex].Cells["Column10"].Value = "SGP";
            //details.country_of_residence
            dataGridView1.Rows[rowIndex].Cells["Column11"].Value = "SGP";
            //details.destination
            dataGridView1.Rows[rowIndex].Cells["Column12"].Value = "TMFT";
            //details.ticket_no
            dataGridView1.Rows[rowIndex].Cells["Column13"].Value = "10032176";
            //details.remarks
            dataGridView1.Rows[rowIndex].Cells["Column14"].Value = "remarks";
            //details.customer_book_code
            dataGridView1.Rows[rowIndex].Cells["Column15"].Value = "ANJOABC1";
            //details.cabin
            dataGridView1.Rows[rowIndex].Cells["Column16"].Value = "Economy";
            //details.pax_type
            dataGridView1.Rows[rowIndex].Cells["Column17"].Value = "A";
            //details.bag_allowance
            dataGridView1.Rows[rowIndex].Cells["Column18"].Value = 10;
            //details.additional_bag_allowance
            dataGridView1.Rows[rowIndex].Cells["Column19"].Value = 20;
            //details.security_program_flag
            dataGridView1.Rows[rowIndex].Cells["Column20"].Value = "A1";
            //details.membership_no
            dataGridView1.Rows[rowIndex].Cells["Column21"].Value = "DF162";
            //details.check_in
            dataGridView1.Rows[rowIndex].Cells["Column22"].Value = 1;
            //details.source_check_in
            dataGridView1.Rows[rowIndex].Cells["Column23"].Value = "FCI";
            //details.ssr
            dataGridView1.Rows[rowIndex].Cells["Column24"].Value = "VJML,BG30";
        }
    }
}
