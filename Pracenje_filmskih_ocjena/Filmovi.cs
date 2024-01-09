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
    public partial class Filmovi : Form
    {
        public Filmovi()
        {
            InitializeComponent();
        }

        private void edit_Click(object sender, EventArgs e)
        {
            new Edit().Show();
        }

        private void add_Click(object sender, EventArgs e)
        {
            new Edit().Show();
        }
    }
}
