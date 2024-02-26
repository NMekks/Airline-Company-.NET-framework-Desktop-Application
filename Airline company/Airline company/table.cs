using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Airline_company.Ticket;

namespace Airline_company
{
    public partial class Record : Form
    {
        public Record()
        {
            InitializeComponent();
        }
        FlightDetails f1 = new FlightDetails();
        
        passengerscs pg = new passengerscs();

        public int passenger { get; set; }
        public string gender { get; set; }
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

        private void table_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'airLineDataSet.PassengerInfo1' table. You can move, or remove it, as needed.
            //this.passengerInfo1TableAdapter.Fill(this.airLineDataSet.PassengerInfo1);
            DataTable dt = pg.Select();
            dgvPassenger.DataSource = dt;



        }

        private void dgvPassenger_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;

            //f1.assigned(a)

            passenger = Convert.ToInt32(dgvPassenger.Rows[i].Cells[0].Value);
            title = dgvPassenger.Rows[i].Cells[1].Value.ToString();
            passportnumber = dgvPassenger.Rows[i].Cells[2].Value.ToString();
            ped = dgvPassenger.Rows[i].Cells[3].Value.ToString();
            firstname = dgvPassenger.Rows[i].Cells[4].Value.ToString();
            lastname = dgvPassenger.Rows[i].Cells[5].Value.ToString();
            if (dgvPassenger.Rows[i].Cells[6].Value.ToString().Contains("Male"))
            {
                gender = "Male";
            }
            else if (dgvPassenger.Rows[i].Cells[6].Value.ToString().Contains("Female"))
            {
                gender = "Female";
            }
           // gender = dgvPassenger.Rows[i].Cells[6].Value.ToString();
            nationality = dgvPassenger.Rows[i].Cells[7].Value.ToString();
            primarycontact = dgvPassenger.Rows[i].Cells[8].Value.ToString();
            countrycode = dgvPassenger.Rows[i].Cells[9].Value.ToString();
            phonenumber = dgvPassenger.Rows[i].Cells[10].Value.ToString();
            email = dgvPassenger.Rows[i].Cells[11].Value.ToString();
            from = dgvPassenger.Rows[i].Cells[12].Value.ToString();
            to= dgvPassenger.Rows[i].Cells[13].Value.ToString();
            departdate = dgvPassenger.Rows[i].Cells[14].Value.ToString();
            returndate = dgvPassenger.Rows[i].Cells[15].Value.ToString();
            Tickettype = dgvPassenger.Rows[i].Cells[16].Value.ToString();
            Class = dgvPassenger.Rows[i].Cells[17].Value.ToString();
           
            f1.passenger = passenger;
            f1.title = title;
            f1.passportnumber = passportnumber;
            f1.ped = ped;
            f1.firstname = firstname;
            f1.lastname = lastname;
            f1.gender = gender;
            f1.nationality = nationality;
            f1.primarycontact= primarycontact;
            f1.countrycode = countrycode;
            f1.phonenumber = phonenumber;   
            f1.email = email;
            f1.from =from;
            f1.to =to;
            f1.departdate = departdate;
            f1.returndate = returndate;
            f1.Tickettype = Tickettype;
            f1.Class = Class;

            

            this.Hide();
            f1.ShowDialog();
          

        }

        private void dgvPassenger_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            string key = txtsearch.Text;
            DataTable dt = new DataTable();

            if(pg.Search(key,dt))
            {
               dgvPassenger.DataSource = dt;
            }
            else
            {
                MessageBox.Show("The Information does not exist in the table");
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            f1.ShowDialog();
           this.Close();


        }
    }
}
