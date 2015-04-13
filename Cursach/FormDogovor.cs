using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp;
using System.IO;
using iTextSharp.text.pdf;

namespace Cursach
{
    public partial class FormDogovor : Form
    {
        public FormDogovor()
        {
            InitializeComponent();
        }
        Random r = new Random();
        ReadFile rf = new ReadFile();

        private void button1_Click(object sender, EventArgs e)
        {
            var doc = new Document();
            PdfWriter.GetInstance(doc, new FileStream(Application.StartupPath + @"\doc\Document.pdf", FileMode.Create));
            doc.Open();
            BaseFont baseFont = BaseFont.CreateFont(@"times.TTF", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Phrase j = new Phrase("Договор №" + r.Next(1, 30),
                new iTextSharp.text.Font(baseFont, 11, iTextSharp.text.Font.BOLDITALIC,
                    new BaseColor(Color.Black)));
            Paragraph a1 = new Paragraph(j);
            a1.Add(Environment.NewLine);
            a1.Alignment = Element.ALIGN_CENTER;
            a1.SpacingAfter = 5;
            doc.Add(a1);
            string s = rf.text(@"doc\part1.txt");
            string s1 = rf.text(@"doc\part2.txt");
            iTextSharp.text.Phrase j2 = new Phrase("  " + s + textBox1.Text + " " + s1,
               new iTextSharp.text.Font(baseFont, 11, iTextSharp.text.Font.BOLDITALIC,
                   new BaseColor(Color.Black)));
            Paragraph a2 = new Paragraph(j2);
            a2.SpacingAfter = 5;
            doc.Add(a2);
            s = rf.text(@"doc\part3.txt");
            iTextSharp.text.Phrase j4 = new Phrase("1. Предмет Договора",
                new iTextSharp.text.Font(baseFont, 11, iTextSharp.text.Font.BOLDITALIC,
                    new BaseColor(Color.Black)));
            Paragraph a4 = new Paragraph(j4);
            a4.Add(Environment.NewLine);
            a4.Alignment = Element.ALIGN_CENTER;
            a4.SpacingAfter = 5;
            doc.Add(a4);
            iTextSharp.text.Phrase j3 = new Phrase(s,
                new iTextSharp.text.Font(baseFont, 11, iTextSharp.text.Font.BOLDITALIC,
                    new BaseColor(Color.Black)));
            Paragraph a3 = new Paragraph(j3);
            a3.Add(Environment.NewLine);
            a3.SpacingAfter = 5;
            doc.Add(a3);
            s = rf.text(@"doc\part4.txt");
            iTextSharp.text.Phrase j5 = new Phrase(s,
                new iTextSharp.text.Font(baseFont, 11, iTextSharp.text.Font.BOLDITALIC,
                    new BaseColor(Color.Black)));
            Paragraph a5 = new Paragraph(j5);
            a5.Add(Environment.NewLine);
            a5.SpacingAfter = 3;
            doc.Add(a5);
            iTextSharp.text.Phrase j6 = new Phrase("Наименование туристических услуг: " + textBox2.Text,
                new iTextSharp.text.Font(baseFont, 11, iTextSharp.text.Font.BOLDITALIC,
                    new BaseColor(Color.Black)));
            Paragraph a6 = new Paragraph(j6);
            a6.Add(Environment.NewLine);
            a6.SpacingAfter = 3;
            doc.Add(a6);

            iTextSharp.text.Phrase j7 = new Phrase("Размещение в отеле: " + textBox3.Text,
                new iTextSharp.text.Font(baseFont, 11, iTextSharp.text.Font.BOLDITALIC,
                    new BaseColor(Color.Black)));
            Paragraph a7 = new Paragraph(j7);
            a7.Add(Environment.NewLine);
            a7.SpacingAfter = 3;
            doc.Add(a7);
            iTextSharp.text.Phrase j8 = new Phrase("Дата заезда: " + textBox4.Text,
                new iTextSharp.text.Font(baseFont, 11, iTextSharp.text.Font.BOLDITALIC,
                    new BaseColor(Color.Black)));
            Paragraph a8 = new Paragraph(j8);
            a8.Add(Environment.NewLine);
            a8.SpacingAfter = 3;
            doc.Add(a8);
            iTextSharp.text.Phrase j9 = new Phrase("Общее количество дней тура: " + textBox5.Text+ " (дней/ночей)",
                new iTextSharp.text.Font(baseFont, 11, iTextSharp.text.Font.BOLDITALIC,
                    new BaseColor(Color.Black)));
            Paragraph a9 = new Paragraph(j9);
            a9.Add(Environment.NewLine);
            a9.SpacingAfter = 3;
            doc.Add(a9);

            iTextSharp.text.Phrase j10 = new Phrase("Дополнительные услуги, входящие в стоимость тура: " + textBox6.Text ,
                new iTextSharp.text.Font(baseFont, 11, iTextSharp.text.Font.BOLDITALIC,
                    new BaseColor(Color.Black)));
            Paragraph a10 = new Paragraph(j10);
            a10.Add(Environment.NewLine);
            a10.SpacingAfter = 3;
            doc.Add(a10);
            iTextSharp.text.Phrase j11 = new Phrase("Количество Туристов: " + textBox7.Text,
                new iTextSharp.text.Font(baseFont, 11, iTextSharp.text.Font.BOLDITALIC,
                    new BaseColor(Color.Black)));
            Paragraph a11 = new Paragraph(j11);
            a11.Add(Environment.NewLine);
            a11.SpacingAfter = 3;
            doc.Add(a11);
            s = rf.text(@"doc\part5.txt");
            iTextSharp.text.Phrase j12 = new Phrase(s,new iTextSharp.text.Font(baseFont, 11, iTextSharp.text.Font.BOLDITALIC,
                    new BaseColor(Color.Black)));
            Paragraph a12 = new Paragraph(j12);
            a12.Add(Environment.NewLine);
            a12.SpacingAfter = 5;
            doc.Add(a12);
            iTextSharp.text.Phrase j13 = new Phrase("2. Условия оплаты",
                new iTextSharp.text.Font(baseFont, 11, iTextSharp.text.Font.BOLDITALIC,
                    new BaseColor(Color.Black)));
            Paragraph a13 = new Paragraph(j13);
            a13.Add(Environment.NewLine);
            a13.Alignment = Element.ALIGN_CENTER;
            a13.SpacingAfter = 5;
            doc.Add(a13);
            iTextSharp.text.Phrase j15 = new Phrase("2.1. Стоимость туристических услуг на момент заключения настоящего Договора составляет: " + textBox8.Text,
               new iTextSharp.text.Font(baseFont, 11, iTextSharp.text.Font.BOLDITALIC,
                   new BaseColor(Color.Black)));
            Paragraph a15 = new Paragraph(j15);
            a15.Add(Environment.NewLine);
            a15.SpacingAfter = 3;
            doc.Add(a15);
            s = rf.text(@"doc\part6.txt");
            iTextSharp.text.Phrase j14 = new Phrase(s, new iTextSharp.text.Font(baseFont, 11, iTextSharp.text.Font.BOLDITALIC,
                    new BaseColor(Color.Black)));
            Paragraph a14 = new Paragraph(j14);
            a14.Add(Environment.NewLine);
            a14.SpacingAfter = 5;
            doc.Add(a14);

            doc.Close();


            MessageBox.Show("Done!");
        }


    }
}
