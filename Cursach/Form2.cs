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

namespace Cursach
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQLiteConnection connection = new SQLiteConnection(@"Data Source=base.sqlite;Version=3");
            connection.Open();
            SQLiteCommand sql = new SQLiteCommand(connection);
            //sql.CommandText = @"SELECT * FROM Resort";
            //sql.CommandText = @"SELECT * FROM Customer";
            sql.CommandText = @"SELECT * FROM Hotel";
            SQLiteDataReader sdr = sql.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sdr);
            dataGridView1.DataSource = dt;
            sdr.Close();
            connection.Close();
        }
    }
}
