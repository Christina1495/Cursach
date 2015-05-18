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
            if(tb_fio.Text != null && tb_email.Text != null && tb_password1.Text != null && tb_password2.Text != null)
            {
                if (tb_password1.Text == tb_password2.Text)
                {
                    BD db = new BD();
                    db.Registration(tb_fio.Text, tb_email.Text, tb_password1.Text);
                }
                else
                {
                    tb_password1.Text = "";
                    tb_password2.Text = "";
                    MessageBox.Show("Неверный пароль");
                }
                MessageBox.Show("Спасибо за регистрацию, теперь вы можите авторизироваться!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Заполните все поля");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tb_ginpassword.Text = "";
            Random r = new Random();
            string password = "qw1ert3yui2op4a5sdf7ghj6kl8z9xcvb0nm";
            int index;
            for (int i = 0; i < 8; i++)
            {
                index = r.Next(0, 35);
                tb_ginpassword.Text += password[index];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tb_password1.Text = tb_ginpassword.Text;
            tb_password2.Text = tb_ginpassword.Text;
        }

        private void FormRegistration_Load(object sender, EventArgs e)
        {

        }
    }
}
