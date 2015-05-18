﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cursach
{
    public partial class FormPayment : Form
    {
        string ID_;
        string FIO;
        string ID;
        string DATE;
        string PAID;
        string PRICE;
        string IDTour;
        string NUMBER;
        string allSUM;
        string PayList;
        BD db = new BD();
        public FormPayment(string id_, string FIO_, string id, string date, string paid, string price, string idTour, string number_, string Allprise_)
        {
            InitializeComponent();
            ID_ = id_;
            FIO = FIO_;
            ID = id;
            DATE = date;
            PAID = paid;
            PRICE = price;
            IDTour = idTour;
            db.FormDog(ID_);
            l_info.Text += PRICE;
            NUMBER = number_;
            allSUM = Allprise_;
            PayList = db.Account;
        }

        DateTime Now = DateTime.Now;
        //List<string> clientBank;
        private void button1_Click(object sender, EventArgs e)
        {            
            Documents doc = new Documents();
            doc.Client_Bank(FIO, Convert.ToInt32(allSUM), Convert.ToInt32(tb_summa.Text) + Convert.ToInt32(PAID), Convert.ToInt32(tb_summa.Text), PayList, NUMBER);
            int sum = Convert.ToInt32(tb_summa.Text) + Convert.ToInt32(PAID);
            db.BankCustomer(tb_summa.Text, DATE, ID, Convert.ToString(sum), PRICE);
            db.DateTour(tb_summa.Text, Now.ToString("MM.yyyy"), IDTour);
            MessageBox.Show("Оплата произведена");
            Hide();
            FormPersonal FP = new FormPersonal(FIO, ID_);
            FP.Show();
            this.Close();


            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
//clientBank = new List<string>();
//this.Size = new Size(this.Width, this.Height + 308);
//clientBank.Add("1CCLIENTBANKExchenge");
//clientBank.Add("Версияфората=1.01");
//clientBank.Add("Кодировка=Windows");
//clientBank.Add("ДатаНачала");
//clientBank.Add("ДатаКонца");
//clientBank.Add("РасчСчет=12345678901234567890");
//clientBank.Add("СекцияРасчСчет");
//clientBank.Add("ДатаНачала");
//clientBank.Add("ДатаКонца");
//clientBank.Add("РасчСчет=12345678901234567890");
//clientBank.Add("Всего=");
//clientBank.Add("Поступило=");
//clientBank.Add("Остаток");
//clientBank.Add("КонецРасчСчет");
//clientBank.Add("СекцияДокумент=Движение по счету");
//clientBank.Add("Номер=");
//clientBank.Add("Дата=" + Now.ToString("dd.MM.yyyy"));
//clientBank.Add("Сумма=" + textBox2.Text);
//clientBank.Add("ПлательщикСчет=" + db.Account);
//listBox1.DataSource = clientBank;
//SaveFile sf = new SaveFile();// посмотри путь, у меня не находит 
//for (int i = 0; i < listBox1.Items.Count; i++)
//{
//    sf.SaveAll(@"\ClientBank\" + Now.ToString("ddMMyyyy") + ".txt", listBox1.Items[i].ToString());
//}