using SupergizWinApp.Models;
using SupergizWinApp.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using WebSocketSharp;

namespace SupergizWinApp
{
    public partial class Payment : UserControl
    {
        POSLink.PosLink pg = new POSLink.PosLink();
        POSLink.ProcessTransResult result = new POSLink.ProcessTransResult();
        POSLink.CommercialCard m_CommercialCard = null;
        private String m_edcType;
        private String m_transType;
        private String m_transAmount;
        Thread process2;
        private string appId;
        private string webId;
        CommSetting_Service commSetting;
        CommSetting_Model settingModel;
        WebSocket_Service wss;

        public Payment()
        {
            InitializeComponent();
            this.tendertype.Text = "CREDIT";
            this.transactiontype.Text = "SALE";
            this.batchBox.Text = "CREDIT";
            this.cardType.Text = "VISA";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            m_edcType = "";
            m_transType = "";

            POSLink.PaymentRequest paymentRequest = new POSLink.PaymentRequest();

            paymentRequest.TenderType = paymentRequest.ParseTenderType(tendertype.Text);
            paymentRequest.TransType = paymentRequest.ParseTransType(transactiontype.Text);

            m_edcType = tendertype.Text;
            m_transType = transactiontype.Text;

            // 2. Next Set the PayLink Properties, the only required field is Amount
            #region Set PayLink Properties

            // Set the only required field: Amount
            String amount = this.amount.Text;
            String retstr;
            // amount.to
            if (amount == "")
            {
                paymentRequest.Amount = "";
                retstr = "";
            }
            else
            {
                //amount = amount.Remove(amount.Length - 3, 1);
                double ret = Convert.ToDouble(amount);
                ret = ret * 100;

                retstr = Convert.ToString(ret);
                paymentRequest.Amount = "$" + retstr;
            }
            m_transAmount = retstr;

            // All these below are optionals
            paymentRequest.OrigRefNum = refNum.Text;
            paymentRequest.InvNum = invNo.Text;
            paymentRequest.ClerkID = ClerkID.Text;
            if (tip.Text.Length > 0) paymentRequest.TipAmt = tip.Text;
            if (tax.Text.Length > 0) paymentRequest.TaxAmt = tax.Text;
            if (cashbackAmount.Text.Length > 0) paymentRequest.CashBackAmt = cashbackAmount.Text;

            paymentRequest.Zip = zip.Text;
            paymentRequest.AuthCode = authcode.Text;
            paymentRequest.CommercialCard = m_CommercialCard;

            String path = signsave.Text;
            if (path.EndsWith(":"))
            {
                path = path + "\\";
            }
            paymentRequest.SigSavePath = path;

            #endregion

            //3 execute the function
            pg.PaymentRequest = paymentRequest;
            //POSLink.ProcessTransResult result = pg.ProcessTrans();  //move to tread
            ThreadStart entry1 = new ThreadStart(Run1);
            Thread process1 = new Thread(entry1);
            process1.IsBackground = true;
            process1.Start();

            ThreadStart entry2 = new ThreadStart(Run2);
            process2 = new Thread(entry2);
            process2.IsBackground = true;
            process2.Start();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            pg.CancelTrans();
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            if (commSetting == null)
                commSetting = new CommSetting_Service();

            settingModel = commSetting.InitCommSetting(pg);
        }

        void Run2()
        {
            int a = 9;

            while (true)
            {
                a = pg.GetReportedStatus();
                MessageBoxTimeOut messageBoxTimeOut = new MessageBoxTimeOut();
                if (a == 0)
                {
                    messageBoxTimeOut.Show("Ready for swipe card/input account.", "Ready for swipe card/input account", 1500);
                }
                else if (a == 1)
                {
                    messageBoxTimeOut.Show("Ready for PIN entry.", "Ready for PIN entry", 1500);
                }
                else if (a == 2)
                {
                    messageBoxTimeOut.Show("Ready for Signature.", "Ready for Signature", 1500);
                }
                else if (a == 3)
                {
                    messageBoxTimeOut.Show("Ready for Online Processing.", "Ready for Online Processing", 1500);
                }
                else if (a == 4)
                {
                    messageBoxTimeOut.Show("Ready for second card input.", "Ready for second card input", 1500);
                }
                else if (a == 5)
                {
                    messageBoxTimeOut.Show("Signature retry.", "Signature retry", 1500);
                }
                else if (a == 6)
                {
                    messageBoxTimeOut.Show("PIN retry.", "PIN retry", 1500);
                }
                else if (a == 9020002)
                {
                    messageBoxTimeOut.Show("Please enter cash back.", "Please enter cash back", 1500);
                }
            }
        }
        public class PayData //: Data
        {
            public string transactionStatus { get; set; }
        }
        public class PayResponse
        {
            public string type { get; set; }
            public PayData data { get; set; }
        }
        PayResponse resp = null;
        PayData dat = null;
        void Run1()
        {
            if (dat == null)
                dat = new PayData();
            if (resp == null) { }
            resp = new PayResponse();

            result = pg.ProcessTrans();
            if (result.Code == POSLink.ProcessTransResultCode.OK)
            {
                resp.type = "payment-complete";
                dat.transactionStatus = "success";

                POSLink.PaymentResponse paymentResponse = pg.PaymentResponse;
                if (paymentResponse != null && paymentResponse.ResultCode != null)
                {
                    response.Text = "ResultCode: " + paymentResponse.ResultCode + "\nMessage:" + paymentResponse.Message + "\nTimestamp: " + paymentResponse.Timestamp + "\nAccountNo: " + paymentResponse.BogusAccountNum + "\nResult: " + paymentResponse.ResultTxt;
                    this.PerformLayout();
                }
                else
                {
                    MessageBox.Show("Unknown error: pg.PaymentResponse is null.");
                }
            }
            else if (result.Code == POSLink.ProcessTransResultCode.TimeOut)
            {
                resp.type = "payment-complete";
                dat.transactionStatus = "success";
                MessageBox.Show("Action Timeout.");
            }
            else
            {
                resp.type = "payment-complete";
                dat.transactionStatus = "success";
                MessageBox.Show(result.Msg, "Error Processing Payment", MessageBoxButtons.OK);
            }
            //dat.amount = this.amount.Text;
            //dat.appId = this.appId;
            //dat.webId = this.webId;
            resp.data = dat;
            //init.SendResponse(resp);
            //this.Focus();

            process2.Abort();
        }

        public void SetWebID(string webId)
        {
            this.webId = webId;
        }

        public class MessageBoxTimeOut
        {
            private string _caption;

            public void Show(string text, string caption, int timeout)
            {
                this._caption = caption;
                StartTimer(timeout);
                MessageBox.Show(text, caption);
            }

            private void StartTimer(int interval)
            {
                System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
                timer.Interval = interval;
                timer.Tick += new EventHandler(Timer_Tick);
                timer.Enabled = true;
            }

            private void Timer_Tick(object sender, EventArgs e)
            {
                KillMessageBox();
                //停止计时器
                ((System.Windows.Forms.Timer)sender).Enabled = false;
            }

            [DllImport("user32.dll", EntryPoint = "FindWindow", CharSet = CharSet.Auto)]
            private extern static IntPtr FindWindow(string lpClassName, string lpWindowName);

            [DllImport("user32.dll", CharSet = CharSet.Auto)]
            public static extern int PostMessage(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);

            public const int WM_CLOSE = 0x10;

            private void KillMessageBox()
            {
                //查找MessageBox的弹出窗口,注意对应标题
                IntPtr ptr = FindWindow(null, this._caption);
                if (ptr != IntPtr.Zero)
                {
                    //查找到窗口则关闭
                    PostMessage(ptr, WM_CLOSE, IntPtr.Zero, IntPtr.Zero);
                }
            }
        }

        public void SetAmount(string amount)
        {
            this.amount.Text = amount;
        }
    }
}
