using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupergizWinApp
{
    public partial class Form3 : Form
    {
        private Payment paymentForm;
        private Batch batchForm;
        public Form3()
        {
            InitializeComponent();
            paymentForm = new Payment();
            batchForm = new Batch();

            this.paymentForm.AutoScroll = true;
            this.paymentForm.AutoSize = true;
            this.paymentForm.Location = new System.Drawing.Point(9, 3);
            this.paymentForm.Size = new System.Drawing.Size(988, 758);
            this.paymentForm.TabIndex = 0;

            this.batchForm.AutoScroll = true;
            this.batchForm.AutoSize = true;
            this.batchForm.Location = new System.Drawing.Point(9, 3);
            this.batchForm.Size = new System.Drawing.Size(988, 758);
            this.batchForm.TabIndex = 0;

            this.tabPage1.Controls.Add(paymentForm);
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            
        }

        private void Tab_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Tab.SelectedIndex == 0)
            {
                tabPage1.Controls.Add(paymentForm);
            }
            else if (Tab.SelectedIndex == 1)
            {
                tabPage2.Controls.Add(batchForm);
            }
        }
        private void Form3_Load(object sender, EventArgs e)
        {
           
            //paymentForm.TopLevel = false;
            //paymentForm.Parent = tabPage1;
            paymentForm.Show();
        }
    }
}
