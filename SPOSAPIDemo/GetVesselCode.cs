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
using System.Net;
using System.Web.UI.WebControls;

namespace SPOSAPIDemo
{
    public partial class GetVesselCode : Form
    {
        private static string token;
        public GetVesselCode(string Token)
        {
            InitializeComponent();
            token = Token;
        }

        private async void btnClickGetVesselCode_Click(object sender, EventArgs e)
        {
            var response = await Helper.GetVesselCode(token);
            if (!string.IsNullOrEmpty(response.error))
            {
                MessageBox.Show(response.error);
            }
            else
            {
                foreach (VesselPaxCode a in response.data)
                {
                    dataGridView2.Rows.Add(a.vessel_id, a.reg_country, a.vessel_name,
                                            a.vessel_owner, a.insurance_company, a.insurance_policy_no,
                                            a.vessel_type,
                                            a.insurance_expiry_date,
                                            a.eids_short_name,
                                            a.vessel_call_sign_type,
                                            a.grt,
                                            a.vessel_length,
                                            a.vessel_width,
                                            a.insurance_reminder_date,
                                            a.date_created,
                                            a.create_by,
                                            a.date_updated,
                                            a.update_by,
                                            a.remark,
                                            a.crew_cap,
                                            a.pax_cap,
                                            a.total_cap,
                                            a.status);
                }
                txterr_msg.Text = response.err_msg;
                txterr_num.Text = response.err_num;
            }
        }
    }
}
