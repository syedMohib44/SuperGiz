using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupergizWinApp.Models
{
    class CommSetting_Model
    {
        public string CommType { private set { value = "TCP"; } get { return CommType; } }
        public string TimeOut { private set { value = "30000"; } get { return TimeOut; } }
        public string SerialPort { private set; get; }
        public string DestIP { private set; get; }
        public string DestPort { private set { value = "10009"; } get { return DestPort; } }
        public string BaudRate { private set { value = "115200"; } get { return BaudRate; } } //also can be 9600
        public string AppId { private set { value = ""; } get { return BaudRate; } } //also can be 9600
    

        public CommSetting_Model(string destIP, string baudRate, string appId, string serialPort = "")
        {
            this.DestIP = destIP;
            this.BaudRate = baudRate;
            this.SerialPort = serialPort;
            this.AppId = appId;
        }
    }
}
