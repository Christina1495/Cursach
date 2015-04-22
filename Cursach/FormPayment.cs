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
    public partial class FormPayment : Form
    {
        string FIO;
        public FormPayment(string FIO_)
        {
            InitializeComponent();
            FIO = FIO_;
        }
        DateTime Now = DateTime.Now;
        List<string> clientBank;
        private void button1_Click(object sender, EventArgs e)
        {
            clientBank = new List<string>();
            this.Size = new Size(this.Width, this.Height + 308);
            clientBank.Add("1CCLIENTBANKExchenge");
            clientBank.Add("Версияфората=1.01");
            clientBank.Add("Кодировка=Windows");
            clientBank.Add("ДатаНачала");
            clientBank.Add("ДатаКонца");
            clientBank.Add("РасчСчет=12345678901234567890");
            clientBank.Add("СекцияРасчСчет");
            clientBank.Add("ДатаНачала");
            clientBank.Add("ДатаКонца");
            clientBank.Add("РасчСчет=12345678901234567890");
            clientBank.Add("Всего=");
            clientBank.Add("Поступило=");
            clientBank.Add("Остаток");
            clientBank.Add("КонецРасчСчет");
            clientBank.Add("СекцияДокумент=Движение по счету");
            clientBank.Add("Номер=");
            clientBank.Add("Дата=" + Now.ToString("dd.MM.yyyy"));
            clientBank.Add("Сумма=" + textBox2.Text);
            clientBank.Add("ПлательщикСчет=" + textBox1.Text);
            listBox1.DataSource = clientBank;
            SaveFile sf = new SaveFile();
            for (int i = 0; i < listBox1.Items.Count; i++)
                sf.SaveAll(@"\ClientBank\" + Now.ToString("ddMMyyyy") + ".txt", listBox1.Items[i].ToString());
            
        }
    }
}
