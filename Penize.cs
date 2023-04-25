using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp1
{
    abstract class Penize : IPenize
    {

        protected string Komentar { get; set; }

        protected decimal Castka { get; set; } 

        protected DateTime DatumOperace=>DateTime.Now;

        public Penize(string komentar, decimal castka)
        {
            Komentar = komentar;
            Castka = castka;
        }


        public Penize() { } 

        public virtual DateTime Datum()
        {
            return DatumOperace;
        }

        public virtual void Prijem()
        {
            Console.WriteLine("Zadej název výdaje: ");
            string nazev = Console.ReadLine();
            Console.Write("Zadej částku: ");
            decimal prijem = decimal.Parse(Console.ReadLine());
            Komentar = nazev;
            Castka = prijem;
            Console.WriteLine("Zadáno");
        }

        public virtual void Vydaj()
        {
            Console.WriteLine("Zadej název příjmu: ");
            string nazev = Console.ReadLine();
            Console.Write("Zadej částku: ");
            decimal prijem = decimal.Parse(Console.ReadLine());
            Komentar = nazev;
            Castka = -prijem;
            Console.WriteLine("Zadáno");

        }

        public virtual void VypisData()
        {
            
        }
    }
}
