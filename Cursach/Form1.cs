﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.Common;

namespace Cursach
{
    public partial class Form1 : Form
    {
        string FIO;
        string ID;
        TourList TL = new TourList();
        DiscountList DL = new DiscountList();
        Documents doc = new Documents();

        public Form1(string FIO_, string ID_)
        {
            DateTime CurrentTime = DateTime.Now;
            InitializeComponent();
            FIO = FIO_;
            ID = ID_;
            label8.Text = "" + FIO + "";
            if (label8.Text == "")
            {
                button4.Visible = false;
                label7.Visible = false;
            }

            else
                if (label8.Text == "Admin")
                {
                    label7.Visible = true;
                    button4.Visible = false;
                }
                    
                else
                {
                    label7.Visible = false;
                    button4.Visible = true;
                }
                 
            string d = CurrentTime.ToString("dd.MM.yyyy");
            label6.Text = "Сегодня: " + d ;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            DL.list.Clear();
            SQLiteConnection connection = new SQLiteConnection(@"Data Source=base.sqlite;Version=3");
            connection.Open();
            SQLiteCommand sql = new SQLiteCommand(connection);
            sql.CommandText = @"SELECT * FROM Discount";
            SQLiteDataReader reader = sql.ExecuteReader();
            foreach (DbDataRecord record in reader)
            {
                Discount D = new Discount();
                D.nameTour = record["name_tour"].ToString();
                D.id = record["id_discount"].ToString();
                D.price = record["prices"].ToString();
                D.discount = record["discount"].ToString();
                D.description = record["description"].ToString();
                D.idResort = record["id_resort"].ToString();
                SQLiteCommand sql1 = new SQLiteCommand(connection);
                sql1.CommandText = @"SELECT * FROM Resort WHERE id_resort = '" + record["id_resort"].ToString() +"'";
                SQLiteDataReader reader1 = sql1.ExecuteReader();
                foreach (DbDataRecord record1 in reader1)
                {
                    D.nameResort = record1["Name"].ToString();
                }
                DL.list.Add(D);
            }
            connection.Close();
            //Thread.Sleep(600);
            //backgroundWorker1.ReportProgress(i, s);           
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //string s = (string)e.UserState;
            //textBox1.Text = s;
            //progressBar1.Value = e.ProgressPercentage; 
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            listBox2.Items.Clear();
            for (int i = 0; i < DL.list.Count; i++)
            {
                listBox2.Items.Add("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                listBox2.Items.Add((i+1).ToString() + ") Описание: " + DL.list[i].description);
                listBox2.Items.Add("Курорт: " + DL.list[i].nameResort + "  Тур: " + DL.list[i].nameTour + "   Цена: " + DL.list[i].price + "руб.  Скидка: " + DL.list[i].discount + "%");
                
            }
            doc.SalePDF(DL.list);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BD db = new BD();
            TL.list = new List<Tour>();
            DL.list = new List<Discount>();
            db.ResortComboBox();
            string[] RCB = db.ResortCB.Split(',');
            comboBox1.Items.AddRange(RCB);
            string[] DCB = { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };
            comboBox2.Items.AddRange(DCB);
            backgroundWorker1.RunWorkerAsync();
        }

        private void comboBox3_Click(object sender, EventArgs e)
        {
            comboBox3.Items.Clear();
            string[] DCB = { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };
            int index = 100;
            if (comboBox2.Text != "")
            {               
                string Text = "";
                string Text1 = "";
                for (int i = 0; i < DCB.GetLength(0); i++)
                {
                    if (DCB[i] == comboBox2.Text)
                    {
                        index = i;
                    }
                    if (i > index)
                    {
                        Text += DCB[i] + ",";
                    }
                    else
                    {
                        Text1 += DCB[i] + ",";
                    }
                }
                Text += Text1;
                Text = Text.Remove(Text.Length - 1, 1);
                string[] DCB2 = Text.Split(',');
                comboBox3.Items.AddRange(DCB2);
                index = 100;
            }
            else
            {
                comboBox3.Items.AddRange(DCB);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            TL.list.Clear();
            BD db = new BD();
            db.UserRequestsTour(comboBox1.Text, comboBox2.Text, comboBox3.Text, textBox1.Text, textBox2.Text, Convert.ToString(numericUpDown2.Value - 1), Convert.ToString(numericUpDown3.Value + 1));
            SQLiteConnection connection = new SQLiteConnection(@"Data Source=base.sqlite;Version=3");
            connection.Open();
            SQLiteCommand sql = new SQLiteCommand(connection);
            sql.CommandText = @"" + db.Condition + @"";
            SQLiteDataReader reader = sql.ExecuteReader();
            foreach (DbDataRecord record in reader)
            {
                Tour T = new Tour();
                db.ResortComboBox();
                string[] Resort = db.ResortCB.Split(',');
                string[] Date = { "Января", "Февраля", "Марта", "Апреля", "Мая", "Июня", "Июля", "Августа", "Сентября", "Октября", "Ноября", "Декабря" };
                T.name = record["tour_name"].ToString();
                T.id = record["id_tour"].ToString();
                T.price = record["price"].ToString();
                T.duration = record["duration"].ToString();
                T.resort = Resort[Convert.ToInt32(record["id_resort"].ToString()) - 2];
                T.dateS = Date[Convert.ToInt32(record["dateS"].ToString()) - 1];
                T.dateE = Date[Convert.ToInt32(record["dataE"].ToString()) - 1];
                TL.list.Add(T);
            }
            listBox1.Items.Clear();
            for (int i = 0; i < TL.list.Count; i++)
            {
                listBox1.Items.Add("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                listBox1.Items.Add(TL.list[i].name + "   Цена: " + TL.list[i].price + "руб.   Продолжительность: " + TL.list[i].duration + "   Курорт: " + TL.list[i].resort + "   Даты тура: c " + TL.list[i].dateS + " до " + TL.list[i].dateE);
                
            }
            doc.Calc(TL.list);
            connection.Close();
        }

        private void button2_Click_1(object sender, EventArgs e) 
        {
            if (listBox1.SelectedIndex != -1 && label8.Text != "")
            {
                Hide();
                FormChoiceTour fct = new FormChoiceTour(TL.list[listBox1.SelectedIndex / 2].id, FIO, ID, TL.list[listBox1.SelectedIndex / 2].name, TL.list[listBox1.SelectedIndex / 2].price, TL.list[listBox1.SelectedIndex / 2].duration, TL.list[listBox1.SelectedIndex / 2].resort, TL.list[listBox1.SelectedIndex / 2].dateS, TL.list[listBox1.SelectedIndex / 2].dateE, "", Convert.ToInt32(numericUpDown1.Value));
                fct.ShowDialog();
                this.Close();
            }
            else
            {
                if (listBox2.SelectedIndex != -1 && label8.Text != "")
                {
                    Hide();
                    FormChoiceTour fct = new FormChoiceTour(DL.list[listBox2.SelectedIndex / 3].id, FIO, ID, DL.list[listBox2.SelectedIndex / 3].nameTour, DL.list[listBox2.SelectedIndex / 3].price, "10", DL.list[listBox2.SelectedIndex / 3].nameResort, "Января", "Декабрь", "", Convert.ToInt32(numericUpDown4.Value));
                    fct.ShowDialog();
                    this.Close();
                }
                else
                {
                    if (label8.Text == "") MessageBox.Show("Авторизируйтесь");
                    else
                    {
                        if (listBox2.SelectedIndex == -1) MessageBox.Show("Выберите тур");
                    }
                }
                
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Hide();
            FormAuthorization fa = new FormAuthorization();
            fa.ShowDialog();
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormPersonal FP = new FormPersonal(FIO, ID);
            FP.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BD db = new BD();
            db.Сreate();
            //Documents doc = new Documents();
            //for (int i = 0; i < listBox1.Items.Count; i++)
            //{
            //db.Resort();
            //    doc.Calc(listBox1.Items[i].ToString());
            //}
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            backgroundWorker2.RunWorkerAsync();
            //try
            //{
            //    Mail m = new Mail();
            //    m.MailSalePDF();
            //    MessageBox.Show("Done");
            //}
            //catch (Exception exc)
            //{
            //    MessageBox.Show(exc.ToString());
            //}
            
        }
        //Mail m = new Mail();
        //string ename = "";
        //private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        //{
        //    SQLiteConnection connection = new SQLiteConnection(@"Data Source=base.sqlite;Version=3");
        //    connection.Open();
        //    SQLiteCommand sql = new SQLiteCommand(connection);
        //    sql.CommandText = @"SELECT * FROM Customer";
        //    SQLiteDataReader reader = sql.ExecuteReader();
            
        //    foreach (DbDataRecord record in reader)
        //    {
        //        ename = record["FIO"].ToString();
        //        string em = record["email"].ToString();
        //        Thread.Sleep(600);
        //        backgroundWorker2.ReportProgress(1, em);
                
        //    }
        //    connection.Close();
        //}       

        //private void backgroundWorker2_ProgressChanged(object sender, ProgressChangedEventArgs e)
        //{
        //    try
        //    {
        //        m.MailSalePDF((string)e.UserState, ename);
        //    }
        //    catch (Exception exc)
        //    {
        //        MessageBox.Show(exc.ToString());
        //    }
        //}

        //private void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        //{
        //    MessageBox.Show("okok");
        //}
    }
}
