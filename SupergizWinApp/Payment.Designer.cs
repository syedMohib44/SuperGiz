using System;

namespace SupergizWinApp
{
    partial class Payment
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.cardType = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.batchBox = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.amount = new System.Windows.Forms.Label();
            this.refNum = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.response = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.signsave = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.transactiontype = new System.Windows.Forms.ComboBox();
            this.tendertype = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.invNo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.serverID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.authcode = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.merchantKey = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.zip = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tax = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tip = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.userID = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.ClerkID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cashbackAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cardType);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.batchBox);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.amount);
            this.panel1.Controls.Add(this.refNum);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.response);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.signsave);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.transactiontype);
            this.panel1.Controls.Add(this.tendertype);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.invNo);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.serverID);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.authcode);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.merchantKey);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.zip);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tax);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tip);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.password);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.userID);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.ClerkID);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.cashbackAmount);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(955, 600);
            this.panel1.TabIndex = 134;
            // 
            // cardType
            // 
            this.cardType.AutoCompleteCustomSource.AddRange(new string[] {
            "VISA",
            "MASTERCARD",
            "AMEX",
            "DISCOVER",
            "DINERCLUB",
            "ENROUTE",
            "JCB",
            "REVOLUTIONCARD",
            "INTERAC",
            "CUP",
            "OTHER"});
            this.cardType.FormattingEnabled = true;
            this.cardType.Items.AddRange(new object[] {
            "VISA",
            "MASTERCARD",
            "AMEX",
            "DISCOVER",
            "DINERCLUB",
            "ENROUTE",
            "JCB",
            "REVOLUTIONCARD",
            "INTERAC",
            "CUP",
            "OTHER"});
            this.cardType.Location = new System.Drawing.Point(437, 386);
            this.cardType.Name = "cardType";
            this.cardType.Size = new System.Drawing.Size(121, 21);
            this.cardType.TabIndex = 45;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(337, 386);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(56, 13);
            this.label18.TabIndex = 44;
            this.label18.Text = "Card Type";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(456, 433);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(102, 49);
            this.button5.TabIndex = 43;
            this.button5.Text = "Start Batch";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // batchBox
            // 
            this.batchBox.AutoCompleteCustomSource.AddRange(new string[] {
            "BATCHCLOSE",
            "FORCEBATCHCLOSE"});
            this.batchBox.FormattingEnabled = true;
            this.batchBox.Items.AddRange(new object[] {
            "CREDIT",
            "DEBIT",
            "CHECK",
            "EBT_FOODSTAMP  ",
            "EBT_CASHBENEFIT",
            "GIFT",
            "LOYALTY",
            "CASH",
            "EBT"});
            this.batchBox.Location = new System.Drawing.Point(438, 345);
            this.batchBox.Name = "batchBox";
            this.batchBox.Size = new System.Drawing.Size(121, 21);
            this.batchBox.TabIndex = 42;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(338, 345);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 13);
            this.label16.TabIndex = 41;
            this.label16.Text = "Batch Command";
            // 
            // amount
            // 
            this.amount.AutoSize = true;
            this.amount.Location = new System.Drawing.Point(128, 131);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(19, 13);
            this.amount.TabIndex = 40;
            this.amount.Text = "00";
            // 
            // refNum
            // 
            this.refNum.Location = new System.Drawing.Point(112, 501);
            this.refNum.Name = "refNum";
            this.refNum.Size = new System.Drawing.Size(100, 20);
            this.refNum.TabIndex = 38;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 501);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(46, 13);
            this.label17.TabIndex = 37;
            this.label17.Text = "RefNum";
            // 
            // response
            // 
            this.response.FormattingEnabled = true;
            this.response.Location = new System.Drawing.Point(636, 13);
            this.response.Name = "response";
            this.response.Size = new System.Drawing.Size(311, 511);
            this.response.TabIndex = 36;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(448, 258);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 49);
            this.button3.TabIndex = 35;
            this.button3.Text = "Cancle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(340, 258);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 49);
            this.button2.TabIndex = 34;
            this.button2.Text = "Start";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(229, 459);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 23);
            this.button1.TabIndex = 33;
            this.button1.Text = "Browser";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // signsave
            // 
            this.signsave.Location = new System.Drawing.Point(112, 459);
            this.signsave.Name = "signsave";
            this.signsave.Size = new System.Drawing.Size(100, 20);
            this.signsave.TabIndex = 32;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 459);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 13);
            this.label15.TabIndex = 31;
            this.label15.Text = "Sign Save Location";
            // 
            // transactiontype
            // 
            this.transactiontype.FormattingEnabled = true;
            this.transactiontype.Items.AddRange(new object[] {
            "UNKNOWN",
            "AUTH",
            "SALE",
            "RETURN",
            "VOID",
            "POSTAUTH",
            "FORCEAUTH",
            "ADJUST",
            "INQUIRY",
            "ACTIVATE",
            "DEACTIVATE",
            "RELOAD",
            "VOID SALE",
            "VOID RETURN",
            "VOID AUTH",
            "VOID POSTAUTH",
            "VOID FORCEAUTH",
            "VOID WITHDRAWAL",
            "REVERSAL",
            "WITHDRAWAL",
            "ISSUE",
            "CASHOUT",
            "REPLACE",
            "MERGE",
            "REPORTLOST",
            "REDEEM",
            "VERIFY",
            "REACTIVATE",
            "FORCE ISSUE",
            "FORCE ADD",
            "UNLOAD",
            "RENEW",
            "GETCONVERTDETAIL",
            "CONVERT",
            "TOKENIZE",
            "INCREMENTALAUTH",
            "BALANCEWITHLOCK",
            "REDEMPTIONWITHUNLOCK",
            "REWARDS",
            "REENTER"});
            this.transactiontype.Location = new System.Drawing.Point(112, 79);
            this.transactiontype.Name = "transactiontype";
            this.transactiontype.Size = new System.Drawing.Size(121, 21);
            this.transactiontype.TabIndex = 29;
            // 
            // tendertype
            // 
            this.tendertype.FormattingEnabled = true;
            this.tendertype.Items.AddRange(new object[] {
            "CREDIT",
            "DEBIT",
            "CHECK",
            "EBT_FOODSTAMP  ",
            "EBT_CASHBENEFIT",
            "GIFT",
            "LOYALTY",
            "CASH",
            "EBT"});
            this.tendertype.Location = new System.Drawing.Point(112, 35);
            this.tendertype.Name = "tendertype";
            this.tendertype.Size = new System.Drawing.Size(121, 21);
            this.tendertype.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Transaction Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Tender Type";
            // 
            // invNo
            // 
            this.invNo.Location = new System.Drawing.Point(425, 70);
            this.invNo.Name = "invNo";
            this.invNo.Size = new System.Drawing.Size(100, 20);
            this.invNo.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(338, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "InvNum";
            // 
            // serverID
            // 
            this.serverID.Location = new System.Drawing.Point(112, 413);
            this.serverID.Name = "serverID";
            this.serverID.Size = new System.Drawing.Size(100, 20);
            this.serverID.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 420);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Server ID";
            // 
            // authcode
            // 
            this.authcode.Location = new System.Drawing.Point(425, 36);
            this.authcode.Name = "authcode";
            this.authcode.Size = new System.Drawing.Size(100, 20);
            this.authcode.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(338, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Auth Code";
            // 
            // merchantKey
            // 
            this.merchantKey.Location = new System.Drawing.Point(112, 366);
            this.merchantKey.Name = "merchantKey";
            this.merchantKey.Size = new System.Drawing.Size(100, 20);
            this.merchantKey.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 373);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Merchant Key";
            // 
            // zip
            // 
            this.zip.Location = new System.Drawing.Point(112, 319);
            this.zip.Name = "zip";
            this.zip.Size = new System.Drawing.Size(100, 20);
            this.zip.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 326);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "ZIP";
            // 
            // tax
            // 
            this.tax.Location = new System.Drawing.Point(112, 273);
            this.tax.Name = "tax";
            this.tax.Size = new System.Drawing.Size(100, 20);
            this.tax.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Tax Amount";
            // 
            // tip
            // 
            this.tip.Location = new System.Drawing.Point(112, 224);
            this.tip.Name = "tip";
            this.tip.Size = new System.Drawing.Size(100, 20);
            this.tip.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tip Amount";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(424, 201);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(100, 20);
            this.password.TabIndex = 9;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(337, 201);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 13);
            this.label14.TabIndex = 8;
            this.label14.Text = "Password";
            // 
            // userID
            // 
            this.userID.Location = new System.Drawing.Point(424, 154);
            this.userID.Name = "userID";
            this.userID.Size = new System.Drawing.Size(100, 20);
            this.userID.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(337, 153);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "UserID";
            // 
            // ClerkID
            // 
            this.ClerkID.Location = new System.Drawing.Point(424, 112);
            this.ClerkID.Name = "ClerkID";
            this.ClerkID.Size = new System.Drawing.Size(100, 20);
            this.ClerkID.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(337, 111);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "ClerkID";
            // 
            // cashbackAmount
            // 
            this.cashbackAmount.Location = new System.Drawing.Point(112, 166);
            this.cashbackAmount.Name = "cashbackAmount";
            this.cashbackAmount.Size = new System.Drawing.Size(100, 20);
            this.cashbackAmount.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Cashback Amount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amount";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 739);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cashbackAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ClerkID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox userID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tip;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tax;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox zip;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox merchantKey;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox authcode;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox serverID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox invNo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox tendertype;
        private System.Windows.Forms.ComboBox transactiontype;
        private System.Windows.Forms.TextBox signsave;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox response;
        private System.Windows.Forms.TextBox refNum;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label amount;
        private System.Windows.Forms.ComboBox batchBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox cardType;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panel1;
    }
}
