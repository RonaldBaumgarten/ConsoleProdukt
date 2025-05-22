using System.ComponentModel;

namespace ConsoleProdukt
{
    internal class Program
    {
        private Produkt[] produkte = new Produkt[100];

        static void Main(string[] args)
        {
            int auswahl = 1;
            while (auswahl >= 1)
            {
                Console.WriteLine("Bitte waehlen sie aus:");
                Console.WriteLine("1. Produkt hinzufuegen");
                Console.WriteLine("2. Produkte auslisten");
                Console.WriteLine("3. Produkte nach Preis sortieren");
                Console.WriteLine("0. Programm beenden");

                if (Int32.TryParse(Console.ReadLine(), out auswahl) && auswahl >= 0 && auswahl < 4)
                {
                    switch (auswahl)
                    {
                        case 1:
                            addProduct();
                            break;
                        case 2:
                            listProducts();
                            break;
                        case 3:
                            sortProducts();
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Bitte treffe sie eine gueltige Auswahl!");
                }
            }
            Console.WriteLine("Bye!");
        }

        public static void addProduct()
        {

        }
        public static void listProducts()
        {

        }

        public static void sortProducts()
        {

        }

    }
}
