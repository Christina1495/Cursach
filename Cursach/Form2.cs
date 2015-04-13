using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.Common;


namespace Cursach
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            SQLiteConnection connection = new SQLiteConnection(@"Data Source=base.sqlite;Version=3");
            connection.Open();
            SQLiteCommand sql = new SQLiteCommand(connection);
            sql.CommandText = @"SELECT * FROM Resort";
            SQLiteDataReader sdr = sql.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sdr);
            dataGridView1.DataSource = dt;
            sql.CommandText = @"SELECT * FROM Customer";
            sdr = sql.ExecuteReader();
            dt = new DataTable();
            dt.Load(sdr);
            dataGridView2.DataSource = dt;
            sql.CommandText = @"SELECT * FROM Hotel";
            sdr = sql.ExecuteReader();
            dt = new DataTable();
            dt.Load(sdr);
            dataGridView3.DataSource = dt;
            sql.CommandText = @"SELECT * FROM Tour";
            sdr = sql.ExecuteReader();
            dt = new DataTable();
            dt.Load(sdr);
            dataGridView4.DataSource = dt;
            sql.CommandText = @"SELECT * FROM Tour_Hotel";
            sdr = sql.ExecuteReader();
            dt = new DataTable();
            dt.Load(sdr);
            dataGridView5.DataSource = dt;
            sql.CommandText = @"SELECT * FROM Excursion";
            sdr = sql.ExecuteReader();
            dt = new DataTable();
            dt.Load(sdr);
            dataGridView6.DataSource = dt;
            sql.CommandText = @"SELECT * FROM Discount";
            sdr = sql.ExecuteReader();
            dt = new DataTable();
            dt.Load(sdr);
            dataGridView7.DataSource = dt;
            sdr.Close();
            sql.CommandText = @"SELECT * FROM Customer_Tour";
            sdr = sql.ExecuteReader();
            dt = new DataTable();
            dt.Load(sdr);
            dataGridView8.DataSource = dt;
            sql.CommandText = @"SELECT * FROM Tour_Excursion";
            sdr = sql.ExecuteReader();
            dt = new DataTable();
            dt.Load(sdr);
            dataGridView9.DataSource = dt;
            sql.CommandText = @"SELECT * FROM Date_Tour";
            sdr = sql.ExecuteReader();
            dt = new DataTable();
            dt.Load(sdr);
            dataGridView10.DataSource = dt;
            sql.CommandText = @"SELECT * FROM Bank_Customer";
            sdr = sql.ExecuteReader();
            dt = new DataTable();
            dt.Load(sdr);
            dataGridView11.DataSource = dt;
            sdr.Close();
            connection.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
