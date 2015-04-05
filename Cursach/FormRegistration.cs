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
    public partial class FormRegistration : Form
    {
        public FormRegistration()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Форма регистрации(+)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != null && textBox2.Text != null && textBox5.Text != null && textBox4.Text != null)
            {
                if (textBox5.Text == textBox4.Text)
                {
                    BD db = new BD();
                    db.Registration(textBox1.Text, textBox2.Text, textBox5.Text);
                }
                else
                {
                    textBox5.Text = "";
                    textBox4.Text = "";
                    MessageBox.Show("Неверный пароль");
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            Random r = new Random();
            string password = "qw1ert3yui2op4a5sdf7ghj6kl8z9xcvb0nm";
            int index;
            for (int i = 0; i < 8; i++)
            {
                index = r.Next(0, 35);
                textBox3.Text += password[index];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox5.Text = textBox3.Text;
            textBox4.Text = textBox3.Text;
        }

        private void FormRegistration_Load(object sender, EventArgs e)
        {

        }
    }
}
