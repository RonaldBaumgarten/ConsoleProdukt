using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProdukt
{
    public class Produkt
    {
        private string name;
        private double preis;
        private string hersteller;

        public String Name { get => name; set => name = value; }
        public double Preis { get => preis; set => preis = value; }
        public string Hersteller { get => hersteller; set => hersteller = value; }
        public Produkt(string name, double preis, string hersteller)
        {
            this.name = name;
            this.preis = preis;
            this.hersteller = hersteller;
        }




    }
}
