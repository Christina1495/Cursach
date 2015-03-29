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
        { get { return Name; } }

        string Date;
        public string DATE
        { get { return Date; } }

        string Hotel;
        public string HOTEL
        { get { return Hotel; } }

        bool Stop = false;
        public bool STOP
        { get { return Stop; } }

        string block_work;
        public string BLOCK_WORK
        { get { return block_work; } }

        string id;
        public string ID
        { get { return id; } }

        string Price;
        public string PRICE
        { get { return Price; } }

        string Duration;
        public string DURATION
        { get { return Duration; } }

        string Resort;
        public string RESORT
        { get { return Resort; } }

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

        public void Check(string container)//Метод обработки отдельной страницы тура(Название, Дата, Отели)
        {
            Name = "";
            Date = "";
            Hotel = "";
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

            HtmlNode text = doc.DocumentNode.SelectSingleNode("//div[1]/div/div[2]/div[1]/div/div[2]");
            if (text != null)
            {
                string temporary = text.OuterHtml;
                string temporary1 = "";
                int index = temporary.IndexOf("Даты тура");
                if (index != -1)
                {
                    for (int j = index + 24; j < temporary.Length - 1; j++)
                    {
                        temporary1 += temporary[j];
                    }
                    index = temporary1.IndexOf("</p>");
                    if (index != -1)
                    {
                        for (int j = 0; j < index; j++)
                        {
                            Date += temporary1[j];
                        }
                        temporary1 = "";
                    }
                }

                index = temporary.IndexOf("Отели тура");
                if(index != -1)
                {
                    for (int j = index; j < temporary.Length - 1; j++)
                    {
                        temporary1 += temporary[j];
                    }
                }
                temporary = "";
                index = temporary1.IndexOf("Дополнительно");
                if(index != -1)
                {
                    for(int j = 0; j < index; j++)
                    {
                        temporary += temporary1[j];
                    }
                }
                else
                {
                    temporary = temporary1;
                }
                index = temporary.IndexOf("</a>");
                string temporary2 = "";
                temporary1 = "";   
                while (index != -1)
                {
                    for (int i = 0; i < index; i++)
                    {
                        temporary2 += temporary[i];
                    }
                    for (int i = index + 1; i < temporary.Length; i++)
                    {
                        temporary1 += temporary[i];
                    }
                    index = temporary2.IndexOf("<a");
                    temporary = temporary1;
                    temporary1 = "";
                    if (index != -1)
                    {
                        for (int i = index; i < temporary2.Length; i++)
                        {
                            temporary1 += temporary2[i];
                        }
                        temporary2 = "";
                        index = temporary1.IndexOf(">");
                        if (index != -1)
                        {
                            for (int i = index + 1; i < temporary1.Length; i++)
                            {
                                Hotel += temporary1[i];
                            }
                            Hotel += ",";
                        }
                    }
                    index = temporary.IndexOf("</a>");
                    temporary2 = "";
                    temporary1 = "";
                }
            }
            else
            {
                Date = "ne ok";
            }
        }

        public string Check1(string Text, string Text1, int Length, int Length1, string block)
        {
            string Variable = "";
            string temporary = "";
            int index = block.IndexOf(Text);
            if (index != -1)
            {
                for (int i = index + Length; i < block.Length; i++)
                {
                    temporary += block[i];
                }
                index = temporary.IndexOf(Text1);
                if (index != -1)
                {
                    for (int i = 0; i < index - Length1; i++)
                    {
                        Variable += temporary[i];
                    }
                }
            }
            return Variable;
        }

        public string Block(string container)
        {
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(container);
            string BLOCK = "";
            HtmlNode block = doc.DocumentNode.SelectSingleNode("//div[@class='entry']");
            if (block != null)
            {
                BLOCK = block.OuterHtml;
            }
            return BLOCK;
        }

        public string Block1(string block)
        {
            string temporary_block = "";
            block_work = "";
            int index;
            index = block.IndexOf("bottom");
            if(index != -1)
            {
                for(int i = 0; i < index; i++)
                {
                    block_work += block[i];
                }
                for(int i = index + 6; i < block.Length; i++)
                {
                    temporary_block += block[i];
                }
                index = temporary_block.IndexOf("<a");
                if(index == -1)
                {
                    Stop = true;
                }
            }
            return temporary_block;
        }

        public void Check1(string block)
        {
            id = Check1("/tours/", ">", 7, 1, block);
            Price = Check1("Цена:", "</span>", 14, 0, block);
            Duration = Check1("Продолжительность:", "</span>", 27, 0, block);
            Resort = Check1("g>Курорт:", "</span>", 18, 0, block);
        }
    }
}
