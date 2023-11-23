using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SCVContract {
    internal class InfoPlaneta {
        public void InfoKaldir() {
            Console.Clear();

            Dictionary<string, string> infoKaldir = new Dictionary<string, string>() {
                {"Planeta:", "Kaldir" },
                {"Informacje ogólne:", "Lodowa pustynia zamieszkała przez zdziczałe szczepy Mastodontów\n                   Główna stacja przesyłowa dla protoskich transportowców"},
                {"Cel misji:        ", "Zdobądź rzadką odmianę minerałów zwanymi 'Złotymi złożami'"},
                {"Trudność:         ", "Ze względu na skrajne warunki atmosferyczne na powierzchni na wykonanie misje masz 1 min"},
                {"                  ", "Po upływie tego czasu nastąpi uszkodzenie kombinezonu"},
                {"\n", "Naciśnij dowolny przycisk, aby kontynuować"},

            };


            foreach(KeyValuePair<string,string> kvp in infoKaldir)
            {
                Thread.Sleep(1000);
                Console.WriteLine("{0} {1}", kvp.Key, kvp.Value);
            }
            
            Console.ReadKey();
        }

        public void InfoAiur()
        {      
            Console.Clear();

            Dictionary<string, string> infoAiur = new Dictionary<string, string>()
            {
                {"Planeta:", "Aiur" },
                {"Informacje ogólne:", "Ojczyzna protosów zagarnięta przez zergi\n                   Dominującą rzeźbą terenu jest dżungla"},
                {"Cel misji:        ", "Odnajdź zaginiony kanister z terrazytem pozostawiony przez poprzednią ekspedycję"},
                {"Trudność:         ", "Z uwagi na wysoką energię psioniczną generowaną przez świątynie twój kombinezon dostanie 'boosta'"},
                {"                  ", "Twój SCV porusza się o 2 pola do przodu (zamiast o 1) lub o 1 pole jeśli ruch o 2 jest niemożliwy\n                   Dodatkowo stojąc przy wąskiej ścianie możesz ją przeskoczyć"},
                {"\n", "Naciśnij dowolny przycisk, aby kontynuować"},

            };


            foreach (KeyValuePair<string, string> kvp in infoAiur)
            {
                Thread.Sleep(1000);
                Console.WriteLine("{0} {1}", kvp.Key, kvp.Value);
            }
            Console.ReadKey();
        }

        public void InfoChar()
        {
            Console.Clear();

            Dictionary<string, string> infoChar = new Dictionary<string, string>()
            {
                {"Planeta:", "Char" },
                {"Informacje ogólne:", "Wulkaniczna planeta\n                   Główne skupisko zergów w tej części galaktyki"},
                {"Cel misji:        ", "Odszukaj zakopany kanister z werspanem w jednej z zergowych tuneli"},
                {"Trudność:         ", "Twój SCV będzie się poruszać po tunelach"},
                {"                  ", "W celu poruszania się między tunelami skorzystaj z otworów oznaczonymi małymi literkami"},
                {"\n", "Naciśnij dowolny przycisk, aby kontynuować"},

            };

            foreach (KeyValuePair<string, string> kvp in infoChar)
            {
                Thread.Sleep(1000);
                Console.WriteLine("{0} {1}", kvp.Key, kvp.Value);
            }
            
            Console.ReadKey();


        }
    }
}
