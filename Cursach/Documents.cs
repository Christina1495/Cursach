﻿using System;
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
    class Documents
    {
        Random r = new Random();
        ReadFile rf = new ReadFile();
        public void Dogovor(string Fio, string usluga, string hotel, int date, string datas, int col, string ex, int kol_tur, int summa)
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
            string st = rf.text(@"doc\part1.txt");
            string st1 = rf.text(@"doc\part2.txt");
            iTextSharp.text.Phrase j2 = new Phrase("  " + st + Fio + " " + st1,
               new iTextSharp.text.Font(baseFont, 11, iTextSharp.text.Font.BOLDITALIC,
                   new BaseColor(Color.Black)));
            Paragraph a2 = new Paragraph(j2);
            a2.SpacingAfter = 5;
            doc.Add(a2);
            st = rf.text(@"doc\part3.txt");
            iTextSharp.text.Phrase j4 = new Phrase("1. Предмет Договора",
                new iTextSharp.text.Font(baseFont, 11, iTextSharp.text.Font.BOLDITALIC,
                    new BaseColor(Color.Black)));
            Paragraph a4 = new Paragraph(j4);
            a4.Add(Environment.NewLine);
            a4.Alignment = Element.ALIGN_CENTER;
            a4.SpacingAfter = 5;
            doc.Add(a4);
            iTextSharp.text.Phrase j3 = new Phrase(st,
                new iTextSharp.text.Font(baseFont, 11, iTextSharp.text.Font.BOLDITALIC,
                    new BaseColor(Color.Black)));
            Paragraph a3 = new Paragraph(j3);
            a3.Add(Environment.NewLine);
            a3.SpacingAfter = 5;
            doc.Add(a3);
            st = rf.text(@"doc\part4.txt");
            iTextSharp.text.Phrase j5 = new Phrase(st,
                new iTextSharp.text.Font(baseFont, 11, iTextSharp.text.Font.BOLDITALIC,
                    new BaseColor(Color.Black)));
            Paragraph a5 = new Paragraph(j5);
            a5.Add(Environment.NewLine);
            a5.SpacingAfter = 3;
            doc.Add(a5);
            iTextSharp.text.Phrase j6 = new Phrase("Наименование туристических услуг: " + usluga,
                new iTextSharp.text.Font(baseFont, 11, iTextSharp.text.Font.BOLDITALIC,
                    new BaseColor(Color.Black)));
            Paragraph a6 = new Paragraph(j6);
            a6.Add(Environment.NewLine);
            a6.SpacingAfter = 3;
            doc.Add(a6);

            iTextSharp.text.Phrase j7 = new Phrase("Размещение в отеле: " + hotel,
                new iTextSharp.text.Font(baseFont, 11, iTextSharp.text.Font.BOLDITALIC,
                    new BaseColor(Color.Black)));
            Paragraph a7 = new Paragraph(j7);
            a7.Add(Environment.NewLine);
            a7.SpacingAfter = 3;
            doc.Add(a7);
            iTextSharp.text.Phrase j8 = new Phrase("Дата заезда: " + date + " " + datas,
                new iTextSharp.text.Font(baseFont, 11, iTextSharp.text.Font.BOLDITALIC,
                    new BaseColor(Color.Black)));
            Paragraph a8 = new Paragraph(j8);
            a8.Add(Environment.NewLine);
            a8.SpacingAfter = 3;
            doc.Add(a8);
            iTextSharp.text.Phrase j9 = new Phrase("Общее количество дней тура: " + col.ToString() + " (дней/ночей)",
                new iTextSharp.text.Font(baseFont, 11, iTextSharp.text.Font.BOLDITALIC,
                    new BaseColor(Color.Black)));
            Paragraph a9 = new Paragraph(j9);
            a9.Add(Environment.NewLine);
            a9.SpacingAfter = 3;
            doc.Add(a9);

            iTextSharp.text.Phrase j10 = new Phrase("Дополнительные услуги, входящие в стоимость тура: " + ex,
                new iTextSharp.text.Font(baseFont, 11, iTextSharp.text.Font.BOLDITALIC,
                    new BaseColor(Color.Black)));
            Paragraph a10 = new Paragraph(j10);
            a10.Add(Environment.NewLine);
            a10.SpacingAfter = 3;
            doc.Add(a10);
            iTextSharp.text.Phrase j11 = new Phrase("Количество Туристов: " + kol_tur.ToString(),
                new iTextSharp.text.Font(baseFont, 11, iTextSharp.text.Font.BOLDITALIC,
                    new BaseColor(Color.Black)));
            Paragraph a11 = new Paragraph(j11);
            a11.Add(Environment.NewLine);
            a11.SpacingAfter = 3;
            doc.Add(a11);
            st = rf.text(@"doc\part5.txt");
            iTextSharp.text.Phrase j12 = new Phrase(st, new iTextSharp.text.Font(baseFont, 11, iTextSharp.text.Font.BOLDITALIC,
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
            iTextSharp.text.Phrase j15 = new Phrase("2.1. Стоимость туристических услуг на момент заключения настоящего Договора составляет: " + summa.ToString(),
               new iTextSharp.text.Font(baseFont, 11, iTextSharp.text.Font.BOLDITALIC,
                   new BaseColor(Color.Black)));
            Paragraph a15 = new Paragraph(j15);
            a15.Add(Environment.NewLine);
            a15.SpacingAfter = 3;
            doc.Add(a15);
            st = rf.text(@"doc\part6.txt");
            iTextSharp.text.Phrase j14 = new Phrase(st, new iTextSharp.text.Font(baseFont, 11, iTextSharp.text.Font.BOLDITALIC,
                    new BaseColor(Color.Black)));
            Paragraph a14 = new Paragraph(j14);
            a14.Add(Environment.NewLine);
            a14.SpacingAfter = 5;
            doc.Add(a14);
            st = rf.text(@"doc\part7.txt");
            iTextSharp.text.Phrase j16 = new Phrase(st, new iTextSharp.text.Font(baseFont, 11, iTextSharp.text.Font.BOLDITALIC,
                    new BaseColor(Color.Black)));
            Paragraph a16 = new Paragraph(j16);
            a16.Add(Environment.NewLine);
            a16.SpacingAfter = 5;
            doc.Add(a16);
            PdfPTable table = new PdfPTable(2);
            PdfPCell cell = new PdfPCell(new Phrase("Юридические адреса и подписи сторон:", new iTextSharp.text.Font(baseFont, 11, iTextSharp.text.Font.BOLDITALIC,
                    new BaseColor(Color.Black))));
            cell.Padding = 5;
            cell.Colspan = 2;
            cell.BorderColor = new BaseColor(Color.White);
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            table.AddCell(cell);
            PdfPCell cell1 = new PdfPCell(new Phrase("Турагенство ООО\"Ривьера-Сочи\"", new iTextSharp.text.Font(baseFont, 11, iTextSharp.text.Font.BOLDITALIC,
                    new BaseColor(Color.Black))));
            cell1.BorderColor = new BaseColor(Color.White);
            cell1.Rowspan = 2;
            cell1.HorizontalAlignment = Element.ALIGN_CENTER;
            table.AddCell(cell1);
            cell1 = new PdfPCell(new Phrase("Турист" + Fio, new iTextSharp.text.Font(baseFont, 11, iTextSharp.text.Font.BOLDITALIC,
                    new BaseColor(Color.Black))));
            cell1.BorderColor = new BaseColor(Color.White);
            cell1.Rowspan = 2;
            cell1.HorizontalAlignment = Element.ALIGN_CENTER;
            table.AddCell(cell1);
            PdfPCell cell2 = new PdfPCell(new Phrase("Адрес: 354000, г.Сочи, ул. Конституции СССР, 18/В", new iTextSharp.text.Font(baseFont, 11, iTextSharp.text.Font.BOLDITALIC,
                    new BaseColor(Color.Black))));
            cell2.BorderColor = new BaseColor(Color.White);
            cell2.Rowspan = 2;
            cell2.HorizontalAlignment = Element.ALIGN_CENTER;
            table.AddCell(cell2);
            cell2 = new PdfPCell(new Phrase("Адрес: ", new iTextSharp.text.Font(baseFont, 11, iTextSharp.text.Font.BOLDITALIC,
                    new BaseColor(Color.Black))));
            cell2.BorderColor = new BaseColor(Color.White);
            cell2.Rowspan = 2;
            cell2.HorizontalAlignment = Element.ALIGN_CENTER;
            table.AddCell(cell2);
            PdfPCell cell3 = new PdfPCell(new Phrase("ИНН: 123467890 Расчетный счет: 12345678901234567890 БИК:123456789 Банк: ОАО «Бин-Банк» г. Сочи", new iTextSharp.text.Font(baseFont, 11, iTextSharp.text.Font.BOLDITALIC,
                    new BaseColor(Color.Black))));
            cell3.BorderColor = new BaseColor(Color.White);
            cell3.Rowspan = 2;
            cell3.HorizontalAlignment = Element.ALIGN_CENTER;
            table.AddCell(cell3);
            cell3 = new PdfPCell(new Phrase("0000", new iTextSharp.text.Font(baseFont, 11, iTextSharp.text.Font.BOLDITALIC,
                    new BaseColor(Color.Black))));
            cell3.BorderColor = new BaseColor(Color.White);
            cell3.Rowspan = 3;
            cell3.HorizontalAlignment = Element.ALIGN_CENTER;
            table.AddCell(cell3);
            PdfPCell cell4 = new PdfPCell(new Phrase("________________/_________", new iTextSharp.text.Font(baseFont, 11, iTextSharp.text.Font.BOLDITALIC,
                    new BaseColor(Color.Black))));
            cell4.BorderColor = new BaseColor(Color.White);
            cell4.Rowspan = 2;
            cell4.HorizontalAlignment = Element.ALIGN_CENTER;
            table.AddCell(cell4);
            cell4 = new PdfPCell(new Phrase("________________/_________", new iTextSharp.text.Font(baseFont, 11, iTextSharp.text.Font.BOLDITALIC,
                    new BaseColor(Color.Black))));
            cell4.BorderColor = new BaseColor(Color.White);
            cell4.Rowspan = 3;
            cell4.HorizontalAlignment = Element.ALIGN_CENTER;
            table.AddCell(cell4);
            doc.Add(table);
            doc.Close();
        }

        public void PaymentAccount()
        {

        }
    }
}
