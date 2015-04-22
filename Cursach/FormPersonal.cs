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
    public partial class FormPersonal : Form
    {
        string FIO;
        string ID;
        public FormPersonal(string FIO_, string ID_)
        {
            InitializeComponent();
            FIO = FIO_;
            ID = ID_;
            label1.Text = FIO;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormPayment FP = new FormPayment(FIO);
            FP.Show();
        }
    }
}
