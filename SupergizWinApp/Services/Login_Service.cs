using Newtonsoft.Json;
using SupergizWinApp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using WebSocketSharp;

namespace SupergizWinApp.Services
{
    class Login_Service
    {
        public string Login(WebSocket ws, Login_Model login)
        {
            string responseFromServer = "";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("/login"); //works on http and not on https
            request.Method = "POST";
            request.ContentType = "application/json";
            string postData = JsonConvert.SerializeObject(login);

            //((HttpWebRequest)request).UserAgent =
            //                 "Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 7.1; Trident/5.0)";
            //request.Accept = "/";
            request.UseDefaultCredentials = true;
            request.Proxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = byteArray.Length;
            Stream dataStream = request.GetRequestStream();
            dataStream.Write(byteArray, 0, byteArray.Length);
            dataStream.Close();

            WebResponse response = request.GetResponse();
            dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            responseFromServer = reader.ReadToEnd();
            reader.Close();
            dataStream.Close();
            response.Close();
            return responseFromServer;
        }


        public string GetAppId(string token)
        {
            string responseFromServer = "";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("api/owner/business/app-setup"); //works on http and not on https  
            request.UseDefaultCredentials = true;
            request.ContentType = "application/json";
    

            // write the "Authorization" header
            request.Headers.Add("Authorization", "Basic " + token);
            request.Method = "POST";

            // get the response
            //WebResponse response = request.GetResponse();
            using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
            {
                StreamReader reader = new StreamReader(response.GetResponseStream());
                responseFromServer = reader.ReadToEnd();
            }
            return responseFromServer;
        }
    }
}
