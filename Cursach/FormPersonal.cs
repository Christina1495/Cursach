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
    public partial class FormPersonal : Form
    {
        string FIO;
        string ID;
        CustomerTourList CTL = new CustomerTourList();
        DateTime CurrentTime = DateTime.Now;
        public FormPersonal(string FIO_, string ID_)
        {
            InitializeComponent();
            FIO = FIO_;
            ID = ID_;
            label1.Text = FIO;
            
        }

        private void FormPersonal_Load(object sender, EventArgs e)
        {
            CTL.list = new List<CustomerTour>();
            CTL.list.Clear();
            BD db = new BD();
            SQLiteConnection connection = new SQLiteConnection(@"Data Source=base.sqlite;Version=3");
            connection.Open();
            SQLiteCommand sql = new SQLiteCommand(connection);
            sql.CommandText = @"SELECT * FROM Customer_Tour WHERE id_customer = '" + ID + "'";
            SQLiteDataReader reader = sql.ExecuteReader();
            foreach (DbDataRecord record in reader)
            {
                CustomerTour CT = new CustomerTour();
                CT.contract = record["contract"].ToString();
                CT.date = record["date_contract"].ToString();
                CT.price = record["allSum"].ToString();
                CT.status = record["status"].ToString();
                CT.paid = record["paid"].ToString();
                CT.id = record["id_CusTour"].ToString();
                CT.idTour = record["id_tour"].ToString();
                SQLiteCommand sql1 = new SQLiteCommand(connection);
                sql1.CommandText = @"SELECT * FROM Tour WHERE id_tour = '" + record["id_tour"].ToString() + "'";
                SQLiteDataReader reader1 = sql1.ExecuteReader();
                foreach (DbDataRecord record1 in reader1)
                {
                    CT.nameTour = record1["tour_name"].ToString();
                }
                CTL.list.Add(CT);
            }
            listBox1.Items.Clear();
            for (int i = 0; i < CTL.list.Count; i++)
            {
                string Status = "";
                if (CTL.list[i].status == "0")
                {
                    Status = "Неоплачено";
                }
                else
                {
                    Status = "Оплачено";
                }
                listBox1.Items.Add("-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                listBox1.Items.Add("Номер договора: " + CTL.list[i].contract + "  Тур: " + CTL.list[i].nameTour + "  Дата заключения договора: " + CTL.list[i].date + "  Сумма к оплате: " + CTL.list[i].price + "  Оплачено: " + CTL.list[i].paid + "   Статус: " + Status);
            }
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BD db = new BD();
            string d = CurrentTime.ToString("dd.MM.yyyy");
            if (listBox1.SelectedIndex != -1)
            {
                Hide();
                FormPayment FP = new FormPayment(ID, FIO, CTL.list[listBox1.SelectedIndex / 2].id, d, CTL.list[listBox1.SelectedIndex / 2].paid, Convert.ToString(Convert.ToInt32(CTL.list[listBox1.SelectedIndex / 2].price) - Convert.ToInt32(CTL.list[listBox1.SelectedIndex / 2].paid)), CTL.list[listBox1.SelectedIndex / 2].idTour, CTL.list[listBox1.SelectedIndex / 2].contract, CTL.list[listBox1.SelectedIndex / 2].price );
                FP.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Выберите, что хотите оплатить");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormListThings flt = new FormListThings();
            flt.Show();
        }        
    }
}
