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


        /// <summary>
        /// Metoda zapíše výdaj
        /// </summary>
        public override string [] VytvorVydajZaklad()
        {  
            var a=  base.VytvorVydajZaklad();
            pohybPenez.Add(new PohybPenez(base.Komentar,base.Castka));
            return a;
        }

        /// <summary>
        /// Metoda zapíše výdaj 
        /// </summary>
        public override void Vydaj()
        { 
            base.Vydaj();
            pohybPenez.Add(new PohybPenez(base.Komentar, base.Castka));

        }


        /// <summary>
        /// Vypíše data v z této třídy
        /// </summary>
        public override void VypisData()
        {

            //Celkem peněz k doplacení
            var penizeCelkem = pohybPenez.Sum(x=>x.Castka);


            foreach (var item in pohybPenez)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(item.Komentar.PadRight(12)+" "+ item.Castka.ToString());
                Console.ResetColor();
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Celkem zaplatit: {0:F} Kč,-",penizeCelkem);
            Console.ResetColor();
            Console.ReadKey();
        }


        /// <summary>
        /// Přepsání do čitelné podoby
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Koment: " +Komentar+" " +Castka; 
        }
    }
}
