using ClassLibrary1;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emlakci.App
{
    public class SatilikEv : Ev
    {
        public SatilikEv()
        {

        }

        public SatilikEv(double satisFiyati, int odasayisi, string semt, int katno, double alan) : base(odasayisi, katno, alan, semt)
        {
            SatisFiyati = satisFiyati;
        }

        public double SatisFiyati { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()}\nSatış Fiyatı:{this.SatisFiyati}";
        }
    }
}
