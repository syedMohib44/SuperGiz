using POSLink;
using SupergizWinApp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupergizWinApp.Services
{
    class CommSetting_Service
    {
        public bool IsCommSett()
        {
            if (!File.Exists("commsetting.ini"))
            {
                return false;
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
            String deviceId = "";
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
                    deviceId = contentValue.Trim();
                }
                buf = fs.ReadLine();
            }

            if (deviceId == "")
            {
                ini.Close();
                fs.Close();
                return false;
            }
            ini.Close();
            fs.Close();
            return true;
        }

        public CommSetting_Model InitCommSetting(PosLink pg)
        {

            string appId = "";         

            if (!File.Exists("commsetting.ini"))
            {
                return null;
            }
            CommSetting_Model settings;
            POSLink.CommSetting commSetting = new POSLink.CommSetting();

            String buf;
            FileStream ini = new FileStream("commsetting.ini", FileMode.OpenOrCreate);
            StreamReader fs = new StreamReader(ini);
            int index;
            String content = "";
            String contentValue = "";
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
                    commSetting.DestPort = contentValue.Trim();
                }
                else if (content == "AppId")
                {
                    appId = contentValue.Trim();
                }
                else if (content == "IP")
                {
                    commSetting.DestIP = contentValue.Trim();
                }
                else if (content == "SERIALPORT")
                {
                    commSetting.SerialPort = contentValue.Trim();
                }
                else if (content == "TIMEOUT")
                {
                    commSetting.TimeOut = contentValue.Trim();
                }
                else if (content == "CommType")
                {
                    commSetting.CommType = contentValue.Trim();
                }
                else if (content == "BAUDRATE")
                {
                    commSetting.BaudRate = contentValue.Trim();
                }
                buf = fs.ReadLine();
            }
            ini.Close();
            fs.Close();
            pg.CommSetting = commSetting;
            return settings = new CommSetting_Model(commSetting.DestIP, commSetting.BaudRate, appId);

        }
    }
}
