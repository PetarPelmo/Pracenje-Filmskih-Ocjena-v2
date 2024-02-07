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
    public partial class Ocjena : Form
    {
        public Ocjena()
        {
            InitializeComponent();
        }

        private void Filmovi_Click(object sender, EventArgs e)
        {
            new Filmovi().Show();
        }

        private void Korisnici_Click(object sender, EventArgs e)
        {
            new Korisnici().Show();
        }

        private void edit3_Click(object sender, EventArgs e)
        {
            new Filmovi_i_korisnici().Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Filmovi_i_korisnici(object sender, EventArgs e)
        {
            new Filmovi_i_korisnici().Show();
        }
    }
}
