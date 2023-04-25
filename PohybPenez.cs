using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class PohybPenez : Penize
    {

        List<PohybPenez> pohybPenez=new List<PohybPenez>();


        public PohybPenez(string komentar, decimal castka): base(komentar, castka)
        {

        }

        public PohybPenez() { }

        public override void Prijem()
        {
            base.Prijem();
            pohybPenez.Add(new PohybPenez(base.Komentar,base.Castka));

           
        }


        public override void Vydaj()
        { 
            base.Vydaj();
            pohybPenez.Add(new PohybPenez(base.Komentar, base.Castka));

        }

        public override void VypisData()
        {
            var pen = pohybPenez.Sum(x=>x.Castka);


            foreach (var item in pohybPenez)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(item.Komentar.PadRight(12)+" "+ item.Castka.ToString());
                Console.ResetColor();
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Celkem zaplatit: {0:F} Kč,-",pen);
            Console.ResetColor();
            Console.ReadKey();
        }

        public override string ToString()
        {
            return "Koment: " +Komentar+" " +Castka; 
        }
    }
}
