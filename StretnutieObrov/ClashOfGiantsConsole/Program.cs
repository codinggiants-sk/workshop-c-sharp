using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClashOfGiantsConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // premenné, ktoré uchovávajú informácie o tom, aké číslo hodil hráč a počítač
            int cisloHraca;
            int cisloPocitaca;

            // premenne, ktoré uchovávajú počet výhrier hráča a počítača
            int vyhryHraca = 0;
            int vyhryPocitaca = 0;

            // počet ťahov - je určený na vytvorenie podmienky na ukončenie hry
            // a zobrazenie obrázku
            int pocetTahov = 0;

            Console.WriteLine("Ahoj! Chceš si zasúťažiť v hádzaní kockou?");
            Console.WriteLine("Ak áno, stlač ľubovoľný kláves.");
            // príkaz ReadKey zastaví program, kým používateľ nestlačí ľubovoľný kláves
            Console.ReadKey();
            // príkaz clear vymaže všetko z konzoly
            Console.Clear();

            // opakujeme hry, kým niekto nevyhrá, použijeme cyklus do while
            do
            {
                // zvýšime počet ťahov
                pocetTahov++;

                Console.WriteLine($"Ťah: {pocetTahov}");
                Console.WriteLine($"Si na ťahu");
                Console.ReadKey();
                Console.Clear();

                // náhodne vygerujeme číslo, ktoré hodil hráč
                cisloHraca = hodKockou();
                Console.WriteLine($"Hodil si: {cisloHraca}");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine($"Ťah: {pocetTahov}");
                Console.WriteLine($"Som na ťahu :)");
                Console.ReadKey();
                Console.Clear();

                // teraz je na ťahu počítač
                cisloPocitaca = hodKockou();
                Console.WriteLine($"Hodil som: {cisloPocitaca}");
                Console.ReadKey();
                Console.Clear();

                // poďme vyhodnotiť, kto vyhral
                // ak niekto vyhral, aktualizujeme počet podov
                // v prípade remízy nikto nezíska body
                Console.WriteLine($"Poďme sa pozrieť, kto vyhral toto kolo...");
                Console.ReadKey();
                Console.Clear();

                if (cisloHraca > cisloPocitaca)
                {
                    vyhryHraca++;
                    Console.WriteLine($"Vyhral si.... ;( ");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (cisloPocitaca > cisloHraca)
                {
                    vyhryPocitaca++;
                    Console.WriteLine($"Ha Ha!!! Vyhral som :D");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine($"Remíza? Ako je to možné? :/ ");
                    Console.ReadKey();
                    Console.Clear();
                }

                Console.WriteLine($"Aktuálne skóre: Ty - {vyhryHraca} : {vyhryPocitaca} - Me");
                Console.ReadKey();
                Console.Clear();

                // skontrolujeme, či už je 5. kolo
                // Ak áno, skontrolujeme, kto vyhral a zobrazíme MessageBox
                // ak nie, hra pokračuje
                if (pocetTahov == 5)
                {
                    if (vyhryHraca > vyhryPocitaca)
                    {
                        Console.WriteLine("Gratulujem, vyhral si!");
                    }
                    else if (vyhryHraca < vyhryPocitaca)
                    {
                        Console.WriteLine("Žiaľ, prehral si!");
                    }
                    else
                    {
                        Console.WriteLine("Je to remíza!");
                    }
                    Console.ReadKey();
                }
            } while (pocetTahov < 5);
        }

        // funkcia, ktorá náhodne vygeneruje hodené číslo na kocke
        // táto časť kódu je rovnaká pre hráča aj počítač, preto použijeme funkciu, aby sme to nemuseli písať 2-krát
        private static int hodKockou()
        {
            // trieda Random - je to genrátor pseudo-náhodných čísel
            // náhodné generovanie čísel je založené na čase počítača
            Random random = new Random();

            // kvôli tomu ak zavoláme túto funkciu viackrát v jednej milisekunde, výsledok bude rovnaký
            // aby sme tomu vyhli, musíme aplikáciu zastaviť na niečo medzi 10 a 99 milisekúnd
            Thread.Sleep(random.Next(10, 100));

            // vytvoríme pomocnú premennú na uloženie výsledku
            // funkcia Next má 2 parametre - hornú a dolnú hranicu intervalu, z ktorého generujeme náhodné čísla
            // maximum nie je zahrnuté v tomto intervale
            int drawnPoints = random.Next(1, 7);

            return drawnPoints;
        }
    }
}
