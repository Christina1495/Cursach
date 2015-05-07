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

namespace Cursach
{
    public partial class FormListThings : Form
    {
        /// <summary>
        /// Форма для формирования списка вещей в поездку.
        /// </summary>

        public FormListThings()
        {
            InitializeComponent();
            panel2.Visible = false;
            panel3.Visible = false;
        }
        
        
        bool b = false, ex = false, p = false;

        List<string> mylist;
        private void button1_Click(object sender, EventArgs e)
        {
            mylist = new List<string>();
            
            if (checkBox1.Checked) b = true; else b = false;
            if (checkBox2.Checked) ex = true; else ex = false;
            if (checkBox3.Checked) p = true; else p = false;
  
            if (b == true)
            {
                mylist.Add("===================");
                mylist.Add("Пляж:");
                mylist.Add("===================");
                InList(1);
            }
            if (ex == true)
            {
                mylist.Add("===================");
                mylist.Add("Экскурсии:");
                mylist.Add("===================");
                InList(2);
            }
            if (p == true)
            {
                mylist.Add("===================");
                mylist.Add("Вечеринка/ужин:");
                mylist.Add("===================");
                InList(3);
            }
            mylist.Add("===================");
            mylist.Add("Личные вещи:");
            mylist.Add("===================");
            InList(5);
            mylist.Add("===================");
            mylist.Add("Лекарства:");
            mylist.Add("===================");
            InList(6);
            mylist.Add("===================");
            mylist.Add("Документы:");
            mylist.Add("===================");
            InList(4);
            listBox1.DataSource = mylist;
            panel1.Visible = false;
            panel2.Visible = true;
        }


        public void InList(int cat)
        {
            SQLiteConnection connection = new SQLiteConnection(@"Data Source=base.sqlite;Version=3");
            connection.Open();
            SQLiteCommand sql = new SQLiteCommand(connection);
            sql.CommandText = @"SELECT * FROM Stuff where id_cat='" + cat + "'";
            SQLiteDataReader reader = sql.ExecuteReader();
            foreach (DbDataRecord record in reader)
            {
                mylist.Add("+ " + record["stuff_name"].ToString());
            }
            connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            panel2.Visible = false;
            panel1.Visible = true;

        }

        private void добавитьНовыйЭлементToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            
            
        }

        private void удалитьЭлементИзСпискаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mylist.Remove(listBox1.SelectedItem.ToString());
            listBox1.DataSource = null;
            listBox1.DataSource = mylist;
        }

        public void add()
        {
            mylist.Insert(listBox1.SelectedIndex, "+ " + textBox1.Text);
            listBox1.DataSource = null;
            listBox1.DataSource = mylist;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "") add();
            else MessageBox.Show("Вы не вписали новую вещь");
            panel3.Visible = false;
        }
      
        private void button4_Click(object sender, EventArgs e)
        {
            SaveFile sf = new SaveFile();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < listBox1.Items.Count; i++)
                    sf.SaveAll(saveFileDialog1.FileName, listBox1.Items[i].ToString());
            }
        }
    }
}
