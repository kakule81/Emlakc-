using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
namespace Emlakci.App
{
    internal class Program
    {
        static void Main(string[] args)
        {


            KiralikEv ke = new KiralikEv(5000, 600, 4, "kiralık ev", 2, 100);
            KiralikEv ke1 = new KiralikEv(4000, 500, 4, "kiralık ev", 3, 300);
            KiralikEv ke2 = new KiralikEv(6000, 700, 4, "kiralık ev", 5, 500);

            Console.WriteLine(ke.ToString());

            var se = new SatilikEv(600, 4, "satılık ev", 3, 100);
            var se1 = new SatilikEv(700, 5, "satılık ev", 4, 200);
            var se2 = new SatilikEv(800, 6, "satılık ev", 5, 300);

        }
    }
}

