
namespace UVPApp
{
    partial class AddressForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.nameLabel = new System.Windows.Forms.Label();
            this.addressLine1Label = new System.Windows.Forms.Label();
            this.addressLine2Label = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.stateLabel = new System.Windows.Forms.Label();
            this.zipCodeLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.addressLine1TextBox = new System.Windows.Forms.TextBox();
            this.addressLine2TextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.zipCodeTextBox = new System.Windows.Forms.TextBox();
            this.stateComboBox = new System.Windows.Forms.ComboBox();
            this.okAddressFormButton = new System.Windows.Forms.Button();
            this.cancelAddressFormButton = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(55, 13);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name:";
            // 
            // addressLine1Label
            // 
            this.addressLine1Label.AutoSize = true;
            this.addressLine1Label.Location = new System.Drawing.Point(13, 35);
            this.addressLine1Label.Name = "addressLine1Label";
            this.addressLine1Label.Size = new System.Drawing.Size(80, 13);
            this.addressLine1Label.TabIndex = 1;
            this.addressLine1Label.Text = "Address Line 1:";
            // 
            // addressLine2Label
            // 
            this.addressLine2Label.AutoSize = true;
            this.addressLine2Label.Location = new System.Drawing.Point(13, 57);
            this.addressLine2Label.Name = "addressLine2Label";
            this.addressLine2Label.Size = new System.Drawing.Size(80, 13);
            this.addressLine2Label.TabIndex = 2;
            this.addressLine2Label.Text = "Address Line 2:";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(66, 79);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(27, 13);
            this.cityLabel.TabIndex = 3;
            this.cityLabel.Text = "City:";
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(58, 101);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(35, 13);
            this.stateLabel.TabIndex = 4;
            this.stateLabel.Text = "State:";
            // 
            // zipCodeLabel
            // 
            this.zipCodeLabel.AutoSize = true;
            this.zipCodeLabel.Location = new System.Drawing.Point(40, 123);
            this.zipCodeLabel.Name = "zipCodeLabel";
            this.zipCodeLabel.Size = new System.Drawing.Size(53, 13);
            this.zipCodeLabel.TabIndex = 5;
            this.zipCodeLabel.Text = "Zip Code:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(99, 10);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 6;
            this.nameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.nameTextBox_Validating);
            // 
            // addressLine1TextBox
            // 
            this.addressLine1TextBox.Location = new System.Drawing.Point(99, 33);
            this.addressLine1TextBox.Name = "addressLine1TextBox";
            this.addressLine1TextBox.Size = new System.Drawing.Size(100, 20);
            this.addressLine1TextBox.TabIndex = 7;
            this.addressLine1TextBox.Validating += new System.ComponentModel.CancelEventHandler(this.addressLine1TextBox_Validating);
            // 
            // addressLine2TextBox
            // 
            this.addressLine2TextBox.Location = new System.Drawing.Point(99, 56);
            this.addressLine2TextBox.Name = "addressLine2TextBox";
            this.addressLine2TextBox.Size = new System.Drawing.Size(100, 20);
            this.addressLine2TextBox.TabIndex = 8;
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(99, 79);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(100, 20);
            this.cityTextBox.TabIndex = 9;
            this.cityTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.cityTextBox_Validating);
            // 
            // zipCodeTextBox
            // 
            this.zipCodeTextBox.Location = new System.Drawing.Point(99, 126);
            this.zipCodeTextBox.Name = "zipCodeTextBox";
            this.zipCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.zipCodeTextBox.TabIndex = 10;
            this.zipCodeTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.zipCodeTextBox_Validating);
            // 
            // stateComboBox
            // 
            this.stateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stateComboBox.FormattingEnabled = true;
            this.stateComboBox.Location = new System.Drawing.Point(99, 102);
            this.stateComboBox.Name = "stateComboBox";
            this.stateComboBox.Size = new System.Drawing.Size(100, 21);
            this.stateComboBox.TabIndex = 11;
            this.stateComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.stateComboBox_Validating);
            // 
            // okAddressFormButton
            // 
            this.okAddressFormButton.Location = new System.Drawing.Point(25, 158);
            this.okAddressFormButton.Name = "okAddressFormButton";
            this.okAddressFormButton.Size = new System.Drawing.Size(75, 23);
            this.okAddressFormButton.TabIndex = 12;
            this.okAddressFormButton.Text = "OK";
            this.okAddressFormButton.UseVisualStyleBackColor = true;
            this.okAddressFormButton.Click += new System.EventHandler(this.okAddressFormButton_Click);
            // 
            // cancelAddressFormButton
            // 
            this.cancelAddressFormButton.Location = new System.Drawing.Point(131, 158);
            this.cancelAddressFormButton.Name = "cancelAddressFormButton";
            this.cancelAddressFormButton.Size = new System.Drawing.Size(75, 23);
            this.cancelAddressFormButton.TabIndex = 13;
            this.cancelAddressFormButton.Text = "Cancel";
            this.cancelAddressFormButton.UseVisualStyleBackColor = true;
            this.cancelAddressFormButton.Click += new System.EventHandler(this.cancelAddressFormButton_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // AddressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 193);
            this.Controls.Add(this.cancelAddressFormButton);
            this.Controls.Add(this.okAddressFormButton);
            this.Controls.Add(this.stateComboBox);
            this.Controls.Add(this.zipCodeTextBox);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.addressLine2TextBox);
            this.Controls.Add(this.addressLine1TextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.zipCodeLabel);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.addressLine2Label);
            this.Controls.Add(this.addressLine1Label);
            this.Controls.Add(this.nameLabel);
            this.Name = "AddressForm";
            this.Text = "AddressForm";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label addressLine1Label;
        private System.Windows.Forms.Label addressLine2Label;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.Label zipCodeLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox addressLine1TextBox;
        private System.Windows.Forms.TextBox addressLine2TextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox zipCodeTextBox;
        private System.Windows.Forms.ComboBox stateComboBox;
        private System.Windows.Forms.Button okAddressFormButton;
        private System.Windows.Forms.Button cancelAddressFormButton;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}