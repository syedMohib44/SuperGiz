using Newtonsoft.Json;
using SupergizWinApp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WebSocketSharp;

namespace SupergizWinApp.Services
{
    public class WebSocket_Service
    {
        private TcpListener ws;
        private TcpClient client;
        Thread t1, t2;
        public WebSocket_Service()
        {
            ws = new TcpListener(IPAddress.Parse("127.0.0.1"), 8088);
            ws.Start();

            t1 = new Thread(AcceptClient);
            t1.Start();
            t2 = new Thread(ReadMessage);
            t2.Start();
            t1.Join();
            t2.Join(); 
        }

        private void AcceptClient()
        {
            while (client != null)
            {
                client = ws.AcceptTcpClient();
                Thread.Sleep(3000);
            }
        }
       
        public void ReadMessage()
        {
            while (client != null)
            {
                NetworkStream stream = client.GetStream();
                StreamReader sdr = new StreamReader(stream);
                string msg = sdr.ReadLine();
                Response_Model data = JsonConvert.DeserializeObject<Response_Model>(msg);
                stream.Close();
                sdr.Close();
                Thread.Sleep(10000);
            }

        }
        public void SendResponse(Form2.PayResponse payResponse)
        {
            string data = JsonConvert.SerializeObject(payResponse);
            NetworkStream stream = client.GetStream();
            StreamWriter sdr = new StreamWriter(stream);
            sdr.WriteLine(data);
            sdr.Flush();
            stream.Close();
            sdr.Close();
        }

        public TcpClient GetClient()
        {
            return client;
        }
    }
}
