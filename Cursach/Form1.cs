using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cursach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            //Parser p = new Parser();
            //string container = p.getRequest("http://www.riviera-sochi.ru/tours/");
            //string Block = p.Block(container, "//div[@class='entry']");
            //int i = 0;
            //string s = "";
            //while (p.STOP == false)
            //{
            //    i++;
            //    Block = p.Block1(Block, "bottom", "<a");
            //    p.Tour(p.BLOCK_WORK);
            //    string URL = "http://www.riviera-sochi.ru/tours/" + p.ID;
            //    container = p.getRequest(URL);
            //    p.Check(container);
            //    s = p.ID + " " + p.DURATION + " " + p.PRICE + " " + p.RESORT + " " + p.DATE + " " + p.HOTEL + " " + p.NAME;
            //    Thread.Sleep(600);
            //    backgroundWorker1.ReportProgress(i, s);
            //}
            //p.STOP = false;
            //container = p.getRequest("http://www.riviera-sochi.ru/excursions");
            //Block = p.Block(container, "//div[@class='center_block']");
            //while (p.STOP == false)
            //{
            //    i++;
            //    Block = p.Block1(Block, "bottom", "excursion_thumb");
            //    p.Excursions(p.BLOCK_WORK);
            //    s = p.RESORT_EX + " " + p.DESCRIPTION + " " + p.DURATION_EX + " " + p.NAME_EX + " " + p.PRICE_EX;
            //    Thread.Sleep(600);
            //    backgroundWorker1.ReportProgress(i, s);
            //}
            //p.STOP = false;
            //container = p.getRequest("http://www.riviera-sochi.ru/resorts/");
            //Block = p.Block(container, "//div[@class='center_block']");
            //while (p.STOP == false)
            //{
            //    i++;
            //    Block = p.Block1(Block, "hotels_selector", "<h4>");
            //    p.Resort_(p.BLOCK_WORK);
            //    s = p.NAME_RES;
            //    Thread.Sleep(600);
            //    backgroundWorker1.ReportProgress(i, s);
            //}
            //container = p.getRequest("http://www.riviera-sochi.ru/hotels/top");
            //p.Hotels_(container);
            //s = p.HOTELS;
            //Thread.Sleep(600);
            //backgroundWorker1.ReportProgress(i, s);
            //container = p.getRequest("http://www.riviera-sochi.ru/offers/");
            //Block = p.Block(container, "//div[@class='center_block']");
            //while (p.STOP == false)//убрать пустую сторку 
            //{
            //    i++;
            //    Block = p.Block1(Block, "entry", "entry");
            //    p.Shares(p.BLOCK_WORK);
            //    s = p.NAME +"-------->"+ p.DESCRIPTION + "----------->" + p.RESORT + "---------->" + p.PRICE + "---------->" + p.DISCOUNT;
            //    Thread.Sleep(600);
            //    backgroundWorker1.ReportProgress(i, s);
            //}
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //string s =(string)e.UserState;
            //textBox1.Text = s;
            //progressBar1.Value = e.ProgressPercentage; 
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //MessageBox.Show("OK");
        }
    }
}
