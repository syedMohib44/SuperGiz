using Newtonsoft.Json;
using SupergizWinApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSocketSharp;

namespace SupergizWinApp.Services
{
    public class WebSocket_Service
    {
        private WebSocket ws;
        public WebSocket_Service()
        {
            ws = new WebSocket("wss://supergized.com/goalrestapi/ingenico");
            string json = "{\"type\": \"desktop-connect\", \"data\": {\"appId\": \"S300-_tC0m\"}}";

            if (!ws.IsAlive)
            {
                //MessageBox.Show(json + " sent.");
            }

            ws.OnOpen += (ss, ee) =>
            {
                //MessageBox.Show("Connected successfully");
                ws.Send(json);
            };

            ws.OnError += (ss, ee) =>
            {
                //MessageBox.Show("Error Occured" + ee.Message);
            };

            ws.OnMessage += (obj, eve) =>
            {
                Response_Model data = JsonConvert.DeserializeObject<Response_Model>(eve.Data);
                //payment.SetAmount((string)data.data.amount);
                //payment.SetWebID((string)data.data.webId);
                //MessageBox.Show("CONNECTED TO WEBSOCKET " + eve.Data);
            };

            ws.OnClose += (ss, ee) =>
            {
                //MessageBox.Show("CONNECTED TO WEBSOCKET " + ee);
            };
            ws.Connect();
        }
        public WebSocket GetConnection()
        {
            return ws;
        }
    
        public void SendResponse(Form2.PayResponse payResponse)
        {
            string data = JsonConvert.SerializeObject(payResponse);
            //MessageBox.Show(data);
            if (data != null && ws.IsAlive)
                ws.Send(data);
        }
    }
}
