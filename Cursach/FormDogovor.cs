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
        List<string> listEx = new List<string>();

        public FormDogovor(string Id_, string Fio_, string idTour, string usluga_, string hotel_, int date_, string datas_, int col_, string ex_, int kol_tur_, int summa_, int TourPr, string ExPr, string ExId, List<string> ListEx)
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
            tb_postindex.Text = db.Postcode;
            tb_city.Text = db.City;
            tb_street.Text = db.Street;
            tb_numberdom.Text = db.House;
            tb_numberkv.Text = db.Apartment;
            tb_payment.Text = db.Account;
            tb_bank.Text = db.Bank;
            listEx = ListEx;
        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            if ((tb_city.Text != "") && (tb_payment.Text != "") && (tb_bank.Text != ""))
            {
                db.Customer(ID, tb_city.Text, tb_street.Text, tb_numberdom.Text, tb_numberkv.Text, tb_postindex.Text, tb_payment.Text, tb_bank.Text);
                address = tb_postindex.Text + ", г. " + tb_city.Text + ", " + tb_street.Text + ", " + tb_numberdom.Text + ", " + tb_numberkv.Text;
                paylist = tb_payment.Text;
                bank = tb_bank.Text;
                d.Dogovor(ID, IDTour, Fio, usluga, hotel, date, dates, col, ex, kol_tur, summa, address, paylist, bank, TourPR, ExPR, ExID, listEx);
                
                d.PaymentAccount(Fio, usluga, ex, summa, kol_tur, address, paylist, bank);
                d.Client_Bank(Fio, summa, 0, 0, paylist,"");
                MessageBox.Show("Done");
                Hide();
                FormMain f1 = new FormMain(Fio, ID);
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
