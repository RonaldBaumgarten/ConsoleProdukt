using System.ComponentModel;

namespace ConsoleProdukt
{
    internal class Program
    {
        private static int anzahl = 0;
        private static Produkt[] produkte = new Produkt[100];

        static void Main(string[] args)
        {
            int auswahl = 1;
            while (auswahl >= 1)
            {
                Console.WriteLine("Bitte waehlen sie aus:");
                Console.WriteLine("1. Produkt hinzufuegen");
                Console.WriteLine("2. Produkte auflisten");
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
            string n = "";
            double p = 0.0;
            string h = "";
            Console.WriteLine("Name:");
            n = Console.ReadLine();
            Console.WriteLine("Preis:");
            p = Double.Parse(Console.ReadLine());
            Console.WriteLine("Hersteller:");
            h = Console.ReadLine();
            Produkt pr = new Produkt(n, p, h);
            produkte[anzahl] = pr;
            anzahl++;
        }
        public static void listProducts()
        {
            for(int i=0; i<anzahl; i++)
            {
                Console.WriteLine(produkte[i].getInfos());
            }
        }

        public static void sortProducts()
        {
            // Implementation of Bubble Sort
            int fin = 0;
            Produkt temp;
            for(int i=0; i<anzahl-1; i++)
            {
                fin = 0;
                for (int j = 1; j < anzahl; j++)
                {
                    if (produkte[i].Preis > produkte[j].Preis)
                    {
                        fin = 1;
                        temp = produkte[i];
                        produkte[i] = produkte[j];
                        produkte[j] = temp;
                    }
                }
                if (fin == 0)
                    break;
            }
            Console.WriteLine("Die Produkte wurden dem Preis nach sortiert.");
        }

    }
}
