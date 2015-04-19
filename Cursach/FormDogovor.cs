﻿using System;
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
        Documents d = new Documents();
        string Fio;
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

        public FormDogovor(string Fio_, string usluga_, string hotel_, int date_, string datas_, int col_, string ex_, int kol_tur_, int summa_)
        {
            InitializeComponent();
            Fio = Fio_;
            usluga = usluga_;
            hotel = hotel_;
            date = date_;
            dates = datas_;
            col = col_;
            ex = ex_;
            kol_tur = kol_tur_;
            summa = summa_;
        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            if ((textBox2.Text != "") && (textBox6.Text != "") && (textBox7.Text != ""))
            {
                address = textBox1.Text + ", г. " + textBox2.Text + ", " + textBox3.Text + ", " + textBox4.Text + ", " + textBox5.Text;
                paylist = textBox6.Text;
                bank = textBox7.Text;
                d.Dogovor(Fio, usluga, hotel, date, dates, col, ex, kol_tur, summa, address, paylist, bank);
                d.PaymentAccount(Fio, usluga, ex, summa, col, address, paylist, bank);
                MessageBox.Show("Done");
            }
            else
            {
                MessageBox.Show("Вы заполнили не все обязательные поля!");
            }
        }


    }
}
