// Program 2
// CIS 200-50
// Fall 2021
// Due: 10/28/2021
// Stduent ID: 5129153

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UVPApp
{
    public partial class LetterForm : Form
    {
        private List<Address> addressList; // list for combobox

        // precondition: none
        // postcondition: Letterform GUI initialized
        public LetterForm(List<Address> addresses)
        {
            addressList = addresses;
            InitializeComponent();

            // foreach loop to add addresses to combo box
            foreach (Address a in addressList)
            {
                originCombo.Items.Add(a.Name);
                destCombo.Items.Add(a.Name);
            }
        }

        internal int OriginAddressSelect
        {
            // precondition: selected option from combo box
            // postcondition: index option returned
            get
            {
                return originCombo.SelectedIndex;
            }

            // precondition: value must be within range of index options
            // postcondition: index # is set to value
            set
            {
                if ((value != -1) && (value < addressList.Count))
                {
                    originCombo.SelectedIndex = value;
                }
                else
                    MessageBox.Show("must be valid)");
            }
        }

        internal int DestinationAddressSelect
        {
            // precondition: selected option from combo box
            // postcondition: index option returned
            get
            {
                return destCombo.SelectedIndex;
            }

            // precondition: value must be within range of index options
            // postcondition: index # is set to value
            set
            {
                if ((value != -1) && (value < addressList.Count))
                {
                    destCombo.SelectedIndex = value;
                }
                else
                    MessageBox.Show("must be valid)");
            }
        }

        internal string FixedCost
        {
            // precondition: none
            // postcondition: fixed cost returned
            get
            {
                return fixedCostTextBox.Text;
            }

            // precondition: none
            // postcondition: fixed cost is set to value
            set
            {
                fixedCostTextBox.Text = value;
            }
        }

        // precondition: changing focus from origin address combo box
        // postcondition: shows error, asks to select address or different address 
        //  if selections are the same
        private void originCombo_Validating(object sender, CancelEventArgs e)
        {
            if (originCombo.SelectedIndex != -1 && originCombo.SelectedIndex == destCombo.SelectedIndex)
            {
                e.Cancel = true;
                errorProvider1.SetError(originCombo, "Address selection cannot be the same");
            }
            else if (originCombo.SelectedIndex == -1)
            {
                e.Cancel = true;
                errorProvider1.SetError(originCombo, "Must select address");
            }
            else
                errorProvider1.SetError(originCombo, ""); // clear error if valid
        }

        // precondition: changing focus from destination address combo box
        // postcondition: shows error, asks to select address or different address 
        //  if selections are the same
        private void destCombo_Validating(object sender, CancelEventArgs e)
        {
            if (destCombo.SelectedIndex != -1 && originCombo.SelectedIndex == destCombo.SelectedIndex)
            {
                e.Cancel = true;
                errorProvider1.SetError(destCombo, "Address selection cannot be the same");
            }
            else if (destCombo.SelectedIndex == -1)
            {
                e.Cancel = true;
                errorProvider1.SetError(destCombo, "Must select address");
            }
            else
                errorProvider1.SetError(destCombo, ""); // clear error if valid
        }

        // precondition: changing focus from fixed cost text box
        // postcondition: shows error, asks to enter valid cost
        private void fixedCost_Validating(object sender, CancelEventArgs e)
        {
            int fixedCost; // fixed cost

            if (!int.TryParse(fixedCostTextBox.Text, out fixedCost)
                || (fixedCost < 0 ))
            {
                e.Cancel = true;
                fixedCostTextBox.SelectAll();
                errorProvider1.SetError(fixedCostTextBox, "Enter valid decimal (greater than or equal to $0.00)");
            }
            else
                errorProvider1.SetError(fixedCostTextBox, ""); // clear error if valid
        }

        // precondition: ok button clicked
        // postcondition: letter form submitted after validation successful
        private void okButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        // precondition: cancel button clicked
        // postcondition: letter form cancelled
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
    }
