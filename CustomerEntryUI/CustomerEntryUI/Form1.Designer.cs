namespace CustomerEntryUI
{
    partial class Form1
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
            this.indexGroupBox = new System.Windows.Forms.GroupBox();
            this.customerAndAccountlinkLabel = new System.Windows.Forms.LinkLabel();
            this.transactionlinkLabel = new System.Windows.Forms.LinkLabel();
            this.searchCustAndAccntLinkLabel = new System.Windows.Forms.LinkLabel();
            this.indexGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // indexGroupBox
            // 
            this.indexGroupBox.Controls.Add(this.searchCustAndAccntLinkLabel);
            this.indexGroupBox.Controls.Add(this.transactionlinkLabel);
            this.indexGroupBox.Controls.Add(this.customerAndAccountlinkLabel);
            this.indexGroupBox.Location = new System.Drawing.Point(12, 47);
            this.indexGroupBox.Name = "indexGroupBox";
            this.indexGroupBox.Size = new System.Drawing.Size(260, 184);
            this.indexGroupBox.TabIndex = 0;
            this.indexGroupBox.TabStop = false;
            this.indexGroupBox.Text = "Index";
            // 
            // customerAndAccountlinkLabel
            // 
            this.customerAndAccountlinkLabel.AutoSize = true;
            this.customerAndAccountlinkLabel.Location = new System.Drawing.Point(26, 39);
            this.customerAndAccountlinkLabel.Name = "customerAndAccountlinkLabel";
            this.customerAndAccountlinkLabel.Size = new System.Drawing.Size(164, 13);
            this.customerAndAccountlinkLabel.TabIndex = 0;
            this.customerAndAccountlinkLabel.TabStop = true;
            this.customerAndAccountlinkLabel.Text = "Save Customer and Account Info";
            this.customerAndAccountlinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.customerAndAccountlinkLabel_LinkClicked);
            // 
            // transactionlinkLabel
            // 
            this.transactionlinkLabel.AutoSize = true;
            this.transactionlinkLabel.Location = new System.Drawing.Point(29, 76);
            this.transactionlinkLabel.Name = "transactionlinkLabel";
            this.transactionlinkLabel.Size = new System.Drawing.Size(63, 13);
            this.transactionlinkLabel.TabIndex = 1;
            this.transactionlinkLabel.TabStop = true;
            this.transactionlinkLabel.Text = "Transaction";
            this.transactionlinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.transactionlinkLabel_LinkClicked);
            // 
            // searchCustAndAccntLinkLabel
            // 
            this.searchCustAndAccntLinkLabel.AutoSize = true;
            this.searchCustAndAccntLinkLabel.Location = new System.Drawing.Point(29, 115);
            this.searchCustAndAccntLinkLabel.Name = "searchCustAndAccntLinkLabel";
            this.searchCustAndAccntLinkLabel.Size = new System.Drawing.Size(173, 13);
            this.searchCustAndAccntLinkLabel.TabIndex = 2;
            this.searchCustAndAccntLinkLabel.TabStop = true;
            this.searchCustAndAccntLinkLabel.Text = "Search Customer and Account Info";
            this.searchCustAndAccntLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.searchCustAndAccntLinkLabel_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.indexGroupBox);
            this.Name = "Form1";
            this.Text = "CustomerEntryUI";
            this.indexGroupBox.ResumeLayout(false);
            this.indexGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox indexGroupBox;
        private System.Windows.Forms.LinkLabel searchCustAndAccntLinkLabel;
        private System.Windows.Forms.LinkLabel transactionlinkLabel;
        private System.Windows.Forms.LinkLabel customerAndAccountlinkLabel;
    }
}

