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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Parser p = new Parser();
            string container = p.getRequest("http://www.riviera-sochi.ru/tours/275");
            p.Check(container);
            textBox1.Text = p.HOTEL + " " + p.DATE + " " + p.NAME;
        }

    }
}
