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

namespace WindowsFormsApp1
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
            CancelPaxRecord cancelpax = new CancelPaxRecord(Token);
            cancelpax.Show();
        }

        private void btngetvessel_Click(object sender, EventArgs e)
        {
            GetVesselCodeRecord getVesselCode = new GetVesselCodeRecord(Token);
            getVesselCode.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetTerminalListRecord getTerminalList = new GetTerminalListRecord(Token);
            getTerminalList.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GetTripInfoRecord getTripInfoRecord = new GetTripInfoRecord(Token);
            getTripInfoRecord.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GetTripList getTripList = new GetTripList(Token);
            getTripList.Show();
        }
    }
}
