// Program 2
// CIS 200-50
// Fall 2021
// Due: 10/28/2021
// Stduent ID: 5129153

using UVPApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UPVApp
{
    public partial class Prog2Form : Form
    {
        private UserParcelView upv;  // UserParcelView

        // precondition: none
        // postcondition: test addresses and parcels added, form displayed
        public Prog2Form()
        {
            InitializeComponent();

            upv = new UserParcelView();

            // test addresses
            upv.AddAddress("Mary Lamb", "1000 Goat Lane", "Louisville", "KY", 40000);
            upv.AddAddress("Bob Smith", "2000 Tree St", "Chicago", "IL", 60000);
            upv.AddAddress("Kevin Cheese", "3000 Ocean Dr", "Gary", "IN", 80000);
            upv.AddAddress("Jane Fondue", "4000 Mountain Rd", "Milwaukee", "WI", 20000);
            upv.AddAddress("Kelly Blue", "5000 Snow Ln", "Chicago", "IL", 30000);

            // test parcels
            upv.AddLetter(upv.AddressAt(1), upv.AddressAt(2), 1.00M);
            upv.AddNextDayAirPackage(upv.AddressAt(3), upv.AddressAt(2), 10, 5, 5, 10, 20.00M);
            upv.AddGroundPackage(upv.AddressAt(1), upv.AddressAt(3), 6, 5, 2, 7);
            upv.AddTwoDayAirPackage(upv.AddressAt(2), upv.AddressAt(4), 4, 2, 7, 3, TwoDayAirPackage.Delivery.Early);

        }

        // precondition: about option is clicked under file menu
        // postcondition: information about student and program are shown
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Grading ID: 5129153 \n" +
                "CIS 200-50 \n" +
                "Fall 2021 \n" +
                "Due: 10/28/2021");
        }

        // precondition: exit option is clicked under file menu
        // postcondition: program closes
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // precondition: address option is clicked under insert menu
        // postcondition: address form is displayed, if validated, data is stored
        private void addressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddressForm addressForm = new AddressForm(); // address form
            DialogResult result = addressForm.ShowDialog(); // store address form data
            int zipCode = 00000; // zip code variable for validation

            if (result ==  DialogResult.OK)
            {
                if (int.TryParse(addressForm.ZipText, out zipCode))
                {
                    upv.AddAddress(addressForm.AddressName, addressForm.Address1,
                    addressForm.Address2, addressForm.City, addressForm.State, zipCode);
                }
            }
            
        }

        // precondition: insert letter is clicked under insert menu
        // postcondition: letter form is displayed, if validated, data is stored
        private void letterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LetterForm letterForm; // letter form
            letterForm = new LetterForm(upv.AddressList); // store list of address
            DialogResult result = letterForm.ShowDialog(); // store letter form data
            decimal fixedCost = 0.00M; // fixed cost variable for validation

            if (result == DialogResult.OK)
            {
                upv.AddLetter(upv.AddressAt(letterForm.OriginAddressSelect), 
                upv.AddressAt(letterForm.DestinationAddressSelect), fixedCost);
            }
        }

        // precondition: user requests report list of addresses
        // postcondition: report text box is cleared then addresses are displayed
        private void listAddressesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string NL = Environment.NewLine; // new line abbrv.

            reportTextBox.Clear();
            reportTextBox.AppendText($"List of Addresses: {NL}" +
                $"{NL}");

            foreach (Address a in upv.AddressList)
            {
                reportTextBox.AppendText(a.ToString());
                reportTextBox.AppendText($"{NL}{NL}********** {NL}");
            }
        }

        // precondition: user requests report list of parcels
        // postcondition: report text box is cleared parcels are displayed
        private void listParcelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string NL = Environment.NewLine; // new line abbrv.
            decimal runningTotal = 0; // decimal for running total

            reportTextBox.Clear(); 
            reportTextBox.AppendText($"List of Parcels: {NL}" +
                $"{NL}");

            foreach (Parcel p in upv.ParcelList)
            {
                reportTextBox.AppendText(p.ToString());
                reportTextBox.AppendText($"{NL}{NL}********** {NL}");
                runningTotal = +p.CalcCost();
            }

            reportTextBox.AppendText($"{NL}Total Cost of Parcels: {NL}" +
                $"{runningTotal:C2}");
        }
    }
}
