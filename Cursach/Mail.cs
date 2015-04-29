using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using System.Net.Mime;
using System.IO;

namespace Cursach
{
    class Mail
    {
        public void MailSalePDF()
        {
            MailMessage message;
            NetworkCredential credential;
            SmtpClient client = new SmtpClient("smtp.rambler.ru", 587);
            credential = new NetworkCredential("cursach.oop", "0123456789");
            client.Credentials = credential;
            var b = File.ReadAllBytes("doc\\SaleList.pdf");
            var stream = new MemoryStream(b);
            var attachment1 = new Attachment(stream, "SaleList.pdf", MediaTypeNames.Application.Pdf);
            //for (int i = 0; i < email.Length; i++)
            //{

                message = new MailMessage { Subject = "Акции", Body = "Sale!!!" };
                message.From = new MailAddress("cursach.oop@rambler.ru");//от кого
                message.To.Add("Rikki0188@mail.ru");//кому
                message.SubjectEncoding = Encoding.GetEncoding(1251);
                message.BodyEncoding = Encoding.GetEncoding(1251);

                try
                {
                    message.Attachments.Add(attachment1);
                    client.Send(message);
                }
                
                finally
                {
                    client.Dispose();
                }
            //}
        }
    }
}
