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

        string Name_Ex;
        public string NAME_EX
        { get { return Name_Ex; } }

        string Name_Res;
        public string NAME_RES
        { get { return Name_Res; } }

        string Description;
        public string DESCRIPTION
        { get { return Description; } }

        int Date;
        public int DATE
        { get { return Date; } }

        int Date_End;
        public int DATE_END
        { get { return Date_End; } }

        string Discount;
        public string DISCOUNT
        { get { return Discount; } }

        string Hotel;
        public string HOTEL
        { get { return Hotel; } }

        bool Stop = false;
        public bool STOP
        { get { return Stop; }
          set { Stop = value; }}

        string block_work;
        public string BLOCK_WORK
        { get { return block_work; } }

        string id;
        public string ID
        { get { return id; } }

        string Price;
        public string PRICE
        { get { return Price; } }

        string Price_Ex;
        public string PRICE_EX
        { get { return Price_Ex; } }

        string Duration;
        public string DURATION
        { get { return Duration; } }

        string Duration_Ex;
        public string DURATION_EX
        { get { return Duration_Ex; } }

        string Resort;
        public string RESORT
        { get { return Resort; } }
        
        string Resort_Ex;
        public string RESORT_EX
        { get { return Resort_Ex; } }

        string Hotels;
        public string HOTELS
        { get { return Hotels; } }

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
            string Date1 = "";
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
                Name = Name.Replace("&quot;", "");
                Name = Name.Replace("'", "");
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
                            Date1 += temporary1[j];
                        }
                        temporary1 = "";
                    }
                    Date_(Date1);
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
                Date = -1;
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

        public string Block(string container, string Text)
        {
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(container);
            string BLOCK = "";
            HtmlNode block = doc.DocumentNode.SelectSingleNode(Text);
            if (block != null)
            {
                BLOCK = block.OuterHtml;
            }
            return BLOCK;
        }

        public string Block1(string block, string Text, string Text1)
        {
            string temporary_block = "";
            block_work = "";
            int index;
            index = block.IndexOf(Text);
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
                index = temporary_block.IndexOf(Text1);
                if(index == -1)
                {
                    Stop = true;
                }
            }
            return temporary_block;
        }

        public void Date_(string date)
        {
            //string Text = "Январь,Февраль,Март,Апрель,Май,Июнь,Июль,Август,Сентябрь,Октябрь,Ноябрь,Декабрь";
            //string[] arr_text = Text.Split(',');
            int[] arr_text = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            string [] arr_m = new string [12];
            arr_m[0] = "Янв,янв,.01";
            arr_m[1] = "Фев,фев,.02";
            arr_m[2] = "Мар,мар,.03";
            arr_m[3] = "Апр,апр,.04";
            arr_m[4] = "Май,май,Мая,мая,.05";
            arr_m[5] = "Ию,ию,.06";
            arr_m[6] = "Ию,ию,.07";
            arr_m[7] = "Ав,ав,.08";
            arr_m[8] = "Се,се,.09";
            arr_m[9] = "Ок,ок,.10";
            arr_m[10] = "Но,но,.11";
            arr_m[11] = "Де,де,.12";
            bool a = false;
            for (int i = 0; i < arr_m.GetLength(0); i++)
            {
                string[] arr = arr_m[i].Split(',');                
                for (int j = 0; j < arr.GetLength(0); j++)
                {                    
                    int index = date.IndexOf(arr[j]);
                    int index1 = date.IndexOf("Ежедневно");
                    if (index != -1 && index1 == -1)
                    {
                        if (a == false)
                        {
                            Date = arr_text[i];
                            a = true;
                        }
                        else
                        {
                            Date_End = arr_text[i];
                            a = false;
                        }
                    }
                    if (a == true)
                    {
                        Date_End = Date;
                    }
                    if (index1 != -1)
                    {
                        Date = 1;
                        Date_End = 12;
                    }
                }
            }
        }

        public void Tour(string block)
        {
            id = Check1("/tours/", ">", 7, 1, block);
            Price = Check1("Цена:", "</span>", 14, 0, block);
            Price = Price.Replace("от ", "");
            Price = Price.Replace(" рублей", "");
            Price = Price.Trim();
            Duration = Check1("Продолжительность:", "</span>", 27, 0, block);
            Resort = Check1("g>Курорт:", "</span>", 18, 0, block);
        }

        public void Shares(string block)
        {
            Name = Check1("<a href", "</a>", 22, 0, block);
            Name = Name.Replace("&quot;", "").Replace("'", "").Replace('"', ' ').Replace("«", "").Replace("»", "").Replace("+", "").Trim();
            Description = Check1("<p>","</p>", 3, 0, block);
            Description = Description.Replace("&quot;", "").Replace("'", "").Replace('"', ' ').Replace("«", "").Replace("»", "").Replace("+", "").Trim();
            Resort = Check1("Курорт:", "</span>", 17, 0, block);
            Resort = Resort.Trim();
            Price = Check1("Цена:", "/сутки", 15, 0, block);
            Price = Price.Replace("от", "").Replace("р.", "").Replace('"', ' ').Trim();
            Discount = Check1("Скидка:", "</span>", 16, 0, block);
            Discount = Discount.Replace("%", "").Trim();
        }

        public void Excursions(string block)
        {
            Name_Ex = "";
            string temporary = "";
            int index = block.IndexOf("<h4>");
            if (index != -1)
            {
                for(int i = index + 5; i < block.Length; i++)
                {
                    temporary += block[i];
                }
                index = temporary.IndexOf(">");
                int index1 = temporary.IndexOf("</a>");
                if (index != -1 || index1 != -1)
                {
                    for(int j = index + 1; j < index1; j++)
                    {
                        Name_Ex += temporary[j];
                    }
                }
                Description = Check1("px;", "</p>", 17, 0, temporary);
                Duration_Ex = Check1("Продолжительность:", "</span>", 18, 0, temporary);
                Duration_Ex = Duration_Ex.Replace("часа", "").Replace("часов", "").Trim();
                Price_Ex = Check1("Цена от:", "</span>", 8, 0, temporary);
                Price_Ex = Price_Ex.Replace("руб.", "").Trim();
                Resort_Ex = Check1("Курорт:", "</span>", 7, 0, temporary);
                Resort_Ex = Resort_Ex.Trim();
            }
        }

        public void Resort_(string block)
        {
            Name_Res = Description = Check1("resorts/", "</a>", 8, 0, block);
            int index = Name_Res.IndexOf(">");
            if (index != -1)
            {
                Name_Res = Name_Res.Remove(0, index + 1);
            }
        }

        public void Hotels_(string container)
        {
            string block_;
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(container);
            HtmlNode block = doc.DocumentNode.SelectSingleNode("//*[@id='tab1']");
            if (block != null)
            {
                doc.LoadHtml(block.OuterHtml);
                HtmlNode block1 = doc.DocumentNode.SelectSingleNode("//div[1]");
                if (block1 != null)
                {
                    string Text = "";
                    block_ = Block1(block1.OuterHtml, "</li>", "<li>");
                    Hotels += Check1("<a", "</a", 21, 0, block_work);
                    int index = Hotels.IndexOf(">");
                    if (index != -1)
                    {
                        Hotels = Hotels.Remove(index, 1);
                    }
                    while (Stop != true)
                    {
                        block_ = Block1(block_, "</li>", "<li>");
                        Text = Check1("<a", "</a", 21, 0, block_work);
                        index = Text.IndexOf(">");
                        if (index != -1)
                        {
                            Hotels += "," + Text.Remove(index, 1);
                        }
                        else
                        {
                            Hotels += "," + Text;
                        }
                    }
                    Hotels = Hotels.Replace("&#39;", "");
                }
            }
        }
    }
}
