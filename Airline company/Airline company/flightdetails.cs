using Airline_company.Ticket;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline_company
{
    public partial class FlightDetails : Form
    {
        public FlightDetails()
        {
            InitializeComponent();
        }

        passengerscs obj = new passengerscs();
        public int passenger { get; set; }
        public string gender { get; set; }
        public string gendero { get; set; }
        public string Class { get; set; }
        public string title { get; set; }
        public string Tickettype { get; set; }
        public string passportnumber { get; set; }
        public string countrycode { get; set; }
        public string primarycontact { get; set; }
        public string nationality { get; set; }
        public string email { get; set; }
        public string from { get; set; }
        public string to { get; set; }
        public string ped { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string returndate { get; set; }
        public string departdate { get; set; }
        public string phonenumber { get; set; }
        
        

       

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnnext_Click(object sender, EventArgs e)
        {

            this.Hide();
            Record form2 = new Record();
            form2.ShowDialog();
            this.Close();



        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (cbadult.Checked)
            {
                Tickettype = cbadult.Text;
            }
            if (cbchild.Checked)
            {
                Tickettype = cbchild.Text;
            }
            if (cbinfant.Checked)
            {
                Tickettype = cbinfant.Text;
            }
            if (rdobusiness.Checked)
            {
                Class = rdobusiness.Text;
            }
            if (rdoeconomy.Checked)
            {
                Class = rdoeconomy.Text;
            }
            if (rdofirstclass.Checked)
            {
                Class = rdofirstclass.Text;
            }
            if (cbMR.Checked)
            {
                title = cbMR.Text;
            }
            if (cbMRS.Checked)
            {
                title = cbMRS.Text;
            }
            if (cbMS.Checked)
            {
                title = cbMS.Text;
            }
            if (rdoM.Checked)
            {
                gendero = rdoM.Text;
            }
            if (rdofemale.Checked)
            {
                gendero = rdofemale.Text;
            }

           

            obj.Title = title;
            obj.PassportNumber = txtpassportno.Text;
            obj.PED = dtpPED.Text;
            obj.FirstName = txtfirstname.Text;
            obj.LastName = txtlastname.Text;
            obj.Gender = gendero;
            obj.Nationality = cbonationality.Text;
            obj.PrimaryContact = txtprimary.Text;
            obj.CountryCode = cbcountry.Text;
            obj.PhoneNumber= txtphone.Text;
            obj.Email = txtemail.Text;  
            obj.CityFrom = cbofrom.Text;
            obj.CityTo = cboto.Text;
            obj.DepartDate = dtpdepart.Text;
            obj.ReturnDate = dtpreturn.Text;
            obj.TicketType = Tickettype;
            obj.Class = Class;
            bool Success = obj.Insert(obj);
            if (Success)
            {

                MessageBox.Show("Record has been saved.");
                Clear();
            }
            else
            {
                MessageBox.Show("Record has not been saved.");
            }
            gendero = "";

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (cbadult.Checked)
            {
                Tickettype = cbadult.Text;
            }
            if (cbchild.Checked)
            {
                Tickettype = cbchild.Text;
            }
            if (cbinfant.Checked)
            {
                Tickettype = cbinfant.Text;
            }
            if (rdobusiness.Checked)
            {
                Class = rdobusiness.Text;
            }
            if (rdoeconomy.Checked)
            {
                Class = rdoeconomy.Text;
            }
            if (rdofirstclass.Checked)
            {
                Class = rdofirstclass.Text;
            }
            if (cbMR.Checked)
            {
                title = cbMR.Text;
            }
            if (cbMRS.Checked)
            {
                title = cbMRS.Text;
            }
            if (cbMS.Checked)
            {
                title = cbMS.Text;
            }
            if (rdoM.Checked)
            {
                gendero = rdoM.Text;
            }
            if (rdofemale.Checked)
            {
                gendero = rdofemale.Text;
            }

            string pass = txtPassangerNo.Text;
            obj.Title = title;
            obj.PassportNumber = txtpassportno.Text;
            obj.PED = dtpPED.Text;
            obj.FirstName = txtfirstname.Text;
            obj.LastName = txtlastname.Text;
            obj.Gender = gendero;
            obj.Nationality = cbonationality.Text;
            obj.PrimaryContact = txtprimary.Text;
            obj.CountryCode = cbcountry.Text;
            obj.PhoneNumber = txtphone.Text;
            obj.Email = txtemail.Text;
            obj.CityFrom = cbofrom.Text;
            obj.CityTo = cboto.Text;
            obj.DepartDate = dtpdepart.Text;
            obj.ReturnDate = dtpreturn.Text;
            obj.TicketType = Tickettype;
            obj.Class = Class;

            // Call the Update method and pass the passengerscs object and the PassportNumber
            bool success = obj.Update(obj, pass);

            if (success)
            {
                // Update successful
                MessageBox.Show("Record has been updated.");
                Clear();
            }
            else
            {
                // Update failed
                MessageBox.Show("Please try again.");
            }

          


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtPassangerNo.Text = Convert.ToString(passenger);
            title = title;
            txtpassportno.Text = passportnumber;
            dtpPED.Text = ped;
            txtfirstname.Text = firstname;
            txtlastname.Text = lastname;
            cbonationality.Text = nationality;
            txtprimary.Text = primarycontact;
            cbcountry.Text = countrycode;
            txtphone.Text = phonenumber;
            txtemail.Text=email;
            cbofrom.Text = from;
            cboto.Text= to;
            dtpdepart.Text=departdate;
            dtpreturn.Text=returndate;

            



        }

        private void btndelete_Click(object sender, EventArgs e)
        {

            DialogResult dialog = MessageBox.Show("Are you sure you want to delete this record?", "Record Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);  

            if(dialog == DialogResult.Yes)
            {
                obj.PassengerNumber = passenger;

                bool success = obj.Delete(obj);
                MessageBox.Show("Record has been deleted successfully.");

                // Load DGV from DB
                Clear();
            }
            else
            {
                //MessageBox.Show("Delete Failed");
            }

          
        }

        private void cbcountry_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public void Clear()
        {
            txtemail.Text = "";
            txtfirstname.Text = "";
            txtlastname.Text = "";
            txtPassangerNo.Text = "";
            txtpassportno.Text = "";
            txtphone.Text = "";
            txtprimary.Text = "";
            cbadult.Checked = false;
            cbchild.Checked = false;
            cbcountry.Text = "";
            cbinfant.Checked = false;
            cbMR.Checked = false;
            cbMRS.Checked = false;
            cbMS.Checked = false;
            cbofrom.Text = "";
            cbonationality.Text = "";
            cboto.Text = "";
            rdobusiness.Checked = false;
            rdoeconomy.Checked = false;
            rdofemale.Checked = false;
            rdofirstclass.Checked = false;
            rdoM.Checked = false;
            dtpdepart.Text = "";
            dtpPED.Text = "";
            dtpreturn.Text = "";
        }
    }
}
