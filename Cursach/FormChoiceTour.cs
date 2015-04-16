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
    public partial class FormChoiceTour : Form
    {
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
        ExcursionList EL = new ExcursionList();

        public FormChoiceTour(string idTour, string FIO_, string ID_, string nameTour, string priseTour, string durationTour, string resortTour, string dateSTour, string dateETour, string hotelTour, int quantity)
        {
            EL.list = new List<Excursion>();
            InitializeComponent();
            FIO = FIO_;
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
            label2.Text = "Тур: " + NameTour + Environment.NewLine + "Отель: " + HotelTour;
            label3.Text = "Курорт: " + ResortTour;
            label4.Text = "Продолжительность: " + DurationTour;
            for (int i = 0; i < 31; i++)
            {
                comboBox2.Items.Add(i);
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
                    comboBox1.Items.Add(DCB[i]);
                }
                if(Date[i] == DateETour)
                {
                    S = false;
                }
            }
            allCost = PriseTour * Quantity;
            label5.Text = "Сумма к оплате: " + Convert.ToString(allCost);
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
            listBox1.Items.Clear();
            for (int i = 0; i < EL.list.Count; i++)
            {
                listBox1.Items.Add("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                listBox1.Items.Add(EL.list[i].name + "   Цена: " + EL.list[i].price + "руб.   Продолжительность: " + EL.list[i].duration + "   Оценка: " + EL.list[i].marks);
            }
            connection.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                FormDescription fd = new FormDescription(EL.list[listBox1.SelectedIndex / 2].name, EL.list[listBox1.SelectedIndex / 2].description);
                fd.ShowDialog();
            }
            else
            {
                MessageBox.Show("Выберите экскурсию");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                label2.Text += Environment.NewLine + "Экскурсия: " + EL.list[listBox1.SelectedIndex / 2].name;
                allCost += Quantity * Convert.ToInt32(EL.list[listBox1.SelectedIndex / 2].price);
                label5.Text = "Сумма к оплате: " + Convert.ToString(allCost);
            }
            else
            {
                MessageBox.Show("Выберите экскурсию");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // договор, счет 
        }

        private void FormChoiceTour_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            BD db = new BD();
            if (listBox1.SelectedIndex != -1)
            {
                db.marks(Convert.ToInt32(numericUpDown1.Value), EL.list[listBox1.SelectedIndex / 2].marks, EL.list[listBox1.SelectedIndex / 2].id);
                EL.list[listBox1.SelectedIndex / 2].marks = Convert.ToString((Convert.ToInt32(numericUpDown1.Value) + Convert.ToInt32(EL.list[listBox1.SelectedIndex / 2].marks)) / 2);
                listBox1.Items.Clear();
                for (int i = 0; i < EL.list.Count; i++)
                {
                    listBox1.Items.Add("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                    listBox1.Items.Add(EL.list[i].name + "   Цена: " + EL.list[i].price + "руб.   Продолжительность: " + EL.list[i].duration + "   Оценка: " + EL.list[i].marks);
                }
            }
            else
            {
                MessageBox.Show("Выберите экскурсию");
            }
        }
    }
}
