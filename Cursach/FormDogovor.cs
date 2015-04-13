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
            iTextSharp.text.Phrase j2 = new Phrase("  " + s + textBox1.Text + s1,
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
            a5.SpacingAfter = 5;
            doc.Add(a5);
            iTextSharp.text.Phrase j6 = new Phrase("Наименование туристических услуг: " + textBox2.Text,
                new iTextSharp.text.Font(baseFont, 11, iTextSharp.text.Font.BOLDITALIC,
                    new BaseColor(Color.Black)));
            Paragraph a6 = new Paragraph(j6);
            a6.Add(Environment.NewLine);
            a6.SpacingAfter = 5;
            doc.Add(a6);

            iTextSharp.text.Phrase j7 = new Phrase("Размещение в отеле: " + textBox3.Text,
                new iTextSharp.text.Font(baseFont, 11, iTextSharp.text.Font.BOLDITALIC,
                    new BaseColor(Color.Black)));
            Paragraph a7 = new Paragraph(j7);
            a7.Add(Environment.NewLine);
            a7.SpacingAfter = 5;
            doc.Add(a7);
            doc.Close();


            MessageBox.Show("Done!");
        }


    }
}
