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
    public partial class FormHotel : Form
    {
        string IdTour = "";
        string FIO = ""; 
        string ID = "";
        string NameTour = "";
        string PriseTour = "";
        string DurationTour = "";
        string ResortTour = "";
        string DateSTour = "";
        string DateETour = "";
        int Quantity;
        int kol_tur;
        HotelList HL = new HotelList();
        public FormHotel(string idTour, string FIO_, string ID_, string nameTour, string priseTour, string durationTour, string resortTour, string dateSTour, string dateETour, int quantity, int kol_tourists)
        {
            HL.list = new List<Hotel>();
            string idHotels = "";
            InitializeComponent();
            IdTour = idTour;
            FIO = FIO_;
            ID = ID_;
            NameTour = nameTour;
            PriseTour = priseTour;
            DurationTour = durationTour;
            ResortTour = resortTour;
            DateSTour = dateSTour;
            DateETour = dateETour;
            label1.Text = NameTour;
            Quantity = quantity;
            kol_tur = kol_tourists;
            BD db = new BD();
            SQLiteConnection connection = new SQLiteConnection(@"Data Source=base.sqlite;Version=3");
            connection.Open();
            SQLiteCommand sql = new SQLiteCommand(connection);
            sql.CommandText = @"SELECT * FROM Tour_Hotel WHERE id_tour = '" + IdTour + "'";
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
            listBox1.Items.Clear();
            for (int i = 0; i < HL.list.Count; i++)
            {
                listBox1.Items.Add("----------------------------------------------------------------------------");
                listBox1.Items.Add(HL.list[i].name);
            }
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                if (FIO != "")
                {
                    Hide();
                    FormChoiceTour fct = new FormChoiceTour(IdTour, FIO, ID, NameTour, PriseTour, DurationTour, ResortTour, DateSTour, DateETour, HL.list[listBox1.SelectedIndex / 2].name, Quantity,kol_tur);
                    fct.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Войдите в систему");
                }
            }
            else
            {
                MessageBox.Show("Выберите отель");
            }
        }
    }
}
