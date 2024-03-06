using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPOSAPIDemo
{
    public partial class MenuAPI : Form
    {
        private static string Token;
        public MenuAPI(string token)
        {
            InitializeComponent();
            Token = token;
        }

        private void btnaddpax_Click(object sender, EventArgs e)
        {
            AddPaxRecord addpax = new AddPaxRecord(Token);
            addpax.Show();
        }

        private void btnupdatepax_Click(object sender, EventArgs e)
        {
            UpdatePaxRecord updatepax = new UpdatePaxRecord(Token);
            updatepax.Show();
        }

        private void btncancelpax_Click(object sender, EventArgs e)
        {
            CancelPax cancelpax = new CancelPax(Token);
            cancelpax.Show();
        }

        private void btngetvessel_Click(object sender, EventArgs e)
        {
            GetVesselCode getVesselCode = new GetVesselCode(Token);
            getVesselCode.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetTerminalList getTerminalList = new GetTerminalList(Token);
            getTerminalList.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GetTripInfo getTripInfoRecord = new GetTripInfo(Token);
            getTripInfoRecord.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GetTripList getTripList = new GetTripList(Token);
            getTripList.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SubmitCheckIn submitCheckIn = new SubmitCheckIn(Token);
            submitCheckIn.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            GetPaxDetail getPaxDetail = new GetPaxDetail(Token);
            getPaxDetail.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GetPaxList getPaxList = new GetPaxList(Token);  
            getPaxList.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GetPaxInfo getPaxInfo = new GetPaxInfo(Token);
            getPaxInfo.Show();
        }

    }
}
