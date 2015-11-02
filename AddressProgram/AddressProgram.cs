using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressProgram
{ 

    public partial class frmAddressProgram : Form
    {

        public void AddressListing(string aptNumber, string streetAddress, string city, string province, string postalCode)
        {
            MessageBox.Show(aptNumber + "\n" + streetAddress + "\n" + city + "\n" + province + "\n" + postalCode, "Address Listing");
        }

        public void AddressListing(string streetAddress, string city, string province, string postalCode)
        {
            MessageBox.Show(streetAddress + "\n" + city + "\n" + province + "\n" + postalCode, "Address Listing");
        }

        public frmAddressProgram()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string aptNumber;
            string streetAddress;
            string city;
            string province;
            string postalCode;

            aptNumber = this.txtAptNumber.Text;
            streetAddress = this.txtStreetAdress.Text; //Convert.ToString(this.txtStreetAdress);
            city = this.txtCity.Text;
            province = this.txtProvince.Text;
            postalCode = this.txtPostalCode.Text;

            AddressListing(aptNumber, streetAddress, city, province, postalCode);

        }
    }
}