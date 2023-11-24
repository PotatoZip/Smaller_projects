using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;
using System.Diagnostics;

namespace SCVContract
{
    internal class Kaldir
    {
        private FunkcjeMapy funkcjeMapy;
        private Poruszanie poruszanie;
        PlanetInfo infoplaneta = new PlanetInfo();

        public bool Play()
        {
            infoplaneta.InfoKaldir();





            string[,] mapa =
            {
                {"▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓", "▓","▓", "▓", "▓"},
                {"▓", " ", "▓"," ", " ", " "," ", " ", " "," ", " ", "▓"," ", " ", " "," ", "▓", " "," ", " ", "▓","▓", " ", " "," ", "▓", "▓","▓", " ", " ","▓", "▓", " "," ", " ", "▓", " "," ", " ", "▓"},
                {"▓", " ", "▓"," ", "▓", " ","▓", " ", "▓","▓", " ", "▓","▓", " ", "▓"," ", "▓", " ","▓", " ", "▓"," ", " ", "▓"," ", " ", "▓","▓", " ", " "," ", "▓", " ","▓", " ", " ", " ","▓", " ", "▓"},
                {"▓", " ", "▓"," ", "▓", " ","▓", " ", "▓","▓", " ", "▓","▓", " ", "▓"," ", "▓", " ","▓", " ", "▓"," ", "▓", "▓","▓", " ", "▓"," ", " ", "▓"," ", "▓", " ","▓", " ", "▓", "▓","▓", " ", "▓"},
                {"▓", " ", "▓"," ", "▓", " ","▓", " ", "▓","▓", " ", " ","▓", " ", "▓"," ", "▓", " ","▓", " ", "▓"," ", " ", " ","▓", " ", "▓","▓", "▓", "▓"," ", "▓", " ","▓", " ", "▓", " "," ", " ", "▓"},
                {"▓", " ", " "," ", "▓", " ","▓", " ", "▓","▓", "▓", " ","▓", " ", "▓"," ", "▓", " ","▓", " ", "▓","▓", "▓", " ","▓", " ", "▓"," ", " ", " "," ", "▓", " ","▓", " ", "▓", " ","▓", "▓", "▓"},
                {"▓", "▓", "▓","▓", "▓", " ","▓", " ", "▓"," ", " ", " "," ", " ", "▓","▓", "▓", "▓","▓", " ", "▓"," ", "▓", " ","▓", " ", " "," ", "▓", "▓"," ", "▓", " ","▓", " ", "▓", "*","▓", "▓", "▓"},
                {"▓", " ", " "," ", " ", " ","▓", " ", "▓"," ", "▓", "▓","▓", "▓", "▓"," ", " ", " "," ", " ", "▓"," ", "▓", " ","▓", "▓", "▓"," ", " ", "▓","▓", "▓", " ","▓", " ", "▓", "▓","▓", " ", "▓"},
                {"▓", " ", "▓","▓", "▓", "▓","▓", " ", "▓"," ", "▓", " "," ", " ", "▓"," ", "▓", "▓","▓", "▓", "▓"," ", " ", " "," ", " ", "▓","▓", " ", "▓"," ", " ", " ","▓", " ", "▓", " "," ", " ", "▓"},
                {"▓", " ", " "," ", " ", "▓"," ", " ", "▓"," ", "▓", " ","▓", " ", "▓"," ", "▓", " "," ", " ", "▓"," ", "▓", "▓","▓", " ", " ","▓", "▓", "▓"," ", "▓", "▓","▓", "▓", "▓", " ","▓", "▓", "▓"},
                {"▓", " ", "▓","▓", "▓", "▓"," ", "▓", "▓"," ", "▓", " ","▓", " ", " "," ", "▓", " ","▓", " ", "▓"," ", " ", " ","▓", "▓", " "," ", " ", " "," ", " ", "▓"," ", " ", " ", " ","▓", " ", "▓"},
                {"▓", " ", "▓"," ", "▓", "▓"," ", "▓", "▓"," ", " ", " ","▓", "▓", "▓","▓", "▓", " ","▓", " ", "▓"," ", "▓", " "," ", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", " ", "▓", "▓","▓", " ", "▓"},
                {"▓", " ", " "," ", "▓", "▓"," ", "▓", "▓","▓", "▓", " ","▓", " ", " "," ", "▓", " ","▓", " ", " "," ", "▓", "▓"," ", " ", " "," ", " ", " "," ", " ", " ","▓", " ", "▓", " "," ", " ", "▓"},
                {"▓", " ", "▓","▓", "▓", "▓"," ", "▓", "▓"," ", " ", " ","▓", " ", "▓"," ", "▓", " ","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", " ", "▓", "▓"," ", "▓", "▓"},
                {"▓", " ", "▓"," ", " ", " "," ", "▓", "▓"," ", "▓", "▓","▓", " ", "▓"," ", "▓", " "," ", " ", "▓"," ", " ", " ","▓", " ", " "," ", "▓", " "," ", " ", "▓"," ", " ", " ", "▓"," ", "▓", "▓"},
                {"▓", " ", "▓","▓", "▓", "▓","▓", "▓", "▓"," ", "▓", " "," ", " ", "▓"," ", "▓", "▓","▓", " ", "▓"," ", "▓", " ","▓", " ", "▓"," ", "▓", " ","▓", " ", "▓"," ", "▓", " ", "▓"," ", "▓", "▓"},
                {"▓", " ", " "," ", " ", " "," ", "▓", "▓"," ", " ", " ","▓", "▓", "▓"," ", " ", " "," ", " ", " "," ", "▓", " "," ", " ", "▓"," ", " ", " ","▓", " ", " "," ", "▓", " ", " "," ", " ", "▓"},
                {"▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓", "▓","▓", "▓", "▓"},
            };

            funkcjeMapy = new FunkcjeMapy(mapa);
            poruszanie = new Poruszanie(1,1);

            return Petla();

            
        }

        private bool Petla()
        {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            while (true)
            {
                
                if(watch.ElapsedMilliseconds > 60000)
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
                        if(funkcjeMapy.czyWolnoIsc(poruszanie.X, poruszanie.Y - 1))
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
                        if (funkcjeMapy.czyWolnoIsc(poruszanie.X -1, poruszanie.Y))
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
 