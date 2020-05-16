using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebSocketSharp;
using Newtonsoft.Json;
using System.Threading;
using SupergizWinApp.Models;
using SupergizWinApp.Services;

namespace SupergizWinApp
{
    public partial class Form1 : Form
    {
        public class Data
        {
            public string webId { get; set; }
            public string appId { get; set; }
            public string amount { get; set; }

        }
        public class Response
        {
            public string type { get; set; }
            public Data data  {get;set;}
        }

        Thread t;
        WebSocket_Service wss = new WebSocket_Service();
        CommSetting_Service commSettingService;
        Form2 payment = null;
        public Form1()
        {
            commSettingService = new CommSetting_Service();
            if (payment == null)
            {
                payment = new Form2();
                payment.SetSocket(wss);
            }

            if (commSettingService.IsCommSett())
            {
                MessageBox.Show("Set");
                payment.Show();
                Application.Run(payment);
                this.Dispose(); // or could be return
            }
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Login_Model login = new Login_Model(username.Text, password.Text);
            Login_Service loginService = new Login_Service();
            string token = loginService.Login(wss.GetConnection(), login);
            Response_Model loginResponse = JsonConvert.DeserializeObject<Response_Model>(loginService.GetAppId(token));


            CommSetting_Model commSetting_Model = new CommSetting_Model(password.Text, "115200", loginResponse.data.appName);
            POSLink.PosLink cg = new POSLink.PosLink();
            POSLink.CommSetting commSetting = new POSLink.CommSetting();
            FileStream fs = new FileStream("commsetting.ini", FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("[COMMUNICATE]" + Environment.NewLine + "BAUDRATE=" + commSetting_Model.BaudRate + Environment.NewLine + "PORT=" + commSetting_Model.DestPort
                + Environment.NewLine + "IP=" + commSetting_Model.DestIP + Environment.NewLine + "SERIALPORT=" + commSetting_Model.SerialPort + Environment.NewLine +
                "TIMEOUT=" + commSetting_Model.TimeOut + Environment.NewLine + "CommType=" + commSetting_Model.CommType + Environment.NewLine + "AppId=" + commSetting_Model.AppId);
            sw.Close();
            commSetting.CommType = "TCP";
            commSetting.TimeOut = "300000";
            commSetting.SerialPort = "";
            commSetting.DestIP = password.Text;
            commSetting.DestPort = "10009";
            commSetting.BaudRate = "115200"; //also can be 9600
            cg.CommSetting = commSetting;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists("commsetting.ini"))
            {
                return;
            }


            String buf;
            FileStream ini = new FileStream("commsetting.ini", FileMode.OpenOrCreate);
            StreamReader fs = new StreamReader(ini);
            int index;
            String content = "";
            String contentValue = "";
            String ipPort = "";
            String ip = "";
            String serialPort = "";
            String timeout = "";
            String commType = "";
            String baudRate = "";
            String appId = "";
            int len;
            buf = fs.ReadLine();
            while (buf != null)
            {
                index = buf.IndexOf("=");
                if (index == -1)
                {
                    buf = fs.ReadLine();
                    continue;
                }
                content = buf.Substring(0, index);
                len = buf.Length - index;
                if (len == 1)
                {
                    buf = fs.ReadLine();
                    continue;
                }
                contentValue = buf.Substring(index + 1, len - 1);
                if (content == "PORT")
                {
                    ipPort = contentValue.Trim();
                }
                else if (content == "IP")
                {
                    ip = contentValue.Trim();
                }
                else if (content == "SERIALPORT")
                {
                    serialPort = contentValue.Trim();
                }
                else if (content == "TIMEOUT")
                {
                    timeout = contentValue.Trim();
                }
                else if (content == "CommType")
                {
                    commType = contentValue.Trim();
                }
                else if (content == "BAUDRATE")
                {
                    baudRate = contentValue.Trim();
                }
                else if (content == "AppId")
                {
                    appId = contentValue.Trim();
                }
                buf = fs.ReadLine();
            }
            if (appId != "")
            {
                this.Dispose();
                return;
            }
            //else
            //{
            //    if (commType != "")
            //    {
            //        this.commtype.Text = commType;
            //    }

            //    if (ip != "")
            //    {
            //        this.ip.Text = ip;
            //    }

            //    if (ipPort != "")
            //    {
            //        this.port.Text = ipPort;
            //    }

            //    if (serialPort != "")
            //    {
            //        this.serialport.Text = serialPort;
            //    }

            //    if (timeout != "")
            //    {
            //        this.timeout.Text = timeout;
            //    }

            //    if (baudRate != "")
            //    {
            //        this.baudrate.Text = baudRate;
            //    }

            //    if (appId != "")
            //    {
            //        this.deviceID.Text = appId;
            //    }
            //}
            ini.Close();
            fs.Close();
        }
      
        private void button2_Click(object sender, EventArgs e)
        {                     
            payment.Show();
            payment.Hide(this);
        }
    }
}
