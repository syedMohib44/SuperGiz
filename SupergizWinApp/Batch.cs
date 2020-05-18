using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace SupergizWinApp
{
    public partial class Batch : UserControl
    {
        POSLink.BatchRequest batch = new POSLink.BatchRequest();
        POSLink.ProcessTransResult result;

        public Batch()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            POSLink.PosLink bg = new POSLink.PosLink();

            batch.EDCType = batch.ParseEDCType(ecdType.Text);

            batch.CardType = batch.ParseCardType(cardType.Text);

            batch.PaymentType = batch.ParsePaymentType(paymentType.Text);

            batch.TransType = batch.ParseTransType(command.Text);
            batch.RefNum = refNum.Text;;

            bg.BatchRequest = batch;
            result = bg.ProcessTrans();




            if (result.Code == POSLink.ProcessTransResultCode.OK)
            {
                POSLink.BatchResponse batchResponse = bg.BatchResponse;
                response.Text = "ResultCode: " + batchResponse.ResultCode + "\nMessage:" + batchResponse.Message + "\nTimestamp: " + batchResponse.Timestamp + "\nResult: " + batchResponse.ResultTxt;
            }
        }
    }
}
