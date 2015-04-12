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
        string FIO;
        string ID;
        public Form1(string FIO_, string ID_)
        {
            //backgroundWorker1.RunWorkerAsync();
            InitializeComponent();
            FIO = FIO_;
            ID = ID_;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {            
            //Thread.Sleep(600);
            //backgroundWorker1.ReportProgress(i, s);           
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //string s = (string)e.UserState;
            //textBox1.Text = s;
            //progressBar1.Value = e.ProgressPercentage; 
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("OK");
        }

        private void hgkfjdbksjdbvkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            FormAuthorization fa = new FormAuthorization();
            fa.ShowDialog();
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BD db = new BD();
            db.ResortComboBox();
            string[] RCB = db.ResortCB.Split(',');
            comboBox1.Items.AddRange(RCB);
            string[] DCB = { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };
            comboBox2.Items.AddRange(DCB);
        }

        private void администрированиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void comboBox3_Click(object sender, EventArgs e)
        {
            comboBox3.Items.Clear();
            string[] DCB = { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };
            int index = 100;
            if (comboBox2.Text != "")
            {               
                string Text = "";
                string Text1 = "";
                for (int i = 0; i < DCB.GetLength(0); i++)
                {
                    if (DCB[i] == comboBox2.Text)
                    {
                        index = i;
                    }
                    if (i > index)
                    {
                        Text += DCB[i] + ",";
                    }
                    else
                    {
                        Text1 += DCB[i] + ",";
                    }
                }
                Text += Text1;
                Text = Text.Remove(Text.Length - 1, 1);
                string[] DCB2 = Text.Split(',');
                comboBox3.Items.AddRange(DCB2);
                index = 100;
            }
            else
            {
                comboBox3.Items.AddRange(DCB);
            }
        }
    }
}
