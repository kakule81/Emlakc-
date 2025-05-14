using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emlakci.App
{
    public class KiralikEv : Ev
    {
        public KiralikEv()
        {

        }

        public KiralikEv(double kira, double depozito, int odasayisi,
            string semt, int katno, double alan) : base(odasayisi, katno, alan, semt)
        {
            this.Kira = kira;
            this.Depozito = depozito;

        }



        public double Kira { get; set; }
        public double Depozito { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()}\nKira:{this.Kira}\nDepozito:{this.Depozito}";
        }
    }

}