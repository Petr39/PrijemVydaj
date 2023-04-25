using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal  class Operace
    {
        //Injektáž základních operací
        IPenize penize = new PohybPenez();
        IUloziste uloziste = new Uloziste();

        /// <summary>
        /// Začátek aplikace
        /// </summary>
        public void Start()
        {
            while(Pokracuj());
        }


        private bool Pokracuj()
        {
            Console.Clear();
            bool pokracovat = true;
            //Instance celé aplikace
            Aplikace aplikace = new Aplikace(penize, uloziste);
            Menu();
            int volba = int.Parse(Console.ReadLine());  

            switch (volba)
            {
                case 1:
                    Console.Clear();
                    aplikace.VytvorVydaj();
                break;
                case 2:
                    Console.Clear();
                    aplikace.Odeber();
                break;
                case 3:
                    Console.Clear();
                    aplikace.VypisSeznam();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Děkujeme za použití aplikace...");
                    Console.ReadKey();
                return !pokracovat;
            }
            return pokracovat;

        }

        private void Menu()
        {
            Console.WriteLine("1 - Vytvořit výdaj");
            Console.WriteLine("2 - Odebrat výdaj");
            Console.WriteLine("3 - Vypiš obrat");
            Console.WriteLine("4 - Konec aplikace");
        }
    }
}
