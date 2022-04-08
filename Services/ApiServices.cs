using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTaller.Services
{
    public class ApiServices
    {
        private String apiKey = "90e4b04c";
        private String url = "http://www.omdbapi.com/";

        public ApiServices() { }

        public void GetItem(String title)
        {
            String apiUrl = $"{url}?apikey={apiKey}&s={title}";
            var request = (HttpWebRequest)WebRequest.Create(apiUrl);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";

            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream stream = response.GetResponseStream())
                    {
                        if (stream == null) return;
                        using (StreamReader strReader = new StreamReader(stream))
                        {
                            string res = strReader.ReadToEnd();
                            Console.WriteLine(res);
                        }
                    }
                }
            }
            catch (WebException e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
