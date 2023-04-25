using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Uloziste : IUloziste
    {


        private const string ulozto = "dataVydaje.txt";

        public string KomentarPolozky { get; private set; }

        public decimal CastkaPolozky { get;private set; }


        public Uloziste(string komentarPolozky, decimal castkaPolozky)
        {
            KomentarPolozky = komentarPolozky;
            CastkaPolozky = castkaPolozky;
        }


        public Uloziste() { }


        /// <summary>
        /// Uloží do souboru všechny zadané data
        /// </summary>
        public void UlozData(string[] seznamKUlozeni)
        {
            

            using(var sw = new StringWriter())
            {
                sw.WriteLine();
                sw.NewLine = "";
            }


        }


        /// <summary>
        /// Přepíše v souboru všechny data
        /// </summary>
        public void PrepisData()
        {
           
        }


        private string[] VyhledejData()
        {
            string[] data=new string[1];

            return data;
        }

    }
}
