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
        /// <summary>
        /// Отправка рассылки об акциях турфирмы
        /// </summary>
        /// <param name="email"></param>
        /// <param name="name"></param>
        public void MailSalePDF(string[] email, string[] ename)
        {
            for (int i = 0; i < email.Length; i++)
            {
                 MailMessage message;
                 NetworkCredential credential;
                 SmtpClient client = new SmtpClient("smtp.rambler.ru", 587);
                 credential = new NetworkCredential("cursach.oop", "0123456789");
                 client.Credentials = credential;
                 var b = File.ReadAllBytes("doc\\SaleList.pdf");
                 var stream = new MemoryStream(b);
                 var attachment1 = new Attachment(stream, "SaleList.pdf", MediaTypeNames.Application.Pdf);
                 message = new MailMessage { Subject = ename[i] + ", Акции для вас!", Body = (i+1).ToString()};
                 message.From = new MailAddress("cursach.oop@rambler.ru");//от кого
                 message.To.Add(email[i]);//кому
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
            }            
        }
    }
}
