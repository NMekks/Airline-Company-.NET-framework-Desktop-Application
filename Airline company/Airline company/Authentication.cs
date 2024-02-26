using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Airline_company.Loginclass;

namespace Airline_company
{
    public partial class Authentication : Form
    {
        public Authentication()
        {
            InitializeComponent();
        }


         loginclass lc = new loginclass();
        private void button1_Click(object sender, EventArgs e)
        {


            lc.username = txtusername.Text;
            lc.password = txtpassword.Text;

            bool added = lc.ReadData(lc);

            if (added == true)
            {

               MessageBox.Show("Login Successful");

                this.Hide();
                FlightDetails form2 = new FlightDetails();
                form2.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Your Credentials Are Incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void Authontication_Load(object sender, EventArgs e)
        {

        }
    }
}
