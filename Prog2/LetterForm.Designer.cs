
namespace UVPApp
{
    partial class LetterForm
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
            this.originLabel = new System.Windows.Forms.Label();
            this.destLabel = new System.Windows.Forms.Label();
            this.fixedCostLabel = new System.Windows.Forms.Label();
            this.originCombo = new System.Windows.Forms.ComboBox();
            this.destCombo = new System.Windows.Forms.ComboBox();
            this.fixedCostTextBox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // originLabel
            // 
            this.originLabel.AutoSize = true;
            this.originLabel.Location = new System.Drawing.Point(52, 25);
            this.originLabel.Name = "originLabel";
            this.originLabel.Size = new System.Drawing.Size(78, 13);
            this.originLabel.TabIndex = 0;
            this.originLabel.Text = "Origin Address:";
            // 
            // destLabel
            // 
            this.destLabel.AutoSize = true;
            this.destLabel.Location = new System.Drawing.Point(26, 61);
            this.destLabel.Name = "destLabel";
            this.destLabel.Size = new System.Drawing.Size(104, 13);
            this.destLabel.TabIndex = 1;
            this.destLabel.Text = "Destination Address:";
            // 
            // fixedCostLabel
            // 
            this.fixedCostLabel.AutoSize = true;
            this.fixedCostLabel.Location = new System.Drawing.Point(71, 97);
            this.fixedCostLabel.Name = "fixedCostLabel";
            this.fixedCostLabel.Size = new System.Drawing.Size(59, 13);
            this.fixedCostLabel.TabIndex = 2;
            this.fixedCostLabel.Text = "Fixed Cost:";
            // 
            // originCombo
            // 
            this.originCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.originCombo.FormattingEnabled = true;
            this.originCombo.Location = new System.Drawing.Point(136, 22);
            this.originCombo.Name = "originCombo";
            this.originCombo.Size = new System.Drawing.Size(121, 21);
            this.originCombo.TabIndex = 3;
            this.originCombo.Validating += new System.ComponentModel.CancelEventHandler(this.originCombo_Validating);
            // 
            // destCombo
            // 
            this.destCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.destCombo.FormattingEnabled = true;
            this.destCombo.Location = new System.Drawing.Point(136, 58);
            this.destCombo.Name = "destCombo";
            this.destCombo.Size = new System.Drawing.Size(121, 21);
            this.destCombo.TabIndex = 4;
            this.destCombo.Validating += new System.ComponentModel.CancelEventHandler(this.destCombo_Validating);
            // 
            // fixedCostTextBox
            // 
            this.fixedCostTextBox.Location = new System.Drawing.Point(136, 94);
            this.fixedCostTextBox.Name = "fixedCostTextBox";
            this.fixedCostTextBox.Size = new System.Drawing.Size(121, 20);
            this.fixedCostTextBox.TabIndex = 5;
            this.fixedCostTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.fixedCost_Validating);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(50, 144);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 6;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(158, 144);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // LetterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 199);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.fixedCostTextBox);
            this.Controls.Add(this.destCombo);
            this.Controls.Add(this.originCombo);
            this.Controls.Add(this.fixedCostLabel);
            this.Controls.Add(this.destLabel);
            this.Controls.Add(this.originLabel);
            this.Name = "LetterForm";
            this.Text = "LetterForm";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label originLabel;
        private System.Windows.Forms.Label destLabel;
        private System.Windows.Forms.Label fixedCostLabel;
        private System.Windows.Forms.ComboBox originCombo;
        private System.Windows.Forms.ComboBox destCombo;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox fixedCostTextBox;
    }
}