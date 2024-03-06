using System;
using System.Windows.Forms;
using SPOSAPIDemo.API_Helper;

namespace SPOSAPIDemo
{
    public partial class Login : Form
    {
        private static string Token;
        public Login()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {

                var response = await Helper.Login(textBox1.Text, textBox2.Text);
                if (!string.IsNullOrEmpty(response.error))
                {
                    MessageBox.Show(response.error);
                }
                else
                {
                    Token = response.data;
                }
                MenuAPI menu = new MenuAPI(Token);
                menu.ShowDialog();
                this.Close();

            }
            else
                MessageBox.Show("Please enter values for both fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
