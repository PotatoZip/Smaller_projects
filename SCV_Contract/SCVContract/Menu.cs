using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;

namespace SCVContract
{
    internal class Menu
    {

        Planety planety = new Planety();
        //Zapis zapis = new Zapis();
        

        //Okno Menu z wyborem NowaGra/WczytajGrę
        public void Uruchamianie(Menu menu)
        {
            Console.WriteLine(@" $$$$$$\   $$$$$$\  $$\    $$\        $$$$$$\   $$$$$$\  $$\   $$\ $$$$$$$$\ $$$$$$$\   $$$$$$\   $$$$$$\ $$$$$$$$\ 
$$  __$$\ $$  __$$\ $$ |   $$ |      $$  __$$\ $$  __$$\ $$$\  $$ |\__$$  __|$$  __$$\ $$  __$$\ $$  __$$\\__$$  __|
$$ /  \__|$$ /  \__|$$ |   $$ |      $$ /  \__|$$ /  $$ |$$$$\ $$ |   $$ |   $$ |  $$ |$$ /  $$ |$$ /  \__|  $$ |   
\$$$$$$\  $$ |      \$$\  $$  |      $$ |      $$ |  $$ |$$ $$\$$ |   $$ |   $$$$$$$  |$$$$$$$$ |$$ |        $$ |   
 \____$$\ $$ |       \$$\$$  /       $$ |      $$ |  $$ |$$ \$$$$ |   $$ |   $$  __$$< $$  __$$ |$$ |        $$ |   
$$\   $$ |$$ |  $$\   \$$$  /        $$ |  $$\ $$ |  $$ |$$ |\$$$ |   $$ |   $$ |  $$ |$$ |  $$ |$$ |  $$\   $$ |   
\$$$$$$  |\$$$$$$  |   \$  /         \$$$$$$  | $$$$$$  |$$ | \$$ |   $$ |   $$ |  $$ |$$ |  $$ |\$$$$$$  |  $$ |   
 \______/  \______/     \_/           \______/  \______/ \__|  \__|   \__|   \__|  \__|\__|  \__| \______/   \__|   
                                                                                                                    


                            ");
            Console.WriteLine("1. ---> Nowa Gra\n2. ---> Wczytaj Grę");
            while(true)
            {
                try
                {
                    string wybor = ReadLine();
                    if(wybor == "1")
                    {
                        menu.NowaGra();
                        break;
                    }
                    else if(wybor == "2")
                    {
                        //menu.WczytajGre();
                        Console.WriteLine("Ta opcja zostanie dodana w przyszłości");
                    }
                    else
                    {
                        Console.WriteLine("Błędne dane");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }


            ReadKey();
        }


        //Rozpoczyna NowąGrę
        public void NowaGra()
        {
            Console.Clear();
            Console.WriteLine("Uruchamianie systemu w toku...");
            Thread.Sleep(500);
            Console.WriteLine(".");
            Thread.Sleep(2000);
            Console.WriteLine(".");
            Thread.Sleep(2000);
            Console.WriteLine(".");
            Thread.Sleep(1000);
            Console.WriteLine("Witaj");
            Thread.Sleep(1000);
            Console.WriteLine("Nazywam się Corel i jestem adiutantem przyjmujących nowych rekrutów na stanowisko SCV Worker ");
            Thread.Sleep(1000);
            Console.WriteLine("Jeśli tu jesteś to znaczy, że zaciekawiła cię nasza oferta pracy");
            Thread.Sleep(1000);
            Console.WriteLine("Do wykonania będziesz mieć 3 misje o różnym poziomie zaawansowania");
            Thread.Sleep(1000);
            Console.WriteLine("Twoim zadaniem będzie udanie się na 3 planety w celu pozyskania surowców jak na dobrego SCV przystało");
            Thread.Sleep(1000);
            Console.WriteLine("Powodzenia!!!\n\n\n\n");
            Thread.Sleep(1000);
            Console.WriteLine("Instrukcja korzystania z kombinezonu SCV:\n'W' lub 'PageUp' ---> Ruch w górę\n'S' lub 'PageDown' ---> Ruch w dół\n'A' lub 'PageLeft' ---> Ruch w lewo\n'D' lub 'PageRight' ---> Ruch w prawo");
            Console.WriteLine("\nNaciśnij dowolny przycisk, aby kontynuować");
            Console.ReadKey();
            planety.WyborPlanety();

        }
        /*
        public void WczytajGre()
        {
            zapis.ZapiszGre();
        }
        */
    }
}
