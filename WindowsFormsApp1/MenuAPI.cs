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
    }
}
