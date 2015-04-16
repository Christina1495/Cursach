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
    public partial class FormDescription : Form
    {
        public FormDescription(string name, string description)
        {
            InitializeComponent();
            label1.Text = name;
            label2.Text = description;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
