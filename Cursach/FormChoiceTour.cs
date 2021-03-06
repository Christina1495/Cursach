﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cursach
{
    public partial class FormChoiceTour : Form
    {
        string IDTour = "";
        string FIO = "";
        string ID = "";
        string NameTour = "";
        int PriseTour;
        string DurationTour = "";
        string ResortTour = "";
        string DateSTour = "";
        string DateETour = "";
        string HotelTour = "";
        int Quantity;
        int allCost;
        string ExCost = "";
        string ExId = "";
        int TourCost;
        bool H = false;
        HotelList HL = new HotelList();
        ExcursionList EL = new ExcursionList();

        public FormChoiceTour(string idTour, string FIO_, string ID_, string nameTour, string priseTour, string durationTour, string resortTour, string dateSTour, string dateETour, string hotelTour, int quantity)
        {
            HL.list = new List<Hotel>();
            string idHotels = "";
            EL.list = new List<Excursion>();
            InitializeComponent();
            FIO = FIO_;
            IDTour = idTour;
            ID = ID_;
            NameTour = nameTour;
            PriseTour = Convert.ToInt32(priseTour);
            DurationTour = durationTour;
            ResortTour = resortTour;
            DateSTour = dateSTour;
            DateETour = dateETour;
            HotelTour = hotelTour;
            Quantity = quantity;
            label1.Text = FIO;
            tb_info.Text = "Тур: " + NameTour + Environment.NewLine;
            label3.Text = "Курорт: " + ResortTour;
            label4.Text = "Продолжительность: " + DurationTour;
            for (int i = 1; i < 31; i++)
            {
                cb_day.Items.Add(i);
            }
            bool S = false;
            string[] Date = { "Января", "Февраля", "Марта", "Апреля", "Мая", "Июня", "Июля", "Августа", "Сентября", "Октября", "Ноября", "Декабря" };
            string[] DCB = { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };
            for (int i = 0; i < DCB.GetLength(0); i++)
            {
                if(Date[i] == DateSTour)
                {
                    S = true;
                }
                if(S == true)
                {
                    cb_month.Items.Add(DCB[i]);
                }
                if(Date[i] == DateETour)
                {
                    S = false;
                }
            }
            allCost = PriseTour * Quantity;
            TourCost = allCost;
            label5.Text = "Сумма к оплате: " + Convert.ToString(allCost);
            BD db = new BD();
            SQLiteConnection connection = new SQLiteConnection(@"Data Source=base.sqlite;Version=3");
            connection.Open();
            SQLiteCommand sql = new SQLiteCommand(connection);
            sql.CommandText = @"SELECT * FROM Tour_Hotel WHERE id_tour = '" + IDTour + "'";
            SQLiteDataReader reader = sql.ExecuteReader();
            foreach (DbDataRecord record in reader)
            {
                idHotels += record["id_hotel"].ToString() + ",";
            }
            string[] arrHotels = idHotels.Split(',');
            for (int i = 0; i < arrHotels.GetLength(0); i++)
            {
                Hotel H = new Hotel();
                SQLiteCommand sql1 = new SQLiteCommand(connection);
                sql1.CommandText = @"SELECT * FROM Hotel WHERE id_hotel = '" + arrHotels[i] + "'";
                SQLiteDataReader reader1 = sql1.ExecuteReader();
                foreach (DbDataRecord record in reader1)
                {
                    H.id = record["id_hotel"].ToString();
                    H.name = record["hotel_name"].ToString();
                    HL.list.Add(H);
                }
            }
            lb_ex.Items.Clear();
            for (int i = 0; i < HL.list.Count; i++)
            {
                lb_hotel.Items.Add("--------------------------------------------------------");
                lb_hotel.Items.Add(HL.list[i].name);
            }
            connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string idResort = "";
            BD db = new BD();
            SQLiteConnection connection = new SQLiteConnection(@"Data Source=base.sqlite;Version=3");
            connection.Open();
            SQLiteCommand sql = new SQLiteCommand(connection);
            sql.CommandText = @"SELECT * FROM Resort WHERE Name = '" + ResortTour + "'";
            SQLiteDataReader reader = sql.ExecuteReader();
            foreach (DbDataRecord record in reader)
            {
                idResort = record["id_resort"].ToString();
            }
            SQLiteCommand sql1 = new SQLiteCommand(connection);
            sql1.CommandText = @"SELECT * FROM Excursion WHERE id_resort = '" + idResort + "'";
            SQLiteDataReader reader1 = sql1.ExecuteReader();
            foreach (DbDataRecord record in reader1)
            {
                Excursion E = new Excursion();
                E.id = record["id_excursion"].ToString();
                E.name = record["exc_name"].ToString();
                E.description = record["description_exc"].ToString();
                E.duration = record["duration_exc"].ToString();
                E.price = record["price_exc"].ToString();
                E.marks = record["marks"].ToString();
                EL.list.Add(E);
            }
            lb_ex.Items.Clear();
            for (int i = 0; i < EL.list.Count; i++)
            {
                lb_ex.Items.Add("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                lb_ex.Items.Add(EL.list[i].name + "   Цена: " + EL.list[i].price + "руб.   Продолжительность: " + EL.list[i].duration + "   Оценка: " + EL.list[i].marks);
            }
            connection.Close();
        }

        bool flag = false;  

        private void button1_Click(object sender, EventArgs e)
        {
            string dop = "";
            if (flag) dop = "экскурсии";
            else dop = "нет";
            if (cb_day.Text != "")
            {
                int dates = Convert.ToInt32(cb_day.Text);
                Hide();
                FormDogovor FD = new FormDogovor(ID, FIO, IDTour, NameTour, HotelTour, dates, DateSTour, Convert.ToInt32(DurationTour), dop, Quantity, allCost, TourCost, ExCost, ExId, listEx);
                FD.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Выберите дату");
            }
        }

        private void FormChoiceTour_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            BD db = new BD();
            if (lb_ex.SelectedIndex != -1)
            {
                db.marks(Convert.ToInt32(nud_marks.Value), EL.list[lb_ex.SelectedIndex / 2].marks, EL.list[lb_ex.SelectedIndex / 2].id);
                EL.list[lb_ex.SelectedIndex / 2].marks = Convert.ToString((Convert.ToInt32(nud_marks.Value) + Convert.ToInt32(EL.list[lb_ex.SelectedIndex / 2].marks)) / 2);
                lb_ex.Items.Clear();
                for (int i = 0; i < EL.list.Count; i++)
                {
                    lb_ex.Items.Add("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                    lb_ex.Items.Add(EL.list[i].name + "   Цена: " + EL.list[i].price + "руб.   Продолжительность: " + EL.list[i].duration + "   Оценка: " + EL.list[i].marks);
                }
            }
            else
            {
                MessageBox.Show("Выберите экскурсию");
            }
        }

        private void информацияОбЭкскурсииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lb_ex.SelectedIndex != -1)
            {
                FormDescription fd = new FormDescription(EL.list[lb_ex.SelectedIndex / 2].name, EL.list[lb_ex.SelectedIndex / 2].description);
                fd.ShowDialog();
            }
            else
            {
                MessageBox.Show("Выберите экскурсию");
            }
        }

        List<string> listEx = new List<string>();

        private void добавитьЭкскурсиюВТурToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ind = lb_ex.Text.IndexOf("----");
            if (ind == -1)
            {
                if (lb_ex.SelectedIndex != -1)
                {
                    tb_info.Text += "Экскурсия: " + EL.list[lb_ex.SelectedIndex / 2].name + Environment.NewLine;
                    listEx.Add("Экскурсия:" + EL.list[lb_ex.SelectedIndex / 2].name + " Цена:" + EL.list[lb_ex.SelectedIndex / 2].price);
                    ExId += EL.list[lb_ex.SelectedIndex / 2].id + "|";
                    ExCost += Convert.ToString(Quantity * Convert.ToInt32(EL.list[lb_ex.SelectedIndex / 2].price)) + "|";
                    allCost += Quantity * Convert.ToInt32(EL.list[lb_ex.SelectedIndex / 2].price);
                    label5.Text = "Сумма к оплате: " + Convert.ToString(allCost);
                    flag = true;
                }
                else
                {
                    MessageBox.Show("Выберите экскурсию");
                }
            }
            else
            {
                lb_ex.ClearSelected();
            }
        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {

        }

        private void выбратьОтельToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ind = lb_hotel.Text.IndexOf("----");
            if (ind == -1)
            {
                if (H == true)
                {
                    int index = tb_info.Text.IndexOf("Отель: ");
                    if (index != -1)
                    {
                        int index2 = tb_info.Text.IndexOf(" * ");
                        if (index2 != -1)
                        {
                            tb_info.Text = tb_info.Text.Remove(index - 1, index2 - index + 3);
                        }
                    }
                }
                if (lb_hotel.SelectedIndex != -1)
                {
                    HotelTour = HL.list[lb_hotel.SelectedIndex / 2].name;
                    tb_info.Text += "Отель: " + HL.list[lb_hotel.SelectedIndex / 2].name + " * " + Environment.NewLine;
                    H = true;
                }
                else
                {
                    MessageBox.Show("Выберите отель");
                }
            }
            else
            {
                lb_hotel.ClearSelected();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int index = tb_info.Text.IndexOf("Экскурсия: ");
            if(index != -1)
            {
                tb_info.Text = tb_info.Text.Remove(index - 1);
            }
        }

        private void FormChoiceTour_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Form1 f1 = new Form1(FIO, ID);
            //f1.Show();
        }

        private void cms_hotel_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
