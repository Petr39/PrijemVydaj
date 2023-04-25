using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    /// <summary>
    /// Operativní třída
    /// </summary>
    internal class Aplikace
    {

        private readonly IPenize penize;

        private readonly IUloziste uloziste;


        public Aplikace(IPenize penize, IUloziste uloziste)
        {
            this.penize = penize;
            this.uloziste = uloziste;
        }
        /// <summary>
        /// Vytvoření výdaju 
        /// </summary>
        public void VytvorVydaj()
        {
            var dataSouboru=penize.VytvorVydajZaklad();
            uloziste.UlozData(dataSouboru);
        }
        /// <summary>
        /// Odebrání výdaju, např příjem nebo někdo něco zaplatil
        /// </summary>
        public void Odeber()
        {
            penize.Vydaj();
        }
        /// <summary>
        /// Vypíše seznam všech výdajů s koncovým výsledkem dlužné nebo přebývající částky
        /// </summary>
        public void VypisSeznam()
        {
            penize.VypisData();
        }

    }
}
