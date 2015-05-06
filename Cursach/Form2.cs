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
using System.Threading;


namespace Cursach
{
    public partial class Form2 : Form
    {
        BD db = new BD();
        Date_TourList DTL = new Date_TourList();
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
            sql.CommandText = @"SELECT * FROM Tour"; // INNER JOIN Resort ON Tour.id_resort = Resort.id_resort
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
            sql.CommandText = @"SELECT * FROM Category";
            sdr = sql.ExecuteReader();
            dt = new DataTable();
            dt.Load(sdr);
            dataGridView12.DataSource = dt;
            sql.CommandText = @"SELECT * FROM Stuff";
            sdr = sql.ExecuteReader();
            dt = new DataTable();
            dt.Load(sdr);
            dataGridView13.DataSource = dt;
            sdr.Close();
            connection.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DTL.list = new List<Date_Tour>();
       }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                db.UPDATE("Resort SET Name = '" + dataGridView1.SelectedCells[1].Value.ToString() + "'", "id_resort = '" + dataGridView1.SelectedCells[0].Value.ToString() + "'");
            }
            catch
            {
                MessageBox.Show("Сторка не выбрана");
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            try
            {
                db.INSERT("'Resort' ('Name') VALUES ('" + dataGridView1.SelectedCells[1].Value.ToString() + @"')");
            }
            catch
            {
                MessageBox.Show("Сторка не выбрана");
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                db.DELETE("'Resort'", "id_resort = '" + dataGridView1.SelectedCells[0].Value.ToString() + "'");
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
            catch
            {
                MessageBox.Show("Сторка не выбрана");
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            try
            {
                db.UPDATE("Customer SET FIO = '" + dataGridView2.SelectedCells[1].Value.ToString() + "' , email = '" + dataGridView2.SelectedCells[2].Value.ToString() + "', password = '" + dataGridView2.SelectedCells[3].Value.ToString() + "', city = '" + dataGridView2.SelectedCells[4].Value.ToString() + "', street = '" + dataGridView2.SelectedCells[5].Value.ToString() + "', house = '" + dataGridView2.SelectedCells[6].Value.ToString() + "', apartment = '" + dataGridView2.SelectedCells[7].Value.ToString() + "', postcode = '" + dataGridView2.SelectedCells[8].Value.ToString() + "', account = '" + dataGridView2.SelectedCells[9].Value.ToString() + "', bank = '" + dataGridView2.SelectedCells[10].Value.ToString() + "'", "id_customer = '" + dataGridView2.SelectedCells[0].Value.ToString() + "'");
            }
            catch
            {
                MessageBox.Show("Сторка не выбрана");
            }
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            try
            {
                db.INSERT("'Customer' ('FIO', 'email', 'password', 'city', 'street', 'house', 'apartment', 'postcode', 'account', 'bank') VALUES ('" + dataGridView2.SelectedCells[1].Value.ToString() + @"', '" + dataGridView2.SelectedCells[2].Value.ToString() + @"', '" + dataGridView2.SelectedCells[3].Value.ToString() + @"', '" + dataGridView2.SelectedCells[4].Value.ToString() + @"', '" + dataGridView2.SelectedCells[5].Value.ToString() + @"', '" + dataGridView2.SelectedCells[6].Value.ToString() + @"', '" + dataGridView2.SelectedCells[7].Value.ToString() + @"', '" + dataGridView2.SelectedCells[8].Value.ToString() + @"', '" + dataGridView2.SelectedCells[9].Value.ToString() + @"', '" + dataGridView2.SelectedCells[10].Value.ToString() + @"')");
            }
            catch
            {
                MessageBox.Show("Сторка не выбрана");
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            try
            {
                db.DELETE("'Customer'", "id_customer = '" + dataGridView2.SelectedCells[0].Value.ToString() + "'");
                dataGridView2.Rows.RemoveAt(dataGridView2.SelectedRows[0].Index);
            }
            catch
            {
                MessageBox.Show("Сторка не выбрана");
            }
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            try
            {
                db.UPDATE("Hotel SET hotel_name = '" + dataGridView3.SelectedCells[1].Value.ToString() + "'", "id_hotel = '" + dataGridView3.SelectedCells[0].Value.ToString() + "'");
            }
            catch
            {
                MessageBox.Show("Сторка не выбрана");
            }
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            try
            {
                db.DELETE("'Hotel'", "id_hotel = '" + dataGridView3.SelectedCells[0].Value.ToString() + "'");
                dataGridView3.Rows.RemoveAt(dataGridView3.SelectedRows[0].Index);
            }
            catch
            {
                MessageBox.Show("Сторка не выбрана");
            }
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            try
            {
                db.INSERT("'Hotel' ('hotel_name') VALUES ('" + dataGridView3.SelectedCells[1].Value.ToString() + @"')");
            }
            catch
            {
                MessageBox.Show("Сторка не выбрана");
            }
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            try
            {
                db.UPDATE("Tour SET tour_name = '" + dataGridView4.SelectedCells[1].Value.ToString() + "' , price = '" + dataGridView4.SelectedCells[2].Value.ToString() + "', duration = '" + dataGridView4.SelectedCells[3].Value.ToString() + "', dateS = '" + dataGridView4.SelectedCells[4].Value.ToString() + "', dataE = '" + dataGridView4.SelectedCells[5].Value.ToString() + "'", "id_tour = '" + dataGridView4.SelectedCells[0].Value.ToString() + "'");
            }
            catch
            {
                MessageBox.Show("Сторка не выбрана");
            }
        }

        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            try
            {
                db.DELETE("'Tour'", "id_tour = '" + dataGridView4.SelectedCells[0].Value.ToString() + "'");
                db.DELETE("'Date_Tour'", "id_tour = '" + dataGridView4.SelectedCells[0].Value.ToString() + "'");
                dataGridView4.Rows.RemoveAt(dataGridView4.SelectedRows[0].Index);
            }
            catch
            {
                MessageBox.Show("Сторка не выбрана");
            }
        }

        private void toolStripButton12_Click(object sender, EventArgs e)
        {
            try
            {
                db.INSERT("'Tour' ('tour_name', 'price', 'duration', 'dateS', 'dataE', 'id_resort') VALUES ('" + dataGridView4.SelectedCells[1].Value.ToString() + @"', '" + dataGridView4.SelectedCells[2].Value.ToString() + @"', '" + dataGridView4.SelectedCells[3].Value.ToString() + @"', '" + dataGridView4.SelectedCells[4].Value.ToString() + @"', '" + dataGridView4.SelectedCells[5].Value.ToString() + @"', '" + dataGridView4.SelectedCells[6].Value.ToString() + @"')");
            }
            catch
            {
                MessageBox.Show("Сторка не выбрана");
            }
        }

        private void toolStripButton13_Click(object sender, EventArgs e)
        {
            try
            {
                db.UPDATE("Tour_Hotel SET id_tour = '" + dataGridView5.SelectedCells[1].Value.ToString() + "', id_hotel = '" + dataGridView5.SelectedCells[2].Value.ToString() + "'", "id_tour_hotel = '" + dataGridView5.SelectedCells[0].Value.ToString() + "'");
            }
            catch
            {
                MessageBox.Show("Сторка не выбрана");
            }
        }

        private void toolStripButton14_Click(object sender, EventArgs e)
        {
            try
            {
                db.DELETE("'Tour_Hotel'", "id_tour_hotel = '" + dataGridView5.SelectedCells[0].Value.ToString() + "'");
                dataGridView5.Rows.RemoveAt(dataGridView5.SelectedRows[0].Index);
            }
            catch
            {
                MessageBox.Show("Сторка не выбрана");
            }
        }

        private void toolStripButton15_Click(object sender, EventArgs e)
        {
            try
            {
                db.INSERT("'Tour_Hotel' ('id_tour', 'id_hotel') VALUES ('" + dataGridView5.SelectedCells[1].Value.ToString() + @"', '" + dataGridView5.SelectedCells[2].Value.ToString() + @"')");
            }
            catch
            {
                MessageBox.Show("Сторка не выбрана");
            }
        }

        private void toolStripButton16_Click(object sender, EventArgs e)
        {
            try
            {
                db.UPDATE("Excursion SET exc_name = '" + dataGridView6.SelectedCells[1].Value.ToString() + "' , description_exc = '" + dataGridView6.SelectedCells[2].Value.ToString() + "', duration_exc = '" + dataGridView6.SelectedCells[3].Value.ToString() + "', price_exc = '" + dataGridView6.SelectedCells[4].Value.ToString() + "', marks = '" + dataGridView6.SelectedCells[5].Value.ToString() + "' id_resort = '" + dataGridView6.SelectedCells[6].Value.ToString() + "'", "id_excursion = '" + dataGridView6.SelectedCells[0].Value.ToString() + "'");
            }
            catch
            {
                MessageBox.Show("Сторка не выбрана");
            }
        }

        private void toolStripButton17_Click(object sender, EventArgs e)
        {
            try
            {
                db.DELETE("'Excursion'", "id_excursion = '" + dataGridView6.SelectedCells[0].Value.ToString() + "'");
                db.DELETE("'Tour_Excursion'", "id_excursion = '" + dataGridView6.SelectedCells[0].Value.ToString() + "'");
                dataGridView6.Rows.RemoveAt(dataGridView6.SelectedRows[0].Index);
            }
            catch
            {
                MessageBox.Show("Сторка не выбрана");
            }
        }

        private void toolStripButton18_Click(object sender, EventArgs e)
        {
            try
            {
                db.INSERT("'Excursion' ('exc_name', 'description_exc', 'duration_exc', 'price_exc', 'marks', 'id_resort') VALUES ('" + dataGridView6.SelectedCells[1].Value.ToString() + @"', '" + dataGridView6.SelectedCells[2].Value.ToString() + @"', '" + dataGridView6.SelectedCells[3].Value.ToString() + @"', '" + dataGridView6.SelectedCells[4].Value.ToString() + @"', '" + dataGridView6.SelectedCells[5].Value.ToString() + @"', '" + dataGridView6.SelectedCells[6].Value.ToString() + @"')");
            }
            catch
            {
                MessageBox.Show("Сторка не выбрана");
            }
        }

        private void toolStripButton19_Click(object sender, EventArgs e)
        {
            try
            {
                db.UPDATE("Discount SET id_resort = '" + dataGridView7.SelectedCells[1].Value.ToString() + "' , name_tour = '" + dataGridView7.SelectedCells[2].Value.ToString() + "', description = '" + dataGridView7.SelectedCells[3].Value.ToString() + "', prices = '" + dataGridView7.SelectedCells[4].Value.ToString() + "', discount = '" + dataGridView7.SelectedCells[5].Value.ToString() + "'", "id_discount = '" + dataGridView7.SelectedCells[0].Value.ToString() + "'");
            }
            catch
            {
                MessageBox.Show("Сторка не выбрана");
            }
        }

        private void toolStripButton20_Click(object sender, EventArgs e)
        {
            try
            {
                db.DELETE("'Discount'", "id_discount = '" + dataGridView7.SelectedCells[0].Value.ToString() + "'");
                dataGridView7.Rows.RemoveAt(dataGridView7.SelectedRows[0].Index);
            }
            catch
            {
                MessageBox.Show("Сторка не выбрана");
            }
        }

        private void toolStripButton21_Click(object sender, EventArgs e)
        {
            try
            {
                db.INSERT("'Discount' ('id_resort', 'name_tour', 'description', 'prices', 'discount') VALUES ('" + dataGridView7.SelectedCells[1].Value.ToString() + @"', '" + dataGridView7.SelectedCells[2].Value.ToString() + @"', '" + dataGridView7.SelectedCells[3].Value.ToString() + @"', '" + dataGridView7.SelectedCells[4].Value.ToString() + @"', '" + dataGridView7.SelectedCells[5].Value.ToString() + @"')");
            }
            catch
            {
                MessageBox.Show("Сторка не выбрана");
            }
        }

        private void toolStripButton22_Click(object sender, EventArgs e)
        {
            try
            {
                db.UPDATE("Customer_Tour SET id_customer = '" + dataGridView8.SelectedCells[1].Value.ToString() + "' , id_tour = '" + dataGridView8.SelectedCells[2].Value.ToString() + "', prices = '" + dataGridView8.SelectedCells[3].Value.ToString() + "', contract = '" + dataGridView8.SelectedCells[4].Value.ToString() + "', date_contract = '" + dataGridView8.SelectedCells[5].Value.ToString() + "', allSum = '" + dataGridView8.SelectedCells[6].Value.ToString() + "', status = '" + dataGridView8.SelectedCells[7].Value.ToString() + "', paid = '" + dataGridView8.SelectedCells[8].Value.ToString() + "'", "id_CusTour = '" + dataGridView8.SelectedCells[0].Value.ToString() + "'");
            }
            catch
            {
                MessageBox.Show("Сторка не выбрана");
            }
        }

        private void toolStripButton23_Click(object sender, EventArgs e)
        {
            try
            {
                db.DELETE("'Customer_Tour'", "id_CusTour = '" + dataGridView8.SelectedCells[0].Value.ToString() + "'");
                db.DELETE("'Bank_Customer'", "id_custour = '" + dataGridView8.SelectedCells[0].Value.ToString() + "'");
                db.DELETE("'Tour_Excursion'", "id_CusTour = '" + dataGridView8.SelectedCells[0].Value.ToString() + "'");
                dataGridView8.Rows.RemoveAt(dataGridView8.SelectedRows[0].Index);
            }
            catch
            {
                MessageBox.Show("Сторка не выбрана");
            }
        }

        private void toolStripButton24_Click(object sender, EventArgs e)
        {
            try
            {
                db.INSERT("'Customer_Tour' ('id_customer', 'id_tour', 'prices', 'contract', 'date_contract', 'allSum', 'status', 'paid') VALUES ('" + dataGridView8.SelectedCells[1].Value.ToString() + @"', '" + dataGridView8.SelectedCells[2].Value.ToString() + @"', '" + dataGridView8.SelectedCells[3].Value.ToString() + @"', '" + dataGridView8.SelectedCells[4].Value.ToString() + @"', '" + dataGridView8.SelectedCells[5].Value.ToString() + @"', '" + dataGridView8.SelectedCells[6].Value.ToString() + @"', '" + dataGridView8.SelectedCells[7].Value.ToString() + @"', '" + dataGridView8.SelectedCells[8].Value.ToString() + @"')");
            }
            catch
            {
                MessageBox.Show("Сторка не выбрана");
            }
        }

        private void toolStripButton25_Click(object sender, EventArgs e)
        {
            try
            {
                db.UPDATE("Tour_Excursion SET price_TourExc = '" + dataGridView9.SelectedCells[1].Value.ToString() + "', id_excursion = '" + dataGridView9.SelectedCells[2].Value.ToString() + "', id_CusTour = '" + dataGridView9.SelectedCells[3].Value.ToString() + "'", "id_tour_excursion = '" + dataGridView9.SelectedCells[0].Value.ToString() + "'");
            }
            catch
            {
                MessageBox.Show("Сторка не выбрана");
            }
        }

        private void toolStripButton26_Click(object sender, EventArgs e)
        {
            try
            {
                db.DELETE("'Tour_Excursion'", "id_tour_excursion = '" + dataGridView9.SelectedCells[0].Value.ToString() + "'");
                dataGridView9.Rows.RemoveAt(dataGridView9.SelectedRows[0].Index);
            }
            catch
            {
                MessageBox.Show("Сторка не выбрана");
            }
        }

        private void toolStripButton27_Click(object sender, EventArgs e)
        {
            try
            {
                db.INSERT("'Tour_Excursion' ('price_TourExc', 'id_excursion', 'id_CusTour') VALUES ('" + dataGridView9.SelectedCells[1].Value.ToString() + @"', '" + dataGridView9.SelectedCells[2].Value.ToString() + @"', '" + dataGridView9.SelectedCells[3].Value.ToString() + @"')");
            }
            catch
            {
                MessageBox.Show("Сторка не выбрана");
            }
        }

        private void toolStripButton28_Click(object sender, EventArgs e)
        {
            try
            {
                db.UPDATE("Date_Tour SET amount = '" + dataGridView10.SelectedCells[1].Value.ToString() + "', date = '" + dataGridView10.SelectedCells[2].Value.ToString() + "', id_tour = '" + dataGridView10.SelectedCells[3].Value.ToString() + "'", "id_datetour = '" + dataGridView10.SelectedCells[0].Value.ToString() + "'");
            }
            catch
            {
                MessageBox.Show("Сторка не выбрана");
            }
        }

        private void toolStripButton29_Click(object sender, EventArgs e)
        {
            try
            {
                db.DELETE("'Date_Tour'", "id_datetour = '" + dataGridView10.SelectedCells[0].Value.ToString() + "'");
                dataGridView10.Rows.RemoveAt(dataGridView10.SelectedRows[0].Index);
            }
            catch
            {
                MessageBox.Show("Сторка не выбрана");
            }
        }

        private void toolStripButton30_Click(object sender, EventArgs e)
        {
            try
            {
                db.INSERT("'Date_Tour' ('amount', 'date', 'id_tour') VALUES ('" + dataGridView10.SelectedCells[1].Value.ToString() + @"', '" + dataGridView10.SelectedCells[2].Value.ToString() + @"', '" + dataGridView10.SelectedCells[3].Value.ToString() + @"')");
            }
            catch
            {
                MessageBox.Show("Сторка не выбрана");
            }
        }

        private void toolStripButton31_Click(object sender, EventArgs e)
        {
            try
            {
                db.UPDATE("Bank_Customer SET paid = '" + dataGridView11.SelectedCells[1].Value.ToString() + "', data_price = '" + dataGridView11.SelectedCells[2].Value.ToString() + "', id_custour = '" + dataGridView11.SelectedCells[3].Value.ToString() + "'", "id_bank_customer = '" + dataGridView11.SelectedCells[0].Value.ToString() + "'");
            }
            catch
            {
                MessageBox.Show("Сторка не выбрана");
            }
        }

        private void toolStripButton32_Click(object sender, EventArgs e)
        {
            try
            {
                db.DELETE("'Bank_Customer'", "id_bank_customer = '" + dataGridView11.SelectedCells[0].Value.ToString() + "'");
                dataGridView11.Rows.RemoveAt(dataGridView11.SelectedRows[0].Index);
            }
            catch
            {
                MessageBox.Show("Сторка не выбрана");
            }
        }

        private void toolStripButton33_Click(object sender, EventArgs e)
        {
            try
            {
                db.INSERT("'Bank_Customer' ('paid', 'data_price', 'id_custour') VALUES ('" + dataGridView11.SelectedCells[1].Value.ToString() + @"', '" + dataGridView11.SelectedCells[2].Value.ToString() + @"', '" + dataGridView11.SelectedCells[3].Value.ToString() + @"')");
            }
            catch
            {
                MessageBox.Show("Сторка не выбрана");
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            db.Hotel();
            db.Tour();
            db.Excursion();
            db.Discount();
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("ok");
            Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DTL.list.Clear();
            SQLiteConnection connection = new SQLiteConnection(@"Data Source=base.sqlite;Version=3");
            connection.Open();
            SQLiteCommand sql = new SQLiteCommand(connection);
            sql.CommandText = @"SELECT * FROM Date_Tour";
            SQLiteDataReader reader = sql.ExecuteReader();
            foreach (DbDataRecord record in reader)
            {
                Date_Tour DT = new Date_Tour();
                DT.idTour = record["id_tour"].ToString();
                DT.price = record["amount"].ToString();
                DT.date = record["date"].ToString();
                SQLiteCommand sql1 = new SQLiteCommand(connection);
                sql1.CommandText = @"SELECT * FROM Tour WHERE id_tour = '" + record["id_tour"].ToString() + "'";
                SQLiteDataReader reader1 = sql1.ExecuteReader();
                foreach (DbDataRecord record1 in reader1)
                {
                    DT.nameTour = record1["tour_name"].ToString();
                }
                DTL.list.Add(DT);
            }
            connection.Close();
        }

        private void toolStripButton34_Click(object sender, EventArgs e)
        {
            try
            {
                db.UPDATE("Category SET cat_name = '" + dataGridView12.SelectedCells[1].Value.ToString() + "'", "id_cat = '" + dataGridView12.SelectedCells[0].Value.ToString() + "'");
            }
            catch
            {
                MessageBox.Show("Сторка не выбрана");
            }
        }

        private void toolStripButton35_Click(object sender, EventArgs e)
        {
            try
            {
                db.DELETE("'Category'", "id_cat = '" + dataGridView12.SelectedCells[0].Value.ToString() + "'");
                db.DELETE("'Stuff'", "id_cat = '" + dataGridView12.SelectedCells[0].Value.ToString() + "'");
                dataGridView12.Rows.RemoveAt(dataGridView12.SelectedRows[0].Index);
            }
            catch
            {
                MessageBox.Show("Сторка не выбрана");
            }
        }

        private void toolStripButton36_Click(object sender, EventArgs e)
        {
            try
            {
                db.INSERT("'Category' ('cat_name') VALUES ('" + dataGridView12.SelectedCells[1].Value.ToString() + @"')");
            }
            catch
            {
                MessageBox.Show("Сторка не выбрана");
            }
        }

        private void toolStripButton37_Click(object sender, EventArgs e)
        {
            try
            {
                db.UPDATE("Stuff SET id_cat = '" + dataGridView13.SelectedCells[1].Value.ToString() + "'stuff_name = '" + dataGridView13.SelectedCells[2].Value.ToString() + "'", "id_stuff = '" + dataGridView13.SelectedCells[0].Value.ToString() + "'");
            }
            catch
            {
                MessageBox.Show("Сторка не выбрана");
            }
        }

        private void toolStripButton38_Click(object sender, EventArgs e)
        {
            try
            {
                db.DELETE("'Stuff'", "id_stuff = '" + dataGridView13.SelectedCells[0].Value.ToString() + "'");
                dataGridView13.Rows.RemoveAt(dataGridView13.SelectedRows[0].Index);
            }
            catch
            {
                MessageBox.Show("Сторка не выбрана");
            }
        }

        private void toolStripButton39_Click(object sender, EventArgs e)
        {
            try
            {
                db.INSERT("'Stuff' ('id_cat', 'stuff_name') VALUES ('" + dataGridView13.SelectedCells[1].Value.ToString() + @"', '" + dataGridView13.SelectedCells[2].Value.ToString() + @"')");
            }
            catch
            {
                MessageBox.Show("Сторка не выбрана");
            }
        }
    }
}
