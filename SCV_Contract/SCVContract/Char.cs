using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;

namespace SCVContract
{
    internal class Char
    {
        private FunkcjeMapy funkcjeMapy;
        private Poruszanie poruszanie;
        PlanetInfo infoPlaneta = new PlanetInfo();

       
        public bool Play()
        {
            infoPlaneta.InfoChar();


            string[,] mapa =
            {
               {"▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓", "▓","▓", "▓", "▓"},
               {"▓", " ", "▓","q", "▓", "▓","▓", "▓", "▓","▓", " ", " "," ", "▓", "▓","▓", "▓", "▓","*", " ", " "," ", " ", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓", "▓","▓", "▓", "▓"},
               {"▓", " ", "▓"," ", "▓", "▓","▓", "▓", "▓","▓", " ", "▓"," ", "▓", " ","p", "▓", "▓"," ", " ", " "," ", " ", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓", "▓","▓", "▓", "▓"},
               {"▓", " ", "▓"," ", " ", "w","▓", "▓", "▓","▓", " ", "▓"," ", "▓", " "," ", "▓", "▓"," ", " ", " "," ", " ", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓", "▓","▓", "▓", "▓"},
               {"▓", " ", "▓"," ", "▓", "▓","▓", "▓", "▓","▓", " ", "▓"," ", "▓", " ","▓", "▓", "▓"," ", " ", " "," ", " ", " ","▓", "▓", "▓","▓", "▓", "▓","▓", " ", " ","▓", " ", " ", " "," ", "▓", "▓"},
               {"▓", "h", "▓","z", "▓", "▓","▓", "▓", "▓","▓", " ", "▓"," ", "▓", " ","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", " ","▓", "▓", "▓","▓", "▓", "▓","▓", "y", " ","▓", " ", " ", " "," ", "▓", "▓"},
               {"▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", " ", "▓"," ", " ", " ","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", " ","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", " ", " ", " "," ", "▓", "▓"},
               {"▓", "▓", "▓","▓", "▓", "▓","▓", " ", " "," ", " ", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", " ", " ","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "i", " ", " "," ", "▓", "▓"},
               {"▓", "▓", "▓","▓", "▓", "▓","▓", " ", "▓","▓", "▓", "▓","▓", "u", "▓","f", " ", " "," ", "▓", "▓","▓", " ", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓", "▓","▓", "▓", "▓"},
               {"▓", "▓", "▓","▓", "▓", "▓","▓", " ", " "," ", " ", " "," ", " ", "▓","▓", "▓", "▓"," ", "▓", "▓","▓", " ", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", " ", " ", " "," ", " ", "▓"},
               {"▓", " ", " ","b", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓"," ", "▓", " "," ", " ", "▓","▓", "▓", "▓","t", "▓", "▓","▓", "▓", "▓","▓", " ", "▓", "▓","▓", " ", "▓"},
               {"▓", " ", " "," ", "▓", "▓","▓", "▓", " "," ", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓"," ", "▓", " ","▓", "▓", "▓","▓", "▓", "▓"," ", "▓", "▓","▓", "▓", "▓"," ", " ", " ", " ","▓", " ", "▓"},
               {"▓", " ", " "," ", "▓", "▓","▓", "g", " "," ", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓"," ", "▓", " ","▓", " ", " "," ", "▓", " "," ", " ", "▓","▓", " ", " "," ", "▓", "▓", "v","▓", " ", "▓"},
               {"▓", " ", " "," ", "▓", "▓","▓", "▓", "▓","▓", "▓", " "," ", " ", " "," ", " ", "▓"," ", " ", " ","▓", " ", "▓"," ", "▓", " ","▓", " ", "▓","▓", " ", "▓","▓", "▓", "▓", "▓","▓", " ", "▓"},
               {"▓", " ", " "," ", "▓", " "," ", " ", "▓","▓", " ", " ","▓", "▓", "▓","▓", " ", "▓","▓", "▓", "▓","▓", " ", "▓"," ", "▓", " ","▓", " ", "▓","▓", " ", " "," ", "▓", " ", " "," ", " ", "▓"},
               {"▓", " ", " "," ", "▓", " ","▓", " ", "▓","▓", " ", "▓","▓", "e", " ","▓", " ", "▓","▓", "▓", "▓","▓", " ", "▓"," ", "▓", " ","▓", " ", "▓","▓", "▓", "▓"," ", "▓", " ", "▓","▓", "▓", "▓"},
               {"▓", "j", " "," ", "▓", "d","▓", "l", "▓","▓", "r", "▓","▓", "▓", " "," ", " ", "▓","▓", "▓", "▓","▓", "s", "▓"," ", " ", " ","▓", " ", " "," ", "k", "▓","m", "▓", " ", " "," ", "n", "▓"},
               {"▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓", "▓","▓", "▓", "▓"},
            };
            
            
            funkcjeMapy = new FunkcjeMapy(mapa);
            poruszanie = new Poruszanie(1, 1);

            return Petla();
            Clear();
            Console.WriteLine("Udało ci się przejść");
            Console.ReadKey();
        }

        private bool Petla()
        {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            while (true)
            {
                if (watch.ElapsedMilliseconds > 1200000000)
                {
                    return false;
                }
                Clear();
                funkcjeMapy.Rysuj();
                poruszanie.Rysuj();

                ConsoleKeyInfo keyInfo = ReadKey(true);
                ConsoleKey key = keyInfo.Key;
                switch (key)
                {
                    case ConsoleKey.UpArrow:
                        if (funkcjeMapy.czyWolnoIsc(poruszanie.X, poruszanie.Y - 1))
                        {
                            poruszanie.Y -= 1;
                        }
                        break;
                    case ConsoleKey.W:
                        if (funkcjeMapy.czyWolnoIsc(poruszanie.X, poruszanie.Y - 1))
                        {
                            poruszanie.Y -= 1;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (funkcjeMapy.czyWolnoIsc(poruszanie.X, poruszanie.Y + 1))
                        {
                            poruszanie.Y += 1;
                        }
                        break;
                    case ConsoleKey.S:
                        if (funkcjeMapy.czyWolnoIsc(poruszanie.X, poruszanie.Y + 1))
                        {
                            poruszanie.Y += 1;
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                        if (funkcjeMapy.czyWolnoIsc(poruszanie.X - 1, poruszanie.Y))
                        {
                            poruszanie.X -= 1;
                        }
                        break;
                    case ConsoleKey.A:
                        if (funkcjeMapy.czyWolnoIsc(poruszanie.X - 1, poruszanie.Y))
                        {
                            poruszanie.X -= 1;
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if (funkcjeMapy.czyWolnoIsc(poruszanie.X + 1, poruszanie.Y))
                        {
                            poruszanie.X += 1;
                        }
                        break;
                    case ConsoleKey.D:
                        if (funkcjeMapy.czyWolnoIsc(poruszanie.X + 1, poruszanie.Y))
                        {
                            poruszanie.X += 1;
                        }
                        break;
                    default:
                        break;
                };

                string koordynatySCV = funkcjeMapy.Koordynaty(poruszanie.X, poruszanie.Y);
                if (koordynatySCV == "h")
                {
                    poruszanie.X = 1;
                    poruszanie.Y = 15;
                    Clear();
                    funkcjeMapy.Rysuj();
                    poruszanie.Rysuj();
                }
                if (koordynatySCV == "j")
                {
                    poruszanie.X = 1;
                    poruszanie.Y = 4;
                    Clear();
                    funkcjeMapy.Rysuj();
                    poruszanie.Rysuj();
                }
                if (koordynatySCV == "b")
                {
                    poruszanie.X = 3;
                    poruszanie.Y = 1;
                    Clear();
                    funkcjeMapy.Rysuj();
                    poruszanie.Rysuj();
                }
                if (koordynatySCV == "q")
                {
                    poruszanie.X = 3;
                    poruszanie.Y = 11;
                    Clear();
                    funkcjeMapy.Rysuj();
                    poruszanie.Rysuj();
                }
                if (koordynatySCV == "w")
                {
                    poruszanie.X = 8;
                    poruszanie.Y = 12;
                    Clear();
                    funkcjeMapy.Rysuj();
                    poruszanie.Rysuj();
                }
                if (koordynatySCV == "g")
                {
                    poruszanie.X = 4;
                    poruszanie.Y = 3;
                    Clear();
                    funkcjeMapy.Rysuj();
                    poruszanie.Rysuj();
                }
                if (koordynatySCV == "z")
                {
                    poruszanie.X = 37;
                    poruszanie.Y = 16;
                    Clear();
                    funkcjeMapy.Rysuj();
                    poruszanie.Rysuj();
                }
                if (koordynatySCV == "n")
                {
                    poruszanie.X = 3;
                    poruszanie.Y = 4;
                    Clear();
                    funkcjeMapy.Rysuj();
                    poruszanie.Rysuj();
                }
                if (koordynatySCV == "v")
                {
                    poruszanie.X = 34;
                    poruszanie.Y = 6;
                    Clear();
                    funkcjeMapy.Rysuj();
                    poruszanie.Rysuj();
                }
                if (koordynatySCV == "i")
                {
                    poruszanie.X = 36;
                    poruszanie.Y = 11;
                    Clear();
                    funkcjeMapy.Rysuj();
                    poruszanie.Rysuj();
                }
                if (koordynatySCV == "m")
                {
                    poruszanie.X = 13;
                    poruszanie.Y = 9;
                    Clear();
                    funkcjeMapy.Rysuj();
                    poruszanie.Rysuj();
                }
                if (koordynatySCV == "u")
                {
                    poruszanie.X = 33;
                    poruszanie.Y = 15;
                    Clear();
                    funkcjeMapy.Rysuj();
                    poruszanie.Rysuj();
                }
                if (koordynatySCV == "p")
                {
                    poruszanie.X = 22;
                    poruszanie.Y = 15;
                    Clear();
                    funkcjeMapy.Rysuj();
                    poruszanie.Rysuj();
                }
                if (koordynatySCV == "s")
                {
                    poruszanie.X = 15;
                    poruszanie.Y = 3;
                    Clear();
                    funkcjeMapy.Rysuj();
                    poruszanie.Rysuj();
                }
                if (koordynatySCV == "t")
                {
                    poruszanie.X = 10;
                    poruszanie.Y = 15;
                    Clear();
                    funkcjeMapy.Rysuj();
                    poruszanie.Rysuj();
                }
                if (koordynatySCV == "r")
                {
                    poruszanie.X = 27;
                    poruszanie.Y = 11;
                    Clear();
                    funkcjeMapy.Rysuj();
                    poruszanie.Rysuj();
                }
                if (koordynatySCV == "e")
                {
                    poruszanie.X = 5;
                    poruszanie.Y = 15;
                    Clear();
                    funkcjeMapy.Rysuj();
                    poruszanie.Rysuj();
                }
                if (koordynatySCV == "d")
                {
                    poruszanie.X = 14;
                    poruszanie.Y = 15;
                    Clear();
                    funkcjeMapy.Rysuj();
                    poruszanie.Rysuj();
                }
                if (koordynatySCV == "l")
                {
                    poruszanie.X = 31;
                    poruszanie.Y = 4;
                    Clear();
                    funkcjeMapy.Rysuj();
                    poruszanie.Rysuj();
                }
                if (koordynatySCV == "y")
                {
                    poruszanie.X = 7;
                    poruszanie.Y = 15;
                    Clear();
                    funkcjeMapy.Rysuj();
                    poruszanie.Rysuj();
                }
                if (koordynatySCV == "k")
                {
                    poruszanie.X = 16;
                    poruszanie.Y = 8;
                    Clear();
                    funkcjeMapy.Rysuj();
                    poruszanie.Rysuj();
                }
                if (koordynatySCV == "f")
                {
                    poruszanie.X = 30;
                    poruszanie.Y = 16;
                    Clear();
                    funkcjeMapy.Rysuj();
                    poruszanie.Rysuj();
                }
                if (koordynatySCV == "*")
                {
                    break;
                }
                Thread.Sleep(30);

            }
            return true;


            
        }

    }
}
