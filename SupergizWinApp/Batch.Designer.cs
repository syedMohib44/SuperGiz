namespace SupergizWinApp
{
    partial class Batch
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.refNum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.command = new System.Windows.Forms.ComboBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.ecdType = new System.Windows.Forms.ComboBox();
            this.paymentType = new System.Windows.Forms.ComboBox();
            this.cardType = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.response = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Command";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ECDType";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Card Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Payment Type";
            // 
            // refNum
            // 
            this.refNum.Location = new System.Drawing.Point(120, 279);
            this.refNum.Name = "refNum";
            this.refNum.Size = new System.Drawing.Size(100, 20);
            this.refNum.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "RefNum";
            // 
            // command
            // 
            this.command.FormattingEnabled = true;
            this.command.Items.AddRange(new object[] {
            "BATCHCLOSE",
            "FORCEBATCHCLOSE",
            "BATCHCLEAR",
            "PURGEBATCH",
            "SAFUPLOAD",
            "DELETESAFFILE",
            "DELETETRANSACTION"});
            this.command.Location = new System.Drawing.Point(120, 60);
            this.command.Name = "command";
            this.command.Size = new System.Drawing.Size(121, 21);
            this.command.TabIndex = 11;
            // 
            // ecdType
            // 
            this.ecdType.FormattingEnabled = true;
            this.ecdType.Items.AddRange(new object[] {
            "---Please Select Only for BATCHCLEAR---",
            "ALL",
            "CREDIT",
            "DEBIT",
            "CHECK",
            "EBT",
            "GIFT",
            "LOYALTY",
            "CASH"});
            this.ecdType.Location = new System.Drawing.Point(120, 107);
            this.ecdType.Name = "ecdType";
            this.ecdType.Size = new System.Drawing.Size(121, 21);
            this.ecdType.TabIndex = 12;
            // 
            // paymentType
            // 
            this.paymentType.FormattingEnabled = true;
            this.paymentType.Items.AddRange(new object[] {
            "---Please Select---",
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
            "TOKENIZE"});
            this.paymentType.Location = new System.Drawing.Point(120, 222);
            this.paymentType.Name = "paymentType";
            this.paymentType.Size = new System.Drawing.Size(121, 21);
            this.paymentType.TabIndex = 14;
            // 
            // cardType
            // 
            this.cardType.FormattingEnabled = true;
            this.cardType.Items.AddRange(new object[] {
            "---Please Select---",
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
            this.cardType.Location = new System.Drawing.Point(120, 165);
            this.cardType.Name = "cardType";
            this.cardType.Size = new System.Drawing.Size(121, 21);
            this.cardType.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(120, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // response
            // 
            this.response.FormattingEnabled = true;
            this.response.Location = new System.Drawing.Point(537, 2);
            this.response.Name = "response";
            this.response.Size = new System.Drawing.Size(250, 446);
            this.response.TabIndex = 16;
            // 
            // Batch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.response);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.paymentType);
            this.Controls.Add(this.cardType);
            this.Controls.Add(this.ecdType);
            this.Controls.Add(this.command);
            this.Controls.Add(this.refNum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Batch";
            this.Size = new System.Drawing.Size(790, 542);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox refNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox command;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ComboBox ecdType;
        private System.Windows.Forms.ComboBox paymentType;
        private System.Windows.Forms.ComboBox cardType;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox response;
    }
}
