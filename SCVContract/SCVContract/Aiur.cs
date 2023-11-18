﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;

namespace SCVContract
{
    internal class Aiur
    {
        private FunkcjeMapy funkcjeMapy;
        private Poruszanie poruszanie;
        InfoPlaneta infoPlaneta = new InfoPlaneta();

        public bool Play()
        {
            infoPlaneta.InfoAiur();

            string[,] mapa =
            {
               
                {"▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓", "▓","▓", "▓", "▓", "▓", "▓", "▓","▓", "▓"},
                {"▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓", "▓","▓", "▓", "▓", "▓", "▓", "▓","▓", "▓"},
                {"▓", "▓", " ","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓", "▓","▓", "▓", "▓", "▓", "▓", "▓","▓", "▓"},
                {"▓", "▓", " ","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", " ", " "," ", " ", " "," ", " ", " ","▓", "▓", "▓"," ", " ", " "," ", " ", " "," ", " ", " ", " "," ", " ", " ", " ", "▓", "▓","▓", "▓"},
                {"▓", "▓", " ","▓", "▓", "▓","▓", "▓", "▓","▓", " ", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", " ","▓", "▓", "▓"," ", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓", "▓","▓", "▓", "▓", " ", "▓", "▓","▓", "▓"},
                {"▓", "▓", " ","▓", "▓", " "," ", " ", " "," ", " ", "▓","▓", "▓", "▓","▓", " ", "▓","▓", "▓", "▓","▓", "▓", " ","▓", "▓", "▓"," ", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓", "▓","▓", "▓", "▓", " ", "▓", "▓","▓", "▓"},
                {"▓", "▓", " ","▓", "▓", " ","▓", "▓", "▓","▓", " ", "▓","▓", "▓", "▓","▓", " ", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓"," ", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓", "▓","▓", "▓", "▓", " ", "▓", "▓","▓", "▓"},
                {"▓", "▓", " ","▓", "▓", " ","▓", "▓", "▓","▓", " ", " "," ", "▓", " "," ", " ", " "," ", "▓", " "," ", " ", " "," ", "▓", "▓","▓", "▓", " "," ", " ", " "," ", "▓", "▓", "▓","▓", "▓", "▓", " ", "▓", "▓","▓", "▓"},
                {"▓", "▓", " "," ", " ", " "," ", " ", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", " ", "▓","▓", "▓", "▓","▓", "▓", "▓"," ", " ", " ","*", "▓", " ","▓", "▓", "▓"," ", "▓", "▓", "▓","▓", "▓", "▓", " ", "▓", "▓","▓", "▓"},
                {"▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", " ", "▓","▓", "▓", "▓","▓", "▓", "▓"," ", "▓", "▓","▓", "▓", " ","▓", "▓", "▓"," ", "▓", "▓", "▓","▓", "▓", "▓", " ", "▓", "▓","▓", "▓"},
                {"▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓"," ", "▓", "▓", "▓","▓", "▓", "▓", " ", "▓", "▓","▓", "▓"},
                {"▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", " ", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓"," ", "▓", "▓","▓", "▓", "▓"," ", "▓", "▓", "▓","▓", "▓", "▓", " ", "▓", "▓","▓", "▓"},
                {"▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", " ", " "," ", " ", " "," ", " ", "▓","▓", "▓", "▓","▓", "▓", "▓"," ", "▓", "▓","▓", "▓", "▓"," ", "▓", "▓", "▓","▓", "▓", "▓", " ", " ", "▓","▓", "▓"},
                {"▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", " ", "▓"," ", " ", " ","▓", " ", "▓","▓", "▓", "▓","▓", "▓", "▓"," ", "▓", "▓","▓", "▓", "▓"," ", "▓", "▓", "▓","▓", "▓", "▓", "▓", " ", "▓","▓", "▓"},
                {"▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", " ", " "," ", " ", " "," ", " ", " "," ", " ", " "," ", " ", " "," ", " ", " "," ", "▓", "▓","▓", "▓", "▓"," ", " ", " ", " ","▓", "▓", "▓", "▓", " ", "▓","▓", "▓"},
                {"▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", " ", "▓","▓", " ", "▓"," ", " ", " ","▓", " ", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓", "▓","▓", "▓", "▓", "▓", " ", "▓","▓", "▓"},
                {"▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", " ", "▓","▓", " ", " "," ", " ", " "," ", " ", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓", " ","▓", "▓", "▓", "▓", " ", "▓","▓", "▓"},
                {"▓", "▓", "▓","▓", " ", " "," ", " ", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", " ", " ","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓", " ","▓", "▓", "▓", "▓", " ", "▓","▓", "▓"},
                {"▓", "▓", "▓","▓", " ", "▓","▓", " ", "▓","▓", " ", "▓","▓", "▓", "▓","▓", " ", " ","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓"," ", " ", " ","▓", " ", " ", " "," ", " ", "▓", "▓", " ", "▓","▓", "▓"},
                {"▓", "▓", "▓","▓", " ", "▓","▓", " ", "▓","▓", " ", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓"," ", "▓", "▓","▓", "▓", "▓", " ","▓", "▓", "▓", "▓", " ", "▓","▓", "▓"},
                {"▓", "▓", "▓","▓", " ", " "," ", " ", " "," ", " ", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓"," ", "▓", "▓","▓", "▓", "▓", " ","▓", "▓", "▓", "▓", " ", "▓","▓", "▓"},
                {"▓", "▓", "▓","▓", "▓", "▓","▓", " ", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓"," ", "▓", "▓","▓", "▓", "▓", "▓","▓", "▓", "▓", "▓", " ", "▓","▓", "▓"},
                {"▓", "▓", "▓","▓", "▓", "▓","▓", " ", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓"," ", " ", "▓","▓", "▓", "▓", " "," ", "▓", "▓", "▓", " ", "▓","▓", "▓"},
                {"▓", "▓", "▓","▓", "▓", "▓","▓", " ", " "," ", " ", " "," ", " ", " "," ", " ", " "," ", " ", " "," ", " ", " "," ", " ", " "," ", " ", " "," ", " ", "▓","▓", "▓", "▓", " "," ", " ", " ", " ", " ", "▓","▓", "▓"},
                {"▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓", " ","▓", "▓", "▓", "▓", "▓", "▓","▓", "▓"},
                {"▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓", "▓","▓", "▓", "▓", "▓", "▓", "▓","▓", "▓"},
                {"▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓", "▓","▓", "▓", "▓", "▓", "▓", "▓","▓", "▓"},
                {"▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓","▓", "▓", "▓", "▓","▓", "▓", "▓", "▓", "▓", "▓","▓", "▓"},
           
               
                

            };

            funkcjeMapy = new FunkcjeMapy(mapa);
            poruszanie = new Poruszanie(2, 2);

            return Petla();

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
                        if (funkcjeMapy.czyWolnoIsc(poruszanie.X, poruszanie.Y - 2))
                        {
                            poruszanie.Y -= 2;
                        }
                        else
                        {
                            if (funkcjeMapy.czyWolnoIsc(poruszanie.X, poruszanie.Y - 1) && (funkcjeMapy.czyWolnoIsc(poruszanie.X, poruszanie.Y - 2) == false))
                            {
                                poruszanie.Y -= 1;
                            }
                            break;
                        }
                        break;
                    case ConsoleKey.W:
                        if (funkcjeMapy.czyWolnoIsc(poruszanie.X, poruszanie.Y - 2))
                        {
                            poruszanie.Y -= 2;
                        }
                        else
                        {
                            if (funkcjeMapy.czyWolnoIsc(poruszanie.X, poruszanie.Y - 1) && (funkcjeMapy.czyWolnoIsc(poruszanie.X, poruszanie.Y - 2) == false))
                            {
                                poruszanie.Y -= 1;
                            }
                            break;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (funkcjeMapy.czyWolnoIsc(poruszanie.X, poruszanie.Y + 2))
                        {
                            poruszanie.Y += 2;
                        }
                        else
                        {
                            if (funkcjeMapy.czyWolnoIsc(poruszanie.X, poruszanie.Y + 1) && (funkcjeMapy.czyWolnoIsc(poruszanie.X, poruszanie.Y + 2) == false))
                            {
                                poruszanie.Y += 1;
                            }
                            break;
                        }
                        break;
                    case ConsoleKey.S:
                        if (funkcjeMapy.czyWolnoIsc(poruszanie.X, poruszanie.Y + 2))
                        {
                            poruszanie.Y += 2;
                        }
                        else
                        {
                            if (funkcjeMapy.czyWolnoIsc(poruszanie.X, poruszanie.Y + 1) && (funkcjeMapy.czyWolnoIsc(poruszanie.X, poruszanie.Y + 2) == false))
                            {
                                poruszanie.Y += 1;
                            }
                            break;
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                        if (funkcjeMapy.czyWolnoIsc(poruszanie.X - 2, poruszanie.Y))
                        {
                            poruszanie.X -= 2;
                        }
                        else
                        {
                            if (funkcjeMapy.czyWolnoIsc(poruszanie.X - 1, poruszanie.Y) && (funkcjeMapy.czyWolnoIsc(poruszanie.X - 2, poruszanie.Y) == false))
                            {
                                poruszanie.X -= 1;
                            }
                            break;
                        }
                        break;
                    case ConsoleKey.A:
                        if (funkcjeMapy.czyWolnoIsc(poruszanie.X - 2, poruszanie.Y))
                        {
                            poruszanie.X -= 2;
                        }
                        else
                        {
                            if (funkcjeMapy.czyWolnoIsc(poruszanie.X - 1, poruszanie.Y) && (funkcjeMapy.czyWolnoIsc(poruszanie.X - 2, poruszanie.Y) == false))
                            {
                                poruszanie.X -= 1;
                            }
                            break;
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if (funkcjeMapy.czyWolnoIsc(poruszanie.X + 2, poruszanie.Y))
                        {
                            poruszanie.X += 2;
                        }
                        else
                        {
                            if (funkcjeMapy.czyWolnoIsc(poruszanie.X + 1, poruszanie.Y) && (funkcjeMapy.czyWolnoIsc(poruszanie.X + 2, poruszanie.Y) == false))
                            {
                                poruszanie.X += 1;
                            }
                            break;
                        }
                        break;
                    case ConsoleKey.D:
                        if (funkcjeMapy.czyWolnoIsc(poruszanie.X + 2, poruszanie.Y))
                        {
                            poruszanie.X += 2;
                        }
                        else
                        {
                            if (funkcjeMapy.czyWolnoIsc(poruszanie.X + 1, poruszanie.Y) && (funkcjeMapy.czyWolnoIsc(poruszanie.X + 2, poruszanie.Y) == false))
                            {
                                poruszanie.X += 1;
                            }
                            break;
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
