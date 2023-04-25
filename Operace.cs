using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal  class Operace
    {

        IPenize penize = new PohybPenez();



        public void Start()
        {
            while(Pokracuj());
        }


        private bool Pokracuj()
        {
            bool pokracovat = true;
            Aplikace aplikace = new Aplikace(penize);


            Console.WriteLine("1 - Vytvořit výdaj");
            Console.WriteLine("2 - Odebrat výdaj");
            Console.WriteLine("3 - Vypiš obrat");
            Console.WriteLine("4 - Konec aplikace");


            int volba = int.Parse(Console.ReadLine());  


            switch (volba)
            {
                case 1:
                    Console.Clear();
                    aplikace.Vytvor();
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
                    Console.WriteLine("Děkujeme za použití aplikace...");
                    Console.ReadKey();
                return !pokracovat;
            }
            return pokracovat;

        }
    }
}
