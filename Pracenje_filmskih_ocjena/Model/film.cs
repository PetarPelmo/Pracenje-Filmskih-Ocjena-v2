using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Pracenje_filmskih_ocjena
{
    public class film : IComparable
    {
        private int id;
        private string naziv;
        private DateTime datIzalsk;//dodati jos jedan atribut.
        private string redatelj;
        private bool boxOffice;

        public int Id { get { return id; } set { id = value; } }
        public string Naziv { get { return naziv; } set { naziv = value; } }
        public DateTime DatIzalsk { get { return datIzalsk; } set { datIzalsk = value; } }
        public string Redatelj { get { return redatelj; } set { redatelj = value; } }
        public bool BoxOffice { get { return boxOffice; } set { boxOffice = value; } }

        public int CompareTo(object obj)
        {
            int rez = this.id.CompareTo(((film)obj).id);
            //if (rez == 0) rez = this.naziv.CompareTo(((film)obj).naziv); nije potrebno komperati vise od samo ID-a
            return rez;
        }
        public override string ToString()

           => naziv + " -> " + Id.ToString();
    }
}
