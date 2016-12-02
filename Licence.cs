using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pytagoras
{
    public partial class Licence : Form
    {
        public Licence()
        {
            InitializeComponent();
            textBox1.Select(0,0);
        }

        private void buttonZatvoriť_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
