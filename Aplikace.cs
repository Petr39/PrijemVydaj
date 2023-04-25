using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Aplikace
    {

        private readonly IPenize penize;

        public Aplikace(IPenize penize)
        {
            this.penize = penize;
        }

        public void Vytvor()
        {
            penize.Prijem();
        }

        public void Odeber()
        {
            penize.Vydaj();
        }

        public void VypisSeznam()
        {
            penize.VypisData();
        }

    }
}
