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
    public partial class AddressForm : Form
    {
        // precondition: none
        // postcondition: AddressForm GUI initialized
        public AddressForm()
        {
            InitializeComponent();
            
            // list of states
            List<string> states = new List<string>
            {
                "IL","IN","WI", "KY"
            }; 

            // foreach loop to add states to combo box
            foreach (string state in states)
            {
                stateComboBox.Items.Add(state);
            }
        }

        internal string AddressName
        {
            // precondition: none
            // postcondition: text in nameTextBox is returned
            get
            {
                return nameTextBox.Text;
            }

            // precondition: value must not be null
            // postcondition: text in nameTextBox is set to value
            set
            {
                nameTextBox.Text = value;
            }
        }

        internal string Address1
        {
            // precondition: none
            // postcondition: text in addressLine1TextBox is returned
            get
            {
                 return addressLine1TextBox.Text;
            }

            // precondition:
            // postcondition: text in addressLine1TextBox is set to value
            set
            {
                 addressLine1TextBox.Text = value;
            }
        }

        internal string Address2
        {
            // precondition: none
            // postcondition: text in addressLine2TextBox is returned
            get
            {
                return addressLine2TextBox.Text;
            }

            // precondition: none
            // postcondition: text in addressLine2TextBox is set to value
            set
            {
                addressLine2TextBox.Text = value;
            }
        }

        internal string City
        {
            // precondition: none
            // postcondition: text in cityTextBox is returned
            get
            {
                return cityTextBox.Text;
            }

            // precondition: none
            // postcondition: text in cityTextBox is set to value
            set
            {
                cityTextBox.Text = value;
            }
        }

        internal string ZipText
        {
            // precondition: none
            // postcondition: text in zipCodeTextBox is returned
            get
            {
                return zipCodeTextBox.Text;
            }

            // precondition: none
            // postcondition: text in zipCodeTextBox is set to value
            set
            {
                zipCodeTextBox.Text = value;
            }
        }

        internal string State
        {
            // precondition: none
            // postcondition: text in stateComboBox is returned
            get
            {
                if (stateComboBox.SelectedIndex != -1)
                {
                    return stateComboBox.SelectedItem.ToString();
                }
                else
                {
                    return "";
                }
            }

            // precondition: value must be from stateComboBox list
            // postcondition: text in stateTextBox is set to value
            set
            {
                stateComboBox.SelectedItem = value;
            }
        }


        // precondition: changing focus from name text box
        // postcondition: shows error, selects field and says field cannot be blank
        private void nameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(nameTextBox.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(nameTextBox, "Name cannot be blank");
            }
            else
                errorProvider.SetError(nameTextBox, ""); // clear error if valid
        }

        // precondition: changing focus from address 1 text box
        // postcondition: shows error, selects field and says field cannot be blank
        private void addressLine1TextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(addressLine1TextBox.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(addressLine1TextBox, "Address cannot be blank");
            }
            else
                errorProvider.SetError(addressLine1TextBox, ""); // clear error if valid
        }

        // precondition: changing focus from city text box
        // postcondition: shows error, selects field and says field cannot be blank
        private void cityTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cityTextBox.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(cityTextBox, "City cannot be blank");
            }
            else
                errorProvider.SetError(cityTextBox, ""); // clear error if valid
        }

        // precondition: changing focus from state combo box
        // postcondition: shows error, selects all text in field and asks
        // to select state from list
        private void stateComboBox_Validating (object sender, CancelEventArgs e)
        {
            if (stateComboBox.SelectedIndex == -1 || string.IsNullOrEmpty(stateComboBox.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(stateComboBox, "Select a state from list");
            }
            else
                errorProvider.SetError(stateComboBox, ""); // clear error if valid
        }

        // precondition: changing focus from zip code text box
        // postcondition: shows error, selects all text in field and asks
        // for valid zip code
        private void zipCodeTextBox_Validating (object sender, CancelEventArgs e)
        {
            int zipCode; // address zip code

            if (!int.TryParse(zipCodeTextBox.Text, out zipCode) 
                || (zipCode < Address.MIN_ZIP) || (zipCode > Address.MAX_ZIP))
            {
                e.Cancel = true;
                zipCodeTextBox.SelectAll();
                errorProvider.SetError(zipCodeTextBox, "Enter valid zip code (integer between 00000 - 99999");
            }
            else
                errorProvider.SetError(zipCodeTextBox, ""); // clear error if valid
        }

        // precondition: ok button clicked
        // postcondition: address form submitted after validation successful
        private void okAddressFormButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        // precondition: cancel button clicked
        // postcondition: address form cancelled
        private void cancelAddressFormButton_Click(object sender, EventArgs e)
        {
                this.DialogResult = DialogResult.Cancel;
        }
    }
}
