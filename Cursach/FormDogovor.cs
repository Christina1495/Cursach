using System;
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
    public partial class FormDogovor : Form
    {
        BD db = new BD();
        Documents d = new Documents();
        string Fio;
        string ID;
        string usluga;
        string hotel;
        int date;
        string dates;
        int col;
        string ex;
        int kol_tur;
        int summa;
        string address;
        string paylist;
        string bank;
        string IDTour;
        int TourPR;
        string ExPR = "";
        string ExID = "";

        public FormDogovor(string Id_, string Fio_, string idTour, string usluga_, string hotel_, int date_, string datas_, int col_, string ex_, int kol_tur_, int summa_, int TourPr, string ExPr, string ExId)
        {
            InitializeComponent();
            ID = Id_;
            IDTour = idTour;
            Fio = Fio_;
            usluga = usluga_;
            hotel = hotel_;
            date = date_;
            dates = datas_;
            col = col_;
            ex = ex_;
            kol_tur = kol_tur_;
            summa = summa_;
            TourPR = TourPr;
            ExPR = ExPr;
            ExID = ExId;
            db.FormDog(ID);
            textBox1.Text = db.Postcode;
            textBox2.Text = db.City;
            textBox3.Text = db.Street;
            textBox4.Text = db.House;
            textBox5.Text = db.Apartment;
            textBox6.Text = db.Account;
            textBox7.Text = db.Bank;
        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            if ((textBox2.Text != "") && (textBox6.Text != "") && (textBox7.Text != ""))
            {
                db.Customer(ID, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox1.Text, textBox6.Text, textBox7.Text);
                address = textBox1.Text + ", г. " + textBox2.Text + ", " + textBox3.Text + ", " + textBox4.Text + ", " + textBox5.Text;
                paylist = textBox6.Text;
                bank = textBox7.Text;
                d.Dogovor(ID, IDTour, Fio, usluga, hotel, date, dates, col, ex, kol_tur, summa, address, paylist, bank, TourPR, ExPR, ExID);
                d.PaymentAccount(Fio, usluga, ex, summa, kol_tur, address, paylist, bank);
                d.Client_Bank(Fio, summa, 0, 0, paylist);
                MessageBox.Show("Done");
                Hide();
                Form1 f1 = new Form1(Fio, ID);
                f1.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Вы заполнили не все обязательные поля!");
            }
        }

        private void FormDogovor_Load(object sender, EventArgs e)
        {

        }


    }
}
