using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pracenje_filmskih_ocjena
{
    internal class Podatkovni_kontekst
    {
        private List<korisnik> korisnici;
        private List<film> filmovi;
        private List<ocjena> ocjene;

        public List<korisnik> Korisnici { get {  return korisnici; } }
        public List<film> Filmovi { get { return filmovi; } }
        public List<ocjena> Ocjene { get { return ocjene; } }
    }
}
