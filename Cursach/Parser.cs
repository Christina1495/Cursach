using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.IO;
using System.Net;

namespace Cursach
{
    class Parser
    {
        string Name;
        public string NAME
        {get { return Name; }}

        private string UTF8(string text)
        {
            Encoding UTF8 = Encoding.UTF8;
            Encoding Unicode = Encoding.Unicode;
            byte[] in_bytes = Unicode.GetBytes(text);
            byte[] out_bytes = Encoding.Convert(Unicode, UTF8, in_bytes);
            text = UTF8.GetString(out_bytes);
            return text;
        }

        public string getRequest(string url)
        {
            try
            {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
                httpWebRequest.AllowAutoRedirect = false;
                httpWebRequest.Method = "GET";
                httpWebRequest.Referer = url;
                using (var httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse())
                {
                    using (var stream = httpWebResponse.GetResponseStream())
                    {
                        using (var reader = new StreamReader(stream, Encoding.GetEncoding(httpWebResponse.CharacterSet)))
                        {
                            return reader.ReadToEnd();
                        }
                    }
                }
            }
            catch
            {
                return String.Empty;
            }
        }

        public void Check(string container)
        {
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(container);
            HtmlNode name = doc.DocumentNode.SelectSingleNode("//h1");
            if (name != null)
            {
                for (int i = 4; i < name.OuterHtml.Length - 5; i++)
                {
                    Name += name.OuterHtml[i];
                }
                Name = Name.Replace("&quot;", "'");
            }
            else
            {
                Name = "ne ok";
            }
        }
    }
}
