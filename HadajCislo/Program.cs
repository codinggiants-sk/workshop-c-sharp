using System;
namespace HadajCislo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // zobrazí privítanie na konzole
            Console.WriteLine("Vitaj v konzolovom svete League of Legends.");
            Console.WriteLine("Som Twisted Faith - pán kariet. Jeden z hrdinov League of Legends");
            Console.WriteLine("Náhodne som vybral jednu zo svojich Kariet.");
            Console.WriteLine("Ak ma chceš poraziť, musíš uhádnuť číslo mojej karty (1 - 100).");
            
            // vytvorí generátor pseudo náhodných čísiel
            Random random = new Random();
            // náhodne vyberie číslo od 1 do 100
            // a uloží ho do premennej
            int toGuess = random.Next(1, 101);
            // Console.WriteLine(" * moja karta je {0}", toGuess);

            // zbytok premenných
            int chancesNumber = 7;

            do
            {
                // zobrazí počet zostávajúcich pokusov
                Console.WriteLine("Počet zostávajúcich pokusov: {0}", chancesNumber);
                // požiada o hádanie čísla
                Console.Write("Zadaj číslo: ");
                // Získa číslo z konzoly ako text
                string inputValue = Console.ReadLine();
                // skúsi zmeniť text na integer
                try
                {
                    int inputNumber = int.Parse(inputValue);
                    // Ak náš pokus je väčší
                    if (inputNumber > toGuess)
                        Console.WriteLine("H@ H@ H@ {0} je príliš veľa!!!", inputNumber);
                    // Ak náš pokus je menší
                    else if (inputNumber < toGuess)
                        Console.WriteLine("H@ H@ H@ {0} je príliš málo!!!", inputNumber);
                    // Museli sme uhádnuť, nastavíme premennú isEnded na true
                    else
                        break;
                }
                catch (FormatException) {
                    Console.WriteLine("Premrhal si jednu šancu, \"{0}\" nie je číslo!", inputValue);
                };
                // zníž počet šancí o 1
                chancesNumber -= 1;  // to isté ako chancesNumber = chancesNumber - 1;

            } while (chancesNumber > 0);

            // ak sme skončili slučku a hráč má ešte nejaké šance znamená to že vyhral
            if (chancesNumber >= 1)
                Console.WriteLine("Ó nie! Uhádol si číslo mojej karty. Porazil si ma...");
            // inak musel prehrať
            else
                Console.WriteLine("Prišiel si o všetky šance - Som víťaz. A ty porazený.");
            
            // Nechaj konzolu zobrazenú pokým nestlačí užívateľ klávesu enter
            Console.ReadLine();
        }

    }
}
