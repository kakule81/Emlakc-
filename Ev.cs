using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emlakci.App
{
    public class Ev
    {
        public static int sayac = 0;
        public Ev()
        {
            sayac++;
        }
        public Ev(int odasayisi, int katno, string semt, double alan)
        {
            this.Odasayisi = odasayisi;
            this.Katno = katno;
            this.Semt = semt;
            this.Alan = alan;
            sayac++;
        }

        public Ev(int odasayisi, int katno, double alan, string semt)
        {
            this.Odasayisi = odasayisi;
            this.Katno = katno;
            this.Semt = semt;
            this.Alan = alan;
            sayac++;
        }
        public static int Sayac { get; private set; }

        private int odasayisi;

        private string semt;


        public string Buyukluk { get; private set; }

        private double alan;

        public double Alan
        {
            get
            {
                return alan;
            }
            set
            {
                if (value < 50)
                {
                    throw new Exception("min alan değeri 50");
                }
                alan = value;
                if (this.alan > 50 && this.alan < 75)
                {
                    this.Buyukluk = "küçük ev";
                }
                else if (this.alan > 75 && this.alan < 120)
                {
                    this.Buyukluk = "orta ev";
                }
                else
                {
                    this.Buyukluk = "büyük ev";
                }

            }
        }


        public string Semt { get => semt; set => semt = value.ToUpper(); }

        public int Odasayisi { get => odasayisi; set => odasayisi = Math.Abs(value); }

        public int Katno { get; set; }
        public void SetOdaSayisi(int odasayisi) => this.Odasayisi = Math.Abs(odasayisi);

        public int GetOdaSayisi() => this.Odasayisi;







        public virtual string ToString()
        {
            return $"Oda Sayısı:{this.Odasayisi}\nKat No:{this.Katno}\nAlan:{this.Alan}\nSemt:{this.Semt}\nBüyüklük:{this.Buyukluk}";

        }


    }
}
