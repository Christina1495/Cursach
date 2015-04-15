using System;
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
        string IdTour;
        string FIO; 
        string ID;
        string NameTour;
        HotelList HL = new HotelList();
        public FormHotel(string idTour, string FIO_, string ID_, string nameTour)
        {
            HL.list = new List<Hotel>();
            string idHotels = "";
            InitializeComponent();
            IdTour = idTour;
            FIO = FIO_;
            ID = ID_;
            NameTour = nameTour;
            label1.Text = NameTour;
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
            //listBox1.Items.Add(idHotels);
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
                listBox1.Items.Add(HL.list[i].name);
                listBox1.Items.Add("----------------------------------------------------------------------------");
            }
            connection.Close();
        }
    }
}
