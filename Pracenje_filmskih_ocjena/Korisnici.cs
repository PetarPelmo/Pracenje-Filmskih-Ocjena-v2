using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pracenje_filmskih_ocjena
{
    public partial class Korisnici : Form
    {
        public Korisnici()
        {
            InitializeComponent();
        }

        private void add3_Click(object sender, EventArgs e)
        {
            new Edit().Show();
        }

        private void edit2_Click(object sender, EventArgs e)
        {
            new Edit().Show();
        }
    }
}
