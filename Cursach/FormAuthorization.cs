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
    public partial class FormAuthorization : Form
    {
        public FormAuthorization()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Форма авторизации(+)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegistration fr = new FormRegistration();
            fr.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BD db = new BD();
            string Message = db.Authorization(tb_email.Text, tb_password.Text);
            if (Message == "ok")
            {
                Hide();
                Form1 f1 = new Form1(db.UserName, db.UserID);
                f1.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Проверьте данные");
            }
        }
    }
}
